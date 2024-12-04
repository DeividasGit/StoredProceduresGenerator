using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CwsctCustomTool
{
 public class param
 {
  public string sqlname = "";
  public bool sqloutput = false;
  public bool sqlbool = false;
  public bool sqldataset = false;
  public bool sqlreturnvalue = false;
  public string sqltype = "";
  public string sqludt = "";
  public bool sqlpasstosp = true;

  public string name
  {
   get
   {
    var n = "";
    if (sqlname.StartsWith("@"))
     n = sqlname.Substring(1);
    else
     n = sqlname;
    if (n == "readonly") n = "_readonly";
    if (n == "class") n = "_class";
    if (n == "object") n = "_object";

    return n;
   }
  }

  public string type
  {
   get
   {
    var s = "";

    if (sqlbool)
    {
     s = s + "bool";
     goto ex;
    }

    if (sqldataset)
    {
     s = s + "DataTable";
     goto ex;
    }

    if (sqltype == "bigint")
    {
     s = s + "long";
     goto ex;
    }

    if (sqltype == "binary")
    {
     s = s + "byte[]";
     goto ex;
    }

    if (sqltype == "bit")
    {
     s = s + "int";
     goto ex;
    }

    if (sqltype == "char")
    {
     s = s + "string";
     goto ex;
    }

    if (sqltype == "date")
    {
     s = s + "DateTime";
     goto ex;
    }

    if (sqltype == "datetime")
    {
     s = s + "DateTime";
     goto ex;
    }

    if (sqltype == "datetime2")
    {
     s = s + "DateTime2";
     goto ex;
    }

    if (sqltype == "datetimeoffset")
    {
     s = s + "DateTimeOffset";
     goto ex;
    }

    if (sqltype == "decimal")
    {
     s = s + "decimal";
     goto ex;
    }

    if (sqltype == "float")
    {
     s = s + "double";
     goto ex;
    }

    if (sqltype == "image")
    {
     s = s + "byte[]";
     goto ex;
    }

    if (sqltype == "int")
    {
     s = s + "int";
     goto ex;
    }

    if (sqltype == "money")
    {
     s = s + "decimal";
     goto ex;
    }

    if (sqltype == "nchar")
    {
     s = s + "string";
     goto ex;
    }

    if (sqltype == "ntext")
    {
     s = s + "string";
     goto ex;
    }

    if (sqltype == "numeric")
    {
     s = s + "decimal";
     goto ex;
    }

    if (sqltype == "nvarchar")
    {
     s = s + "string";
     goto ex;
    }

    if (sqltype == "real")
    {
     s = s + "decimal";
     goto ex;
    }

    if (sqltype == "smalldatetime")
    {
     s = s + "DateTime";
     goto ex;
    }

    if (sqltype == "smallint")
    {
     s = s + "int";
     goto ex;
    }

    if (sqltype == "smallmoney")
    {
     s = s + "decimal";
     goto ex;
    }

    if (sqltype == "text")
    {
     s = s + "string";
     goto ex;
    }

    if (sqltype == "time")
    {
     s = s + "TimeSpan";
     goto ex;
    }

    if (sqltype == "timestamp")
    {
     s = s + "TimeSpan";
     goto ex;
    }

    if (sqltype == "tinyint")
    {
     s = s + "int";
     goto ex;
    }

    if (sqltype == "uniqueidentifier")
    {
     s = s + "Guid";
     goto ex;
    }

    if (sqltype == "varbinary")
    {
     s = s + "byte[]";
     goto ex;
    }

    if (sqltype == "varchar")
    {
     s = s + "string";
     goto ex;
    }

    if (sqltype == "xml")
    {
     s = s + "string";
     goto ex;
    }

    s = s + sqltype;
    ex:
    return s;
   }
  }

  public string fqdn
  {
   get
   {
    var s = "";
    if (sqloutput) s = "ref ";
    s = s + name;
    s = s + " " + type;
    return s;
   }
  }

  public string qm
  {
   get
   {
    var s = "";
    if (type == "bool")
    {
     s = "q2b";
     goto ex;
    }

    if (type.In("int", "long"))
    {
     s = "q2i";
     goto ex;
    }

    if (type.In("decimal"))
    {
     s = "q2e";
     goto ex;
    }

    if (type.In("double"))
    {
     s = "q2l";
     goto ex;
    }

    if (sqltype == "date")
    {
     s = "q2d";
     goto ex;
    }

    if (type.In("DateTime", "DateTime2", "DateTimeOffset"))
    {
     s = "q2dt";
     goto ex;
    }

    if (type.In("TimeSpan"))
    {
     s = "q2tm";
     goto ex;
    }

    if (type.In("Guid"))
    {
     s = "q2g";
     goto ex;
    }

    if (type.In("byte[]"))
    {
     s = "q2a";
     goto ex;
    }

    s = "q2s";

    ex:
    return s;
   }
  }

  public string gm
  {
   get
   {
    var s = "";
    if (type == "bool")
    {
     s = "gb";
     goto ex;
    }

    if (type.In("int", "long"))
    {
     s = "gi";
     goto ex;
    }

    if (type.In("decimal"))
    {
     s = "ge";
     goto ex;
    }

    if (type.In("double"))
    {
     s = "gl";
     goto ex;
    }

    if (sqltype == "date")
    {
     s = "gd";
     goto ex;
    }

    if (type.In("DateTime", "DateTime2"))
    {
     s = "gdt";
     goto ex;
    }

    if (type.In("DateTimeOffset"))
    {
     s = "gdto";
     goto ex;
    }

    if (type.In("TimeSpan"))
    {
     s = "gtm";
     goto ex;
    }

    if (type.In("Guid"))
    {
     s = "gg";
     goto ex;
    }

    if (type.In("byte[]"))
    {
     s = "ga";
     goto ex;
    }

    s = "gs";

    ex:
    return s;
   }
  }
 }

 public class method
 {
  public string sqlname;
  public string sqlproc;
  public int sqlobjectid;
  public bool sqlhasdataset;

  public string name
  {
   get
   {
    var s = sqlproc;
    var c = s.ToLower().ToCharArray();
    var b = true;
    for (var i = 0; i < c.Length; i++)
    {
     if (b)
     {
      c[i] = c[i].ToString().ToUpper()[0];
      b = false;
     }

     if (c[i] == '_') b = true;
    }

    var a = new string(c);
    a = a.Replace("_", "");
    return a;
   }
  }
 }
}

namespace ui
{
 public static class Environment4
 {
  public static bool bUTC = true;
 }
}