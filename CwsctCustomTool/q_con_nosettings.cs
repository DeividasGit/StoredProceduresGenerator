using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

public sealed class q
{
 public static string sqlapp = "";
 public static string sqlserver = "";
 public static int sqlauth = 0;
 public static string sqllogin = "";
 public static string sqlpass = "";
 public static string sqldb = "";
 public static bool sqlautologin = false;

 public static string defaultdb = "";
 public static SqlConnection conn = null;
 private static Dictionary<string, List<SqlParameter>> paramscache = null;

 private static string connstr_winauth =
  @"Data Source={0};Connection Timeout=10;Application Name={1};Trusted_Connection=Yes";

 private static string connstr_sqlauth =
  @"Data Source={0};Connection Timeout=10;Application Name={1};User Id={2};Password={3}";

 private static readonly q instance = new q();

 private q()
 {
 }

 public static q Instance => instance;

 public static void InfoShow(string msg)
 {
  Console.WriteLine(msg);
 }

 public static string ErrorTextGet(Exception ex)
 {
  return ex.Message;
 }

 public static string ErrorTextGet(SqlException ex)
 {
  var s = "";
  foreach (SqlError se in ex.Errors)
  {
   if (se.Class == 0) continue;
   if (se.Class == 16)
   {
    s = s + se.Message + "\r\n\r\n\r\n";
    continue;
   }

   s = s + se.Message + "\r\n\r\n\r\n" +
       "  Proc: " + se.Procedure + "\r\n" +
       "  Application: " + sqlapp + "\r\n";
  }

  return s;
 }

 public static void ErrorShow(string msg)
 {
  Console.WriteLine(msg);
 }

 public static void ErrorShow(Exception ex)
 {
  ErrorShow(ErrorTextGet(ex));
 }

 public static void ErrorShow(SqlException ex)
 {
  ErrorShow(ErrorTextGet(ex));
 }

 private static bool OpenDB()
 {
  return OpenDB(true);
 }

 private static bool OpenDB(bool bUI)
 {
  var bisconnected = false;

  lock ("sql_opendb")
  {
   if (conn != null)
   {
    bisconnected = conn.State == ConnectionState.Open || conn.State == ConnectionState.Executing ||
                   conn.State == ConnectionState.Connecting || conn.State == ConnectionState.Fetching;
    if (bisconnected) return true;
   }

   if (sqlserver == "") return false;
   if (sqlauth == 1)
   {
    if (sqllogin == "") return false;
    if (sqlpass == "") return false;
   }

   var connstr = string.Format(sqlauth == 0 ? connstr_winauth : connstr_sqlauth, sqlserver, sqlapp, sqllogin, sqlpass);

   if (sqldb != "") connstr = connstr + string.Format(";Initial Catalog={0}", sqldb);

   if (bUI)
   {
    conn = new SqlConnection(connstr);
    try
    {
     conn.Open();
    }
    catch (Exception e)
    {
     ErrorShow(e.Message);
     conn = null;
    }
   }
   else
   {
    var retry = 0;
    while (retry <= 1)
    {
     conn = new SqlConnection(connstr);
     try
     {
      conn.Open();
      break;
     }
     catch
     {
      conn = null;
     }

     retry++;
    }
   }

   if (conn != null)
    bisconnected = conn.State == ConnectionState.Open || conn.State == ConnectionState.Executing ||
                   conn.State == ConnectionState.Connecting || conn.State == ConnectionState.Fetching;

   return bisconnected;
  }
 }

 public static bool CheckDB(bool bUI)
 {
  return OpenDB(bUI);
 }

 public static void CloseDB()
 {
  if (conn == null) return;
  conn.Close();
  conn.Dispose();
  conn = null;
 }

 private static bool UpdateCache(SqlCommand sc)
 {
  if (paramscache == null) paramscache = new Dictionary<string, List<SqlParameter>>();

  var bhascache = paramscache.ContainsKey(sc.CommandText);

  if (bhascache)
  {
   if (sc.Parameters.Count == 0)
   {
    var lp2 = paramscache[sc.CommandText];
    foreach (var sp in lp2)
    {
     var cachesp = (SqlParameter)((ICloneable)sp).Clone();
     sc.Parameters.Add(cachesp);
     cachesp.Value = DBNull.Value;
    }
   }
  }
  else
  {
   try
   {
    SqlCommandBuilder.DeriveParameters(sc);
   }
   catch (Exception ex)
   {
    ErrorShow(ex);
    return false;
   }

   var lp = new List<SqlParameter>();
   foreach (SqlParameter sp in sc.Parameters)
   {
    sp.Value = DBNull.Value;
    var cachesp = (SqlParameter)((ICloneable)sp).Clone();
    lp.Add(cachesp);
   }

   paramscache.Add(sc.CommandText, lp);
  }

  return true;
 }

 public static SqlDataReader r(string cmd)
 {
  if (OpenDB() == false) return null;

  var sc = new SqlCommand(cmd, conn);
  sc.CommandTimeout = 0;
  SqlDataReader sdr;

  try
  {
   sdr = sc.ExecuteReader();
  }
  catch (Exception e)
  {
   ErrorShow(e);
   sdr = null;
  }

  return sdr;
 }

 public static SqlDataReader r(SqlCommand sc)
 {
  if (OpenDB() == false) return null;

  sc.CommandTimeout = 0;
  SqlDataReader sdr;

  try
  {
   sdr = sc.ExecuteReader();
  }
  catch (Exception e)
  {
   ErrorShow(e);
   sdr = null;
  }

  return sdr;
 }

 public static SqlCommand e(string cmd)
 {
  if (OpenDB() == false) return null;

  var sc = new SqlCommand();
  sc.Connection = conn;
  sc.CommandTimeout = 0;
  sc.CommandType = CommandType.StoredProcedure;
  sc.CommandText = cmd;

  if (UpdateCache(sc) == false) return null;

  return sc;
 }

 public static bool x(SqlCommand sc)
 {
  if (sc == null)
  {
   ErrorShow("Object is not initialized");
   return false;
  }

  var b = false;
  try
  {
   sc.ExecuteNonQuery();
   b = true;
  }
  catch (SqlException e)
  {
   ErrorShow(e);
  }
  catch (Exception e)
  {
   ErrorShow(e);
  }

  return b;
 }

 public static bool x(SqlCommand sc, ref string error)
 {
  error = "";
  if (sc == null)
  {
   error = "SqlCommand object is not initialized";
   return false;
  }

  var b = false;
  try
  {
   sc.ExecuteNonQuery();
   b = true;
  }
  catch (SqlException e)
  {
   error = ErrorTextGet(e);
  }
  catch (Exception e)
  {
   error = ErrorTextGet(e);
  }

  return b;
 }

 public static DataSet d(string cmd)
 {
  if (OpenDB() == false) return null;

  var sda = new SqlDataAdapter(cmd, conn);

  var sds = new DataSet();
  sda.Fill(sds);

  /* TODO: convert all UTC datetime to localdatetime */

  return sds;
 }

 public static DataSet d(SqlCommand sc)
 {
  if (OpenDB() == false) return null;

  var sda = new SqlDataAdapter(sc);

  var sds = new DataSet();
  sda.Fill(sds);

  /* TODO: convert all UTC datetime to localdatetime */

  return sds;
 }

 public static string gs(object o)
 {
  return gs(o, true);
 }

 public static string gs(object o, bool trimend)
 {
  if (o == null) return "";
  if (o == DBNull.Value) return "";

  if (trimend)
   return o.ToString().TrimEnd();
  else
   return o.ToString();
 }

 public static string gs(SqlCommand sc, string paramname)
 {
  return gs(sc, paramname, true);
 }

 public static string gs(SqlCommand sc, string paramname, bool trim)
 {
  if (sc.Parameters[paramname].SqlDbType == SqlDbType.Date)
  {
   var o = sc.Parameters[paramname].Value;
   if (o == null) return "";
   if (o == DBNull.Value) return "";

   return ((DateTime)o).ToShortDateString();
  }
  else if (sc.Parameters[paramname].SqlDbType == SqlDbType.Decimal ||
           sc.Parameters[paramname].SqlDbType == SqlDbType.Money)
  {
   var o = sc.Parameters[paramname].Value;
   if (o == null) return "";
   if (o == DBNull.Value) return "";

   return ((decimal)o).ToString("#,##0.##");
  }
  else
  {
   return gs(sc.Parameters[paramname].Value, trim);
  }
 }

 public static int gidef(object o, int def)
 {
  if (o == null) return def;
  if (o == DBNull.Value) return def;

  var s = o.ToString();

  var i = -1;
  i = def;
  var b = int.TryParse(s, out i);
  if (b)
  {
   return i;
  }
  else
  {
   i = def;
   return i;
  }
 }

 public static int gidef(SqlCommand sc, string param, int def)
 {
  return gidef(sc.Parameters[param].Value, def);
 }

 public static long gi64def(object o, long def)
 {
  if (o == null) return def;
  if (o == DBNull.Value) return def;

  var s = o.ToString();

  long i = -1;
  i = def;
  var b = long.TryParse(s, out i);
  if (b)
  {
   return i;
  }
  else
  {
   i = def;
   return i;
  }
 }

 public static int gi(object o)
 {
  return gidef(o, -1);
 }

 public static int gi(SqlCommand sc)
 {
  return gi(sc, "@RETURN_VALUE");
 }

 public static int gi(SqlCommand sc, string paramname)
 {
  return gi(sc.Parameters[paramname].Value);
 }

 public static long gi64(object o)
 {
  return gi64def(o, -1);
 }

 public static DateTime gdt(object o)
 {
  if (o == null) return DateTime.MinValue;
  if (o == DBNull.Value) return DateTime.MinValue;

  return (DateTime)o;
 }

 public static DateTime gdt(SqlCommand sc, string paramname)
 {
  return gdt(sc.Parameters[paramname].Value);
 }

 public static bool gb(object o)
 {
  if (o is bool) return (bool)o;

  return gs(o) == "1";
 }

 public static bool gb(SqlCommand sc, string paramname)
 {
  if (sc == null) return false;

  return gb(sc.Parameters[paramname].Value);
 }

 public static string ge(SqlCommand sc, string paramname, string format)
 {
  return ge(sc.Parameters[paramname].Value, format);
 }

 public static string ge(object o, string format)
 {
  if (o == null) return "";
  if (o == DBNull.Value) return "";

  if (format == "") format = "#,##0.##";

  return ((decimal)o).ToString(format);
 }

 public static decimal ge(SqlCommand sc, string paramname)
 {
  return ge(sc.Parameters[paramname].Value);
 }

 public static decimal ge(object o)
 {
  if (o == null) return 0;
  if (o == DBNull.Value) return 0;

  return (decimal)o;
 }

 public static Guid gg(object o)
 {
  if (o == null) return Guid.Empty;
  if (o == DBNull.Value) return Guid.Empty;

  return (Guid)o;
 }

 public static Guid gg(SqlCommand sc, string paramname)
 {
  return gg(sc.Parameters[paramname].Value);
 }

 public static byte[] ga(object o)
 {
  if (o == null) return null;
  if (o == DBNull.Value) return null;

  return (byte[])o;
 }

 public static byte[] ga(SqlCommand sc, string paramname)
 {
  if (sc == null) return null;

  return ga(sc.Parameters[paramname].Value);
 }

 public static int q2b(bool b)
 {
  var bs = 0;

  if (b)
   bs = 1;
  else
   bs = 0;
  return bs;
 }

 public static void q2b(SqlCommand sc, string param, bool b)
 {
  if (sc == null) return;
  sc.Parameters[param].Value = q2b(b);
 }

 public static object q2i(string s)
 {
  if (s == null) return DBNull.Value;
  if (s == "") return DBNull.Value;

  var i = -1;
  var b = int.TryParse(s, out i);
  if (b == false) return DBNull.Value;

  return i;
 }

 public static void q2i(SqlCommand sc, string param, string s)
 {
  if (sc == null) return;

  sc.Parameters[param].Value = q2i(s);
 }

 public static object q2i(int i)
 {
  if (i == -1) return DBNull.Value;

  return i;
 }

 public static object q2idef(int i, int def)
 {
  if (i == def) return DBNull.Value;

  return i;
 }

 public static void q2i(SqlCommand sc, string param, int i)
 {
  if (sc == null) return;
  sc.Parameters[param].Value = q2i(i);
 }

 public static void q2i(SqlCommand sc, string param, int i, int def)
 {
  if (sc == null) return;
  sc.Parameters[param].Value = q2idef(i, def);
 }

 public static object q2i(long i)
 {
  if (i == -1) return DBNull.Value;
  return i;
 }

 public static void q2i(SqlCommand sc, string param, long i)
 {
  if (sc == null) return;
  sc.Parameters[param].Value = q2i(i);
 }

 public static object q2s(string s)
 {
  if (s == null) return DBNull.Value;
  if (s == "") return DBNull.Value;

  return s;
 }

 public static void q2s(SqlCommand sc, string param, string s)
 {
  if (sc == null) return;
  sc.Parameters[param].Value = q2s(s);
 }

 public static void q2s(SqlCommand sc, string param, byte[] a)
 {
  if (sc == null) return;
  sc.Parameters[param].Value = q2a(a);
 }

 public static object q2e(string s)
 {
  if (s == null) return DBNull.Value;
  if (s == "") return DBNull.Value;

  decimal e = 0;
  var b = decimal.TryParse(s, out e);
  if (b == false) return DBNull.Value;

  return e;
 }

 public static void q2e(SqlCommand sc, string param, string s)
 {
  if (sc == null) return;
  sc.Parameters[param].Value = q2e(s);
 }

 public static object q2e(decimal e)
 {
  return e;
 }

 public static void q2e(SqlCommand sc, string param, decimal e)
 {
  if (sc == null) return;
  sc.Parameters[param].Value = q2e(e);
 }

 public static object q2dt(DateTime dt)
 {
  if (dt == DateTime.MinValue)
   return DBNull.Value;
  else
   return dt;
 }

 public static object q2dt(DateTimeOffset dt)
 {
  if (dt == DateTimeOffset.MinValue)
   return DBNull.Value;
  else
   return dt;
 }

 public static void q2dt(SqlCommand sc, string param, DateTime dt)
 {
  if (sc == null) return;
  sc.Parameters[param].Value = q2dt(dt);
 }

 public static void q2dt(SqlCommand sc, string param, DateTimeOffset dt)
 {
  if (sc == null) return;
  sc.Parameters[param].Value = q2dt(dt);
 }

 public static object q2a(byte[] a)
 {
  if (a.Length == 0) return DBNull.Value;
  return a;
 }

 public static void q2a(SqlCommand sc, string param, byte[] a)
 {
  if (sc == null) return;
  sc.Parameters[param].Value = q2a(a);
 }

 public static object q2m(string s)
 {
  if (s == "" || s == null) return DBNull.Value;

  decimal i = -1;
  var b = decimal.TryParse(s, out i);
  if (b == false) return DBNull.Value;

  return i;
 }

 public static void q2m(SqlCommand sc, string paramname, string s)
 {
  sc.Parameters[paramname].Value = q2m(s);
 }

 public static object q2m(decimal m, bool b0isnull)
 {
  if (m == 0 && b0isnull) return DBNull.Value;

  return m;
 }

 public static void q2m(SqlCommand sc, string paramname, decimal m, bool b0isnull)
 {
  sc.Parameters[paramname].Value = q2m(m, b0isnull);
 }

 public static void q2u(SqlCommand sc, string paramname, string udt, DataTable dt)
 {
  if (sc == null) return;

  if (dt == null)
  {
   sc.Parameters[paramname].UdtTypeName = udt;
   sc.Parameters[paramname].Value = DBNull.Value;
   return;
  }

  sc.Parameters[paramname].UdtTypeName = udt;
  sc.Parameters[paramname].Value = dt;
 }

 public static string Base64StringToHexString(string base64String)
 {
  var bytes = Convert.FromBase64String(base64String);

  var sbHexString = new StringBuilder();
  for (var i = 0; i < bytes.Length; i++) sbHexString.Append(bytes[i].ToString("X2"));
  return sbHexString.ToString();
 }

 public static byte[] StringToByteArray(string hex)
 {
  var NumberChars = hex.Length;
  var bytes = new byte[NumberChars / 2];
  for (var i = 0; i < NumberChars; i += 2) bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
  return bytes;
 }
}