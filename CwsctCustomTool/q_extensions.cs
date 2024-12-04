using System;
using System.Net.NetworkInformation;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Data;
using System.Reflection;

public static class qext
{
 public static void si(this DataRow dr, string fieldname, int newvalue)
 {
  if (dr == null) return;

  var tb = dr.Table;
  if (tb == null) return;

  if (tb.Columns.Contains(fieldname) == false)
   foreach (DataColumn dc in tb.Columns)
    if (dc.ColumnName.ToLower().StartsWith(fieldname.ToLower() + "!"))
    {
     fieldname = dc.ColumnName;
     break;
    }

  if (tb.Columns.Contains(fieldname) == false) return;

  dr[fieldname] = newvalue;
 }

 public static void ss(this DataRow dr, string fieldname, string newvalue)
 {
  if (dr == null) return;

  var tb = dr.Table;
  if (tb == null) return;

  if (tb.Columns.Contains(fieldname) == false)
   foreach (DataColumn dc in tb.Columns)
    if (dc.ColumnName.ToLower().StartsWith(fieldname.ToLower() + "!"))
    {
     fieldname = dc.ColumnName;
     break;
    }

  if (tb.Columns.Contains(fieldname) == false) return;

  dr[fieldname] = newvalue;
 }

 public static void se(this DataRow dr, string fieldname, decimal newvalue)
 {
  if (dr == null) return;

  var tb = dr.Table;
  if (tb == null) return;

  if (tb.Columns.Contains(fieldname) == false)
   foreach (DataColumn dc in tb.Columns)
    if (dc.ColumnName.ToLower().StartsWith(fieldname.ToLower() + "!"))
    {
     fieldname = dc.ColumnName;
     break;
    }

  if (tb.Columns.Contains(fieldname) == false) return;

  dr[fieldname] = newvalue;
 }

 public static void snull(this DataRow dr, string fieldname)
 {
  if (dr == null) return;

  var tb = dr.Table;
  if (tb == null) return;

  if (tb.Columns.Contains(fieldname) == false)
   foreach (DataColumn dc in tb.Columns)
    if (dc.ColumnName.ToLower().StartsWith(fieldname.ToLower() + "!"))
    {
     fieldname = dc.ColumnName;
     break;
    }

  if (tb.Columns.Contains(fieldname) == false) return;

  dr[fieldname] = DBNull.Value;
 }

 private static object go(DataRow dr, string fieldname)
 {
  if (dr == null) return null;

  var tb = dr.Table;
  if (tb == null) return null;

  if (tb.Columns.Contains(fieldname) == false)
   foreach (DataColumn dc in tb.Columns)
    if (dc.ColumnName.ToLower().StartsWith(fieldname.ToLower() + "!"))
    {
     fieldname = dc.ColumnName;
     break;
    }

  if (tb.Columns.Contains(fieldname) == false) return null;

  return dr[fieldname];
 }

 public static int gi(this DataRow dr)
 {
  if (dr == null) return -1;
  if (dr.Table.Columns.Contains("ID") == false) return -1;
  if (dr["ID"] == null) return -1;
  if (dr["ID"] == DBNull.Value) return -1;
  return (int)dr["ID"];
 }

 public static int gi(this DataRow dr, string fieldname)
 {
  var o = go(dr, fieldname);

  if (o == null) return -1;
  if (o == DBNull.Value) return -1;

  if (o is byte) return (int)(byte)o;
  if (o is short) return (int)(short)o;
  return (int)o;
 }

 public static string gs(this DataRow dr, string fieldname)
 {
  var o = go(dr, fieldname);

  if (o == null) return "";
  if (o == DBNull.Value) return "";
  return (string)o;
 }

 public static byte[] ga(this DataRow dr, string fieldname)
 {
  var o = go(dr, fieldname);

  if (o == null) return null;
  if (o == DBNull.Value) return null;
  return (byte[])o;
 }

 public static decimal ge(this DataRow dr, string fieldname)
 {
  var o = go(dr, fieldname);

  if (o == null) return 0;
  if (o == DBNull.Value) return 0;
  return (decimal)o;
 }

 public static DateTime gd(this DataRow dr, string fieldname)
 {
  var o = go(dr, fieldname);

  if (o == null) return DateTime.MinValue;
  if (o == DBNull.Value) return DateTime.MinValue;
  return (DateTime)o;
 }

 public static DateTime gdt(this DataRow dr, string fieldname)
 {
  var o = go(dr, fieldname);

  if (o == null) return DateTime.MinValue;
  if (o == DBNull.Value) return DateTime.MinValue;

  var dt = (DateTime)o;

  if (ui.Environment4.bUTC) dt = DateTime.SpecifyKind(dt, DateTimeKind.Utc);

  return dt;
 }

 public static bool gb(this DataRow dr, string fieldname)
 {
  var o = go(dr, fieldname);

  if (o == null) return false;
  if (o == DBNull.Value) return false;

  var b = false;
  if (o.GetType() == typeof(byte)) b = (byte)o == 1;
  if (o.GetType() == typeof(int)) b = (int)o == 1;
  if (o.GetType() == typeof(short)) b = (short)o == 1;
  if (o.GetType() == typeof(bool)) b = (bool)o == true;
  return b;
 }
 // negalima dėl q.EnvironmentUTC
 //public static DateTime gdt(this DataRow dr, string fieldname) {
 //  if (dr.Table.Columns.Contains(fieldname) == false) { return DateTime.MinValue; }
 //  if (dr[fieldname] == null) { return DateTime.MinValue; }
 //  if (dr[fieldname] == DBNull.Value) { return DateTime.MinValue; }

 //  DateTime dt = (DateTime)dr[fieldname];

 //  if (q.EnvironmentUTC) { dt = DateTime.SpecifyKind(dt, DateTimeKind.Utc); }
 //  return dt;
 //}

 public static bool IsValuesEmpty(this DataRow dr)
 {
  var bIsEmpty = true;

  foreach (var o in dr.ItemArray)
  {
   if (o == null) continue;
   if (o == DBNull.Value) continue;

   if (o is string)
    if ((o as string).IsNull() == false)
    {
     bIsEmpty = false;
     break;
    }

   if (o is decimal)
    if ((decimal)o != 0)
    {
     bIsEmpty = false;
     break;
    }

   if (o is int)
    if ((int)o != 0)
    {
     bIsEmpty = false;
     break;
    }

   if (o is byte)
    if ((byte)o != 0)
    {
     bIsEmpty = false;
     break;
    }

   if (o is short)
    if ((short)o != 0)
    {
     bIsEmpty = false;
     break;
    }

   if (o is DateTime)
    if ((DateTime)o != DateTime.MinValue)
    {
     bIsEmpty = false;
     break;
    }
   // bool nėra kaip tikrinti
  }

  return bIsEmpty;
 }

 public static string WordFirst(this string s)
 {
  //string word = "";

  var x = s.IndexOf(" ");
  if (x == -1) return s;

  return s.SqlSubstring(0, x);
 }

 public static string WordLast(this string s)
 {
  var x = s.LastIndexOf(" ");
  if (x == -1) return s;

  return s.SqlSubstring(x + 1);
 }

 public static string ConvertToLatin(this string s)
 {
  s = s.Replace("ą", "a");
  s = s.Replace("č", "c");
  s = s.Replace("ę", "e");
  s = s.Replace("ė", "e");
  s = s.Replace("į", "i");
  s = s.Replace("ų", "u");
  s = s.Replace("ū", "u");
  s = s.Replace("š", "s");
  s = s.Replace("ž", "z");
  s = s.Replace("Ą", "A");
  s = s.Replace("Č", "C");
  s = s.Replace("Ę", "E");
  s = s.Replace("Ė", "E");
  s = s.Replace("Į", "I");
  s = s.Replace("Ų", "U");
  s = s.Replace("Ū", "U");
  s = s.Replace("Š", "S");
  s = s.Replace("Ž", "Z");

  return s;
 }

 public static bool NotNull(this string s)
 {
  return string.IsNullOrEmpty(s) == false;
 }

 public static bool IsNull(this string s)
 {
  return string.IsNullOrEmpty(s);
 }

 public static bool In(this int i, params int[] arr)
 {
  foreach (var ii in arr)
   if (ii == i)
    return true;
  return false;
 }

 public static bool In(this string s, params string[] arr)
 {
  foreach (var n in arr)
  {
   var b = n.Equals(s, StringComparison.CurrentCultureIgnoreCase);
   if (b) return true;
  }

  return false;
 }

 public static bool In(this string s, bool partial, params string[] arr)
 {
  if (partial)
  {
   s = s.ToLower();
   foreach (var n in arr)
   {
    var a = n.ToLower();
    if (a.StartsWith(n)) return true;
   }
  }
  else
  {
   foreach (var n in arr)
   {
    var b = n.Equals(s, StringComparison.CurrentCultureIgnoreCase);
    if (b) return true;
   }
  }

  return false;
 }

 public static bool In(this string s, params int[] arr)
 {
  foreach (var n in arr)
  {
   var b = n.ToString().Equals(s, StringComparison.CurrentCultureIgnoreCase);
   if (b) return true;
  }

  return false;
 }

 public static bool NotIn(this string s, params string[] arr)
 {
  foreach (var n in arr)
  {
   var b = n.Equals(s, StringComparison.CurrentCultureIgnoreCase);
   if (b) return false;
  }

  return true;
 }

 public static bool NotIn(this string s, bool partial, params string[] arr)
 {
  if (partial)
  {
   s = s.ToLower();
   foreach (var n in arr)
   {
    var a = n.ToLower();
    if (a.StartsWith(n)) return false;
   }
  }
  else
  {
   foreach (var n in arr)
   {
    var b = n.Equals(s, StringComparison.CurrentCultureIgnoreCase);
    if (b) return false;
   }
  }

  return true;
 }

 public static string Left(this string s, int charcount)
 {
  if (charcount > s.Length || charcount < 0)
   return "";
  else
   return s.Substring(0, charcount);
 }

 public static string Right(this string s, int charcount)
 {
  if (charcount > s.Length || charcount < 0)
   return "";
  else
   return s.Substring(s.Length - charcount, charcount);
 }

 public static string SqlSubstring(this string s, int start, int length)
 {
  var l = s.Length;
  if (start < 0) return "";
  if (start >= l) return "";

  if (start + length >= l)
   return s.Substring(start);
  else
   return s.Substring(start, length);
 }

 public static string SqlSubstring(this string s, int start)
 {
  var l = s.Length;
  if (start < 0) return "";
  if (start >= l) return "";

  return s.Substring(start);
 }

 public static decimal HoursFromString(this string s)
 {
  decimal e = 0;

  var b = decimal.TryParse(s, out e);
  if (b) return e;

  var tsp = s.TimeSpanFromString(false);

  return (decimal)tsp.TotalHours;
 }

 public static TimeSpan TimeSpanFromString(this string s, bool bEOD)
 {
  if (s == "")
  {
   if (bEOD)
   {
    return new TimeSpan(0, 23, 59, 59, 999);
    ;
   }
   else
   {
    return new TimeSpan(0, 0, 0);
   }
  }

  var t = s;
  var tsp = new TimeSpan(0, 0, 0);

  if (t.Contains(":") == false)
  {
   if (t.Length == 1)
   {
    t = "0" + t + ":00";
   }
   else if (t.Length == 2)
   {
    t = t + ":00";
   }
   else if (t.Length == 3)
   {
    t = "0" + t;
    t = t.Insert(2, ":");
   }
   else if (t.Length == 4)
   {
    t = t.Insert(2, ":");
   }
  }
  else
  {
   if (t.Length == 4) t = "0" + t;
  }

  //bool b = TimeSpan.TryParseExact(t, "HH:mm", null, out tsp);
  var b = TimeSpan.TryParseExact(t, "hh\\:mm", CultureInfo.CurrentCulture, out tsp);
  if (b == false) return new TimeSpan(0, 0, 0);

  return tsp;
 }

 public static DateTime DateFromString(this string s)
 {
  if (s.IsNull()) return DateTime.MinValue;

  var dt = DateTime.MinValue;

  var b = DateTime.TryParse(s, out dt);
  if (b)
  {
   dt = DateTime.SpecifyKind(dt, DateTimeKind.Local);
   return dt;
  }

  var i = 0;
  var t = "";
  while (i < s.Length)
  {
   if (char.IsDigit(s[i])) t = t + s[i];
   i++;
  }

  if (t.IsNull()) return DateTime.MinValue;

  if (t.Length > 8) t = t.Substring(0, 8);

  if (t.Length == 1) t = "0" + t;
  if (t.Length == 3) t = "0" + t;

  if (t.Length == 2) t = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("00") + t;
  if (t.Length == 4) t = DateTime.Now.Year.ToString() + t;

  if (t.Length < 8)
  {
   var tt = DateTime.Now.ToString("yyyyMMdd");
   t = tt.SqlSubstring(0, 8 - t.Length) + t;
  }

  t = t.Insert(4, "-");
  t = t.Insert(7, "-");
  if (t.EndsWith("00")) t = t.Substring(0, t.Length - 2) + "01";
  b = DateTime.TryParseExact(t, "yyyy-MM-dd", null, DateTimeStyles.AssumeLocal, out dt);
  if (b == false) dt = DateTime.MinValue;
  return dt;
 }

 public static DateTime DateFromString(this string s, bool bEOM)
 {
  var dt = s.DateFromString();

  if (bEOM)
   if (dt != DateTime.MinValue)
    dt = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));

  return dt;
 }

 public static string dts(this DateTime dt)
 {
  if (dt == DateTime.MinValue) return "";
  if (dt.Year == 1753) return "";
  if (dt.Kind == DateTimeKind.Utc) dt = dt.ToLocalTime();
  return dt.ToShortDateString();
 }

 public static string mts(this DateTime dt)
 {
  if (dt == DateTime.MinValue) return "";
  if (dt.Year == 1753) return "";
  if (dt.Kind == DateTimeKind.Utc) dt = dt.ToLocalTime();
  return dt.ToString("yyyy-MM");
 }

 public static string tms(this DateTime dt)
 {
  if (dt == DateTime.MinValue) return "";
  if (dt.Kind == DateTimeKind.Utc) dt = dt.ToLocalTime();
  return dt.ToShortTimeString();
 }

 public static string dtms(this DateTime dt)
 {
  if (dt == DateTime.MinValue) return "";
  if (dt.Year == 1753) return "";

  if (dt.Kind == DateTimeKind.Utc) dt = dt.ToLocalTime();

  return dt.ToShortDateString() + " " + dt.ToShortTimeString();
 }

 public static DateTime DateTimeSince(this string s)
 {
  var dt = DateTime.MinValue;
  if (s.IsNull()) return dt;

  if (s.Contains("..") == false)
  {
   dt = DateFromString(s);
   return dt;
  }

  var s1 = s.Substring(0, s.IndexOf(".."));
  if (s1.IsNull()) return dt;

  dt = DateFromString(s1);
  return dt;
 }

 public static DateTime DateTimeTill(this string s)
 {
  var dt = DateTime.MinValue;
  if (s.IsNull()) return dt;
  if (s.Contains("..") == false)
  {
   dt = DateFromString(s);
   return dt;
  }

  var s1 = s.Substring(s.IndexOf("..") + 2);
  if (s1.IsNull()) return dt;
  dt = DateFromString(s1);
  return dt;
 }

 public static bool MonthSame(this DateTime dt, DateTime comparedt)
 {
  return dt.Month == comparedt.Month && dt.Year == comparedt.Year;
 }

 public static bool MonthGreather(this DateTime dt, DateTime comparedt)
 {
  return dt.Year > comparedt.Year || (dt.Year == comparedt.Year && dt.Month > comparedt.Month);
 }

 public static bool InBeginning(this string s, params string[] arr)
 {
  for (var i = 0; i < arr.Length; i++)
   if (s.StartsWith(arr[i]))
    return true;

  return false;
 }

 public static DateTime bom(this DateTime dt)
 {
  return new DateTime(dt.Year, dt.Month, 1);
 }

 public static DateTime eom(this DateTime dt)
 {
  return new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
 }

 public static DateTime eoy(this DateTime dt)
 {
  return new DateTime(dt.Year, 12, 31);
 }

 public static DateTime eolq(this DateTime dt)
 {
  // end of last quarter
  var currq = (dt.Month - 1) / 3 + 1;
  return new DateTime(dt.Year, 3 * currq - 2, 1).AddDays(-1);
 }

 public static bool IsNull(this DateTime dt)
 {
  return dt == DateTime.MinValue;
 }

 public static bool IsNotNull(this DateTime dt)
 {
  return dt != DateTime.MinValue;
 }

 public static decimal round(this decimal m, int decimalafterpoint)
 {
  return Math.Round(m, decimalafterpoint, MidpointRounding.AwayFromZero);
 }

 public static void SetWord(this byte[] ba, int start, int w)
 {
  ba[start] = (byte)(w >> 8);
  ba[start + 1] = (byte)(w >> 0);
 }

 public static void SetByte(this byte[] ba, int start, int b)
 {
  ba[start] = (byte)b;
 }

 public static void ZeroArray(this byte[] ba)
 {
  for (var i = 0; i < ba.Length; i++) ba[i] = 0;
 }

 public static ushort GetWord(this byte[] ba, int start)
 {
  return (ushort)((ba[start] << 8) + ba[start + 1]);
 }

 public static int GetInt3(this byte[] ba, int start)
 {
  return (ba[start + 2] << 16) | (ba[start + 1] << 8) | ba[start];
 }

 public static int GetInt(this byte[] ba, int start)
 {
  return (ba[start + 3] << 24) | (ba[start + 2] << 16) | (ba[start + 1] << 8) | ba[start];
 }

 public static string GetString(this byte[] ba, int start, int l)
 {
  var s = "";
  while (l > 0)
  {
   l--;
   s = (char)ba[start + l] + s;
  }

  return s;
 }

 public static float GetFloat(this byte[] ba, int start)
 {
  var f = BitConverter.ToSingle(ba, start);
  return f;
 }

 public static TimeSpan LocalTimeToUTCTime(this TimeSpan localTime)
 {
  var dt = new DateTime(localTime.Ticks, DateTimeKind.Local);
  var utc = dt.ToUniversalTime();
  return new TimeSpan(utc.Ticks);
 }

 public static TimeSpan UTCTimeToLocalTime(this TimeSpan utctime)
 {
  var dt = new DateTime(utctime.Ticks, DateTimeKind.Utc);
  var lt = dt.ToLocalTime();
  return new TimeSpan(lt.Ticks);
 }

 public static long ToLong(this object s, long defaultValue = -1)
 {
  var i = defaultValue;
  if (s is long) i = (long)s;
  return i;
 }

 public static int ToInt(this object s, int defaultValue = -1)
 {
  var i = defaultValue;
  if (s is int) i = (int)s;
  if (s is string) i = ((string)s).ToInt(defaultValue);

  return i;
 }

 public static int ToInt(this string s, int defaultValue)
 {
  var b = false;
  var i = defaultValue;

  s = s.Replace("€", "");

  b = int.TryParse(s, NumberStyles.AllowThousands | NumberStyles.Integer, null, out i);
  if (b == false) i = defaultValue;

  return i;
 }

 public static bool toBool(this object s, bool defaultValue = false)
 {
  var b = defaultValue;
  if (s is bool) b = (bool)s;

  return b;
 }

 public static long ToLong(this string s, long defaultValue)
 {
  var b = false;
  var i = defaultValue;

  b = long.TryParse(s, NumberStyles.AllowThousands | NumberStyles.Integer, null, out i);
  if (b == false) i = defaultValue;

  return i;
 }

 public static string ToString2(this TimeSpan ts)
 {
  if (ts == null) return "";
  if (ts == TimeSpan.MinValue) return "";

  var s = string.Format("{0:D2}:{1:D2}", ts.Hours, ts.Minutes);
  if (s == "00:00") return "";

  return s;
 }

 public static decimal ToDecimal(this string s, decimal defaultValue)
 {
  var i = defaultValue;
  s = s.Replace("€", "");
  s = s.Replace("- ", "-");
  s = s.Trim();

  var numberFormatInfo = CultureInfo.CurrentCulture.NumberFormat;
  var decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
  var groupSeparator = numberFormatInfo.NumberGroupSeparator;
  var negativeSign = numberFormatInfo.NegativeSign;
  var percentSign = numberFormatInfo.PercentSymbol;

  var i1 = s.IndexOf(".");
  var i2 = s.IndexOf(",");
  if (i1 < i2 && i1 != -1)
  {
   s = s.Replace(".", "");
   s = s.Replace(",", numberFormatInfo.NumberDecimalSeparator);
  }
  else if (i2 < i1 && i2 != -1)
  {
   s = s.Replace(",", "");
   s = s.Replace(".", numberFormatInfo.NumberDecimalSeparator);
  }
  else if (i1 != -1)
  {
   s = s.Replace(".", numberFormatInfo.NumberDecimalSeparator);
  }
  else if (i2 != -1)
  {
   s = s.Replace(",", numberFormatInfo.NumberDecimalSeparator);
  }

  s = s.Replace(groupSeparator, "");
  s = s.Replace(percentSign, "");

  var b = decimal.TryParse(s, NumberStyles.Number, numberFormatInfo, out i);
  if (b == false) return defaultValue;

  return i;
 }

 public static decimal ToDecimal(this object o, decimal defaultValue = 0)
 {
  if (o == null) return defaultValue;
  if (o == DBNull.Value) return defaultValue;
  if (o.GetType() == typeof(decimal)) return (decimal)o;
  if (o.GetType() == typeof(long)) return (decimal)(long)o;
  if (o.GetType() == typeof(int)) return (decimal)(int)o;
  if (o.GetType() == typeof(short)) return (decimal)(short)o;
  if (o.GetType() == typeof(byte)) return (decimal)(byte)o;
  if (o.GetType() == typeof(string)) return ((string)o).ToDecimal(defaultValue);
  return defaultValue;
 }

 public static string ss(this decimal e)
 {
  return e.ToString("0.00", CultureInfo.InvariantCulture);
 }

 public static string es(this decimal e, int numsafterdecimal)
 {
  var dp = "";
  for (var i = 1; i <= numsafterdecimal; i++)
   if (i.In(1, 2))
    dp = dp + "0";
   else
    dp = dp + "#";
  return e == 0 ? "" : e.ToString("#,##0." + dp);
 }

 public static string es(this decimal e, int numsafterdecimal, decimal dv)
 {
  var dp = "";
  for (var i = 1; i <= numsafterdecimal; i++)
   if (i.In(1, 2))
    dp = dp + "0";
   else
    dp = dp + "#";
  return e == 0 ? dv.ToString("#,##0." + dp) : e.ToString("#,##0." + dp);
 }

 public static string ns(this int i)
 {
  return i == -1 ? "" : i.ToString("#,##0");
 }

 public static string ms(this decimal m)
 {
  return m.ToString("#,##0.00####' €'");
 }

 public static string ms2(this decimal m)
 {
  return string.Format("{0} {1:#,##0.00####}", "€", m);
 }

 public static string ms4(this decimal m)
 {
  return string.Format("{0} {1:###0}", "", m);
 }

 public static string ms3(this decimal m, string currencycode)
 {
  return string.Format("{0} {1:#,##0.00####}", currencycode, m);
 }

 public static string TimePeriod2String(TimeSpan b, TimeSpan e)
 {
  if (b == null) b = TimeSpan.MinValue;
  if (e == null) e = TimeSpan.MinValue;

  if (b == TimeSpan.MinValue && e == TimeSpan.MinValue) return "";

  return string.Format("{0}..{1}", b.ToString2(), e.ToString2());
 }

 public static string DateTimePeriod2String(this DateTime dt)
 {
  var f = "{0:0\" d. \";0\" d. \";#}{1:00}:{2:00}:{3:00}";
  if (dt == DateTime.MinValue) return string.Format(f, 0, 0, 0, 0);
  // -1, todėl, kad data 1900-01-01
  return string.Format(f, dt.DayOfYear - 1, dt.Hour, dt.Minute, dt.Second);
 }

 public static string TimePeriod2String(this TimeSpan ts)
 {
  var f = "{0:00}:{1:00}:{2:00}";

  if (ts == TimeSpan.MinValue) return string.Format(f, 0, 0, 0);

  return string.Format(f, ts.Hours, ts.Minutes, ts.Seconds);
 }

 public static string GetLocalIPv4()
 {
  var output = "";
  foreach (var item in NetworkInterface.GetAllNetworkInterfaces())
   if (item.OperationalStatus == OperationalStatus.Up)
   {
    var adapterProperties = item.GetIPProperties();
    if (adapterProperties.GatewayAddresses.Count == 0) continue;

    foreach (var ip in adapterProperties.UnicastAddresses)
     if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
      output = ip.Address.ToString();
   }

  return output;
 }

 public static XmlNamespaceManager GetNameSpaceManager(this XmlDocument xDoc)
 {
  var nsm = new XmlNamespaceManager(xDoc.NameTable);
  var RootNode = xDoc.CreateNavigator();
  RootNode.MoveToFollowing(XPathNodeType.Element);
  var NameSpaces = RootNode.GetNamespacesInScope(XmlNamespaceScope.All);

  foreach (var kvp in NameSpaces) nsm.AddNamespace(kvp.Key == "" ? "sn" : kvp.Key, kvp.Value);

  return nsm;
 }

 public static decimal SafeDiv(decimal a, decimal b)
 {
  if (b == 0) return 0;
  return a / b;
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

 public static string EncodeTo64(string toEncode)
 {
  var toEncodeAsBytes = Encoding.ASCII.GetBytes(toEncode);
  var returnValue = Convert.ToBase64String(toEncodeAsBytes);
  return returnValue;
 }

 public static IEnumerable<int> i(this DataTable tb, string fieldname)
 {
  foreach (DataRow dr in tb.Rows) yield return dr.gi(fieldname);
 }

 public static IEnumerable<string> s(this DataTable tb, string fieldname)
 {
  foreach (DataRow dr in tb.Rows) yield return dr.gs(fieldname);
 }

 public static IEnumerable<decimal> e(this DataTable tb, string fieldname)
 {
  foreach (DataRow dr in tb.Rows) yield return dr.ge(fieldname);
 }

 public static DataRow RowById(this DataTable tb, int id)
 {
  if (id == -1) return null;

  foreach (DataRow dr in tb.Rows)
   if (dr.gi("ID") == id)
    return dr;

  return null;
 }

 public static DataRow RowById(this DataTable tb, string fieldname, int id)
 {
  if (id == -1) return null;

  foreach (DataRow dr in tb.Rows)
   if (dr.gi(fieldname) == id)
    return dr;

  return null;
 }

 public static DataRow RowFindByPrimaryKey(this DataTable tb, int pkvalue)
 {
  var newrow = false;
  return tb.RowFindByPrimaryKey(pkvalue, ref newrow);
 }

 public static DataRow RowFindByPrimaryKey(this DataTable tb, int pkvalue, ref bool newrow)
 {
  var dr = tb.Rows.Find(pkvalue);
  if (dr == null)
  {
   var pkfield = tb.PrimaryKey[0].ColumnName;

   dr = tb.NewRow();
   dr[pkfield] = pkvalue;
   tb.Rows.Add(dr);

   newrow = true;
  }

  return dr;
 }

 public static string KVPValue(this string s)
 {
  var x = s.IndexOf("=");
  if (x == -1) return "";

  return s.SqlSubstring(x + 1);
 }

 public static string FromUTF8(this byte[] dd)
 {
  if (dd == null) return "";
  return Encoding.UTF8.GetString(dd);
 }

 /*
 public static string SelectExcelFile(this System.Windows.Forms.OpenFileDialog of) {
   of.Multiselect = false;
   of.Title = "Select file";
   of.FileName = "";
   of.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

   if (of.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return ""; }

   return of.FileName;
 }
  */
}

public static class qext_xmlserializer
{
 public static string ToXmlMetaData(this object obj)
 {
  return ((XElement)ToXml2(obj, "metadata")).ToString();
 }


 /// <summary>
 /// Converts an anonymous type to an XElement.
 /// </summary>
 /// <param name="input">The input.</param>
 /// <returns>Returns the object as it's XML representation in an XElement.</returns>
 public static XElement ToXml2(this object input)
 {
  return input.ToXml2(null);
 }

 /// <summary>
 /// Converts an anonymous type to an XElement.
 /// </summary>
 /// <param name="input">The input.</param>
 /// <param name="element">The element name.</param>
 /// <returns>Returns the object as it's XML representation in an XElement.</returns>
 public static XElement ToXml2(this object input, string element)
 {
  return _ToXml(input, element);
 }

 private static XElement _ToXml(object input, string element, int? arrayIndex = null, string arrayName = null)
 {
  if (input == null)
   return null;

  if (string.IsNullOrEmpty(element))
  {
   var name = input.GetType().Name;
   element = name.Contains("AnonymousType")
    ? "Object"
    : arrayIndex != null
     ? arrayName + "_" + arrayIndex
     : name;
  }

  element = XmlConvert.EncodeName(element);
  var ret = new XElement(element);

  if (input != null)
  {
   var type = input.GetType();
   var props = type.GetProperties();

   XElement xl = null;
   foreach (var p in props)
   {
    var pty = Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType;

    if (input is DataRow) // tam, kad tik ItemArray() imtume, priešingu atveju ima DataTable ir užsiloopina
     if (pty.IsArray == false)
      continue;

    var name = XmlConvert.EncodeName(p.Name);
    var val = p.GetValue(input, null);
    if (val == null) continue;

    if (pty.IsEnumerable())
    {
     if (input is DataRow)
      xl = GetDataRowElements(input as DataRow);
     else
      xl = GetEnumerableElements(p, (IEnumerable)val);
     ret.Add(xl);
     continue;
    }

    if (pty == typeof(DataTable))
    {
     var re = new XElement(name);
     foreach (DataRow dr in (val as DataTable).Rows)
     {
      xl = GetDataRowElements(dr);
      re.Add(xl);
     }

     ret.Add(re);
     continue;
    }

    if (pty == typeof(DateTime))
    {
     var dt = (DateTime)val;
     if (dt == DateTime.MinValue)
     {
      xl = new XElement(name, "");
      ret.Add(xl);
      continue;
     }
     else if (dt.TimeOfDay.TotalHours == 0 && dt.TimeOfDay.TotalMinutes == 0 && dt.TimeOfDay.TotalSeconds == 0)
     {
      xl = new XElement(name, dt.ToString("yyyy-MM-dd"));
      ret.Add(xl);
      continue;
     }
     else
     {
      xl = new XElement(name, val);
      ret.Add(xl);
      continue;
     }
    }

    if (pty.IsArray)
    {
     ret.Add(new XElement(name, "array"));
     continue;
    }

    if (pty.IsSimpleType2() || pty.IsEnum)
    {
     if (pty == typeof(string))
      xl = new XElement(name, new XCData((string)val /*.Replace("\n", "&#x0a;").Replace("\r", "&#x0d;")*/));
     else
      xl = new XElement(name, val);
    }
    else
    {
     xl = val.ToXml2(name);
    }

    if (xl != null) ret.Add(xl);
   }
  }

  return ret;
 }

 #region helpers

 private static XElement GetDataRowElements(DataRow dr)
 {
  var tb = dr.Table;

  var re = new XElement("row");
  for (var i = 0; i < dr.ItemArray.Length; i++)
  {
   var o = dr.ItemArray[i];
   var col = tb.Columns[i].ColumnName;
   var ce = new XElement(col, o);
   re.Add(ce);
  }

  return re;
 }

 private static XElement GetEnumerableElements(PropertyInfo info, IEnumerable input)
 {
  var name = XmlConvert.EncodeName(info.Name);

  var rootElement = new XElement(name);

  var i = 0;
  foreach (var v in input)
  {
   var childElement = v.GetType().IsSimpleType2() || v.GetType().IsEnum
    ? new XElement(name + "_" + i, v)
    : _ToXml(v, null, i, name);
   rootElement.Add(childElement);
   i++;
  }

  return rootElement;
 }

 private static readonly Type[] WriteTypes = new[]
  { typeof(string), typeof(DateTime), typeof(Enum), typeof(decimal), typeof(Guid) };

 public static bool IsSimpleType2(this Type type)
 {
  if (type.IsPrimitive) return true;

  foreach (var ty in WriteTypes)
   if (ty == type)
    return true;

  return false;
 }

 private static readonly Type[] FlatternTypes = new[] { typeof(string) };

 public static bool IsEnumerable(this Type type)
 {
  var b = typeof(IEnumerable).IsAssignableFrom(type);

  var c = false; // FlatternTypes.Contains(type)
  foreach (var ty in FlatternTypes)
   if (ty == type)
   {
    c = true;
    break;
   }

  return b && c == false;
 }

 #endregion
}


/*
public unsafe sealed partial class StringFast {
  // assigned int values for bytes (0-255)
  static readonly int[] toHexTable = new int[] {
            3145776, 3211312, 3276848, 3342384, 3407920, 3473456, 3538992, 3604528, 3670064, 3735600,
            4259888, 4325424, 4390960, 4456496, 4522032, 4587568, 3145777, 3211313, 3276849, 3342385,
            3407921, 3473457, 3538993, 3604529, 3670065, 3735601, 4259889, 4325425, 4390961, 4456497,
            4522033, 4587569, 3145778, 3211314, 3276850, 3342386, 3407922, 3473458, 3538994, 3604530,
            3670066, 3735602, 4259890, 4325426, 4390962, 4456498, 4522034, 4587570, 3145779, 3211315,
            3276851, 3342387, 3407923, 3473459, 3538995, 3604531, 3670067, 3735603, 4259891, 4325427,
            4390963, 4456499, 4522035, 4587571, 3145780, 3211316, 3276852, 3342388, 3407924, 3473460,
            3538996, 3604532, 3670068, 3735604, 4259892, 4325428, 4390964, 4456500, 4522036, 4587572,
            3145781, 3211317, 3276853, 3342389, 3407925, 3473461, 3538997, 3604533, 3670069, 3735605,
            4259893, 4325429, 4390965, 4456501, 4522037, 4587573, 3145782, 3211318, 3276854, 3342390,
            3407926, 3473462, 3538998, 3604534, 3670070, 3735606, 4259894, 4325430, 4390966, 4456502,
            4522038, 4587574, 3145783, 3211319, 3276855, 3342391, 3407927, 3473463, 3538999, 3604535,
            3670071, 3735607, 4259895, 4325431, 4390967, 4456503, 4522039, 4587575, 3145784, 3211320,
            3276856, 3342392, 3407928, 3473464, 3539000, 3604536, 3670072, 3735608, 4259896, 4325432,
            4390968, 4456504, 4522040, 4587576, 3145785, 3211321, 3276857, 3342393, 3407929, 3473465,
            3539001, 3604537, 3670073, 3735609, 4259897, 4325433, 4390969, 4456505, 4522041, 4587577,
            3145793, 3211329, 3276865, 3342401, 3407937, 3473473, 3539009, 3604545, 3670081, 3735617,
            4259905, 4325441, 4390977, 4456513, 4522049, 4587585, 3145794, 3211330, 3276866, 3342402,
            3407938, 3473474, 3539010, 3604546, 3670082, 3735618, 4259906, 4325442, 4390978, 4456514,
            4522050, 4587586, 3145795, 3211331, 3276867, 3342403, 3407939, 3473475, 3539011, 3604547,
            3670083, 3735619, 4259907, 4325443, 4390979, 4456515, 4522051, 4587587, 3145796, 3211332,
            3276868, 3342404, 3407940, 3473476, 3539012, 3604548, 3670084, 3735620, 4259908, 4325444,
            4390980, 4456516, 4522052, 4587588, 3145797, 3211333, 3276869, 3342405, 3407941, 3473477,
            3539013, 3604549, 3670085, 3735621, 4259909, 4325445, 4390981, 4456517, 4522053, 4587589,
            3145798, 3211334, 3276870, 3342406, 3407942, 3473478, 3539014, 3604550, 3670086, 3735622,
            4259910, 4325446, 4390982, 4456518, 4522054, 4587590
        };

  public static string ToHexString(byte[] source) {
    return ToHexString(source, false);
  }
  // hexIndicator: use prefix ("0x") or not
  public static string ToHexString(byte[] source, bool hexIndicator) {
    // freeze toHexTable position in memory
    fixed (int* hexRef = toHexTable)
    // freeze source position in memory
    fixed (byte* sourceRef = source) {
      // take first parsing position of source - allow inline pointer positioning
      byte* s = sourceRef;
      // calculate result length
      int resultLen = (source.Length << 1);
      // use prefix ("Ox")
      if (hexIndicator)
        // adapt result length
        resultLen += 2;
      // initialize result string with any character expect '\0'
      string result = new string(' ', resultLen);
      // take the first character address of result
      fixed (char* resultRef = result) {
        // pairs of characters explain the endianess of toHexTable
        // move on by pairs of characters (2 x 2 bytes) - allow inline pointer positioning
        int* pair = (int*)resultRef;
        // use prefix ("Ox") ?
        if (hexIndicator)
          // set first pair value
          *pair++ = 7864368;
        // more to go
        while (*pair != 0)
          // set the value of the current pair and move to next pair and source byte
          *pair++ = hexRef[*s++];
        return result;
      }
    }
  }
}
 */

/*
        <Tab CommandName="DocsTab">
          <Group CommandName="DocsGroup1" SizeDefinition="OneButton">
            <DropDownButton CommandName="cmdButtonDocsTemplategenera_smplTerms" >
              <MenuGroup>
                <Button CommandName="cmdButtonDocsTemplategenera_smplTermsFAOL"></Button>
                <Button CommandName="cmdButtonDocsTemplategenera_smplTermsJAFL"></Button>
                <Button CommandName="cmdButtonDocsTemplategenera_smplTermsJAOL"></Button>
              </MenuGroup>
            </DropDownButton>
          </Group>
        </Tab>
*/