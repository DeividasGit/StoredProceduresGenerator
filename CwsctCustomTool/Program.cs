using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CwsctCustomTool
{
 internal class Program
 {
  private static void Main(string[] args)
  {
   uint output;
   string inputfilename = "",
    outputfilename = "",
    inputfilecontent = "",
    projectfilename = "",
    projectdirectoryname = "";

   //External tool arguments: $(ItemPath) $(ProjectDir) $(ProjectFileName)
   if (args.Length > 0) inputfilename = args[0]; //selected file path
   if (args.Length > 1) projectdirectoryname = args[1]; //project directory
   if (args.Length > 2) projectfilename = args[2]; //csproj path

   if (projectdirectoryname != "")
   {
    inputfilename = Path.Combine(projectdirectoryname, "q_ws.txt");
    projectfilename = Path.Combine(projectdirectoryname, projectfilename);
   }

   Console.WriteLine(projectfilename); //csproj path
   Console.WriteLine(inputfilename); //input file path

   try
   {
    //Read input file
    inputfilecontent = File.ReadAllText(inputfilename);
   }
   catch (Exception ex)
   {
    output = 0;
   }

   outputfilename = OutputFileNameGet(inputfilename);

   Console.WriteLine(outputfilename); //output file path

   //Generate output file content
   Generate(inputfilename, inputfilecontent, outputfilename, out output);

   //Add generated file to the project
   if (projectdirectoryname != "")
   {
    var p = new Microsoft.Build.Evaluation.Project(projectfilename);
    var metadataList = new List<KeyValuePair<string, string>>(); //metadata

    //If file is not yet included in project
    if (p.GetItemsByEvaluatedInclude(outputfilename).Count == 0)
    {
     //Set q_ws.cs DependentUpon q_ws.txt (output file upon input file). Result in csproj file:
     //<Compile Include="C:\Users\d.zemeckas\source\repos\CwsctCustomTool\CwsctCustomTool\q_ws.cs">
     //  < DependentUpon > q_ws.txt </ DependentUpon >
     //</ Compile >
     if (inputfilename != "")
      metadataList.Add(new KeyValuePair<string, string>("DependentUpon", Path.GetFileName(inputfilename)));
     //Add file to project
     p.AddItem("Compile", outputfilename, metadataList);
     p.Save();
    }
   }

   Console.WriteLine(output);
  }

  private static string OutputFileNameGet(string inputfilename)
  {
   var outputfilename = "";
   var lastbackslashindex = -1;

   lastbackslashindex = inputfilename.LastIndexOf("\\");
   outputfilename = inputfilename.Substring(0, lastbackslashindex);

   if (outputfilename != "") outputfilename = Path.Combine(outputfilename, "q_ws.cs");

   return outputfilename;
  }

  private static string CsBody(string sqlserver, string sqldb, string sqlschema, int sqlauth, string sqllogin = "",
   string sqlpass = "", bool nonstatic = false)
  {
   q.sqlserver = sqlserver;
   q.sqldb = sqldb;
   q.sqlauth = sqlauth;
   q.sqllogin = sqllogin;
   q.sqlpass = sqlpass;

   if (q.CheckDB(false) == false)
    return string.Format("(can not connect to sql db. param: {0} {1} {2} {3} {4} {5})", sqlserver, sqldb, sqlschema,
     sqlauth, sqllogin, sqlpass);

   var sb = new StringBuilder();

   sb.AppendLine("using System;");
   sb.AppendLine("using System.Data;");
   sb.AppendLine("using System.Data.SqlClient;");
   sb.AppendLine("using System.IO;");
   sb.AppendLine("");
   sb.AppendLine(string.Format("/* param: {0} {1} {2} {3} {4} */", sqlserver, sqldb, sqlschema, sqlauth, sqllogin));
   sb.AppendLine("public static partial class co {");

   var m = new List<method>();
   var p = new List<param>();

   var sc = q.e("i.METHODS_vw");
   q.q2s(sc, "@wsschema", sqlschema);
   var sdr = q.r(sc);
   while (sdr.Read())
   {
    var e = new method();
    e.sqlname = q.gs(sdr["fqdn"]);
    e.sqlproc = q.gs(sdr["method"]);
    e.sqlobjectid = q.gi(sdr["objectid"]);
    e.sqlhasdataset = q.gb(sdr["hasdataset"]);
    m.Add(e);
   }

   sdr.Close();
   sdr.Dispose();
   sdr = null;
   sc.Dispose();
   sc = null;


   sc = q.e("i.METHOD_PARAMS_vw");
   foreach (var e in m)
   {
    p.Clear();

    q.q2i(sc, "@objectid", e.sqlobjectid);
    sdr = q.r(sc);
    while (sdr.Read())
    {
     var r = new param();
     r.sqlname = q.gs(sdr["paramname"]);
     r.sqltype = q.gs(sdr["systype"]);
     r.sqludt = q.gs(sdr["udtname"]);
     r.sqloutput = q.gb(sdr["isoutput"]);
     r.sqlbool = q.gb(sdr["bool"]);
     r.sqldataset = q.gb(sdr["dataset"]);
     r.sqlreturnvalue = false;
     r.sqlpasstosp = true;
     p.Add(r);
    }

    sdr.Close();
    sdr.Dispose();
    sdr = null;

    if (e.sqlhasdataset)
    {
     var r = new param();
     r.sqlname = "tb";
     r.sqltype = "DataTable";
     r.sqludt = "";
     r.sqloutput = true;
     r.sqlbool = false;
     r.sqldataset = true;
     r.sqlreturnvalue = false;
     r.sqlpasstosp = false;
     p.Add(r);
    }

    var fullmethodname = e.name;

    var fullparams = "";
    var fullparamspass = "";
    foreach (var r in p)
    {
     fullparamspass = fullparamspass + (fullparamspass.IsNull() == false ? ", " : "");
     if (r.sqldataset)
      fullparamspass = fullparamspass + string.Format("{0}{1}", r.sqloutput ? "out " : "", r.name);
     else
      fullparamspass = fullparamspass + string.Format("{0}{1}", r.sqloutput ? "ref " : "", r.name);

     if (r.sqlreturnvalue) continue;
     if (r.sqlpasstosp == false && r.sqldataset == false) continue;

     fullparams = fullparams + (fullparams.IsNull() == false ? ", " : "");
     if (r.sqldataset)
      fullparams = fullparams + string.Format("{0}{1} {2}", r.sqloutput ? "out " : "", r.type, r.name);
     else
      fullparams = fullparams + string.Format("{0}{1} {2}", r.sqloutput ? "ref " : "", r.type, r.name);
    }

    sb.AppendLine(string.Format("public static bool {0} ({2}{3}{1}) {{", fullmethodname, fullparams,
     nonstatic ? "q q" : "", fullparams.IsNull() == false && nonstatic ? "," : ""));
    sb.AppendLine(string.Format("  int RETURN_VALUE = -1;"));
    sb.AppendLine(string.Format("  bool bSupressErrorMessage = false;"));
    sb.AppendLine(string.Format("  string error=\"\";"));
    sb.AppendLine(string.Format(""));
    sb.AppendLine(string.Format(
     "  return {0} (" + (nonstatic ? "q," : "") + "{1}" + (fullparams.IsNull() == false ? "," : "") +
     "ref RETURN_VALUE,bSupressErrorMessage,ref error);", fullmethodname, fullparamspass));
    sb.AppendLine(string.Format("}}"));

    sb.AppendLine(string.Format("public static bool {0} ({3}{1}{2}ref int RETURN_VALUE, bool bSupressErrorMessage) {{",
     fullmethodname, fullparams, fullparams.IsNull() ? "" : ",", nonstatic ? "q q," : ""));
    sb.AppendLine(string.Format("  RETURN_VALUE = -1;"));
    sb.AppendLine(string.Format("  string error=\"\";"));
    sb.AppendLine(string.Format(""));
    sb.AppendLine(string.Format(
     "  return {0} (" + (nonstatic ? "q," : "") + "{1}" + (fullparams.IsNull() == false ? "," : "") +
     "ref RETURN_VALUE,bSupressErrorMessage,ref error);", fullmethodname, fullparamspass));
    sb.AppendLine(string.Format("}}"));

    sb.AppendLine(string.Format("public static bool {0} ({3}{1}{2}ref int RETURN_VALUE, ref string error) {{",
     fullmethodname, fullparams, fullparams.IsNull() ? "" : ",", nonstatic ? "q q," : ""));
    sb.AppendLine(string.Format("  RETURN_VALUE = -1;"));
    sb.AppendLine(string.Format("  bool bSupressErrorMessage = true;"));
    sb.AppendLine(string.Format("  error=\"\";"));
    sb.AppendLine(string.Format(""));
    sb.AppendLine(string.Format(
     "  return {0} (" + (nonstatic ? "q," : "") + "{1}" + (fullparams.IsNull() == false ? "," : "") +
     "ref RETURN_VALUE,bSupressErrorMessage,ref error);", fullmethodname, fullparamspass));
    sb.AppendLine(string.Format("}}"));

    fullparams = "";
    fullparamspass = "";
    foreach (var r in p)
    {
     fullparams = fullparams + (fullparams.IsNull() == false ? ", " : "");
     if (r.sqldataset)
      fullparams = fullparams + string.Format("{0}{1} {2}", r.sqloutput ? "out " : "", r.type, r.name);
     else
      fullparams = fullparams + string.Format("{0}{1} {2}", r.sqloutput ? "ref " : "", r.type, r.name);

     fullparamspass = fullparamspass + (fullparamspass.IsNull() == false ? ", " : "");
     if (r.sqldataset)
      fullparamspass = fullparamspass + string.Format("{0}{1}", r.sqloutput ? "out " : "", r.name);
     else
      fullparamspass = fullparamspass + string.Format("{0}{1}", r.sqloutput ? "ref " : "", r.name);
    }

    sb.AppendLine(string.Format(
     "public static bool {0} ({3}{4}{1}{2}ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {{",
     fullmethodname, fullparams, fullparams.IsNull() ? "" : ",", nonstatic ? "q q," : "", ""));
    sb.AppendLine(string.Format("  error = \"\";"));
    sb.AppendLine(string.Format("  bool r = false;"));
    sb.AppendLine(string.Format(""));
    sb.AppendLine(string.Format("  SqlCommand sc = q.e(\"{0}\"); ", e.sqlname));

    foreach (var r in p)
    {
     //if (r.sqloutput) { continue; }
     if (r.sqlpasstosp == false) continue;

     if (r.sqldataset)
      sb.AppendLine(string.Format("  q.q2u(sc, \"{0}\", \"{2}\", {1});", r.sqlname, r.name, r.sqludt));
     else
      sb.AppendLine(string.Format("  q.{2}(sc, \"{0}\", {1});", r.sqlname, r.name, r.qm));
    }

    if (e.sqlhasdataset)
    {
     sb.AppendLine(string.Format("  tb = new DataTable(\"t\");"));
     sb.AppendLine(string.Format("  if (sc==null) {{ return false; }}"));
     sb.AppendLine(string.Format("  SqlDataAdapter sda = new SqlDataAdapter(sc);"));
     sb.AppendLine(string.Format("  sda.SelectCommand.CommandTimeout = 0;"));
     sb.AppendLine(string.Format("  try {{"));
     sb.AppendLine(string.Format("    sda.Fill(tb);"));
     sb.AppendLine(string.Format("    r = true;"));
     sb.AppendLine(string.Format("  }} catch (Exception e) {{"));
     sb.AppendLine(string.Format("    if (bSupressErrorMessage) {{"));
     sb.AppendLine(string.Format("      error = q.ErrorTextGet(e);"));
     sb.AppendLine(string.Format("    }} else {{"));
     sb.AppendLine(string.Format("      q.ErrorShow(e);"));
     sb.AppendLine(string.Format("    }}"));
     sb.AppendLine(string.Format("    r = false;"));
     sb.AppendLine(string.Format("  }}"));
     sb.AppendLine(string.Format("  sda.Dispose(); sda = null;"));
    }
    else
    {
     sb.AppendLine(string.Format("  if (sc==null) {{ return false; }}"));
     sb.AppendLine(string.Format("  if (bSupressErrorMessage) {{"));
     sb.AppendLine(string.Format("    r = q.x(sc, ref error);"));
     sb.AppendLine(string.Format("  }} else {{"));
     sb.AppendLine(string.Format("    r = q.x(sc);"));
     sb.AppendLine(string.Format("  }}"));
    }

    sb.AppendLine(string.Format("  if (r) {{"));
    sb.AppendLine(string.Format("    RETURN_VALUE = q.gi(sc);"));
    foreach (var r in p)
    {
     if (!(r.sqloutput && r.sqldataset == false)) continue;
     sb.AppendLine(string.Format("   {1} = q.{2}(sc,\"{0}\");", r.sqlname, r.name, r.gm));
    }

    sb.AppendLine(string.Format("  }}"));
    sb.AppendLine(string.Format("  sc.Dispose();sc=null;"));
    sb.AppendLine(string.Format("  return r;"));
    sb.AppendLine(string.Format("}}"));
   }

   sc.Dispose();
   sc = null;

   q.CloseDB();

   sb.AppendLine("}");

   return sb.ToString();
  }

  public static int Generate(string wszInputFilePath, string bstrInputFileContents, string wszOutputFilePath,
   out uint pcbOutput)
  {
   try
   {
    var sqlserver = "";
    var sqldb = "";
    var sqlschema = "";
    var sqlauth = 0;
    var sqllogin = "";
    var sqlpass = "";
    var nonstatic = false;

    var ls = bstrInputFileContents.Split('\n');
    if (1 <= ls.Length) sqlserver = ls[0].Replace("\r", "");
    if (2 <= ls.Length) sqldb = ls[1].Replace("\r", "");
    if (3 <= ls.Length) sqlschema = ls[2].Replace("\r", "");
    if (4 <= ls.Length) sqlauth = Convert.ToInt32(ls[3].Replace("\r", ""));
    if (5 <= ls.Length) sqllogin = ls[4].Replace("\r", "");
    if (6 <= ls.Length) sqlpass = ls[5].Replace("\r", "");
    if (7 <= ls.Length) nonstatic = ls[6].Replace("\r", "") == "nonstatic";

    var s = "";
    try
    {
     s = CsBody(sqlserver, sqldb, sqlschema, sqlauth, sqllogin, sqlpass, nonstatic);
    }
    catch (Exception ex)
    {
     s = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n", sqlserver, sqldb, sqlschema, sqlauth,
      sqllogin, nonstatic, ex.Message);
    }

    var bytes = Encoding.UTF8.GetBytes(s);
    var length = bytes.Length;

    File.WriteAllBytes(wszOutputFilePath, bytes);

    pcbOutput = (uint)length;
   }
   catch (Exception ex)
   {
    pcbOutput = 0;
   }

   return 0;
  }
 }
}