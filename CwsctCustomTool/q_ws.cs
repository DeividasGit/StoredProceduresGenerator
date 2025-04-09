using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

/* param: 192.168.0.94 vivaldi a15 1 developer */
public static partial class co {
public static bool AddonAdd (string code, string description, int brandid, string modelfilter, int eriortype, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonAdd (code, description, brandid, modelfilter, eriortype, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonAdd (string code, string description, int brandid, string modelfilter, int eriortype, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonAdd (code, description, brandid, modelfilter, eriortype, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonAdd (string code, string description, int brandid, string modelfilter, int eriortype, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonAdd (code, description, brandid, modelfilter, eriortype, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonAdd (string code, string description, int brandid, string modelfilter, int eriortype, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDON__ADD"); 
  q.q2s(sc, "@code", code);
  q.q2s(sc, "@description", description);
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@modelfilter", modelfilter);
  q.q2i(sc, "@eriortype", eriortype);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonDelete (int addonid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonDelete (addonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonDelete (int addonid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonDelete (addonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonDelete (int addonid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonDelete (addonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonDelete (int addonid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDON__DELETE"); 
  q.q2i(sc, "@addonid", addonid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonInfoGet (int addonid, ref string code, ref string description) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonInfoGet (addonid, ref code, ref description,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonInfoGet (int addonid, ref string code, ref string description,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonInfoGet (addonid, ref code, ref description,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonInfoGet (int addonid, ref string code, ref string description,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonInfoGet (addonid, ref code, ref description,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonInfoGet (int addonid, ref string code, ref string description,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDON__INFO_GET"); 
  q.q2i(sc, "@addonid", addonid);
  q.q2s(sc, "@code", code);
  q.q2s(sc, "@description", description);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   code = q.gs(sc,"@code");
   description = q.gs(sc,"@description");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonUpdate (int addonid, string code, string description, int brandid, string modelfilter, int eriortype, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonUpdate (addonid, code, description, brandid, modelfilter, eriortype, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonUpdate (int addonid, string code, string description, int brandid, string modelfilter, int eriortype, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonUpdate (addonid, code, description, brandid, modelfilter, eriortype, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonUpdate (int addonid, string code, string description, int brandid, string modelfilter, int eriortype, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonUpdate (addonid, code, description, brandid, modelfilter, eriortype, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonUpdate (int addonid, string code, string description, int brandid, string modelfilter, int eriortype, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDON__UPDATE"); 
  q.q2i(sc, "@addonid", addonid);
  q.q2s(sc, "@code", code);
  q.q2s(sc, "@description", description);
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@modelfilter", modelfilter);
  q.q2i(sc, "@eriortype", eriortype);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonModelRelationAdd (int addonid, string modelcode, bool ignoreonvalidation, decimal defaultprice, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonModelRelationAdd (addonid, modelcode, ignoreonvalidation, defaultprice, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationAdd (int addonid, string modelcode, bool ignoreonvalidation, decimal defaultprice, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonModelRelationAdd (addonid, modelcode, ignoreonvalidation, defaultprice, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationAdd (int addonid, string modelcode, bool ignoreonvalidation, decimal defaultprice, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonModelRelationAdd (addonid, modelcode, ignoreonvalidation, defaultprice, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationAdd (int addonid, string modelcode, bool ignoreonvalidation, decimal defaultprice, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDON_MODEL_RELATION__ADD"); 
  q.q2i(sc, "@addonid", addonid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2b(sc, "@ignoreonvalidation", ignoreonvalidation);
  q.q2e(sc, "@defaultprice", defaultprice);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonModelRelationDelete (int addonmodelrelationid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonModelRelationDelete (addonmodelrelationid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationDelete (int addonmodelrelationid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonModelRelationDelete (addonmodelrelationid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationDelete (int addonmodelrelationid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonModelRelationDelete (addonmodelrelationid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationDelete (int addonmodelrelationid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDON_MODEL_RELATION__DELETE"); 
  q.q2i(sc, "@addonmodelrelationid", addonmodelrelationid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonModelRelationGet (int addonmodelrelationid, ref string modelcode, ref bool ignoreonvalidation, ref decimal defaultprice, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonModelRelationGet (addonmodelrelationid, ref modelcode, ref ignoreonvalidation, ref defaultprice, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationGet (int addonmodelrelationid, ref string modelcode, ref bool ignoreonvalidation, ref decimal defaultprice, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonModelRelationGet (addonmodelrelationid, ref modelcode, ref ignoreonvalidation, ref defaultprice, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationGet (int addonmodelrelationid, ref string modelcode, ref bool ignoreonvalidation, ref decimal defaultprice, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonModelRelationGet (addonmodelrelationid, ref modelcode, ref ignoreonvalidation, ref defaultprice, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationGet (int addonmodelrelationid, ref string modelcode, ref bool ignoreonvalidation, ref decimal defaultprice, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDON_MODEL_RELATION__GET"); 
  q.q2i(sc, "@addonmodelrelationid", addonmodelrelationid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2b(sc, "@ignoreonvalidation", ignoreonvalidation);
  q.q2e(sc, "@defaultprice", defaultprice);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   modelcode = q.gs(sc,"@modelcode");
   ignoreonvalidation = q.gb(sc,"@ignoreonvalidation");
   defaultprice = q.ge(sc,"@defaultprice");
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonModelRelationNoteGet (int addonmodelrelationid, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonModelRelationNoteGet (addonmodelrelationid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationNoteGet (int addonmodelrelationid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonModelRelationNoteGet (addonmodelrelationid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationNoteGet (int addonmodelrelationid, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonModelRelationNoteGet (addonmodelrelationid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationNoteGet (int addonmodelrelationid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDON_MODEL_RELATION__NOTE_GET"); 
  q.q2i(sc, "@addonmodelrelationid", addonmodelrelationid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonModelRelationNoteSet (int addonmodelrelationid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonModelRelationNoteSet (addonmodelrelationid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationNoteSet (int addonmodelrelationid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonModelRelationNoteSet (addonmodelrelationid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationNoteSet (int addonmodelrelationid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonModelRelationNoteSet (addonmodelrelationid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationNoteSet (int addonmodelrelationid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDON_MODEL_RELATION__NOTE_SET"); 
  q.q2i(sc, "@addonmodelrelationid", addonmodelrelationid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonModelRelationUpdate (int addonmodelrelationid, string modelcode, bool ignoreonvalidation, decimal defaultprice, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonModelRelationUpdate (addonmodelrelationid, modelcode, ignoreonvalidation, defaultprice, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationUpdate (int addonmodelrelationid, string modelcode, bool ignoreonvalidation, decimal defaultprice, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonModelRelationUpdate (addonmodelrelationid, modelcode, ignoreonvalidation, defaultprice, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationUpdate (int addonmodelrelationid, string modelcode, bool ignoreonvalidation, decimal defaultprice, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonModelRelationUpdate (addonmodelrelationid, modelcode, ignoreonvalidation, defaultprice, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationUpdate (int addonmodelrelationid, string modelcode, bool ignoreonvalidation, decimal defaultprice, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDON_MODEL_RELATION__UPDATE"); 
  q.q2i(sc, "@addonmodelrelationid", addonmodelrelationid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2b(sc, "@ignoreonvalidation", ignoreonvalidation);
  q.q2e(sc, "@defaultprice", defaultprice);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonModelRelationsVw (int addonid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonModelRelationsVw (addonid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationsVw (int addonid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonModelRelationsVw (addonid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationsVw (int addonid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonModelRelationsVw (addonid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonModelRelationsVw (int addonid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDON_MODEL_RELATIONS_vw"); 
  q.q2i(sc, "@addonid", addonid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonsByArrangementVwq (int arrangementid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonsByArrangementVwq (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonsByArrangementVwq (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonsByArrangementVwq (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonsByArrangementVwq (int arrangementid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonsByArrangementVwq (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonsByArrangementVwq (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDONS_BY_ARRANGEMENT_vwq"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonsVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonsVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDONS_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool AddonsVwq (string st, DataTable suppliercontractitemids, DataTable existingoptions, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return AddonsVwq (st, suppliercontractitemids, existingoptions, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonsVwq (string st, DataTable suppliercontractitemids, DataTable existingoptions, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return AddonsVwq (st, suppliercontractitemids, existingoptions, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonsVwq (string st, DataTable suppliercontractitemids, DataTable existingoptions, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return AddonsVwq (st, suppliercontractitemids, existingoptions, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool AddonsVwq (string st, DataTable suppliercontractitemids, DataTable existingoptions, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ADDONS_vwq"); 
  q.q2s(sc, "@st", st);
  q.q2u(sc, "@suppliercontractitemids", "eids", suppliercontractitemids);
  q.q2u(sc, "@existingoptions", "eids", existingoptions);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArchivePurchaseContractsCanceledVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArchivePurchaseContractsCanceledVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchivePurchaseContractsCanceledVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArchivePurchaseContractsCanceledVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchivePurchaseContractsCanceledVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArchivePurchaseContractsCanceledVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchivePurchaseContractsCanceledVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARCHIVE_PURCHASE_CONTRACTS_CANCELED_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArchiveSupplierContractsVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArchiveSupplierContractsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchiveSupplierContractsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArchiveSupplierContractsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchiveSupplierContractsVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArchiveSupplierContractsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchiveSupplierContractsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARCHIVE_SUPPLIER_CONTRACTS_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArchiveSupplierVehicleLoadsVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArchiveSupplierVehicleLoadsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchiveSupplierVehicleLoadsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArchiveSupplierVehicleLoadsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchiveSupplierVehicleLoadsVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArchiveSupplierVehicleLoadsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchiveSupplierVehicleLoadsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARCHIVE_SUPPLIER_VEHICLE_LOADS_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArchiveVehiclesVw (int viewindex, bool showall, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArchiveVehiclesVw (viewindex, showall, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchiveVehiclesVw (int viewindex, bool showall, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArchiveVehiclesVw (viewindex, showall, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchiveVehiclesVw (int viewindex, bool showall, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArchiveVehiclesVw (viewindex, showall, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArchiveVehiclesVw (int viewindex, bool showall, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARCHIVE_VEHICLES_vw"); 
  q.q2i(sc, "@viewindex", viewindex);
  q.q2b(sc, "@showall", showall);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementAdd (string arrangementtype, DateTime dt, int brandid, string modelcode, string modelname, string modelshortname, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementAdd (arrangementtype, dt, brandid, modelcode, modelname, modelshortname, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAdd (string arrangementtype, DateTime dt, int brandid, string modelcode, string modelname, string modelshortname, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementAdd (arrangementtype, dt, brandid, modelcode, modelname, modelshortname, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAdd (string arrangementtype, DateTime dt, int brandid, string modelcode, string modelname, string modelshortname, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementAdd (arrangementtype, dt, brandid, modelcode, modelname, modelshortname, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAdd (string arrangementtype, DateTime dt, int brandid, string modelcode, string modelname, string modelshortname, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__ADD"); 
  q.q2s(sc, "@arrangementtype", arrangementtype);
  q.q2d(sc, "@dt", dt);
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@modelshortname", modelshortname);
  q.q2i(sc, "@quantity", quantity);
  q.q2e(sc, "@price", price);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@standardequipment", standardequipment);
  q.q2e(sc, "@supportcost", supportcost);
  q.q2e(sc, "@supportcost2", supportcost2);
  q.q2i(sc, "@freecoloraddonid", freecoloraddonid);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2e(sc, "@hm", hm);
  q.q2b(sc, "@notifyavailabilityinadvance", notifyavailabilityinadvance);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2e(sc, "@regcostdefault", regcostdefault);
  q.q2e(sc, "@transportdefault", transportdefault);
  q.q2e(sc, "@pdicostdefault", pdicostdefault);
  q.q2e(sc, "@margindefault", margindefault);
  q.q2e(sc, "@marginminimum", marginminimum);
  q.q2b(sc, "@pdinotavailable", pdinotavailable);
  q.q2i(sc, "@pditype", pditype);
  q.q2s(sc, "@dealtype", dealtype);
  q.q2s(sc, "@typevariantversion", typevariantversion);
  q.q2s(sc, "@typeconfirmationnumber", typeconfirmationnumber);
  q.q2d(sc, "@typeconfirmationnumberdate", typeconfirmationnumberdate);
  q.q2s(sc, "@availablein", availablein);
  q.q2s(sc, "@loadingfrom", loadingfrom);
  q.q2i(sc, "@registrationincluded", registrationincluded);
  q.q2s(sc, "@wltp", wltp);
  q.q2d(sc, "@dealvalid", dealvalid);
  q.q2i(sc, "@sellerid", sellerid);
  q.q2s(sc, "@carsused", carsused);
  q.q2i(sc, "@dealid", dealid);
  q.q2i(sc, "@mileage", mileage);
  q.q2b(sc, "@ontop", ontop);
  q.q2i(sc, "@color", color);
  q.q2s(sc, "@additionalnote", additionalnote);
  q.q2b(sc, "@isownstock", isownstock);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2s(sc, "@mileagetext", mileagetext);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementClose (int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementClose (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementClose (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementClose (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementClose (int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementClose (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementClose (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__CLOSE"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementDelete (int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementDelete (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementDelete (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementDelete (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementDelete (int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementDelete (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementDelete (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__DELETE"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementDuplicate (int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementDuplicate (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementDuplicate (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementDuplicate (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementDuplicate (int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementDuplicate (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementDuplicate (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__DUPLICATE"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementGet (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementGet (arrangementid, ref brandid, ref modelcode, ref modelname, ref modelshortname, ref quantity, ref dt, ref price, ref supportcost, ref supportcost2, ref note, ref standardequipment, ref arrangementst, ref freecoloraddonid, ref freecoloraddon, ref freecoloraddonname, ref arrangementtype, ref qtyintruck, ref hm, ref notifyavailabilityinadvance, ref supplierid, ref suppliername, ref regcostdefault, ref transportdefault, ref pdicostdefault, ref margindefault, ref marginminimum, ref pdinotavailable, ref pditype, ref dealtype, ref typevariantversion, ref typeconfirmationnumber, ref typeconfirmationnumberdate, ref availablein, ref loadingfrom, ref registrationincluded, ref wltp, ref dealvalid, ref sellerid, ref sellername, ref carsused, ref dealid, ref mileage, ref ontop, ref manager, ref color, ref additionalnote, ref isownstock, ref supplierboardnum, ref firstregistration, ref mileagetext, ref isfca, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref damage, ref webmargin, ref webmarginpercent, ref fueltype, ref enginecapacity,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementGet (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementGet (arrangementid, ref brandid, ref modelcode, ref modelname, ref modelshortname, ref quantity, ref dt, ref price, ref supportcost, ref supportcost2, ref note, ref standardequipment, ref arrangementst, ref freecoloraddonid, ref freecoloraddon, ref freecoloraddonname, ref arrangementtype, ref qtyintruck, ref hm, ref notifyavailabilityinadvance, ref supplierid, ref suppliername, ref regcostdefault, ref transportdefault, ref pdicostdefault, ref margindefault, ref marginminimum, ref pdinotavailable, ref pditype, ref dealtype, ref typevariantversion, ref typeconfirmationnumber, ref typeconfirmationnumberdate, ref availablein, ref loadingfrom, ref registrationincluded, ref wltp, ref dealvalid, ref sellerid, ref sellername, ref carsused, ref dealid, ref mileage, ref ontop, ref manager, ref color, ref additionalnote, ref isownstock, ref supplierboardnum, ref firstregistration, ref mileagetext, ref isfca, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref damage, ref webmargin, ref webmarginpercent, ref fueltype, ref enginecapacity,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementGet (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementGet (arrangementid, ref brandid, ref modelcode, ref modelname, ref modelshortname, ref quantity, ref dt, ref price, ref supportcost, ref supportcost2, ref note, ref standardequipment, ref arrangementst, ref freecoloraddonid, ref freecoloraddon, ref freecoloraddonname, ref arrangementtype, ref qtyintruck, ref hm, ref notifyavailabilityinadvance, ref supplierid, ref suppliername, ref regcostdefault, ref transportdefault, ref pdicostdefault, ref margindefault, ref marginminimum, ref pdinotavailable, ref pditype, ref dealtype, ref typevariantversion, ref typeconfirmationnumber, ref typeconfirmationnumberdate, ref availablein, ref loadingfrom, ref registrationincluded, ref wltp, ref dealvalid, ref sellerid, ref sellername, ref carsused, ref dealid, ref mileage, ref ontop, ref manager, ref color, ref additionalnote, ref isownstock, ref supplierboardnum, ref firstregistration, ref mileagetext, ref isfca, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref damage, ref webmargin, ref webmarginpercent, ref fueltype, ref enginecapacity,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementGet (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__GET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@modelshortname", modelshortname);
  q.q2i(sc, "@quantity", quantity);
  q.q2d(sc, "@dt", dt);
  q.q2e(sc, "@price", price);
  q.q2e(sc, "@supportcost", supportcost);
  q.q2e(sc, "@supportcost2", supportcost2);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@standardequipment", standardequipment);
  q.q2s(sc, "@arrangementst", arrangementst);
  q.q2i(sc, "@freecoloraddonid", freecoloraddonid);
  q.q2s(sc, "@freecoloraddon", freecoloraddon);
  q.q2s(sc, "@freecoloraddonname", freecoloraddonname);
  q.q2s(sc, "@arrangementtype", arrangementtype);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2e(sc, "@hm", hm);
  q.q2b(sc, "@notifyavailabilityinadvance", notifyavailabilityinadvance);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2s(sc, "@suppliername", suppliername);
  q.q2e(sc, "@regcostdefault", regcostdefault);
  q.q2e(sc, "@transportdefault", transportdefault);
  q.q2e(sc, "@pdicostdefault", pdicostdefault);
  q.q2e(sc, "@margindefault", margindefault);
  q.q2e(sc, "@marginminimum", marginminimum);
  q.q2b(sc, "@pdinotavailable", pdinotavailable);
  q.q2i(sc, "@pditype", pditype);
  q.q2s(sc, "@dealtype", dealtype);
  q.q2s(sc, "@typevariantversion", typevariantversion);
  q.q2s(sc, "@typeconfirmationnumber", typeconfirmationnumber);
  q.q2d(sc, "@typeconfirmationnumberdate", typeconfirmationnumberdate);
  q.q2s(sc, "@availablein", availablein);
  q.q2s(sc, "@loadingfrom", loadingfrom);
  q.q2i(sc, "@registrationincluded", registrationincluded);
  q.q2s(sc, "@wltp", wltp);
  q.q2d(sc, "@dealvalid", dealvalid);
  q.q2i(sc, "@sellerid", sellerid);
  q.q2s(sc, "@sellername", sellername);
  q.q2s(sc, "@carsused", carsused);
  q.q2i(sc, "@dealid", dealid);
  q.q2i(sc, "@mileage", mileage);
  q.q2b(sc, "@ontop", ontop);
  q.q2s(sc, "@manager", manager);
  q.q2i(sc, "@color", color);
  q.q2s(sc, "@additionalnote", additionalnote);
  q.q2b(sc, "@isownstock", isownstock);
  q.q2s(sc, "@supplierboardnum", supplierboardnum);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2s(sc, "@mileagetext", mileagetext);
  q.q2b(sc, "@isfca", isfca);
  q.q2d(sc, "@plannedproductionat", plannedproductionat);
  q.q2d(sc, "@plannedpaymentat", plannedpaymentat);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2d(sc, "@loadingfromsupplierat", loadingfromsupplierat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  q.q2e(sc, "@damage", damage);
  q.q2e(sc, "@webmargin", webmargin);
  q.q2e(sc, "@webmarginpercent", webmarginpercent);
  q.q2s(sc, "@fueltype", fueltype);
  q.q2e(sc, "@enginecapacity", enginecapacity);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   brandid = q.gi(sc,"@brandid");
   modelcode = q.gs(sc,"@modelcode");
   modelname = q.gs(sc,"@modelname");
   modelshortname = q.gs(sc,"@modelshortname");
   quantity = q.gi(sc,"@quantity");
   dt = q.gd(sc,"@dt");
   price = q.ge(sc,"@price");
   supportcost = q.ge(sc,"@supportcost");
   supportcost2 = q.ge(sc,"@supportcost2");
   note = q.gs(sc,"@note");
   standardequipment = q.gs(sc,"@standardequipment");
   arrangementst = q.gs(sc,"@arrangementst");
   freecoloraddonid = q.gi(sc,"@freecoloraddonid");
   freecoloraddon = q.gs(sc,"@freecoloraddon");
   freecoloraddonname = q.gs(sc,"@freecoloraddonname");
   arrangementtype = q.gs(sc,"@arrangementtype");
   qtyintruck = q.gi(sc,"@qtyintruck");
   hm = q.ge(sc,"@hm");
   notifyavailabilityinadvance = q.gb(sc,"@notifyavailabilityinadvance");
   supplierid = q.gi(sc,"@supplierid");
   suppliername = q.gs(sc,"@suppliername");
   regcostdefault = q.ge(sc,"@regcostdefault");
   transportdefault = q.ge(sc,"@transportdefault");
   pdicostdefault = q.ge(sc,"@pdicostdefault");
   margindefault = q.ge(sc,"@margindefault");
   marginminimum = q.ge(sc,"@marginminimum");
   pdinotavailable = q.gb(sc,"@pdinotavailable");
   pditype = q.gi(sc,"@pditype");
   dealtype = q.gs(sc,"@dealtype");
   typevariantversion = q.gs(sc,"@typevariantversion");
   typeconfirmationnumber = q.gs(sc,"@typeconfirmationnumber");
   typeconfirmationnumberdate = q.gd(sc,"@typeconfirmationnumberdate");
   availablein = q.gs(sc,"@availablein");
   loadingfrom = q.gs(sc,"@loadingfrom");
   registrationincluded = q.gi(sc,"@registrationincluded");
   wltp = q.gs(sc,"@wltp");
   dealvalid = q.gd(sc,"@dealvalid");
   sellerid = q.gi(sc,"@sellerid");
   sellername = q.gs(sc,"@sellername");
   carsused = q.gs(sc,"@carsused");
   dealid = q.gi(sc,"@dealid");
   mileage = q.gi(sc,"@mileage");
   ontop = q.gb(sc,"@ontop");
   manager = q.gs(sc,"@manager");
   color = q.gi(sc,"@color");
   additionalnote = q.gs(sc,"@additionalnote");
   isownstock = q.gb(sc,"@isownstock");
   supplierboardnum = q.gs(sc,"@supplierboardnum");
   firstregistration = q.gd(sc,"@firstregistration");
   mileagetext = q.gs(sc,"@mileagetext");
   isfca = q.gb(sc,"@isfca");
   plannedproductionat = q.gd(sc,"@plannedproductionat");
   plannedpaymentat = q.gd(sc,"@plannedpaymentat");
   preparationperiod = q.gi(sc,"@preparationperiod");
   holdperiod = q.gi(sc,"@holdperiod");
   documentholdperiod = q.gi(sc,"@documentholdperiod");
   loadingday = q.gd(sc,"@loadingday");
   loadingfromsupplierat = q.gd(sc,"@loadingfromsupplierat");
   registrationperiod = q.gi(sc,"@registrationperiod");
   transportationperiod = q.gi(sc,"@transportationperiod");
   damage = q.ge(sc,"@damage");
   webmargin = q.ge(sc,"@webmargin");
   webmarginpercent = q.ge(sc,"@webmarginpercent");
   fueltype = q.gs(sc,"@fueltype");
   enginecapacity = q.ge(sc,"@enginecapacity");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementGet2 (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity, ref string ownername, ref int ownersellerid, ref string operatorname, ref int operatorsellerid, ref string plannedownername, ref int plannedownersellerid, ref string plannedoperatorname, ref int plannedoperatorsellerid, ref string plannedrentername, ref int plannedrenterclientid, ref decimal plannedsalesmargin, ref decimal plannedsalesprice, ref string buybackownername, ref int buybackownersellerid, ref decimal buybackmargin, ref int buybackmileage, ref int buybackperiod) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementGet2 (arrangementid, ref brandid, ref modelcode, ref modelname, ref modelshortname, ref quantity, ref dt, ref price, ref supportcost, ref supportcost2, ref note, ref standardequipment, ref arrangementst, ref freecoloraddonid, ref freecoloraddon, ref freecoloraddonname, ref arrangementtype, ref qtyintruck, ref hm, ref notifyavailabilityinadvance, ref supplierid, ref suppliername, ref regcostdefault, ref transportdefault, ref pdicostdefault, ref margindefault, ref marginminimum, ref pdinotavailable, ref pditype, ref dealtype, ref typevariantversion, ref typeconfirmationnumber, ref typeconfirmationnumberdate, ref availablein, ref loadingfrom, ref registrationincluded, ref wltp, ref dealvalid, ref sellerid, ref sellername, ref carsused, ref dealid, ref mileage, ref ontop, ref manager, ref color, ref additionalnote, ref isownstock, ref supplierboardnum, ref firstregistration, ref mileagetext, ref isfca, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref damage, ref webmargin, ref webmarginpercent, ref fueltype, ref enginecapacity, ref ownername, ref ownersellerid, ref operatorname, ref operatorsellerid, ref plannedownername, ref plannedownersellerid, ref plannedoperatorname, ref plannedoperatorsellerid, ref plannedrentername, ref plannedrenterclientid, ref plannedsalesmargin, ref plannedsalesprice, ref buybackownername, ref buybackownersellerid, ref buybackmargin, ref buybackmileage, ref buybackperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementGet2 (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity, ref string ownername, ref int ownersellerid, ref string operatorname, ref int operatorsellerid, ref string plannedownername, ref int plannedownersellerid, ref string plannedoperatorname, ref int plannedoperatorsellerid, ref string plannedrentername, ref int plannedrenterclientid, ref decimal plannedsalesmargin, ref decimal plannedsalesprice, ref string buybackownername, ref int buybackownersellerid, ref decimal buybackmargin, ref int buybackmileage, ref int buybackperiod,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementGet2 (arrangementid, ref brandid, ref modelcode, ref modelname, ref modelshortname, ref quantity, ref dt, ref price, ref supportcost, ref supportcost2, ref note, ref standardequipment, ref arrangementst, ref freecoloraddonid, ref freecoloraddon, ref freecoloraddonname, ref arrangementtype, ref qtyintruck, ref hm, ref notifyavailabilityinadvance, ref supplierid, ref suppliername, ref regcostdefault, ref transportdefault, ref pdicostdefault, ref margindefault, ref marginminimum, ref pdinotavailable, ref pditype, ref dealtype, ref typevariantversion, ref typeconfirmationnumber, ref typeconfirmationnumberdate, ref availablein, ref loadingfrom, ref registrationincluded, ref wltp, ref dealvalid, ref sellerid, ref sellername, ref carsused, ref dealid, ref mileage, ref ontop, ref manager, ref color, ref additionalnote, ref isownstock, ref supplierboardnum, ref firstregistration, ref mileagetext, ref isfca, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref damage, ref webmargin, ref webmarginpercent, ref fueltype, ref enginecapacity, ref ownername, ref ownersellerid, ref operatorname, ref operatorsellerid, ref plannedownername, ref plannedownersellerid, ref plannedoperatorname, ref plannedoperatorsellerid, ref plannedrentername, ref plannedrenterclientid, ref plannedsalesmargin, ref plannedsalesprice, ref buybackownername, ref buybackownersellerid, ref buybackmargin, ref buybackmileage, ref buybackperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementGet2 (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity, ref string ownername, ref int ownersellerid, ref string operatorname, ref int operatorsellerid, ref string plannedownername, ref int plannedownersellerid, ref string plannedoperatorname, ref int plannedoperatorsellerid, ref string plannedrentername, ref int plannedrenterclientid, ref decimal plannedsalesmargin, ref decimal plannedsalesprice, ref string buybackownername, ref int buybackownersellerid, ref decimal buybackmargin, ref int buybackmileage, ref int buybackperiod,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementGet2 (arrangementid, ref brandid, ref modelcode, ref modelname, ref modelshortname, ref quantity, ref dt, ref price, ref supportcost, ref supportcost2, ref note, ref standardequipment, ref arrangementst, ref freecoloraddonid, ref freecoloraddon, ref freecoloraddonname, ref arrangementtype, ref qtyintruck, ref hm, ref notifyavailabilityinadvance, ref supplierid, ref suppliername, ref regcostdefault, ref transportdefault, ref pdicostdefault, ref margindefault, ref marginminimum, ref pdinotavailable, ref pditype, ref dealtype, ref typevariantversion, ref typeconfirmationnumber, ref typeconfirmationnumberdate, ref availablein, ref loadingfrom, ref registrationincluded, ref wltp, ref dealvalid, ref sellerid, ref sellername, ref carsused, ref dealid, ref mileage, ref ontop, ref manager, ref color, ref additionalnote, ref isownstock, ref supplierboardnum, ref firstregistration, ref mileagetext, ref isfca, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref damage, ref webmargin, ref webmarginpercent, ref fueltype, ref enginecapacity, ref ownername, ref ownersellerid, ref operatorname, ref operatorsellerid, ref plannedownername, ref plannedownersellerid, ref plannedoperatorname, ref plannedoperatorsellerid, ref plannedrentername, ref plannedrenterclientid, ref plannedsalesmargin, ref plannedsalesprice, ref buybackownername, ref buybackownersellerid, ref buybackmargin, ref buybackmileage, ref buybackperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementGet2 (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity, ref string ownername, ref int ownersellerid, ref string operatorname, ref int operatorsellerid, ref string plannedownername, ref int plannedownersellerid, ref string plannedoperatorname, ref int plannedoperatorsellerid, ref string plannedrentername, ref int plannedrenterclientid, ref decimal plannedsalesmargin, ref decimal plannedsalesprice, ref string buybackownername, ref int buybackownersellerid, ref decimal buybackmargin, ref int buybackmileage, ref int buybackperiod,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__GET2"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@modelshortname", modelshortname);
  q.q2i(sc, "@quantity", quantity);
  q.q2d(sc, "@dt", dt);
  q.q2e(sc, "@price", price);
  q.q2e(sc, "@supportcost", supportcost);
  q.q2e(sc, "@supportcost2", supportcost2);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@standardequipment", standardequipment);
  q.q2s(sc, "@arrangementst", arrangementst);
  q.q2i(sc, "@freecoloraddonid", freecoloraddonid);
  q.q2s(sc, "@freecoloraddon", freecoloraddon);
  q.q2s(sc, "@freecoloraddonname", freecoloraddonname);
  q.q2s(sc, "@arrangementtype", arrangementtype);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2e(sc, "@hm", hm);
  q.q2b(sc, "@notifyavailabilityinadvance", notifyavailabilityinadvance);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2s(sc, "@suppliername", suppliername);
  q.q2e(sc, "@regcostdefault", regcostdefault);
  q.q2e(sc, "@transportdefault", transportdefault);
  q.q2e(sc, "@pdicostdefault", pdicostdefault);
  q.q2e(sc, "@margindefault", margindefault);
  q.q2e(sc, "@marginminimum", marginminimum);
  q.q2b(sc, "@pdinotavailable", pdinotavailable);
  q.q2i(sc, "@pditype", pditype);
  q.q2s(sc, "@dealtype", dealtype);
  q.q2s(sc, "@typevariantversion", typevariantversion);
  q.q2s(sc, "@typeconfirmationnumber", typeconfirmationnumber);
  q.q2d(sc, "@typeconfirmationnumberdate", typeconfirmationnumberdate);
  q.q2s(sc, "@availablein", availablein);
  q.q2s(sc, "@loadingfrom", loadingfrom);
  q.q2i(sc, "@registrationincluded", registrationincluded);
  q.q2s(sc, "@wltp", wltp);
  q.q2d(sc, "@dealvalid", dealvalid);
  q.q2i(sc, "@sellerid", sellerid);
  q.q2s(sc, "@sellername", sellername);
  q.q2s(sc, "@carsused", carsused);
  q.q2i(sc, "@dealid", dealid);
  q.q2i(sc, "@mileage", mileage);
  q.q2b(sc, "@ontop", ontop);
  q.q2s(sc, "@manager", manager);
  q.q2i(sc, "@color", color);
  q.q2s(sc, "@additionalnote", additionalnote);
  q.q2b(sc, "@isownstock", isownstock);
  q.q2s(sc, "@supplierboardnum", supplierboardnum);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2s(sc, "@mileagetext", mileagetext);
  q.q2b(sc, "@isfca", isfca);
  q.q2d(sc, "@plannedproductionat", plannedproductionat);
  q.q2d(sc, "@plannedpaymentat", plannedpaymentat);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2d(sc, "@loadingfromsupplierat", loadingfromsupplierat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  q.q2e(sc, "@damage", damage);
  q.q2e(sc, "@webmargin", webmargin);
  q.q2e(sc, "@webmarginpercent", webmarginpercent);
  q.q2s(sc, "@fueltype", fueltype);
  q.q2e(sc, "@enginecapacity", enginecapacity);
  q.q2s(sc, "@ownername", ownername);
  q.q2i(sc, "@ownersellerid", ownersellerid);
  q.q2s(sc, "@operatorname", operatorname);
  q.q2i(sc, "@operatorsellerid", operatorsellerid);
  q.q2s(sc, "@plannedownername", plannedownername);
  q.q2i(sc, "@plannedownersellerid", plannedownersellerid);
  q.q2s(sc, "@plannedoperatorname", plannedoperatorname);
  q.q2i(sc, "@plannedoperatorsellerid", plannedoperatorsellerid);
  q.q2s(sc, "@plannedrentername", plannedrentername);
  q.q2i(sc, "@plannedrenterclientid", plannedrenterclientid);
  q.q2e(sc, "@plannedsalesmargin", plannedsalesmargin);
  q.q2e(sc, "@plannedsalesprice", plannedsalesprice);
  q.q2s(sc, "@buybackownername", buybackownername);
  q.q2i(sc, "@buybackownersellerid", buybackownersellerid);
  q.q2e(sc, "@buybackmargin", buybackmargin);
  q.q2i(sc, "@buybackmileage", buybackmileage);
  q.q2i(sc, "@buybackperiod", buybackperiod);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   brandid = q.gi(sc,"@brandid");
   modelcode = q.gs(sc,"@modelcode");
   modelname = q.gs(sc,"@modelname");
   modelshortname = q.gs(sc,"@modelshortname");
   quantity = q.gi(sc,"@quantity");
   dt = q.gd(sc,"@dt");
   price = q.ge(sc,"@price");
   supportcost = q.ge(sc,"@supportcost");
   supportcost2 = q.ge(sc,"@supportcost2");
   note = q.gs(sc,"@note");
   standardequipment = q.gs(sc,"@standardequipment");
   arrangementst = q.gs(sc,"@arrangementst");
   freecoloraddonid = q.gi(sc,"@freecoloraddonid");
   freecoloraddon = q.gs(sc,"@freecoloraddon");
   freecoloraddonname = q.gs(sc,"@freecoloraddonname");
   arrangementtype = q.gs(sc,"@arrangementtype");
   qtyintruck = q.gi(sc,"@qtyintruck");
   hm = q.ge(sc,"@hm");
   notifyavailabilityinadvance = q.gb(sc,"@notifyavailabilityinadvance");
   supplierid = q.gi(sc,"@supplierid");
   suppliername = q.gs(sc,"@suppliername");
   regcostdefault = q.ge(sc,"@regcostdefault");
   transportdefault = q.ge(sc,"@transportdefault");
   pdicostdefault = q.ge(sc,"@pdicostdefault");
   margindefault = q.ge(sc,"@margindefault");
   marginminimum = q.ge(sc,"@marginminimum");
   pdinotavailable = q.gb(sc,"@pdinotavailable");
   pditype = q.gi(sc,"@pditype");
   dealtype = q.gs(sc,"@dealtype");
   typevariantversion = q.gs(sc,"@typevariantversion");
   typeconfirmationnumber = q.gs(sc,"@typeconfirmationnumber");
   typeconfirmationnumberdate = q.gd(sc,"@typeconfirmationnumberdate");
   availablein = q.gs(sc,"@availablein");
   loadingfrom = q.gs(sc,"@loadingfrom");
   registrationincluded = q.gi(sc,"@registrationincluded");
   wltp = q.gs(sc,"@wltp");
   dealvalid = q.gd(sc,"@dealvalid");
   sellerid = q.gi(sc,"@sellerid");
   sellername = q.gs(sc,"@sellername");
   carsused = q.gs(sc,"@carsused");
   dealid = q.gi(sc,"@dealid");
   mileage = q.gi(sc,"@mileage");
   ontop = q.gb(sc,"@ontop");
   manager = q.gs(sc,"@manager");
   color = q.gi(sc,"@color");
   additionalnote = q.gs(sc,"@additionalnote");
   isownstock = q.gb(sc,"@isownstock");
   supplierboardnum = q.gs(sc,"@supplierboardnum");
   firstregistration = q.gd(sc,"@firstregistration");
   mileagetext = q.gs(sc,"@mileagetext");
   isfca = q.gb(sc,"@isfca");
   plannedproductionat = q.gd(sc,"@plannedproductionat");
   plannedpaymentat = q.gd(sc,"@plannedpaymentat");
   preparationperiod = q.gi(sc,"@preparationperiod");
   holdperiod = q.gi(sc,"@holdperiod");
   documentholdperiod = q.gi(sc,"@documentholdperiod");
   loadingday = q.gd(sc,"@loadingday");
   loadingfromsupplierat = q.gd(sc,"@loadingfromsupplierat");
   registrationperiod = q.gi(sc,"@registrationperiod");
   transportationperiod = q.gi(sc,"@transportationperiod");
   damage = q.ge(sc,"@damage");
   webmargin = q.ge(sc,"@webmargin");
   webmarginpercent = q.ge(sc,"@webmarginpercent");
   fueltype = q.gs(sc,"@fueltype");
   enginecapacity = q.ge(sc,"@enginecapacity");
   ownername = q.gs(sc,"@ownername");
   ownersellerid = q.gi(sc,"@ownersellerid");
   operatorname = q.gs(sc,"@operatorname");
   operatorsellerid = q.gi(sc,"@operatorsellerid");
   plannedownername = q.gs(sc,"@plannedownername");
   plannedownersellerid = q.gi(sc,"@plannedownersellerid");
   plannedoperatorname = q.gs(sc,"@plannedoperatorname");
   plannedoperatorsellerid = q.gi(sc,"@plannedoperatorsellerid");
   plannedrentername = q.gs(sc,"@plannedrentername");
   plannedrenterclientid = q.gi(sc,"@plannedrenterclientid");
   plannedsalesmargin = q.ge(sc,"@plannedsalesmargin");
   plannedsalesprice = q.ge(sc,"@plannedsalesprice");
   buybackownername = q.gs(sc,"@buybackownername");
   buybackownersellerid = q.gi(sc,"@buybackownersellerid");
   buybackmargin = q.ge(sc,"@buybackmargin");
   buybackmileage = q.gi(sc,"@buybackmileage");
   buybackperiod = q.gi(sc,"@buybackperiod");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementGet3 (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity, ref string ownername, ref int ownersellerid, ref string operatorname, ref int operatorsellerid, ref string plannedownername, ref int plannedownersellerid, ref string plannedoperatorname, ref int plannedoperatorsellerid, ref string plannedrentername, ref int plannedrenterclientid, ref decimal plannedsalesmargin, ref decimal plannedsalesprice, ref string buybackownername, ref int buybackownersellerid, ref decimal buybackmargin, ref int buybackmileage, ref int buybackperiod, ref decimal plannedsalesmarginpercent, ref decimal buybackprice, ref string buybackst, ref decimal buybackpenalty) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementGet3 (arrangementid, ref brandid, ref modelcode, ref modelname, ref modelshortname, ref quantity, ref dt, ref price, ref supportcost, ref supportcost2, ref note, ref standardequipment, ref arrangementst, ref freecoloraddonid, ref freecoloraddon, ref freecoloraddonname, ref arrangementtype, ref qtyintruck, ref hm, ref notifyavailabilityinadvance, ref supplierid, ref suppliername, ref regcostdefault, ref transportdefault, ref pdicostdefault, ref margindefault, ref marginminimum, ref pdinotavailable, ref pditype, ref dealtype, ref typevariantversion, ref typeconfirmationnumber, ref typeconfirmationnumberdate, ref availablein, ref loadingfrom, ref registrationincluded, ref wltp, ref dealvalid, ref sellerid, ref sellername, ref carsused, ref dealid, ref mileage, ref ontop, ref manager, ref color, ref additionalnote, ref isownstock, ref supplierboardnum, ref firstregistration, ref mileagetext, ref isfca, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref damage, ref webmargin, ref webmarginpercent, ref fueltype, ref enginecapacity, ref ownername, ref ownersellerid, ref operatorname, ref operatorsellerid, ref plannedownername, ref plannedownersellerid, ref plannedoperatorname, ref plannedoperatorsellerid, ref plannedrentername, ref plannedrenterclientid, ref plannedsalesmargin, ref plannedsalesprice, ref buybackownername, ref buybackownersellerid, ref buybackmargin, ref buybackmileage, ref buybackperiod, ref plannedsalesmarginpercent, ref buybackprice, ref buybackst, ref buybackpenalty,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementGet3 (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity, ref string ownername, ref int ownersellerid, ref string operatorname, ref int operatorsellerid, ref string plannedownername, ref int plannedownersellerid, ref string plannedoperatorname, ref int plannedoperatorsellerid, ref string plannedrentername, ref int plannedrenterclientid, ref decimal plannedsalesmargin, ref decimal plannedsalesprice, ref string buybackownername, ref int buybackownersellerid, ref decimal buybackmargin, ref int buybackmileage, ref int buybackperiod, ref decimal plannedsalesmarginpercent, ref decimal buybackprice, ref string buybackst, ref decimal buybackpenalty,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementGet3 (arrangementid, ref brandid, ref modelcode, ref modelname, ref modelshortname, ref quantity, ref dt, ref price, ref supportcost, ref supportcost2, ref note, ref standardequipment, ref arrangementst, ref freecoloraddonid, ref freecoloraddon, ref freecoloraddonname, ref arrangementtype, ref qtyintruck, ref hm, ref notifyavailabilityinadvance, ref supplierid, ref suppliername, ref regcostdefault, ref transportdefault, ref pdicostdefault, ref margindefault, ref marginminimum, ref pdinotavailable, ref pditype, ref dealtype, ref typevariantversion, ref typeconfirmationnumber, ref typeconfirmationnumberdate, ref availablein, ref loadingfrom, ref registrationincluded, ref wltp, ref dealvalid, ref sellerid, ref sellername, ref carsused, ref dealid, ref mileage, ref ontop, ref manager, ref color, ref additionalnote, ref isownstock, ref supplierboardnum, ref firstregistration, ref mileagetext, ref isfca, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref damage, ref webmargin, ref webmarginpercent, ref fueltype, ref enginecapacity, ref ownername, ref ownersellerid, ref operatorname, ref operatorsellerid, ref plannedownername, ref plannedownersellerid, ref plannedoperatorname, ref plannedoperatorsellerid, ref plannedrentername, ref plannedrenterclientid, ref plannedsalesmargin, ref plannedsalesprice, ref buybackownername, ref buybackownersellerid, ref buybackmargin, ref buybackmileage, ref buybackperiod, ref plannedsalesmarginpercent, ref buybackprice, ref buybackst, ref buybackpenalty,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementGet3 (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity, ref string ownername, ref int ownersellerid, ref string operatorname, ref int operatorsellerid, ref string plannedownername, ref int plannedownersellerid, ref string plannedoperatorname, ref int plannedoperatorsellerid, ref string plannedrentername, ref int plannedrenterclientid, ref decimal plannedsalesmargin, ref decimal plannedsalesprice, ref string buybackownername, ref int buybackownersellerid, ref decimal buybackmargin, ref int buybackmileage, ref int buybackperiod, ref decimal plannedsalesmarginpercent, ref decimal buybackprice, ref string buybackst, ref decimal buybackpenalty,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementGet3 (arrangementid, ref brandid, ref modelcode, ref modelname, ref modelshortname, ref quantity, ref dt, ref price, ref supportcost, ref supportcost2, ref note, ref standardequipment, ref arrangementst, ref freecoloraddonid, ref freecoloraddon, ref freecoloraddonname, ref arrangementtype, ref qtyintruck, ref hm, ref notifyavailabilityinadvance, ref supplierid, ref suppliername, ref regcostdefault, ref transportdefault, ref pdicostdefault, ref margindefault, ref marginminimum, ref pdinotavailable, ref pditype, ref dealtype, ref typevariantversion, ref typeconfirmationnumber, ref typeconfirmationnumberdate, ref availablein, ref loadingfrom, ref registrationincluded, ref wltp, ref dealvalid, ref sellerid, ref sellername, ref carsused, ref dealid, ref mileage, ref ontop, ref manager, ref color, ref additionalnote, ref isownstock, ref supplierboardnum, ref firstregistration, ref mileagetext, ref isfca, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref damage, ref webmargin, ref webmarginpercent, ref fueltype, ref enginecapacity, ref ownername, ref ownersellerid, ref operatorname, ref operatorsellerid, ref plannedownername, ref plannedownersellerid, ref plannedoperatorname, ref plannedoperatorsellerid, ref plannedrentername, ref plannedrenterclientid, ref plannedsalesmargin, ref plannedsalesprice, ref buybackownername, ref buybackownersellerid, ref buybackmargin, ref buybackmileage, ref buybackperiod, ref plannedsalesmarginpercent, ref buybackprice, ref buybackst, ref buybackpenalty,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementGet3 (int arrangementid, ref int brandid, ref string modelcode, ref string modelname, ref string modelshortname, ref int quantity, ref DateTime dt, ref decimal price, ref decimal supportcost, ref decimal supportcost2, ref string note, ref string standardequipment, ref string arrangementst, ref int freecoloraddonid, ref string freecoloraddon, ref string freecoloraddonname, ref string arrangementtype, ref int qtyintruck, ref decimal hm, ref bool notifyavailabilityinadvance, ref int supplierid, ref string suppliername, ref decimal regcostdefault, ref decimal transportdefault, ref decimal pdicostdefault, ref decimal margindefault, ref decimal marginminimum, ref bool pdinotavailable, ref int pditype, ref string dealtype, ref string typevariantversion, ref string typeconfirmationnumber, ref DateTime typeconfirmationnumberdate, ref string availablein, ref string loadingfrom, ref int registrationincluded, ref string wltp, ref DateTime dealvalid, ref int sellerid, ref string sellername, ref string carsused, ref int dealid, ref int mileage, ref bool ontop, ref string manager, ref int color, ref string additionalnote, ref bool isownstock, ref string supplierboardnum, ref DateTime firstregistration, ref string mileagetext, ref bool isfca, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref decimal damage, ref decimal webmargin, ref decimal webmarginpercent, ref string fueltype, ref decimal enginecapacity, ref string ownername, ref int ownersellerid, ref string operatorname, ref int operatorsellerid, ref string plannedownername, ref int plannedownersellerid, ref string plannedoperatorname, ref int plannedoperatorsellerid, ref string plannedrentername, ref int plannedrenterclientid, ref decimal plannedsalesmargin, ref decimal plannedsalesprice, ref string buybackownername, ref int buybackownersellerid, ref decimal buybackmargin, ref int buybackmileage, ref int buybackperiod, ref decimal plannedsalesmarginpercent, ref decimal buybackprice, ref string buybackst, ref decimal buybackpenalty,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__GET3"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@modelshortname", modelshortname);
  q.q2i(sc, "@quantity", quantity);
  q.q2d(sc, "@dt", dt);
  q.q2e(sc, "@price", price);
  q.q2e(sc, "@supportcost", supportcost);
  q.q2e(sc, "@supportcost2", supportcost2);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@standardequipment", standardequipment);
  q.q2s(sc, "@arrangementst", arrangementst);
  q.q2i(sc, "@freecoloraddonid", freecoloraddonid);
  q.q2s(sc, "@freecoloraddon", freecoloraddon);
  q.q2s(sc, "@freecoloraddonname", freecoloraddonname);
  q.q2s(sc, "@arrangementtype", arrangementtype);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2e(sc, "@hm", hm);
  q.q2b(sc, "@notifyavailabilityinadvance", notifyavailabilityinadvance);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2s(sc, "@suppliername", suppliername);
  q.q2e(sc, "@regcostdefault", regcostdefault);
  q.q2e(sc, "@transportdefault", transportdefault);
  q.q2e(sc, "@pdicostdefault", pdicostdefault);
  q.q2e(sc, "@margindefault", margindefault);
  q.q2e(sc, "@marginminimum", marginminimum);
  q.q2b(sc, "@pdinotavailable", pdinotavailable);
  q.q2i(sc, "@pditype", pditype);
  q.q2s(sc, "@dealtype", dealtype);
  q.q2s(sc, "@typevariantversion", typevariantversion);
  q.q2s(sc, "@typeconfirmationnumber", typeconfirmationnumber);
  q.q2d(sc, "@typeconfirmationnumberdate", typeconfirmationnumberdate);
  q.q2s(sc, "@availablein", availablein);
  q.q2s(sc, "@loadingfrom", loadingfrom);
  q.q2i(sc, "@registrationincluded", registrationincluded);
  q.q2s(sc, "@wltp", wltp);
  q.q2d(sc, "@dealvalid", dealvalid);
  q.q2i(sc, "@sellerid", sellerid);
  q.q2s(sc, "@sellername", sellername);
  q.q2s(sc, "@carsused", carsused);
  q.q2i(sc, "@dealid", dealid);
  q.q2i(sc, "@mileage", mileage);
  q.q2b(sc, "@ontop", ontop);
  q.q2s(sc, "@manager", manager);
  q.q2i(sc, "@color", color);
  q.q2s(sc, "@additionalnote", additionalnote);
  q.q2b(sc, "@isownstock", isownstock);
  q.q2s(sc, "@supplierboardnum", supplierboardnum);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2s(sc, "@mileagetext", mileagetext);
  q.q2b(sc, "@isfca", isfca);
  q.q2d(sc, "@plannedproductionat", plannedproductionat);
  q.q2d(sc, "@plannedpaymentat", plannedpaymentat);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2d(sc, "@loadingfromsupplierat", loadingfromsupplierat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  q.q2e(sc, "@damage", damage);
  q.q2e(sc, "@webmargin", webmargin);
  q.q2e(sc, "@webmarginpercent", webmarginpercent);
  q.q2s(sc, "@fueltype", fueltype);
  q.q2e(sc, "@enginecapacity", enginecapacity);
  q.q2s(sc, "@ownername", ownername);
  q.q2i(sc, "@ownersellerid", ownersellerid);
  q.q2s(sc, "@operatorname", operatorname);
  q.q2i(sc, "@operatorsellerid", operatorsellerid);
  q.q2s(sc, "@plannedownername", plannedownername);
  q.q2i(sc, "@plannedownersellerid", plannedownersellerid);
  q.q2s(sc, "@plannedoperatorname", plannedoperatorname);
  q.q2i(sc, "@plannedoperatorsellerid", plannedoperatorsellerid);
  q.q2s(sc, "@plannedrentername", plannedrentername);
  q.q2i(sc, "@plannedrenterclientid", plannedrenterclientid);
  q.q2e(sc, "@plannedsalesmargin", plannedsalesmargin);
  q.q2e(sc, "@plannedsalesprice", plannedsalesprice);
  q.q2s(sc, "@buybackownername", buybackownername);
  q.q2i(sc, "@buybackownersellerid", buybackownersellerid);
  q.q2e(sc, "@buybackmargin", buybackmargin);
  q.q2i(sc, "@buybackmileage", buybackmileage);
  q.q2i(sc, "@buybackperiod", buybackperiod);
  q.q2e(sc, "@plannedsalesmarginpercent", plannedsalesmarginpercent);
  q.q2e(sc, "@buybackprice", buybackprice);
  q.q2s(sc, "@buybackst", buybackst);
  q.q2e(sc, "@buybackpenalty", buybackpenalty);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   brandid = q.gi(sc,"@brandid");
   modelcode = q.gs(sc,"@modelcode");
   modelname = q.gs(sc,"@modelname");
   modelshortname = q.gs(sc,"@modelshortname");
   quantity = q.gi(sc,"@quantity");
   dt = q.gd(sc,"@dt");
   price = q.ge(sc,"@price");
   supportcost = q.ge(sc,"@supportcost");
   supportcost2 = q.ge(sc,"@supportcost2");
   note = q.gs(sc,"@note");
   standardequipment = q.gs(sc,"@standardequipment");
   arrangementst = q.gs(sc,"@arrangementst");
   freecoloraddonid = q.gi(sc,"@freecoloraddonid");
   freecoloraddon = q.gs(sc,"@freecoloraddon");
   freecoloraddonname = q.gs(sc,"@freecoloraddonname");
   arrangementtype = q.gs(sc,"@arrangementtype");
   qtyintruck = q.gi(sc,"@qtyintruck");
   hm = q.ge(sc,"@hm");
   notifyavailabilityinadvance = q.gb(sc,"@notifyavailabilityinadvance");
   supplierid = q.gi(sc,"@supplierid");
   suppliername = q.gs(sc,"@suppliername");
   regcostdefault = q.ge(sc,"@regcostdefault");
   transportdefault = q.ge(sc,"@transportdefault");
   pdicostdefault = q.ge(sc,"@pdicostdefault");
   margindefault = q.ge(sc,"@margindefault");
   marginminimum = q.ge(sc,"@marginminimum");
   pdinotavailable = q.gb(sc,"@pdinotavailable");
   pditype = q.gi(sc,"@pditype");
   dealtype = q.gs(sc,"@dealtype");
   typevariantversion = q.gs(sc,"@typevariantversion");
   typeconfirmationnumber = q.gs(sc,"@typeconfirmationnumber");
   typeconfirmationnumberdate = q.gd(sc,"@typeconfirmationnumberdate");
   availablein = q.gs(sc,"@availablein");
   loadingfrom = q.gs(sc,"@loadingfrom");
   registrationincluded = q.gi(sc,"@registrationincluded");
   wltp = q.gs(sc,"@wltp");
   dealvalid = q.gd(sc,"@dealvalid");
   sellerid = q.gi(sc,"@sellerid");
   sellername = q.gs(sc,"@sellername");
   carsused = q.gs(sc,"@carsused");
   dealid = q.gi(sc,"@dealid");
   mileage = q.gi(sc,"@mileage");
   ontop = q.gb(sc,"@ontop");
   manager = q.gs(sc,"@manager");
   color = q.gi(sc,"@color");
   additionalnote = q.gs(sc,"@additionalnote");
   isownstock = q.gb(sc,"@isownstock");
   supplierboardnum = q.gs(sc,"@supplierboardnum");
   firstregistration = q.gd(sc,"@firstregistration");
   mileagetext = q.gs(sc,"@mileagetext");
   isfca = q.gb(sc,"@isfca");
   plannedproductionat = q.gd(sc,"@plannedproductionat");
   plannedpaymentat = q.gd(sc,"@plannedpaymentat");
   preparationperiod = q.gi(sc,"@preparationperiod");
   holdperiod = q.gi(sc,"@holdperiod");
   documentholdperiod = q.gi(sc,"@documentholdperiod");
   loadingday = q.gd(sc,"@loadingday");
   loadingfromsupplierat = q.gd(sc,"@loadingfromsupplierat");
   registrationperiod = q.gi(sc,"@registrationperiod");
   transportationperiod = q.gi(sc,"@transportationperiod");
   damage = q.ge(sc,"@damage");
   webmargin = q.ge(sc,"@webmargin");
   webmarginpercent = q.ge(sc,"@webmarginpercent");
   fueltype = q.gs(sc,"@fueltype");
   enginecapacity = q.ge(sc,"@enginecapacity");
   ownername = q.gs(sc,"@ownername");
   ownersellerid = q.gi(sc,"@ownersellerid");
   operatorname = q.gs(sc,"@operatorname");
   operatorsellerid = q.gi(sc,"@operatorsellerid");
   plannedownername = q.gs(sc,"@plannedownername");
   plannedownersellerid = q.gi(sc,"@plannedownersellerid");
   plannedoperatorname = q.gs(sc,"@plannedoperatorname");
   plannedoperatorsellerid = q.gi(sc,"@plannedoperatorsellerid");
   plannedrentername = q.gs(sc,"@plannedrentername");
   plannedrenterclientid = q.gi(sc,"@plannedrenterclientid");
   plannedsalesmargin = q.ge(sc,"@plannedsalesmargin");
   plannedsalesprice = q.ge(sc,"@plannedsalesprice");
   buybackownername = q.gs(sc,"@buybackownername");
   buybackownersellerid = q.gi(sc,"@buybackownersellerid");
   buybackmargin = q.ge(sc,"@buybackmargin");
   buybackmileage = q.gi(sc,"@buybackmileage");
   buybackperiod = q.gi(sc,"@buybackperiod");
   plannedsalesmarginpercent = q.ge(sc,"@plannedsalesmarginpercent");
   buybackprice = q.ge(sc,"@buybackprice");
   buybackst = q.gs(sc,"@buybackst");
   buybackpenalty = q.ge(sc,"@buybackpenalty");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementHoldingDatesGet (int arrangementid, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementHoldingDatesGet (arrangementid, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementHoldingDatesGet (int arrangementid, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementHoldingDatesGet (arrangementid, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementHoldingDatesGet (int arrangementid, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementHoldingDatesGet (arrangementid, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementHoldingDatesGet (int arrangementid, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__HOLDING_DATES_GET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2d(sc, "@plannedproductionat", plannedproductionat);
  q.q2d(sc, "@plannedpaymentat", plannedpaymentat);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2d(sc, "@loadingfromsupplierat", loadingfromsupplierat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   plannedproductionat = q.gd(sc,"@plannedproductionat");
   plannedpaymentat = q.gd(sc,"@plannedpaymentat");
   preparationperiod = q.gi(sc,"@preparationperiod");
   holdperiod = q.gi(sc,"@holdperiod");
   documentholdperiod = q.gi(sc,"@documentholdperiod");
   loadingday = q.gd(sc,"@loadingday");
   loadingfromsupplierat = q.gd(sc,"@loadingfromsupplierat");
   registrationperiod = q.gi(sc,"@registrationperiod");
   transportationperiod = q.gi(sc,"@transportationperiod");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementIdGet (int arrangementvehicleid, ref int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementIdGet (arrangementvehicleid, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementIdGet (int arrangementvehicleid, ref int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementIdGet (arrangementvehicleid, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementIdGet (int arrangementvehicleid, ref int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementIdGet (arrangementvehicleid, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementIdGet (int arrangementvehicleid, ref int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__ID_GET"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   arrangementid = q.gi(sc,"@arrangementid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementInfoGet (int arrangementid, ref bool isom) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementInfoGet (arrangementid, ref isom,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementInfoGet (int arrangementid, ref bool isom,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementInfoGet (arrangementid, ref isom,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementInfoGet (int arrangementid, ref bool isom,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementInfoGet (arrangementid, ref isom,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementInfoGet (int arrangementid, ref bool isom,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__INFO_GET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2b(sc, "@isom", isom);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   isom = q.gb(sc,"@isom");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementNewPrimeCostGet (int arrangementid, ref decimal newprimecost) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementNewPrimeCostGet (arrangementid, ref newprimecost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementNewPrimeCostGet (int arrangementid, ref decimal newprimecost,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementNewPrimeCostGet (arrangementid, ref newprimecost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementNewPrimeCostGet (int arrangementid, ref decimal newprimecost,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementNewPrimeCostGet (arrangementid, ref newprimecost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementNewPrimeCostGet (int arrangementid, ref decimal newprimecost,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__NEW_PRIME_COST_GET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2e(sc, "@newprimecost", newprimecost);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   newprimecost = q.ge(sc,"@newprimecost");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementNewPrimeCostSet (int arrangementid, int updatetype, int compensatetype, decimal newprimecost) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementNewPrimeCostSet (arrangementid, updatetype, compensatetype, newprimecost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementNewPrimeCostSet (int arrangementid, int updatetype, int compensatetype, decimal newprimecost,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementNewPrimeCostSet (arrangementid, updatetype, compensatetype, newprimecost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementNewPrimeCostSet (int arrangementid, int updatetype, int compensatetype, decimal newprimecost,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementNewPrimeCostSet (arrangementid, updatetype, compensatetype, newprimecost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementNewPrimeCostSet (int arrangementid, int updatetype, int compensatetype, decimal newprimecost,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__NEW_PRIME_COST_SET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@updatetype", updatetype);
  q.q2i(sc, "@compensatetype", compensatetype);
  q.q2e(sc, "@newprimecost", newprimecost);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementOldVw (int arrangementid, ref string modelcode, ref string modelname, ref int quantity, ref decimal price, ref string freecoloraddon, ref string freecoloraddonname, ref string intaddon, ref string intaddonname, ref string options, ref int ispricenew, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementOldVw (arrangementid, ref modelcode, ref modelname, ref quantity, ref price, ref freecoloraddon, ref freecoloraddonname, ref intaddon, ref intaddonname, ref options, ref ispricenew, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementOldVw (int arrangementid, ref string modelcode, ref string modelname, ref int quantity, ref decimal price, ref string freecoloraddon, ref string freecoloraddonname, ref string intaddon, ref string intaddonname, ref string options, ref int ispricenew, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementOldVw (arrangementid, ref modelcode, ref modelname, ref quantity, ref price, ref freecoloraddon, ref freecoloraddonname, ref intaddon, ref intaddonname, ref options, ref ispricenew, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementOldVw (int arrangementid, ref string modelcode, ref string modelname, ref int quantity, ref decimal price, ref string freecoloraddon, ref string freecoloraddonname, ref string intaddon, ref string intaddonname, ref string options, ref int ispricenew, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementOldVw (arrangementid, ref modelcode, ref modelname, ref quantity, ref price, ref freecoloraddon, ref freecoloraddonname, ref intaddon, ref intaddonname, ref options, ref ispricenew, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementOldVw (int arrangementid, ref string modelcode, ref string modelname, ref int quantity, ref decimal price, ref string freecoloraddon, ref string freecoloraddonname, ref string intaddon, ref string intaddonname, ref string options, ref int ispricenew, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__OLD_vw"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@modelname", modelname);
  q.q2i(sc, "@quantity", quantity);
  q.q2e(sc, "@price", price);
  q.q2s(sc, "@freecoloraddon", freecoloraddon);
  q.q2s(sc, "@freecoloraddonname", freecoloraddonname);
  q.q2s(sc, "@intaddon", intaddon);
  q.q2s(sc, "@intaddonname", intaddonname);
  q.q2s(sc, "@options", options);
  q.q2i(sc, "@ispricenew", ispricenew);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   modelcode = q.gs(sc,"@modelcode");
   modelname = q.gs(sc,"@modelname");
   quantity = q.gi(sc,"@quantity");
   price = q.ge(sc,"@price");
   freecoloraddon = q.gs(sc,"@freecoloraddon");
   freecoloraddonname = q.gs(sc,"@freecoloraddonname");
   intaddon = q.gs(sc,"@intaddon");
   intaddonname = q.gs(sc,"@intaddonname");
   options = q.gs(sc,"@options");
   ispricenew = q.gi(sc,"@ispricenew");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementOld2Vw (int arrangementid, ref string modelcode, ref string modelname, ref int quantity, ref decimal price, ref string freecoloraddon, ref string freecoloraddonname, ref string intaddon, ref string intaddonname, ref string options, ref int ispricenew, ref string staffname, ref DateTime annexedat, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementOld2Vw (arrangementid, ref modelcode, ref modelname, ref quantity, ref price, ref freecoloraddon, ref freecoloraddonname, ref intaddon, ref intaddonname, ref options, ref ispricenew, ref staffname, ref annexedat, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementOld2Vw (int arrangementid, ref string modelcode, ref string modelname, ref int quantity, ref decimal price, ref string freecoloraddon, ref string freecoloraddonname, ref string intaddon, ref string intaddonname, ref string options, ref int ispricenew, ref string staffname, ref DateTime annexedat, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementOld2Vw (arrangementid, ref modelcode, ref modelname, ref quantity, ref price, ref freecoloraddon, ref freecoloraddonname, ref intaddon, ref intaddonname, ref options, ref ispricenew, ref staffname, ref annexedat, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementOld2Vw (int arrangementid, ref string modelcode, ref string modelname, ref int quantity, ref decimal price, ref string freecoloraddon, ref string freecoloraddonname, ref string intaddon, ref string intaddonname, ref string options, ref int ispricenew, ref string staffname, ref DateTime annexedat, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementOld2Vw (arrangementid, ref modelcode, ref modelname, ref quantity, ref price, ref freecoloraddon, ref freecoloraddonname, ref intaddon, ref intaddonname, ref options, ref ispricenew, ref staffname, ref annexedat, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementOld2Vw (int arrangementid, ref string modelcode, ref string modelname, ref int quantity, ref decimal price, ref string freecoloraddon, ref string freecoloraddonname, ref string intaddon, ref string intaddonname, ref string options, ref int ispricenew, ref string staffname, ref DateTime annexedat, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__OLD2_vw"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@modelname", modelname);
  q.q2i(sc, "@quantity", quantity);
  q.q2e(sc, "@price", price);
  q.q2s(sc, "@freecoloraddon", freecoloraddon);
  q.q2s(sc, "@freecoloraddonname", freecoloraddonname);
  q.q2s(sc, "@intaddon", intaddon);
  q.q2s(sc, "@intaddonname", intaddonname);
  q.q2s(sc, "@options", options);
  q.q2i(sc, "@ispricenew", ispricenew);
  q.q2s(sc, "@staffname", staffname);
  q.q2d(sc, "@annexedat", annexedat);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   modelcode = q.gs(sc,"@modelcode");
   modelname = q.gs(sc,"@modelname");
   quantity = q.gi(sc,"@quantity");
   price = q.ge(sc,"@price");
   freecoloraddon = q.gs(sc,"@freecoloraddon");
   freecoloraddonname = q.gs(sc,"@freecoloraddonname");
   intaddon = q.gs(sc,"@intaddon");
   intaddonname = q.gs(sc,"@intaddonname");
   options = q.gs(sc,"@options");
   ispricenew = q.gi(sc,"@ispricenew");
   staffname = q.gs(sc,"@staffname");
   annexedat = q.gd(sc,"@annexedat");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementPost (int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementPost (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementPost (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementPost (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementPost (int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementPost (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementPost (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__POST"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementReopen (int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementReopen (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementReopen (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementReopen (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementReopen (int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementReopen (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementReopen (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__REOPEN"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementResume (int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementResume (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementResume (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementResume (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementResume (int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementResume (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementResume (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__RESUME"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementSalesSupportAdjust (int arrangementid, decimal newsalessupport, decimal newsalessupport2) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementSalesSupportAdjust (arrangementid, newsalessupport, newsalessupport2,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementSalesSupportAdjust (int arrangementid, decimal newsalessupport, decimal newsalessupport2,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementSalesSupportAdjust (arrangementid, newsalessupport, newsalessupport2,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementSalesSupportAdjust (int arrangementid, decimal newsalessupport, decimal newsalessupport2,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementSalesSupportAdjust (arrangementid, newsalessupport, newsalessupport2,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementSalesSupportAdjust (int arrangementid, decimal newsalessupport, decimal newsalessupport2,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__SALES_SUPPORT_ADJUST"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2e(sc, "@newsalessupport", newsalessupport);
  q.q2e(sc, "@newsalessupport2", newsalessupport2);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementSalesSupportGet (int arrangementid, ref decimal salessupport, ref decimal salessupport2) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementSalesSupportGet (arrangementid, ref salessupport, ref salessupport2,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementSalesSupportGet (int arrangementid, ref decimal salessupport, ref decimal salessupport2,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementSalesSupportGet (arrangementid, ref salessupport, ref salessupport2,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementSalesSupportGet (int arrangementid, ref decimal salessupport, ref decimal salessupport2,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementSalesSupportGet (arrangementid, ref salessupport, ref salessupport2,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementSalesSupportGet (int arrangementid, ref decimal salessupport, ref decimal salessupport2,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__SALES_SUPPORT_GET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2e(sc, "@salessupport", salessupport);
  q.q2e(sc, "@salessupport2", salessupport2);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   salessupport = q.ge(sc,"@salessupport");
   salessupport2 = q.ge(sc,"@salessupport2");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementStandardEqpGet (int arrangementid, ref string standardeqp, ref bool optionsshow) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementStandardEqpGet (arrangementid, ref standardeqp, ref optionsshow,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEqpGet (int arrangementid, ref string standardeqp, ref bool optionsshow,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementStandardEqpGet (arrangementid, ref standardeqp, ref optionsshow,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEqpGet (int arrangementid, ref string standardeqp, ref bool optionsshow,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementStandardEqpGet (arrangementid, ref standardeqp, ref optionsshow,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEqpGet (int arrangementid, ref string standardeqp, ref bool optionsshow,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__STANDARD_EQP_GET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@standardeqp", standardeqp);
  q.q2b(sc, "@optionsshow", optionsshow);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   standardeqp = q.gs(sc,"@standardeqp");
   optionsshow = q.gb(sc,"@optionsshow");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementStandardEqpRenew (int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementStandardEqpRenew (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEqpRenew (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementStandardEqpRenew (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEqpRenew (int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementStandardEqpRenew (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEqpRenew (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__STANDARD_EQP_RENEW"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementSuspend (int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementSuspend (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementSuspend (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementSuspend (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementSuspend (int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementSuspend (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementSuspend (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__SUSPEND"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementUpdate (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementUpdate (arrangementid, modelcode, modelname, modelshortname, dt, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext, datesupdate, vehiclesatvendor, plannedpaymentat, preparationperiod, physicalholdperiod, documentholdperiod, loadingdaytoclient, readytoloadfromsupplierat, registrationperiod, transportationperiod, damage, marginpercent, marginmoney, fueltype, enginecapacity,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementUpdate (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementUpdate (arrangementid, modelcode, modelname, modelshortname, dt, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext, datesupdate, vehiclesatvendor, plannedpaymentat, preparationperiod, physicalholdperiod, documentholdperiod, loadingdaytoclient, readytoloadfromsupplierat, registrationperiod, transportationperiod, damage, marginpercent, marginmoney, fueltype, enginecapacity,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementUpdate (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementUpdate (arrangementid, modelcode, modelname, modelshortname, dt, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext, datesupdate, vehiclesatvendor, plannedpaymentat, preparationperiod, physicalholdperiod, documentholdperiod, loadingdaytoclient, readytoloadfromsupplierat, registrationperiod, transportationperiod, damage, marginpercent, marginmoney, fueltype, enginecapacity,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementUpdate (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__UPDATE"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@modelshortname", modelshortname);
  q.q2d(sc, "@dt", dt);
  q.q2i(sc, "@quantity", quantity);
  q.q2e(sc, "@price", price);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@standardequipment", standardequipment);
  q.q2e(sc, "@supportcost", supportcost);
  q.q2e(sc, "@supportcost2", supportcost2);
  q.q2i(sc, "@freecoloraddonid", freecoloraddonid);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2e(sc, "@hm", hm);
  q.q2b(sc, "@notifyavailabilityinadvance", notifyavailabilityinadvance);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2e(sc, "@regcostdefault", regcostdefault);
  q.q2e(sc, "@transportdefault", transportdefault);
  q.q2e(sc, "@pdicostdefault", pdicostdefault);
  q.q2e(sc, "@margindefault", margindefault);
  q.q2e(sc, "@marginminimum", marginminimum);
  q.q2b(sc, "@pdinotavailable", pdinotavailable);
  q.q2i(sc, "@pditype", pditype);
  q.q2s(sc, "@dealtype", dealtype);
  q.q2s(sc, "@typevariantversion", typevariantversion);
  q.q2s(sc, "@typeconfirmationnumber", typeconfirmationnumber);
  q.q2d(sc, "@typeconfirmationnumberdate", typeconfirmationnumberdate);
  q.q2s(sc, "@availablein", availablein);
  q.q2s(sc, "@loadingfrom", loadingfrom);
  q.q2i(sc, "@registrationincluded", registrationincluded);
  q.q2s(sc, "@wltp", wltp);
  q.q2d(sc, "@dealvalid", dealvalid);
  q.q2i(sc, "@sellerid", sellerid);
  q.q2s(sc, "@carsused", carsused);
  q.q2i(sc, "@dealid", dealid);
  q.q2i(sc, "@mileage", mileage);
  q.q2b(sc, "@ontop", ontop);
  q.q2i(sc, "@color", color);
  q.q2s(sc, "@additionalnote", additionalnote);
  q.q2b(sc, "@isownstock", isownstock);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2s(sc, "@mileagetext", mileagetext);
  q.q2b(sc, "@datesupdate", datesupdate);
  q.q2d(sc, "@vehiclesatvendor", vehiclesatvendor);
  q.q2d(sc, "@plannedpaymentat", plannedpaymentat);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2i(sc, "@physicalholdperiod", physicalholdperiod);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2d(sc, "@loadingdaytoclient", loadingdaytoclient);
  q.q2d(sc, "@readytoloadfromsupplierat", readytoloadfromsupplierat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  q.q2e(sc, "@damage", damage);
  q.q2e(sc, "@marginpercent", marginpercent);
  q.q2e(sc, "@marginmoney", marginmoney);
  q.q2s(sc, "@fueltype", fueltype);
  q.q2e(sc, "@enginecapacity", enginecapacity);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementUpdate2 (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity, int ownersellerid, int operatorsellerid, int plannedownersellerid, int plannedoperatorsellerid, int plannedrenterclientid, decimal plannedsalesmargin, decimal plannedsalesprice, int buybackownersellerid, decimal buybackmargin, int buybackmileage, int buybackperiod) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementUpdate2 (arrangementid, modelcode, modelname, modelshortname, dt, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext, datesupdate, vehiclesatvendor, plannedpaymentat, preparationperiod, physicalholdperiod, documentholdperiod, loadingdaytoclient, readytoloadfromsupplierat, registrationperiod, transportationperiod, damage, marginpercent, marginmoney, fueltype, enginecapacity, ownersellerid, operatorsellerid, plannedownersellerid, plannedoperatorsellerid, plannedrenterclientid, plannedsalesmargin, plannedsalesprice, buybackownersellerid, buybackmargin, buybackmileage, buybackperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementUpdate2 (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity, int ownersellerid, int operatorsellerid, int plannedownersellerid, int plannedoperatorsellerid, int plannedrenterclientid, decimal plannedsalesmargin, decimal plannedsalesprice, int buybackownersellerid, decimal buybackmargin, int buybackmileage, int buybackperiod,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementUpdate2 (arrangementid, modelcode, modelname, modelshortname, dt, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext, datesupdate, vehiclesatvendor, plannedpaymentat, preparationperiod, physicalholdperiod, documentholdperiod, loadingdaytoclient, readytoloadfromsupplierat, registrationperiod, transportationperiod, damage, marginpercent, marginmoney, fueltype, enginecapacity, ownersellerid, operatorsellerid, plannedownersellerid, plannedoperatorsellerid, plannedrenterclientid, plannedsalesmargin, plannedsalesprice, buybackownersellerid, buybackmargin, buybackmileage, buybackperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementUpdate2 (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity, int ownersellerid, int operatorsellerid, int plannedownersellerid, int plannedoperatorsellerid, int plannedrenterclientid, decimal plannedsalesmargin, decimal plannedsalesprice, int buybackownersellerid, decimal buybackmargin, int buybackmileage, int buybackperiod,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementUpdate2 (arrangementid, modelcode, modelname, modelshortname, dt, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext, datesupdate, vehiclesatvendor, plannedpaymentat, preparationperiod, physicalholdperiod, documentholdperiod, loadingdaytoclient, readytoloadfromsupplierat, registrationperiod, transportationperiod, damage, marginpercent, marginmoney, fueltype, enginecapacity, ownersellerid, operatorsellerid, plannedownersellerid, plannedoperatorsellerid, plannedrenterclientid, plannedsalesmargin, plannedsalesprice, buybackownersellerid, buybackmargin, buybackmileage, buybackperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementUpdate2 (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity, int ownersellerid, int operatorsellerid, int plannedownersellerid, int plannedoperatorsellerid, int plannedrenterclientid, decimal plannedsalesmargin, decimal plannedsalesprice, int buybackownersellerid, decimal buybackmargin, int buybackmileage, int buybackperiod,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__UPDATE2"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@modelshortname", modelshortname);
  q.q2d(sc, "@dt", dt);
  q.q2i(sc, "@quantity", quantity);
  q.q2e(sc, "@price", price);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@standardequipment", standardequipment);
  q.q2e(sc, "@supportcost", supportcost);
  q.q2e(sc, "@supportcost2", supportcost2);
  q.q2i(sc, "@freecoloraddonid", freecoloraddonid);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2e(sc, "@hm", hm);
  q.q2b(sc, "@notifyavailabilityinadvance", notifyavailabilityinadvance);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2e(sc, "@regcostdefault", regcostdefault);
  q.q2e(sc, "@transportdefault", transportdefault);
  q.q2e(sc, "@pdicostdefault", pdicostdefault);
  q.q2e(sc, "@margindefault", margindefault);
  q.q2e(sc, "@marginminimum", marginminimum);
  q.q2b(sc, "@pdinotavailable", pdinotavailable);
  q.q2i(sc, "@pditype", pditype);
  q.q2s(sc, "@dealtype", dealtype);
  q.q2s(sc, "@typevariantversion", typevariantversion);
  q.q2s(sc, "@typeconfirmationnumber", typeconfirmationnumber);
  q.q2d(sc, "@typeconfirmationnumberdate", typeconfirmationnumberdate);
  q.q2s(sc, "@availablein", availablein);
  q.q2s(sc, "@loadingfrom", loadingfrom);
  q.q2i(sc, "@registrationincluded", registrationincluded);
  q.q2s(sc, "@wltp", wltp);
  q.q2d(sc, "@dealvalid", dealvalid);
  q.q2i(sc, "@sellerid", sellerid);
  q.q2s(sc, "@carsused", carsused);
  q.q2i(sc, "@dealid", dealid);
  q.q2i(sc, "@mileage", mileage);
  q.q2b(sc, "@ontop", ontop);
  q.q2i(sc, "@color", color);
  q.q2s(sc, "@additionalnote", additionalnote);
  q.q2b(sc, "@isownstock", isownstock);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2s(sc, "@mileagetext", mileagetext);
  q.q2b(sc, "@datesupdate", datesupdate);
  q.q2d(sc, "@vehiclesatvendor", vehiclesatvendor);
  q.q2d(sc, "@plannedpaymentat", plannedpaymentat);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2i(sc, "@physicalholdperiod", physicalholdperiod);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2d(sc, "@loadingdaytoclient", loadingdaytoclient);
  q.q2d(sc, "@readytoloadfromsupplierat", readytoloadfromsupplierat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  q.q2e(sc, "@damage", damage);
  q.q2e(sc, "@marginpercent", marginpercent);
  q.q2e(sc, "@marginmoney", marginmoney);
  q.q2s(sc, "@fueltype", fueltype);
  q.q2e(sc, "@enginecapacity", enginecapacity);
  q.q2i(sc, "@ownersellerid", ownersellerid);
  q.q2i(sc, "@operatorsellerid", operatorsellerid);
  q.q2i(sc, "@plannedownersellerid", plannedownersellerid);
  q.q2i(sc, "@plannedoperatorsellerid", plannedoperatorsellerid);
  q.q2i(sc, "@plannedrenterclientid", plannedrenterclientid);
  q.q2e(sc, "@plannedsalesmargin", plannedsalesmargin);
  q.q2e(sc, "@plannedsalesprice", plannedsalesprice);
  q.q2i(sc, "@buybackownersellerid", buybackownersellerid);
  q.q2e(sc, "@buybackmargin", buybackmargin);
  q.q2i(sc, "@buybackmileage", buybackmileage);
  q.q2i(sc, "@buybackperiod", buybackperiod);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementUpdate3 (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity, int ownersellerid, int operatorsellerid, int plannedownersellerid, int plannedoperatorsellerid, int plannedrenterclientid, decimal plannedsalesmargin, decimal plannedsalesprice, int buybackownersellerid, decimal buybackmargin, int buybackmileage, int buybackperiod, decimal plannedsalesmarginpercent, decimal buybackprice, string buybackst, decimal buybackpenalty) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementUpdate3 (arrangementid, modelcode, modelname, modelshortname, dt, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext, datesupdate, vehiclesatvendor, plannedpaymentat, preparationperiod, physicalholdperiod, documentholdperiod, loadingdaytoclient, readytoloadfromsupplierat, registrationperiod, transportationperiod, damage, marginpercent, marginmoney, fueltype, enginecapacity, ownersellerid, operatorsellerid, plannedownersellerid, plannedoperatorsellerid, plannedrenterclientid, plannedsalesmargin, plannedsalesprice, buybackownersellerid, buybackmargin, buybackmileage, buybackperiod, plannedsalesmarginpercent, buybackprice, buybackst, buybackpenalty,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementUpdate3 (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity, int ownersellerid, int operatorsellerid, int plannedownersellerid, int plannedoperatorsellerid, int plannedrenterclientid, decimal plannedsalesmargin, decimal plannedsalesprice, int buybackownersellerid, decimal buybackmargin, int buybackmileage, int buybackperiod, decimal plannedsalesmarginpercent, decimal buybackprice, string buybackst, decimal buybackpenalty,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementUpdate3 (arrangementid, modelcode, modelname, modelshortname, dt, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext, datesupdate, vehiclesatvendor, plannedpaymentat, preparationperiod, physicalholdperiod, documentholdperiod, loadingdaytoclient, readytoloadfromsupplierat, registrationperiod, transportationperiod, damage, marginpercent, marginmoney, fueltype, enginecapacity, ownersellerid, operatorsellerid, plannedownersellerid, plannedoperatorsellerid, plannedrenterclientid, plannedsalesmargin, plannedsalesprice, buybackownersellerid, buybackmargin, buybackmileage, buybackperiod, plannedsalesmarginpercent, buybackprice, buybackst, buybackpenalty,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementUpdate3 (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity, int ownersellerid, int operatorsellerid, int plannedownersellerid, int plannedoperatorsellerid, int plannedrenterclientid, decimal plannedsalesmargin, decimal plannedsalesprice, int buybackownersellerid, decimal buybackmargin, int buybackmileage, int buybackperiod, decimal plannedsalesmarginpercent, decimal buybackprice, string buybackst, decimal buybackpenalty,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementUpdate3 (arrangementid, modelcode, modelname, modelshortname, dt, quantity, price, note, standardequipment, supportcost, supportcost2, freecoloraddonid, qtyintruck, hm, notifyavailabilityinadvance, supplierid, regcostdefault, transportdefault, pdicostdefault, margindefault, marginminimum, pdinotavailable, pditype, dealtype, typevariantversion, typeconfirmationnumber, typeconfirmationnumberdate, availablein, loadingfrom, registrationincluded, wltp, dealvalid, sellerid, carsused, dealid, mileage, ontop, color, additionalnote, isownstock, firstregistration, mileagetext, datesupdate, vehiclesatvendor, plannedpaymentat, preparationperiod, physicalholdperiod, documentholdperiod, loadingdaytoclient, readytoloadfromsupplierat, registrationperiod, transportationperiod, damage, marginpercent, marginmoney, fueltype, enginecapacity, ownersellerid, operatorsellerid, plannedownersellerid, plannedoperatorsellerid, plannedrenterclientid, plannedsalesmargin, plannedsalesprice, buybackownersellerid, buybackmargin, buybackmileage, buybackperiod, plannedsalesmarginpercent, buybackprice, buybackst, buybackpenalty,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementUpdate3 (int arrangementid, string modelcode, string modelname, string modelshortname, DateTime dt, int quantity, decimal price, string note, string standardequipment, decimal supportcost, decimal supportcost2, int freecoloraddonid, int qtyintruck, decimal hm, bool notifyavailabilityinadvance, int supplierid, decimal regcostdefault, decimal transportdefault, decimal pdicostdefault, decimal margindefault, decimal marginminimum, bool pdinotavailable, int pditype, string dealtype, string typevariantversion, string typeconfirmationnumber, DateTime typeconfirmationnumberdate, string availablein, string loadingfrom, int registrationincluded, string wltp, DateTime dealvalid, int sellerid, string carsused, int dealid, int mileage, bool ontop, int color, string additionalnote, bool isownstock, DateTime firstregistration, string mileagetext, bool datesupdate, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int physicalholdperiod, int documentholdperiod, DateTime loadingdaytoclient, DateTime readytoloadfromsupplierat, int registrationperiod, int transportationperiod, decimal damage, decimal marginpercent, decimal marginmoney, string fueltype, decimal enginecapacity, int ownersellerid, int operatorsellerid, int plannedownersellerid, int plannedoperatorsellerid, int plannedrenterclientid, decimal plannedsalesmargin, decimal plannedsalesprice, int buybackownersellerid, decimal buybackmargin, int buybackmileage, int buybackperiod, decimal plannedsalesmarginpercent, decimal buybackprice, string buybackst, decimal buybackpenalty,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__UPDATE3"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@modelshortname", modelshortname);
  q.q2d(sc, "@dt", dt);
  q.q2i(sc, "@quantity", quantity);
  q.q2e(sc, "@price", price);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@standardequipment", standardequipment);
  q.q2e(sc, "@supportcost", supportcost);
  q.q2e(sc, "@supportcost2", supportcost2);
  q.q2i(sc, "@freecoloraddonid", freecoloraddonid);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2e(sc, "@hm", hm);
  q.q2b(sc, "@notifyavailabilityinadvance", notifyavailabilityinadvance);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2e(sc, "@regcostdefault", regcostdefault);
  q.q2e(sc, "@transportdefault", transportdefault);
  q.q2e(sc, "@pdicostdefault", pdicostdefault);
  q.q2e(sc, "@margindefault", margindefault);
  q.q2e(sc, "@marginminimum", marginminimum);
  q.q2b(sc, "@pdinotavailable", pdinotavailable);
  q.q2i(sc, "@pditype", pditype);
  q.q2s(sc, "@dealtype", dealtype);
  q.q2s(sc, "@typevariantversion", typevariantversion);
  q.q2s(sc, "@typeconfirmationnumber", typeconfirmationnumber);
  q.q2d(sc, "@typeconfirmationnumberdate", typeconfirmationnumberdate);
  q.q2s(sc, "@availablein", availablein);
  q.q2s(sc, "@loadingfrom", loadingfrom);
  q.q2i(sc, "@registrationincluded", registrationincluded);
  q.q2s(sc, "@wltp", wltp);
  q.q2d(sc, "@dealvalid", dealvalid);
  q.q2i(sc, "@sellerid", sellerid);
  q.q2s(sc, "@carsused", carsused);
  q.q2i(sc, "@dealid", dealid);
  q.q2i(sc, "@mileage", mileage);
  q.q2b(sc, "@ontop", ontop);
  q.q2i(sc, "@color", color);
  q.q2s(sc, "@additionalnote", additionalnote);
  q.q2b(sc, "@isownstock", isownstock);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2s(sc, "@mileagetext", mileagetext);
  q.q2b(sc, "@datesupdate", datesupdate);
  q.q2d(sc, "@vehiclesatvendor", vehiclesatvendor);
  q.q2d(sc, "@plannedpaymentat", plannedpaymentat);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2i(sc, "@physicalholdperiod", physicalholdperiod);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2d(sc, "@loadingdaytoclient", loadingdaytoclient);
  q.q2d(sc, "@readytoloadfromsupplierat", readytoloadfromsupplierat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  q.q2e(sc, "@damage", damage);
  q.q2e(sc, "@marginpercent", marginpercent);
  q.q2e(sc, "@marginmoney", marginmoney);
  q.q2s(sc, "@fueltype", fueltype);
  q.q2e(sc, "@enginecapacity", enginecapacity);
  q.q2i(sc, "@ownersellerid", ownersellerid);
  q.q2i(sc, "@operatorsellerid", operatorsellerid);
  q.q2i(sc, "@plannedownersellerid", plannedownersellerid);
  q.q2i(sc, "@plannedoperatorsellerid", plannedoperatorsellerid);
  q.q2i(sc, "@plannedrenterclientid", plannedrenterclientid);
  q.q2e(sc, "@plannedsalesmargin", plannedsalesmargin);
  q.q2e(sc, "@plannedsalesprice", plannedsalesprice);
  q.q2i(sc, "@buybackownersellerid", buybackownersellerid);
  q.q2e(sc, "@buybackmargin", buybackmargin);
  q.q2i(sc, "@buybackmileage", buybackmileage);
  q.q2i(sc, "@buybackperiod", buybackperiod);
  q.q2e(sc, "@plannedsalesmarginpercent", plannedsalesmarginpercent);
  q.q2e(sc, "@buybackprice", buybackprice);
  q.q2s(sc, "@buybackst", buybackst);
  q.q2e(sc, "@buybackpenalty", buybackpenalty);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVinsImportExcel (int arrangementid, string xlsfn, string xlsext, byte[] xls, string worksheet, DataTable colmap, int firstdatarow, ref int totalexcelrows, ref string info, ref int irc) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVinsImportExcel (arrangementid, xlsfn, xlsext, xls, worksheet, colmap, firstdatarow, ref totalexcelrows, ref info, ref irc,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVinsImportExcel (int arrangementid, string xlsfn, string xlsext, byte[] xls, string worksheet, DataTable colmap, int firstdatarow, ref int totalexcelrows, ref string info, ref int irc,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVinsImportExcel (arrangementid, xlsfn, xlsext, xls, worksheet, colmap, firstdatarow, ref totalexcelrows, ref info, ref irc,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVinsImportExcel (int arrangementid, string xlsfn, string xlsext, byte[] xls, string worksheet, DataTable colmap, int firstdatarow, ref int totalexcelrows, ref string info, ref int irc,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVinsImportExcel (arrangementid, xlsfn, xlsext, xls, worksheet, colmap, firstdatarow, ref totalexcelrows, ref info, ref irc,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVinsImportExcel (int arrangementid, string xlsfn, string xlsext, byte[] xls, string worksheet, DataTable colmap, int firstdatarow, ref int totalexcelrows, ref string info, ref int irc,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT__VINS_IMPORT_EXCEL"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@xlsfn", xlsfn);
  q.q2s(sc, "@xlsext", xlsext);
  q.q2a(sc, "@xls", xls);
  q.q2s(sc, "@worksheet", worksheet);
  q.q2u(sc, "@colmap", "eexcelcolmap", colmap);
  q.q2i(sc, "@firstdatarow", firstdatarow);
  q.q2i(sc, "@totalexcelrows", totalexcelrows);
  q.q2s(sc, "@info", info);
  q.q2i(sc, "@irc", irc);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   totalexcelrows = q.gi(sc,"@totalexcelrows");
   info = q.gs(sc,"@info");
   irc = q.gi(sc,"@irc");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementAddonAdd (int arrangementid, string code, int eriortype, string description, bool appendtoglossary, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementAddonAdd (arrangementid, code, eriortype, description, appendtoglossary, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonAdd (int arrangementid, string code, int eriortype, string description, bool appendtoglossary, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementAddonAdd (arrangementid, code, eriortype, description, appendtoglossary, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonAdd (int arrangementid, string code, int eriortype, string description, bool appendtoglossary, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementAddonAdd (arrangementid, code, eriortype, description, appendtoglossary, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonAdd (int arrangementid, string code, int eriortype, string description, bool appendtoglossary, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_ADDON__ADD"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@code", code);
  q.q2i(sc, "@eriortype", eriortype);
  q.q2s(sc, "@description", description);
  q.q2b(sc, "@appendtoglossary", appendtoglossary);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementAddonDelete (int arrangementaddonid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementAddonDelete (arrangementaddonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonDelete (int arrangementaddonid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementAddonDelete (arrangementaddonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonDelete (int arrangementaddonid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementAddonDelete (arrangementaddonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonDelete (int arrangementaddonid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_ADDON__DELETE"); 
  q.q2i(sc, "@arrangementaddonid", arrangementaddonid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementAddonInfoGetBycode (int arrangementid, string addoncode, int requirederiortype, ref string description, ref int addonid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementAddonInfoGetBycode (arrangementid, addoncode, requirederiortype, ref description, ref addonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonInfoGetBycode (int arrangementid, string addoncode, int requirederiortype, ref string description, ref int addonid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementAddonInfoGetBycode (arrangementid, addoncode, requirederiortype, ref description, ref addonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonInfoGetBycode (int arrangementid, string addoncode, int requirederiortype, ref string description, ref int addonid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementAddonInfoGetBycode (arrangementid, addoncode, requirederiortype, ref description, ref addonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonInfoGetBycode (int arrangementid, string addoncode, int requirederiortype, ref string description, ref int addonid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_ADDON__INFO_GET_BYCODE"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@addoncode", addoncode);
  q.q2i(sc, "@requirederiortype", requirederiortype);
  q.q2s(sc, "@description", description);
  q.q2i(sc, "@addonid", addonid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   description = q.gs(sc,"@description");
   addonid = q.gi(sc,"@addonid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementAddonUpdate (int arrangementaddonid, string description, int eriortype, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementAddonUpdate (arrangementaddonid, description, eriortype, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonUpdate (int arrangementaddonid, string description, int eriortype, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementAddonUpdate (arrangementaddonid, description, eriortype, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonUpdate (int arrangementaddonid, string description, int eriortype, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementAddonUpdate (arrangementaddonid, description, eriortype, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonUpdate (int arrangementaddonid, string description, int eriortype, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_ADDON__UPDATE"); 
  q.q2i(sc, "@arrangementaddonid", arrangementaddonid);
  q.q2s(sc, "@description", description);
  q.q2i(sc, "@eriortype", eriortype);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementAddonMainOptionGet (int arrangementid, ref bool alloywheels15, ref bool alloywheels16, ref bool alloywheels17, ref bool alloywheels18, ref bool alloywheels19, ref bool alloywheels20, ref bool alloywheels21, ref bool alloywheels15black, ref bool alloywheels16black, ref bool alloywheels17black, ref bool alloywheels18black, ref bool alloywheels19black, ref bool alloywheels20black, ref bool alloywheels21black, ref bool steelwheels14, ref bool steelwheels15, ref bool steelwheels16, ref bool steelwheels17, ref bool twotonepaint, ref bool metallicpaint, ref bool pastelpaintfree, ref bool leddayrunninglights, ref bool halogenheadlights, ref bool bixenonheadlights, ref bool ecoledheadlights, ref bool fullledheadlights, ref bool adaptativefullledheadlights, ref bool highbeamheadlights, ref bool foglights, ref bool corneringfoglights, ref bool rainsensor, ref bool dusksensor, ref bool frontparkingsensors, ref bool rearparkingsensors, ref bool heatedfrontseats, ref bool heatedrearseats, ref bool seatswithmassagefunction, ref bool ventilatedfrontseats, ref bool electricseats, ref bool textileinterior, ref bool alcantarainterior, ref bool leatherinterior, ref bool electrochromaticrearviewmirror, ref bool electricheatedmirrors, ref bool electricallyfoldingmirrors, ref bool automaticairconditionner, ref bool manualairconditionner, ref bool cruisecontrol, ref bool adaptativecruisecontrol, ref bool trafficsignrecognition, ref bool laneassist, ref bool intelligentlaneassist, ref bool blindspotmonitor, ref bool inductioncharging, ref bool carplayandroidauto, ref bool carplayandroidautowireless, ref bool navigation, ref bool navigationpro, ref bool parkingassistant, ref bool coffeebreakalert, ref bool sparewheel, ref bool sportexhaust, ref bool panoramicroof, ref bool fixedglassroof, ref bool openingglassroof, ref bool radio, ref bool tintedrearwindows, ref bool premiumqualitysoundsystem, ref bool heatedfrontwindow, ref bool winterpackage, ref bool heatedsteeringwheel, ref bool electrictailgate, ref bool keylessstart, ref bool keylessstartandentry, ref bool armrest, ref bool digitalcockpit, ref bool camera, ref bool camera360, ref bool preparationforsparewheel, ref bool alarm, ref bool softdoorclosing) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementAddonMainOptionGet (arrangementid, ref alloywheels15, ref alloywheels16, ref alloywheels17, ref alloywheels18, ref alloywheels19, ref alloywheels20, ref alloywheels21, ref alloywheels15black, ref alloywheels16black, ref alloywheels17black, ref alloywheels18black, ref alloywheels19black, ref alloywheels20black, ref alloywheels21black, ref steelwheels14, ref steelwheels15, ref steelwheels16, ref steelwheels17, ref twotonepaint, ref metallicpaint, ref pastelpaintfree, ref leddayrunninglights, ref halogenheadlights, ref bixenonheadlights, ref ecoledheadlights, ref fullledheadlights, ref adaptativefullledheadlights, ref highbeamheadlights, ref foglights, ref corneringfoglights, ref rainsensor, ref dusksensor, ref frontparkingsensors, ref rearparkingsensors, ref heatedfrontseats, ref heatedrearseats, ref seatswithmassagefunction, ref ventilatedfrontseats, ref electricseats, ref textileinterior, ref alcantarainterior, ref leatherinterior, ref electrochromaticrearviewmirror, ref electricheatedmirrors, ref electricallyfoldingmirrors, ref automaticairconditionner, ref manualairconditionner, ref cruisecontrol, ref adaptativecruisecontrol, ref trafficsignrecognition, ref laneassist, ref intelligentlaneassist, ref blindspotmonitor, ref inductioncharging, ref carplayandroidauto, ref carplayandroidautowireless, ref navigation, ref navigationpro, ref parkingassistant, ref coffeebreakalert, ref sparewheel, ref sportexhaust, ref panoramicroof, ref fixedglassroof, ref openingglassroof, ref radio, ref tintedrearwindows, ref premiumqualitysoundsystem, ref heatedfrontwindow, ref winterpackage, ref heatedsteeringwheel, ref electrictailgate, ref keylessstart, ref keylessstartandentry, ref armrest, ref digitalcockpit, ref camera, ref camera360, ref preparationforsparewheel, ref alarm, ref softdoorclosing,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonMainOptionGet (int arrangementid, ref bool alloywheels15, ref bool alloywheels16, ref bool alloywheels17, ref bool alloywheels18, ref bool alloywheels19, ref bool alloywheels20, ref bool alloywheels21, ref bool alloywheels15black, ref bool alloywheels16black, ref bool alloywheels17black, ref bool alloywheels18black, ref bool alloywheels19black, ref bool alloywheels20black, ref bool alloywheels21black, ref bool steelwheels14, ref bool steelwheels15, ref bool steelwheels16, ref bool steelwheels17, ref bool twotonepaint, ref bool metallicpaint, ref bool pastelpaintfree, ref bool leddayrunninglights, ref bool halogenheadlights, ref bool bixenonheadlights, ref bool ecoledheadlights, ref bool fullledheadlights, ref bool adaptativefullledheadlights, ref bool highbeamheadlights, ref bool foglights, ref bool corneringfoglights, ref bool rainsensor, ref bool dusksensor, ref bool frontparkingsensors, ref bool rearparkingsensors, ref bool heatedfrontseats, ref bool heatedrearseats, ref bool seatswithmassagefunction, ref bool ventilatedfrontseats, ref bool electricseats, ref bool textileinterior, ref bool alcantarainterior, ref bool leatherinterior, ref bool electrochromaticrearviewmirror, ref bool electricheatedmirrors, ref bool electricallyfoldingmirrors, ref bool automaticairconditionner, ref bool manualairconditionner, ref bool cruisecontrol, ref bool adaptativecruisecontrol, ref bool trafficsignrecognition, ref bool laneassist, ref bool intelligentlaneassist, ref bool blindspotmonitor, ref bool inductioncharging, ref bool carplayandroidauto, ref bool carplayandroidautowireless, ref bool navigation, ref bool navigationpro, ref bool parkingassistant, ref bool coffeebreakalert, ref bool sparewheel, ref bool sportexhaust, ref bool panoramicroof, ref bool fixedglassroof, ref bool openingglassroof, ref bool radio, ref bool tintedrearwindows, ref bool premiumqualitysoundsystem, ref bool heatedfrontwindow, ref bool winterpackage, ref bool heatedsteeringwheel, ref bool electrictailgate, ref bool keylessstart, ref bool keylessstartandentry, ref bool armrest, ref bool digitalcockpit, ref bool camera, ref bool camera360, ref bool preparationforsparewheel, ref bool alarm, ref bool softdoorclosing,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementAddonMainOptionGet (arrangementid, ref alloywheels15, ref alloywheels16, ref alloywheels17, ref alloywheels18, ref alloywheels19, ref alloywheels20, ref alloywheels21, ref alloywheels15black, ref alloywheels16black, ref alloywheels17black, ref alloywheels18black, ref alloywheels19black, ref alloywheels20black, ref alloywheels21black, ref steelwheels14, ref steelwheels15, ref steelwheels16, ref steelwheels17, ref twotonepaint, ref metallicpaint, ref pastelpaintfree, ref leddayrunninglights, ref halogenheadlights, ref bixenonheadlights, ref ecoledheadlights, ref fullledheadlights, ref adaptativefullledheadlights, ref highbeamheadlights, ref foglights, ref corneringfoglights, ref rainsensor, ref dusksensor, ref frontparkingsensors, ref rearparkingsensors, ref heatedfrontseats, ref heatedrearseats, ref seatswithmassagefunction, ref ventilatedfrontseats, ref electricseats, ref textileinterior, ref alcantarainterior, ref leatherinterior, ref electrochromaticrearviewmirror, ref electricheatedmirrors, ref electricallyfoldingmirrors, ref automaticairconditionner, ref manualairconditionner, ref cruisecontrol, ref adaptativecruisecontrol, ref trafficsignrecognition, ref laneassist, ref intelligentlaneassist, ref blindspotmonitor, ref inductioncharging, ref carplayandroidauto, ref carplayandroidautowireless, ref navigation, ref navigationpro, ref parkingassistant, ref coffeebreakalert, ref sparewheel, ref sportexhaust, ref panoramicroof, ref fixedglassroof, ref openingglassroof, ref radio, ref tintedrearwindows, ref premiumqualitysoundsystem, ref heatedfrontwindow, ref winterpackage, ref heatedsteeringwheel, ref electrictailgate, ref keylessstart, ref keylessstartandentry, ref armrest, ref digitalcockpit, ref camera, ref camera360, ref preparationforsparewheel, ref alarm, ref softdoorclosing,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonMainOptionGet (int arrangementid, ref bool alloywheels15, ref bool alloywheels16, ref bool alloywheels17, ref bool alloywheels18, ref bool alloywheels19, ref bool alloywheels20, ref bool alloywheels21, ref bool alloywheels15black, ref bool alloywheels16black, ref bool alloywheels17black, ref bool alloywheels18black, ref bool alloywheels19black, ref bool alloywheels20black, ref bool alloywheels21black, ref bool steelwheels14, ref bool steelwheels15, ref bool steelwheels16, ref bool steelwheels17, ref bool twotonepaint, ref bool metallicpaint, ref bool pastelpaintfree, ref bool leddayrunninglights, ref bool halogenheadlights, ref bool bixenonheadlights, ref bool ecoledheadlights, ref bool fullledheadlights, ref bool adaptativefullledheadlights, ref bool highbeamheadlights, ref bool foglights, ref bool corneringfoglights, ref bool rainsensor, ref bool dusksensor, ref bool frontparkingsensors, ref bool rearparkingsensors, ref bool heatedfrontseats, ref bool heatedrearseats, ref bool seatswithmassagefunction, ref bool ventilatedfrontseats, ref bool electricseats, ref bool textileinterior, ref bool alcantarainterior, ref bool leatherinterior, ref bool electrochromaticrearviewmirror, ref bool electricheatedmirrors, ref bool electricallyfoldingmirrors, ref bool automaticairconditionner, ref bool manualairconditionner, ref bool cruisecontrol, ref bool adaptativecruisecontrol, ref bool trafficsignrecognition, ref bool laneassist, ref bool intelligentlaneassist, ref bool blindspotmonitor, ref bool inductioncharging, ref bool carplayandroidauto, ref bool carplayandroidautowireless, ref bool navigation, ref bool navigationpro, ref bool parkingassistant, ref bool coffeebreakalert, ref bool sparewheel, ref bool sportexhaust, ref bool panoramicroof, ref bool fixedglassroof, ref bool openingglassroof, ref bool radio, ref bool tintedrearwindows, ref bool premiumqualitysoundsystem, ref bool heatedfrontwindow, ref bool winterpackage, ref bool heatedsteeringwheel, ref bool electrictailgate, ref bool keylessstart, ref bool keylessstartandentry, ref bool armrest, ref bool digitalcockpit, ref bool camera, ref bool camera360, ref bool preparationforsparewheel, ref bool alarm, ref bool softdoorclosing,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementAddonMainOptionGet (arrangementid, ref alloywheels15, ref alloywheels16, ref alloywheels17, ref alloywheels18, ref alloywheels19, ref alloywheels20, ref alloywheels21, ref alloywheels15black, ref alloywheels16black, ref alloywheels17black, ref alloywheels18black, ref alloywheels19black, ref alloywheels20black, ref alloywheels21black, ref steelwheels14, ref steelwheels15, ref steelwheels16, ref steelwheels17, ref twotonepaint, ref metallicpaint, ref pastelpaintfree, ref leddayrunninglights, ref halogenheadlights, ref bixenonheadlights, ref ecoledheadlights, ref fullledheadlights, ref adaptativefullledheadlights, ref highbeamheadlights, ref foglights, ref corneringfoglights, ref rainsensor, ref dusksensor, ref frontparkingsensors, ref rearparkingsensors, ref heatedfrontseats, ref heatedrearseats, ref seatswithmassagefunction, ref ventilatedfrontseats, ref electricseats, ref textileinterior, ref alcantarainterior, ref leatherinterior, ref electrochromaticrearviewmirror, ref electricheatedmirrors, ref electricallyfoldingmirrors, ref automaticairconditionner, ref manualairconditionner, ref cruisecontrol, ref adaptativecruisecontrol, ref trafficsignrecognition, ref laneassist, ref intelligentlaneassist, ref blindspotmonitor, ref inductioncharging, ref carplayandroidauto, ref carplayandroidautowireless, ref navigation, ref navigationpro, ref parkingassistant, ref coffeebreakalert, ref sparewheel, ref sportexhaust, ref panoramicroof, ref fixedglassroof, ref openingglassroof, ref radio, ref tintedrearwindows, ref premiumqualitysoundsystem, ref heatedfrontwindow, ref winterpackage, ref heatedsteeringwheel, ref electrictailgate, ref keylessstart, ref keylessstartandentry, ref armrest, ref digitalcockpit, ref camera, ref camera360, ref preparationforsparewheel, ref alarm, ref softdoorclosing,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonMainOptionGet (int arrangementid, ref bool alloywheels15, ref bool alloywheels16, ref bool alloywheels17, ref bool alloywheels18, ref bool alloywheels19, ref bool alloywheels20, ref bool alloywheels21, ref bool alloywheels15black, ref bool alloywheels16black, ref bool alloywheels17black, ref bool alloywheels18black, ref bool alloywheels19black, ref bool alloywheels20black, ref bool alloywheels21black, ref bool steelwheels14, ref bool steelwheels15, ref bool steelwheels16, ref bool steelwheels17, ref bool twotonepaint, ref bool metallicpaint, ref bool pastelpaintfree, ref bool leddayrunninglights, ref bool halogenheadlights, ref bool bixenonheadlights, ref bool ecoledheadlights, ref bool fullledheadlights, ref bool adaptativefullledheadlights, ref bool highbeamheadlights, ref bool foglights, ref bool corneringfoglights, ref bool rainsensor, ref bool dusksensor, ref bool frontparkingsensors, ref bool rearparkingsensors, ref bool heatedfrontseats, ref bool heatedrearseats, ref bool seatswithmassagefunction, ref bool ventilatedfrontseats, ref bool electricseats, ref bool textileinterior, ref bool alcantarainterior, ref bool leatherinterior, ref bool electrochromaticrearviewmirror, ref bool electricheatedmirrors, ref bool electricallyfoldingmirrors, ref bool automaticairconditionner, ref bool manualairconditionner, ref bool cruisecontrol, ref bool adaptativecruisecontrol, ref bool trafficsignrecognition, ref bool laneassist, ref bool intelligentlaneassist, ref bool blindspotmonitor, ref bool inductioncharging, ref bool carplayandroidauto, ref bool carplayandroidautowireless, ref bool navigation, ref bool navigationpro, ref bool parkingassistant, ref bool coffeebreakalert, ref bool sparewheel, ref bool sportexhaust, ref bool panoramicroof, ref bool fixedglassroof, ref bool openingglassroof, ref bool radio, ref bool tintedrearwindows, ref bool premiumqualitysoundsystem, ref bool heatedfrontwindow, ref bool winterpackage, ref bool heatedsteeringwheel, ref bool electrictailgate, ref bool keylessstart, ref bool keylessstartandentry, ref bool armrest, ref bool digitalcockpit, ref bool camera, ref bool camera360, ref bool preparationforsparewheel, ref bool alarm, ref bool softdoorclosing,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_ADDON_MAIN_OPTION__GET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2b(sc, "@alloywheels15", alloywheels15);
  q.q2b(sc, "@alloywheels16", alloywheels16);
  q.q2b(sc, "@alloywheels17", alloywheels17);
  q.q2b(sc, "@alloywheels18", alloywheels18);
  q.q2b(sc, "@alloywheels19", alloywheels19);
  q.q2b(sc, "@alloywheels20", alloywheels20);
  q.q2b(sc, "@alloywheels21", alloywheels21);
  q.q2b(sc, "@alloywheels15black", alloywheels15black);
  q.q2b(sc, "@alloywheels16black", alloywheels16black);
  q.q2b(sc, "@alloywheels17black", alloywheels17black);
  q.q2b(sc, "@alloywheels18black", alloywheels18black);
  q.q2b(sc, "@alloywheels19black", alloywheels19black);
  q.q2b(sc, "@alloywheels20black", alloywheels20black);
  q.q2b(sc, "@alloywheels21black", alloywheels21black);
  q.q2b(sc, "@steelwheels14", steelwheels14);
  q.q2b(sc, "@steelwheels15", steelwheels15);
  q.q2b(sc, "@steelwheels16", steelwheels16);
  q.q2b(sc, "@steelwheels17", steelwheels17);
  q.q2b(sc, "@twotonepaint", twotonepaint);
  q.q2b(sc, "@metallicpaint", metallicpaint);
  q.q2b(sc, "@pastelpaintfree", pastelpaintfree);
  q.q2b(sc, "@leddayrunninglights", leddayrunninglights);
  q.q2b(sc, "@halogenheadlights", halogenheadlights);
  q.q2b(sc, "@bixenonheadlights", bixenonheadlights);
  q.q2b(sc, "@ecoledheadlights", ecoledheadlights);
  q.q2b(sc, "@fullledheadlights", fullledheadlights);
  q.q2b(sc, "@adaptativefullledheadlights", adaptativefullledheadlights);
  q.q2b(sc, "@highbeamheadlights", highbeamheadlights);
  q.q2b(sc, "@foglights", foglights);
  q.q2b(sc, "@corneringfoglights", corneringfoglights);
  q.q2b(sc, "@rainsensor", rainsensor);
  q.q2b(sc, "@dusksensor", dusksensor);
  q.q2b(sc, "@frontparkingsensors", frontparkingsensors);
  q.q2b(sc, "@rearparkingsensors", rearparkingsensors);
  q.q2b(sc, "@heatedfrontseats", heatedfrontseats);
  q.q2b(sc, "@heatedrearseats", heatedrearseats);
  q.q2b(sc, "@seatswithmassagefunction", seatswithmassagefunction);
  q.q2b(sc, "@ventilatedfrontseats", ventilatedfrontseats);
  q.q2b(sc, "@electricseats", electricseats);
  q.q2b(sc, "@textileinterior", textileinterior);
  q.q2b(sc, "@alcantarainterior", alcantarainterior);
  q.q2b(sc, "@leatherinterior", leatherinterior);
  q.q2b(sc, "@electrochromaticrearviewmirror", electrochromaticrearviewmirror);
  q.q2b(sc, "@electricheatedmirrors", electricheatedmirrors);
  q.q2b(sc, "@electricallyfoldingmirrors", electricallyfoldingmirrors);
  q.q2b(sc, "@automaticairconditionner", automaticairconditionner);
  q.q2b(sc, "@manualairconditionner", manualairconditionner);
  q.q2b(sc, "@cruisecontrol", cruisecontrol);
  q.q2b(sc, "@adaptativecruisecontrol", adaptativecruisecontrol);
  q.q2b(sc, "@trafficsignrecognition", trafficsignrecognition);
  q.q2b(sc, "@laneassist", laneassist);
  q.q2b(sc, "@intelligentlaneassist", intelligentlaneassist);
  q.q2b(sc, "@blindspotmonitor", blindspotmonitor);
  q.q2b(sc, "@inductioncharging", inductioncharging);
  q.q2b(sc, "@carplayandroidauto", carplayandroidauto);
  q.q2b(sc, "@carplayandroidautowireless", carplayandroidautowireless);
  q.q2b(sc, "@navigation", navigation);
  q.q2b(sc, "@navigationpro", navigationpro);
  q.q2b(sc, "@parkingassistant", parkingassistant);
  q.q2b(sc, "@coffeebreakalert", coffeebreakalert);
  q.q2b(sc, "@sparewheel", sparewheel);
  q.q2b(sc, "@sportexhaust", sportexhaust);
  q.q2b(sc, "@panoramicroof", panoramicroof);
  q.q2b(sc, "@fixedglassroof", fixedglassroof);
  q.q2b(sc, "@openingglassroof", openingglassroof);
  q.q2b(sc, "@radio", radio);
  q.q2b(sc, "@tintedrearwindows", tintedrearwindows);
  q.q2b(sc, "@premiumqualitysoundsystem", premiumqualitysoundsystem);
  q.q2b(sc, "@heatedfrontwindow", heatedfrontwindow);
  q.q2b(sc, "@winterpackage", winterpackage);
  q.q2b(sc, "@heatedsteeringwheel", heatedsteeringwheel);
  q.q2b(sc, "@electrictailgate", electrictailgate);
  q.q2b(sc, "@keylessstart", keylessstart);
  q.q2b(sc, "@keylessstartandentry", keylessstartandentry);
  q.q2b(sc, "@armrest", armrest);
  q.q2b(sc, "@digitalcockpit", digitalcockpit);
  q.q2b(sc, "@camera", camera);
  q.q2b(sc, "@camera360", camera360);
  q.q2b(sc, "@preparationforsparewheel", preparationforsparewheel);
  q.q2b(sc, "@alarm", alarm);
  q.q2b(sc, "@softdoorclosing", softdoorclosing);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   alloywheels15 = q.gb(sc,"@alloywheels15");
   alloywheels16 = q.gb(sc,"@alloywheels16");
   alloywheels17 = q.gb(sc,"@alloywheels17");
   alloywheels18 = q.gb(sc,"@alloywheels18");
   alloywheels19 = q.gb(sc,"@alloywheels19");
   alloywheels20 = q.gb(sc,"@alloywheels20");
   alloywheels21 = q.gb(sc,"@alloywheels21");
   alloywheels15black = q.gb(sc,"@alloywheels15black");
   alloywheels16black = q.gb(sc,"@alloywheels16black");
   alloywheels17black = q.gb(sc,"@alloywheels17black");
   alloywheels18black = q.gb(sc,"@alloywheels18black");
   alloywheels19black = q.gb(sc,"@alloywheels19black");
   alloywheels20black = q.gb(sc,"@alloywheels20black");
   alloywheels21black = q.gb(sc,"@alloywheels21black");
   steelwheels14 = q.gb(sc,"@steelwheels14");
   steelwheels15 = q.gb(sc,"@steelwheels15");
   steelwheels16 = q.gb(sc,"@steelwheels16");
   steelwheels17 = q.gb(sc,"@steelwheels17");
   twotonepaint = q.gb(sc,"@twotonepaint");
   metallicpaint = q.gb(sc,"@metallicpaint");
   pastelpaintfree = q.gb(sc,"@pastelpaintfree");
   leddayrunninglights = q.gb(sc,"@leddayrunninglights");
   halogenheadlights = q.gb(sc,"@halogenheadlights");
   bixenonheadlights = q.gb(sc,"@bixenonheadlights");
   ecoledheadlights = q.gb(sc,"@ecoledheadlights");
   fullledheadlights = q.gb(sc,"@fullledheadlights");
   adaptativefullledheadlights = q.gb(sc,"@adaptativefullledheadlights");
   highbeamheadlights = q.gb(sc,"@highbeamheadlights");
   foglights = q.gb(sc,"@foglights");
   corneringfoglights = q.gb(sc,"@corneringfoglights");
   rainsensor = q.gb(sc,"@rainsensor");
   dusksensor = q.gb(sc,"@dusksensor");
   frontparkingsensors = q.gb(sc,"@frontparkingsensors");
   rearparkingsensors = q.gb(sc,"@rearparkingsensors");
   heatedfrontseats = q.gb(sc,"@heatedfrontseats");
   heatedrearseats = q.gb(sc,"@heatedrearseats");
   seatswithmassagefunction = q.gb(sc,"@seatswithmassagefunction");
   ventilatedfrontseats = q.gb(sc,"@ventilatedfrontseats");
   electricseats = q.gb(sc,"@electricseats");
   textileinterior = q.gb(sc,"@textileinterior");
   alcantarainterior = q.gb(sc,"@alcantarainterior");
   leatherinterior = q.gb(sc,"@leatherinterior");
   electrochromaticrearviewmirror = q.gb(sc,"@electrochromaticrearviewmirror");
   electricheatedmirrors = q.gb(sc,"@electricheatedmirrors");
   electricallyfoldingmirrors = q.gb(sc,"@electricallyfoldingmirrors");
   automaticairconditionner = q.gb(sc,"@automaticairconditionner");
   manualairconditionner = q.gb(sc,"@manualairconditionner");
   cruisecontrol = q.gb(sc,"@cruisecontrol");
   adaptativecruisecontrol = q.gb(sc,"@adaptativecruisecontrol");
   trafficsignrecognition = q.gb(sc,"@trafficsignrecognition");
   laneassist = q.gb(sc,"@laneassist");
   intelligentlaneassist = q.gb(sc,"@intelligentlaneassist");
   blindspotmonitor = q.gb(sc,"@blindspotmonitor");
   inductioncharging = q.gb(sc,"@inductioncharging");
   carplayandroidauto = q.gb(sc,"@carplayandroidauto");
   carplayandroidautowireless = q.gb(sc,"@carplayandroidautowireless");
   navigation = q.gb(sc,"@navigation");
   navigationpro = q.gb(sc,"@navigationpro");
   parkingassistant = q.gb(sc,"@parkingassistant");
   coffeebreakalert = q.gb(sc,"@coffeebreakalert");
   sparewheel = q.gb(sc,"@sparewheel");
   sportexhaust = q.gb(sc,"@sportexhaust");
   panoramicroof = q.gb(sc,"@panoramicroof");
   fixedglassroof = q.gb(sc,"@fixedglassroof");
   openingglassroof = q.gb(sc,"@openingglassroof");
   radio = q.gb(sc,"@radio");
   tintedrearwindows = q.gb(sc,"@tintedrearwindows");
   premiumqualitysoundsystem = q.gb(sc,"@premiumqualitysoundsystem");
   heatedfrontwindow = q.gb(sc,"@heatedfrontwindow");
   winterpackage = q.gb(sc,"@winterpackage");
   heatedsteeringwheel = q.gb(sc,"@heatedsteeringwheel");
   electrictailgate = q.gb(sc,"@electrictailgate");
   keylessstart = q.gb(sc,"@keylessstart");
   keylessstartandentry = q.gb(sc,"@keylessstartandentry");
   armrest = q.gb(sc,"@armrest");
   digitalcockpit = q.gb(sc,"@digitalcockpit");
   camera = q.gb(sc,"@camera");
   camera360 = q.gb(sc,"@camera360");
   preparationforsparewheel = q.gb(sc,"@preparationforsparewheel");
   alarm = q.gb(sc,"@alarm");
   softdoorclosing = q.gb(sc,"@softdoorclosing");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementAddonMainOptionUpdate (int arrangementid, bool alloywheels15, bool alloywheels16, bool alloywheels17, bool alloywheels18, bool alloywheels19, bool alloywheels20, bool alloywheels21, bool alloywheels15black, bool alloywheels16black, bool alloywheels17black, bool alloywheels18black, bool alloywheels19black, bool alloywheels20black, bool alloywheels21black, bool steelwheels14, bool steelwheels15, bool steelwheels16, bool steelwheels17, bool twotonepaint, bool metallicpaint, bool pastelpaintfree, bool leddayrunninglights, bool halogenheadlights, bool bixenonheadlights, bool ecoledheadlights, bool fullledheadlights, bool adaptativefullledheadlights, bool highbeamheadlights, bool foglights, bool corneringfoglights, bool rainsensor, bool dusksensor, bool frontparkingsensors, bool rearparkingsensors, bool heatedfrontseats, bool heatedrearseats, bool seatswithmassagefunction, bool ventilatedfrontseats, bool electricseats, bool textileinterior, bool alcantarainterior, bool leatherinterior, bool electrochromaticrearviewmirror, bool electricheatedmirrors, bool electricallyfoldingmirrors, bool automaticairconditionner, bool manualairconditionner, bool cruisecontrol, bool adaptativecruisecontrol, bool trafficsignrecognition, bool laneassist, bool intelligentlaneassist, bool blindspotmonitor, bool inductioncharging, bool carplayandroidauto, bool carplayandroidautowireless, bool navigation, bool navigationpro, bool parkingassistant, bool coffeebreakalert, bool sparewheel, bool sportexhaust, bool panoramicroof, bool fixedglassroof, bool openingglassroof, bool radio, bool tintedrearwindows, bool premiumqualitysoundsystem, bool heatedfrontwindow, bool winterpackage, bool heatedsteeringwheel, bool electrictailgate, bool keylessstart, bool keylessstartandentry, bool armrest, bool digitalcockpit, bool camera, bool camera360, bool preparationforsparewheel, bool alarm, bool softdoorclosing) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementAddonMainOptionUpdate (arrangementid, alloywheels15, alloywheels16, alloywheels17, alloywheels18, alloywheels19, alloywheels20, alloywheels21, alloywheels15black, alloywheels16black, alloywheels17black, alloywheels18black, alloywheels19black, alloywheels20black, alloywheels21black, steelwheels14, steelwheels15, steelwheels16, steelwheels17, twotonepaint, metallicpaint, pastelpaintfree, leddayrunninglights, halogenheadlights, bixenonheadlights, ecoledheadlights, fullledheadlights, adaptativefullledheadlights, highbeamheadlights, foglights, corneringfoglights, rainsensor, dusksensor, frontparkingsensors, rearparkingsensors, heatedfrontseats, heatedrearseats, seatswithmassagefunction, ventilatedfrontseats, electricseats, textileinterior, alcantarainterior, leatherinterior, electrochromaticrearviewmirror, electricheatedmirrors, electricallyfoldingmirrors, automaticairconditionner, manualairconditionner, cruisecontrol, adaptativecruisecontrol, trafficsignrecognition, laneassist, intelligentlaneassist, blindspotmonitor, inductioncharging, carplayandroidauto, carplayandroidautowireless, navigation, navigationpro, parkingassistant, coffeebreakalert, sparewheel, sportexhaust, panoramicroof, fixedglassroof, openingglassroof, radio, tintedrearwindows, premiumqualitysoundsystem, heatedfrontwindow, winterpackage, heatedsteeringwheel, electrictailgate, keylessstart, keylessstartandentry, armrest, digitalcockpit, camera, camera360, preparationforsparewheel, alarm, softdoorclosing,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonMainOptionUpdate (int arrangementid, bool alloywheels15, bool alloywheels16, bool alloywheels17, bool alloywheels18, bool alloywheels19, bool alloywheels20, bool alloywheels21, bool alloywheels15black, bool alloywheels16black, bool alloywheels17black, bool alloywheels18black, bool alloywheels19black, bool alloywheels20black, bool alloywheels21black, bool steelwheels14, bool steelwheels15, bool steelwheels16, bool steelwheels17, bool twotonepaint, bool metallicpaint, bool pastelpaintfree, bool leddayrunninglights, bool halogenheadlights, bool bixenonheadlights, bool ecoledheadlights, bool fullledheadlights, bool adaptativefullledheadlights, bool highbeamheadlights, bool foglights, bool corneringfoglights, bool rainsensor, bool dusksensor, bool frontparkingsensors, bool rearparkingsensors, bool heatedfrontseats, bool heatedrearseats, bool seatswithmassagefunction, bool ventilatedfrontseats, bool electricseats, bool textileinterior, bool alcantarainterior, bool leatherinterior, bool electrochromaticrearviewmirror, bool electricheatedmirrors, bool electricallyfoldingmirrors, bool automaticairconditionner, bool manualairconditionner, bool cruisecontrol, bool adaptativecruisecontrol, bool trafficsignrecognition, bool laneassist, bool intelligentlaneassist, bool blindspotmonitor, bool inductioncharging, bool carplayandroidauto, bool carplayandroidautowireless, bool navigation, bool navigationpro, bool parkingassistant, bool coffeebreakalert, bool sparewheel, bool sportexhaust, bool panoramicroof, bool fixedglassroof, bool openingglassroof, bool radio, bool tintedrearwindows, bool premiumqualitysoundsystem, bool heatedfrontwindow, bool winterpackage, bool heatedsteeringwheel, bool electrictailgate, bool keylessstart, bool keylessstartandentry, bool armrest, bool digitalcockpit, bool camera, bool camera360, bool preparationforsparewheel, bool alarm, bool softdoorclosing,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementAddonMainOptionUpdate (arrangementid, alloywheels15, alloywheels16, alloywheels17, alloywheels18, alloywheels19, alloywheels20, alloywheels21, alloywheels15black, alloywheels16black, alloywheels17black, alloywheels18black, alloywheels19black, alloywheels20black, alloywheels21black, steelwheels14, steelwheels15, steelwheels16, steelwheels17, twotonepaint, metallicpaint, pastelpaintfree, leddayrunninglights, halogenheadlights, bixenonheadlights, ecoledheadlights, fullledheadlights, adaptativefullledheadlights, highbeamheadlights, foglights, corneringfoglights, rainsensor, dusksensor, frontparkingsensors, rearparkingsensors, heatedfrontseats, heatedrearseats, seatswithmassagefunction, ventilatedfrontseats, electricseats, textileinterior, alcantarainterior, leatherinterior, electrochromaticrearviewmirror, electricheatedmirrors, electricallyfoldingmirrors, automaticairconditionner, manualairconditionner, cruisecontrol, adaptativecruisecontrol, trafficsignrecognition, laneassist, intelligentlaneassist, blindspotmonitor, inductioncharging, carplayandroidauto, carplayandroidautowireless, navigation, navigationpro, parkingassistant, coffeebreakalert, sparewheel, sportexhaust, panoramicroof, fixedglassroof, openingglassroof, radio, tintedrearwindows, premiumqualitysoundsystem, heatedfrontwindow, winterpackage, heatedsteeringwheel, electrictailgate, keylessstart, keylessstartandentry, armrest, digitalcockpit, camera, camera360, preparationforsparewheel, alarm, softdoorclosing,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonMainOptionUpdate (int arrangementid, bool alloywheels15, bool alloywheels16, bool alloywheels17, bool alloywheels18, bool alloywheels19, bool alloywheels20, bool alloywheels21, bool alloywheels15black, bool alloywheels16black, bool alloywheels17black, bool alloywheels18black, bool alloywheels19black, bool alloywheels20black, bool alloywheels21black, bool steelwheels14, bool steelwheels15, bool steelwheels16, bool steelwheels17, bool twotonepaint, bool metallicpaint, bool pastelpaintfree, bool leddayrunninglights, bool halogenheadlights, bool bixenonheadlights, bool ecoledheadlights, bool fullledheadlights, bool adaptativefullledheadlights, bool highbeamheadlights, bool foglights, bool corneringfoglights, bool rainsensor, bool dusksensor, bool frontparkingsensors, bool rearparkingsensors, bool heatedfrontseats, bool heatedrearseats, bool seatswithmassagefunction, bool ventilatedfrontseats, bool electricseats, bool textileinterior, bool alcantarainterior, bool leatherinterior, bool electrochromaticrearviewmirror, bool electricheatedmirrors, bool electricallyfoldingmirrors, bool automaticairconditionner, bool manualairconditionner, bool cruisecontrol, bool adaptativecruisecontrol, bool trafficsignrecognition, bool laneassist, bool intelligentlaneassist, bool blindspotmonitor, bool inductioncharging, bool carplayandroidauto, bool carplayandroidautowireless, bool navigation, bool navigationpro, bool parkingassistant, bool coffeebreakalert, bool sparewheel, bool sportexhaust, bool panoramicroof, bool fixedglassroof, bool openingglassroof, bool radio, bool tintedrearwindows, bool premiumqualitysoundsystem, bool heatedfrontwindow, bool winterpackage, bool heatedsteeringwheel, bool electrictailgate, bool keylessstart, bool keylessstartandentry, bool armrest, bool digitalcockpit, bool camera, bool camera360, bool preparationforsparewheel, bool alarm, bool softdoorclosing,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementAddonMainOptionUpdate (arrangementid, alloywheels15, alloywheels16, alloywheels17, alloywheels18, alloywheels19, alloywheels20, alloywheels21, alloywheels15black, alloywheels16black, alloywheels17black, alloywheels18black, alloywheels19black, alloywheels20black, alloywheels21black, steelwheels14, steelwheels15, steelwheels16, steelwheels17, twotonepaint, metallicpaint, pastelpaintfree, leddayrunninglights, halogenheadlights, bixenonheadlights, ecoledheadlights, fullledheadlights, adaptativefullledheadlights, highbeamheadlights, foglights, corneringfoglights, rainsensor, dusksensor, frontparkingsensors, rearparkingsensors, heatedfrontseats, heatedrearseats, seatswithmassagefunction, ventilatedfrontseats, electricseats, textileinterior, alcantarainterior, leatherinterior, electrochromaticrearviewmirror, electricheatedmirrors, electricallyfoldingmirrors, automaticairconditionner, manualairconditionner, cruisecontrol, adaptativecruisecontrol, trafficsignrecognition, laneassist, intelligentlaneassist, blindspotmonitor, inductioncharging, carplayandroidauto, carplayandroidautowireless, navigation, navigationpro, parkingassistant, coffeebreakalert, sparewheel, sportexhaust, panoramicroof, fixedglassroof, openingglassroof, radio, tintedrearwindows, premiumqualitysoundsystem, heatedfrontwindow, winterpackage, heatedsteeringwheel, electrictailgate, keylessstart, keylessstartandentry, armrest, digitalcockpit, camera, camera360, preparationforsparewheel, alarm, softdoorclosing,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonMainOptionUpdate (int arrangementid, bool alloywheels15, bool alloywheels16, bool alloywheels17, bool alloywheels18, bool alloywheels19, bool alloywheels20, bool alloywheels21, bool alloywheels15black, bool alloywheels16black, bool alloywheels17black, bool alloywheels18black, bool alloywheels19black, bool alloywheels20black, bool alloywheels21black, bool steelwheels14, bool steelwheels15, bool steelwheels16, bool steelwheels17, bool twotonepaint, bool metallicpaint, bool pastelpaintfree, bool leddayrunninglights, bool halogenheadlights, bool bixenonheadlights, bool ecoledheadlights, bool fullledheadlights, bool adaptativefullledheadlights, bool highbeamheadlights, bool foglights, bool corneringfoglights, bool rainsensor, bool dusksensor, bool frontparkingsensors, bool rearparkingsensors, bool heatedfrontseats, bool heatedrearseats, bool seatswithmassagefunction, bool ventilatedfrontseats, bool electricseats, bool textileinterior, bool alcantarainterior, bool leatherinterior, bool electrochromaticrearviewmirror, bool electricheatedmirrors, bool electricallyfoldingmirrors, bool automaticairconditionner, bool manualairconditionner, bool cruisecontrol, bool adaptativecruisecontrol, bool trafficsignrecognition, bool laneassist, bool intelligentlaneassist, bool blindspotmonitor, bool inductioncharging, bool carplayandroidauto, bool carplayandroidautowireless, bool navigation, bool navigationpro, bool parkingassistant, bool coffeebreakalert, bool sparewheel, bool sportexhaust, bool panoramicroof, bool fixedglassroof, bool openingglassroof, bool radio, bool tintedrearwindows, bool premiumqualitysoundsystem, bool heatedfrontwindow, bool winterpackage, bool heatedsteeringwheel, bool electrictailgate, bool keylessstart, bool keylessstartandentry, bool armrest, bool digitalcockpit, bool camera, bool camera360, bool preparationforsparewheel, bool alarm, bool softdoorclosing,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_ADDON_MAIN_OPTION__UPDATE"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2b(sc, "@alloywheels15", alloywheels15);
  q.q2b(sc, "@alloywheels16", alloywheels16);
  q.q2b(sc, "@alloywheels17", alloywheels17);
  q.q2b(sc, "@alloywheels18", alloywheels18);
  q.q2b(sc, "@alloywheels19", alloywheels19);
  q.q2b(sc, "@alloywheels20", alloywheels20);
  q.q2b(sc, "@alloywheels21", alloywheels21);
  q.q2b(sc, "@alloywheels15black", alloywheels15black);
  q.q2b(sc, "@alloywheels16black", alloywheels16black);
  q.q2b(sc, "@alloywheels17black", alloywheels17black);
  q.q2b(sc, "@alloywheels18black", alloywheels18black);
  q.q2b(sc, "@alloywheels19black", alloywheels19black);
  q.q2b(sc, "@alloywheels20black", alloywheels20black);
  q.q2b(sc, "@alloywheels21black", alloywheels21black);
  q.q2b(sc, "@steelwheels14", steelwheels14);
  q.q2b(sc, "@steelwheels15", steelwheels15);
  q.q2b(sc, "@steelwheels16", steelwheels16);
  q.q2b(sc, "@steelwheels17", steelwheels17);
  q.q2b(sc, "@twotonepaint", twotonepaint);
  q.q2b(sc, "@metallicpaint", metallicpaint);
  q.q2b(sc, "@pastelpaintfree", pastelpaintfree);
  q.q2b(sc, "@leddayrunninglights", leddayrunninglights);
  q.q2b(sc, "@halogenheadlights", halogenheadlights);
  q.q2b(sc, "@bixenonheadlights", bixenonheadlights);
  q.q2b(sc, "@ecoledheadlights", ecoledheadlights);
  q.q2b(sc, "@fullledheadlights", fullledheadlights);
  q.q2b(sc, "@adaptativefullledheadlights", adaptativefullledheadlights);
  q.q2b(sc, "@highbeamheadlights", highbeamheadlights);
  q.q2b(sc, "@foglights", foglights);
  q.q2b(sc, "@corneringfoglights", corneringfoglights);
  q.q2b(sc, "@rainsensor", rainsensor);
  q.q2b(sc, "@dusksensor", dusksensor);
  q.q2b(sc, "@frontparkingsensors", frontparkingsensors);
  q.q2b(sc, "@rearparkingsensors", rearparkingsensors);
  q.q2b(sc, "@heatedfrontseats", heatedfrontseats);
  q.q2b(sc, "@heatedrearseats", heatedrearseats);
  q.q2b(sc, "@seatswithmassagefunction", seatswithmassagefunction);
  q.q2b(sc, "@ventilatedfrontseats", ventilatedfrontseats);
  q.q2b(sc, "@electricseats", electricseats);
  q.q2b(sc, "@textileinterior", textileinterior);
  q.q2b(sc, "@alcantarainterior", alcantarainterior);
  q.q2b(sc, "@leatherinterior", leatherinterior);
  q.q2b(sc, "@electrochromaticrearviewmirror", electrochromaticrearviewmirror);
  q.q2b(sc, "@electricheatedmirrors", electricheatedmirrors);
  q.q2b(sc, "@electricallyfoldingmirrors", electricallyfoldingmirrors);
  q.q2b(sc, "@automaticairconditionner", automaticairconditionner);
  q.q2b(sc, "@manualairconditionner", manualairconditionner);
  q.q2b(sc, "@cruisecontrol", cruisecontrol);
  q.q2b(sc, "@adaptativecruisecontrol", adaptativecruisecontrol);
  q.q2b(sc, "@trafficsignrecognition", trafficsignrecognition);
  q.q2b(sc, "@laneassist", laneassist);
  q.q2b(sc, "@intelligentlaneassist", intelligentlaneassist);
  q.q2b(sc, "@blindspotmonitor", blindspotmonitor);
  q.q2b(sc, "@inductioncharging", inductioncharging);
  q.q2b(sc, "@carplayandroidauto", carplayandroidauto);
  q.q2b(sc, "@carplayandroidautowireless", carplayandroidautowireless);
  q.q2b(sc, "@navigation", navigation);
  q.q2b(sc, "@navigationpro", navigationpro);
  q.q2b(sc, "@parkingassistant", parkingassistant);
  q.q2b(sc, "@coffeebreakalert", coffeebreakalert);
  q.q2b(sc, "@sparewheel", sparewheel);
  q.q2b(sc, "@sportexhaust", sportexhaust);
  q.q2b(sc, "@panoramicroof", panoramicroof);
  q.q2b(sc, "@fixedglassroof", fixedglassroof);
  q.q2b(sc, "@openingglassroof", openingglassroof);
  q.q2b(sc, "@radio", radio);
  q.q2b(sc, "@tintedrearwindows", tintedrearwindows);
  q.q2b(sc, "@premiumqualitysoundsystem", premiumqualitysoundsystem);
  q.q2b(sc, "@heatedfrontwindow", heatedfrontwindow);
  q.q2b(sc, "@winterpackage", winterpackage);
  q.q2b(sc, "@heatedsteeringwheel", heatedsteeringwheel);
  q.q2b(sc, "@electrictailgate", electrictailgate);
  q.q2b(sc, "@keylessstart", keylessstart);
  q.q2b(sc, "@keylessstartandentry", keylessstartandentry);
  q.q2b(sc, "@armrest", armrest);
  q.q2b(sc, "@digitalcockpit", digitalcockpit);
  q.q2b(sc, "@camera", camera);
  q.q2b(sc, "@camera360", camera360);
  q.q2b(sc, "@preparationforsparewheel", preparationforsparewheel);
  q.q2b(sc, "@alarm", alarm);
  q.q2b(sc, "@softdoorclosing", softdoorclosing);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementAddonsVw (int arrangementid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementAddonsVw (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonsVw (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementAddonsVw (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonsVw (int arrangementid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementAddonsVw (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementAddonsVw (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_ADDONS_vw"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementContractsVw (int arrangementid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementContractsVw (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementContractsVw (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementContractsVw (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementContractsVw (int arrangementid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementContractsVw (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementContractsVw (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_CONTRACTS_vw"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementEshopGet (int arrangementid, ref string webtitle, ref string brand, ref decimal price, ref int quantity, ref string modeltype, ref int mileage, ref int co2, ref int doors, ref int seats, ref string color, ref string features, ref int eshopconditionid, ref int eshoplabelid, ref int eshoptransmissionid, ref int eshopvehiclebodytypeid, ref int eshopfuelid, ref bool ispublishingonweb, ref string url) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementEshopGet (arrangementid, ref webtitle, ref brand, ref price, ref quantity, ref modeltype, ref mileage, ref co2, ref doors, ref seats, ref color, ref features, ref eshopconditionid, ref eshoplabelid, ref eshoptransmissionid, ref eshopvehiclebodytypeid, ref eshopfuelid, ref ispublishingonweb, ref url,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementEshopGet (int arrangementid, ref string webtitle, ref string brand, ref decimal price, ref int quantity, ref string modeltype, ref int mileage, ref int co2, ref int doors, ref int seats, ref string color, ref string features, ref int eshopconditionid, ref int eshoplabelid, ref int eshoptransmissionid, ref int eshopvehiclebodytypeid, ref int eshopfuelid, ref bool ispublishingonweb, ref string url,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementEshopGet (arrangementid, ref webtitle, ref brand, ref price, ref quantity, ref modeltype, ref mileage, ref co2, ref doors, ref seats, ref color, ref features, ref eshopconditionid, ref eshoplabelid, ref eshoptransmissionid, ref eshopvehiclebodytypeid, ref eshopfuelid, ref ispublishingonweb, ref url,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementEshopGet (int arrangementid, ref string webtitle, ref string brand, ref decimal price, ref int quantity, ref string modeltype, ref int mileage, ref int co2, ref int doors, ref int seats, ref string color, ref string features, ref int eshopconditionid, ref int eshoplabelid, ref int eshoptransmissionid, ref int eshopvehiclebodytypeid, ref int eshopfuelid, ref bool ispublishingonweb, ref string url,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementEshopGet (arrangementid, ref webtitle, ref brand, ref price, ref quantity, ref modeltype, ref mileage, ref co2, ref doors, ref seats, ref color, ref features, ref eshopconditionid, ref eshoplabelid, ref eshoptransmissionid, ref eshopvehiclebodytypeid, ref eshopfuelid, ref ispublishingonweb, ref url,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementEshopGet (int arrangementid, ref string webtitle, ref string brand, ref decimal price, ref int quantity, ref string modeltype, ref int mileage, ref int co2, ref int doors, ref int seats, ref string color, ref string features, ref int eshopconditionid, ref int eshoplabelid, ref int eshoptransmissionid, ref int eshopvehiclebodytypeid, ref int eshopfuelid, ref bool ispublishingonweb, ref string url,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_ESHOP__GET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@webtitle", webtitle);
  q.q2s(sc, "@brand", brand);
  q.q2e(sc, "@price", price);
  q.q2i(sc, "@quantity", quantity);
  q.q2s(sc, "@modeltype", modeltype);
  q.q2i(sc, "@mileage", mileage);
  q.q2i(sc, "@co2", co2);
  q.q2i(sc, "@doors", doors);
  q.q2i(sc, "@seats", seats);
  q.q2s(sc, "@color", color);
  q.q2s(sc, "@features", features);
  q.q2i(sc, "@eshopconditionid", eshopconditionid);
  q.q2i(sc, "@eshoplabelid", eshoplabelid);
  q.q2i(sc, "@eshoptransmissionid", eshoptransmissionid);
  q.q2i(sc, "@eshopvehiclebodytypeid", eshopvehiclebodytypeid);
  q.q2i(sc, "@eshopfuelid", eshopfuelid);
  q.q2b(sc, "@ispublishingonweb", ispublishingonweb);
  q.q2s(sc, "@url", url);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   webtitle = q.gs(sc,"@webtitle");
   brand = q.gs(sc,"@brand");
   price = q.ge(sc,"@price");
   quantity = q.gi(sc,"@quantity");
   modeltype = q.gs(sc,"@modeltype");
   mileage = q.gi(sc,"@mileage");
   co2 = q.gi(sc,"@co2");
   doors = q.gi(sc,"@doors");
   seats = q.gi(sc,"@seats");
   color = q.gs(sc,"@color");
   features = q.gs(sc,"@features");
   eshopconditionid = q.gi(sc,"@eshopconditionid");
   eshoplabelid = q.gi(sc,"@eshoplabelid");
   eshoptransmissionid = q.gi(sc,"@eshoptransmissionid");
   eshopvehiclebodytypeid = q.gi(sc,"@eshopvehiclebodytypeid");
   eshopfuelid = q.gi(sc,"@eshopfuelid");
   ispublishingonweb = q.gb(sc,"@ispublishingonweb");
   url = q.gs(sc,"@url");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementEshopPublishSet (int arrangementid, bool publish) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementEshopPublishSet (arrangementid, publish,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementEshopPublishSet (int arrangementid, bool publish,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementEshopPublishSet (arrangementid, publish,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementEshopPublishSet (int arrangementid, bool publish,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementEshopPublishSet (arrangementid, publish,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementEshopPublishSet (int arrangementid, bool publish,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_ESHOP__PUBLISH_SET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2b(sc, "@publish", publish);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementEshopSet (int arrangementid, string webtitle, decimal price, int quantity, string modeltype, int mileage, int co2, int doors, int seats, string color, string features, int eshopconditionid, int eshoplabelid, int eshoptransmissionid, int eshopvehiclebodytypeid, int eshopfuelid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementEshopSet (arrangementid, webtitle, price, quantity, modeltype, mileage, co2, doors, seats, color, features, eshopconditionid, eshoplabelid, eshoptransmissionid, eshopvehiclebodytypeid, eshopfuelid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementEshopSet (int arrangementid, string webtitle, decimal price, int quantity, string modeltype, int mileage, int co2, int doors, int seats, string color, string features, int eshopconditionid, int eshoplabelid, int eshoptransmissionid, int eshopvehiclebodytypeid, int eshopfuelid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementEshopSet (arrangementid, webtitle, price, quantity, modeltype, mileage, co2, doors, seats, color, features, eshopconditionid, eshoplabelid, eshoptransmissionid, eshopvehiclebodytypeid, eshopfuelid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementEshopSet (int arrangementid, string webtitle, decimal price, int quantity, string modeltype, int mileage, int co2, int doors, int seats, string color, string features, int eshopconditionid, int eshoplabelid, int eshoptransmissionid, int eshopvehiclebodytypeid, int eshopfuelid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementEshopSet (arrangementid, webtitle, price, quantity, modeltype, mileage, co2, doors, seats, color, features, eshopconditionid, eshoplabelid, eshoptransmissionid, eshopvehiclebodytypeid, eshopfuelid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementEshopSet (int arrangementid, string webtitle, decimal price, int quantity, string modeltype, int mileage, int co2, int doors, int seats, string color, string features, int eshopconditionid, int eshoplabelid, int eshoptransmissionid, int eshopvehiclebodytypeid, int eshopfuelid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_ESHOP__SET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@webtitle", webtitle);
  q.q2e(sc, "@price", price);
  q.q2i(sc, "@quantity", quantity);
  q.q2s(sc, "@modeltype", modeltype);
  q.q2i(sc, "@mileage", mileage);
  q.q2i(sc, "@co2", co2);
  q.q2i(sc, "@doors", doors);
  q.q2i(sc, "@seats", seats);
  q.q2s(sc, "@color", color);
  q.q2s(sc, "@features", features);
  q.q2i(sc, "@eshopconditionid", eshopconditionid);
  q.q2i(sc, "@eshoplabelid", eshoplabelid);
  q.q2i(sc, "@eshoptransmissionid", eshoptransmissionid);
  q.q2i(sc, "@eshopvehiclebodytypeid", eshopvehiclebodytypeid);
  q.q2i(sc, "@eshopfuelid", eshopfuelid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementFileDirectoriesVw (int arrangementid, int parentid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementFileDirectoriesVw (arrangementid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoriesVw (int arrangementid, int parentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementFileDirectoriesVw (arrangementid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoriesVw (int arrangementid, int parentid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementFileDirectoriesVw (arrangementid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoriesVw (int arrangementid, int parentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_FILE__DIRECTORIES_vw"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@parentid", parentid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementFileDirectoryDelete (int arrangementid, int arrangementfileid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementFileDirectoryDelete (arrangementid, arrangementfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoryDelete (int arrangementid, int arrangementfileid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementFileDirectoryDelete (arrangementid, arrangementfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoryDelete (int arrangementid, int arrangementfileid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementFileDirectoryDelete (arrangementid, arrangementfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoryDelete (int arrangementid, int arrangementfileid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_FILE__DIRECTORY_DELETE"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@arrangementfileid", arrangementfileid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementFileDirectoryNew (int arrangementid, int parentid, ref int newid, ref string newname) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementFileDirectoryNew (arrangementid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoryNew (int arrangementid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementFileDirectoryNew (arrangementid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoryNew (int arrangementid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementFileDirectoryNew (arrangementid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoryNew (int arrangementid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_FILE__DIRECTORY_NEW"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@parentid", parentid);
  q.q2i(sc, "@newid", newid);
  q.q2s(sc, "@newname", newname);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   newid = q.gi(sc,"@newid");
   newname = q.gs(sc,"@newname");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementFileDirectoryRename (int arrangementid, int arrangementfileid, string name) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementFileDirectoryRename (arrangementid, arrangementfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoryRename (int arrangementid, int arrangementfileid, string name,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementFileDirectoryRename (arrangementid, arrangementfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoryRename (int arrangementid, int arrangementfileid, string name,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementFileDirectoryRename (arrangementid, arrangementfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileDirectoryRename (int arrangementid, int arrangementfileid, string name,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_FILE__DIRECTORY_RENAME"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@arrangementfileid", arrangementfileid);
  q.q2s(sc, "@name", name);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementFileFileAdd (int arrangementid, int dirarrangementfileid, string fn, string ext, byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementFileFileAdd (arrangementid, dirarrangementfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileAdd (int arrangementid, int dirarrangementfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementFileFileAdd (arrangementid, dirarrangementfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileAdd (int arrangementid, int dirarrangementfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementFileFileAdd (arrangementid, dirarrangementfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileAdd (int arrangementid, int dirarrangementfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_FILE__FILE_ADD"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@dirarrangementfileid", dirarrangementfileid);
  q.q2s(sc, "@fn", fn);
  q.q2s(sc, "@ext", ext);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementFileFileDelete (int arrangementid, int arrangementfileid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementFileFileDelete (arrangementid, arrangementfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileDelete (int arrangementid, int arrangementfileid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementFileFileDelete (arrangementid, arrangementfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileDelete (int arrangementid, int arrangementfileid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementFileFileDelete (arrangementid, arrangementfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileDelete (int arrangementid, int arrangementfileid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_FILE__FILE_DELETE"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@arrangementfileid", arrangementfileid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementFileFileInfoGet (int arrangementid, int arrangementfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementFileFileInfoGet (arrangementid, arrangementfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileInfoGet (int arrangementid, int arrangementfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementFileFileInfoGet (arrangementid, arrangementfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileInfoGet (int arrangementid, int arrangementfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementFileFileInfoGet (arrangementid, arrangementfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileInfoGet (int arrangementid, int arrangementfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_FILE__FILE_INFO_GET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@arrangementfileid", arrangementfileid);
  q.q2s(sc, "@name", name);
  q.q2dt(sc, "@uploaded", uploaded);
  q.q2s(sc, "@type", type);
  q.q2i(sc, "@size", size);
  q.q2s(sc, "@uploadedby", uploadedby);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   name = q.gs(sc,"@name");
   uploaded = q.gdt(sc,"@uploaded");
   type = q.gs(sc,"@type");
   size = q.gi(sc,"@size");
   uploadedby = q.gs(sc,"@uploadedby");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementFileFileOpenGet (int arrangementid, int arrangementfileid, ref string fn, ref byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementFileFileOpenGet (arrangementid, arrangementfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileOpenGet (int arrangementid, int arrangementfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementFileFileOpenGet (arrangementid, arrangementfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileOpenGet (int arrangementid, int arrangementfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementFileFileOpenGet (arrangementid, arrangementfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileOpenGet (int arrangementid, int arrangementfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_FILE__FILE_OPEN_GET"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@arrangementfileid", arrangementfileid);
  q.q2s(sc, "@fn", fn);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   fn = q.gs(sc,"@fn");
   body = q.ga(sc,"@body");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementFileFileRename (int arrangementid, int arrangementfileid, string newfn) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementFileFileRename (arrangementid, arrangementfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileRename (int arrangementid, int arrangementfileid, string newfn,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementFileFileRename (arrangementid, arrangementfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileRename (int arrangementid, int arrangementfileid, string newfn,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementFileFileRename (arrangementid, arrangementfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFileRename (int arrangementid, int arrangementfileid, string newfn,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_FILE__FILE_RENAME"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@arrangementfileid", arrangementfileid);
  q.q2s(sc, "@newfn", newfn);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementFileFilesVw (int arrangementid, int arrangementfileid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementFileFilesVw (arrangementid, arrangementfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFilesVw (int arrangementid, int arrangementfileid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementFileFilesVw (arrangementid, arrangementfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFilesVw (int arrangementid, int arrangementfileid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementFileFilesVw (arrangementid, arrangementfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementFileFilesVw (int arrangementid, int arrangementfileid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_FILE__FILES_vw"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@arrangementfileid", arrangementfileid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementQuantityUpdate (int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementQuantityUpdate (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementQuantityUpdate (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementQuantityUpdate (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementQuantityUpdate (int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementQuantityUpdate (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementQuantityUpdate (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_QUANTITY__UPDATE"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementQuotesVw (int arrangmentid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementQuotesVw (arrangmentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementQuotesVw (int arrangmentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementQuotesVw (arrangmentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementQuotesVw (int arrangmentid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementQuotesVw (arrangmentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementQuotesVw (int arrangmentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_QUOTES_vw"); 
  q.q2i(sc, "@arrangmentid", arrangmentid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementStandardEquipmentUpdate (int arrangementid, DataTable arrangementstandardequipmentids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementStandardEquipmentUpdate (arrangementid, arrangementstandardequipmentids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEquipmentUpdate (int arrangementid, DataTable arrangementstandardequipmentids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementStandardEquipmentUpdate (arrangementid, arrangementstandardequipmentids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEquipmentUpdate (int arrangementid, DataTable arrangementstandardequipmentids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementStandardEquipmentUpdate (arrangementid, arrangementstandardequipmentids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEquipmentUpdate (int arrangementid, DataTable arrangementstandardequipmentids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_STANDARD_EQUIPMENT__UPDATE"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2u(sc, "@arrangementstandardequipmentids", "eids", arrangementstandardequipmentids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementStandardEquipmentVwq (int arrangementid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementStandardEquipmentVwq (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEquipmentVwq (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementStandardEquipmentVwq (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEquipmentVwq (int arrangementid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementStandardEquipmentVwq (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementStandardEquipmentVwq (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_STANDARD_EQUIPMENT_vwq"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleAdd (int arrangementid, string vin) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleAdd (arrangementid, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleAdd (int arrangementid, string vin,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleAdd (arrangementid, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleAdd (int arrangementid, string vin,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleAdd (arrangementid, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleAdd (int arrangementid, string vin,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__ADD"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2s(sc, "@vin", vin);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleArrangementIdGet (int arrangementvehicleid, ref int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleArrangementIdGet (arrangementvehicleid, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleArrangementIdGet (int arrangementvehicleid, ref int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleArrangementIdGet (arrangementvehicleid, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleArrangementIdGet (int arrangementvehicleid, ref int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleArrangementIdGet (arrangementvehicleid, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleArrangementIdGet (int arrangementvehicleid, ref int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__ARRANGEMENT_ID_GET"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   arrangementid = q.gi(sc,"@arrangementid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleEvaReturn (int arrangementvehicleid, int companyid, string reservationnotes, string returntoautobravareason) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleEvaReturn (arrangementvehicleid, companyid, reservationnotes, returntoautobravareason,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleEvaReturn (int arrangementvehicleid, int companyid, string reservationnotes, string returntoautobravareason,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleEvaReturn (arrangementvehicleid, companyid, reservationnotes, returntoautobravareason,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleEvaReturn (int arrangementvehicleid, int companyid, string reservationnotes, string returntoautobravareason,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleEvaReturn (arrangementvehicleid, companyid, reservationnotes, returntoautobravareason,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleEvaReturn (int arrangementvehicleid, int companyid, string reservationnotes, string returntoautobravareason,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__EVA_RETURN"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2i(sc, "@companyid", companyid);
  q.q2s(sc, "@reservationnotes", reservationnotes);
  q.q2s(sc, "@returntoautobravareason", returntoautobravareason);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleNoteGet (int arrangementvehicleid, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleNoteGet (arrangementvehicleid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleNoteGet (int arrangementvehicleid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleNoteGet (arrangementvehicleid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleNoteGet (int arrangementvehicleid, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleNoteGet (arrangementvehicleid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleNoteGet (int arrangementvehicleid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__NOTE_GET"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleNoteSet (int arrangementvehicleid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleNoteSet (arrangementvehicleid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleNoteSet (int arrangementvehicleid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleNoteSet (arrangementvehicleid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleNoteSet (int arrangementvehicleid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleNoteSet (arrangementvehicleid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleNoteSet (int arrangementvehicleid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__NOTE_SET"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleOrdernoGet (int arrangementvehicleid, ref string orderno) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleOrdernoGet (arrangementvehicleid, ref orderno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleOrdernoGet (int arrangementvehicleid, ref string orderno,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleOrdernoGet (arrangementvehicleid, ref orderno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleOrdernoGet (int arrangementvehicleid, ref string orderno,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleOrdernoGet (arrangementvehicleid, ref orderno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleOrdernoGet (int arrangementvehicleid, ref string orderno,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__ORDERNO_GET"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2s(sc, "@orderno", orderno);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   orderno = q.gs(sc,"@orderno");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleOrdernoSet (int arrangementvehicleid, string orderno) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleOrdernoSet (arrangementvehicleid, orderno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleOrdernoSet (int arrangementvehicleid, string orderno,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleOrdernoSet (arrangementvehicleid, orderno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleOrdernoSet (int arrangementvehicleid, string orderno,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleOrdernoSet (arrangementvehicleid, orderno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleOrdernoSet (int arrangementvehicleid, string orderno,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__ORDERNO_SET"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2s(sc, "@orderno", orderno);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclePlaceholderAdd (int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclePlaceholderAdd (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclePlaceholderAdd (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclePlaceholderAdd (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclePlaceholderAdd (int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclePlaceholderAdd (arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclePlaceholderAdd (int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__PLACEHOLDER_ADD"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleSupplierContractGet (int arrangementvehicleid, ref int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleSupplierContractGet (arrangementvehicleid, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleSupplierContractGet (int arrangementvehicleid, ref int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleSupplierContractGet (arrangementvehicleid, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleSupplierContractGet (int arrangementvehicleid, ref int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleSupplierContractGet (arrangementvehicleid, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleSupplierContractGet (int arrangementvehicleid, ref int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__SUPPLIER_CONTRACT_GET"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   suppliercontractid = q.gi(sc,"@suppliercontractid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleSupplierContractItemIdGetVw (DataTable arrangementvehicleids, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleSupplierContractItemIdGetVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleSupplierContractItemIdGetVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleSupplierContractItemIdGetVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleSupplierContractItemIdGetVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleSupplierContractItemIdGetVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleSupplierContractItemIdGetVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__SUPPLIER_CONTRACT_ITEM_ID_GET_vw"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleSupplierVehicleLoadGet (int arrangementvehicleid, ref int suppliervehicleloadid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleSupplierVehicleLoadGet (arrangementvehicleid, ref suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleSupplierVehicleLoadGet (int arrangementvehicleid, ref int suppliervehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleSupplierVehicleLoadGet (arrangementvehicleid, ref suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleSupplierVehicleLoadGet (int arrangementvehicleid, ref int suppliervehicleloadid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleSupplierVehicleLoadGet (arrangementvehicleid, ref suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleSupplierVehicleLoadGet (int arrangementvehicleid, ref int suppliervehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__SUPPLIER_VEHICLE_LOAD_GET"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   suppliervehicleloadid = q.gi(sc,"@suppliervehicleloadid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleVinGet (int arrangementvehicleid, ref string vin) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleVinGet (arrangementvehicleid, ref vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleVinGet (int arrangementvehicleid, ref string vin,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleVinGet (arrangementvehicleid, ref vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleVinGet (int arrangementvehicleid, ref string vin,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleVinGet (arrangementvehicleid, ref vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleVinGet (int arrangementvehicleid, ref string vin,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__VIN_GET"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2s(sc, "@vin", vin);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   vin = q.gs(sc,"@vin");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehicleVinSet (int arrangementvehicleid, string vin) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehicleVinSet (arrangementvehicleid, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleVinSet (int arrangementvehicleid, string vin,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehicleVinSet (arrangementvehicleid, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleVinSet (int arrangementvehicleid, string vin,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehicleVinSet (arrangementvehicleid, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehicleVinSet (int arrangementvehicleid, string vin,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLE__VIN_SET"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2s(sc, "@vin", vin);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesAddToSupplierVehicleLoad (DataTable arrangementvehicleids, int suppliervehicleloadid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesAddToSupplierVehicleLoad (arrangementvehicleids, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAddToSupplierVehicleLoad (DataTable arrangementvehicleids, int suppliervehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesAddToSupplierVehicleLoad (arrangementvehicleids, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAddToSupplierVehicleLoad (DataTable arrangementvehicleids, int suppliervehicleloadid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesAddToSupplierVehicleLoad (arrangementvehicleids, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAddToSupplierVehicleLoad (DataTable arrangementvehicleids, int suppliervehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__ADD_TO_SUPPLIER_VEHICLE_LOAD"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesAnnexCreate (DataTable arrangementvehiclesids, int interioraddonid, int exterioraddonid, DataTable optionaddonids, int quantity, string annexnum, decimal purchaseprice, decimal buffer) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesAnnexCreate (arrangementvehiclesids, interioraddonid, exterioraddonid, optionaddonids, quantity, annexnum, purchaseprice, buffer,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAnnexCreate (DataTable arrangementvehiclesids, int interioraddonid, int exterioraddonid, DataTable optionaddonids, int quantity, string annexnum, decimal purchaseprice, decimal buffer,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesAnnexCreate (arrangementvehiclesids, interioraddonid, exterioraddonid, optionaddonids, quantity, annexnum, purchaseprice, buffer,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAnnexCreate (DataTable arrangementvehiclesids, int interioraddonid, int exterioraddonid, DataTable optionaddonids, int quantity, string annexnum, decimal purchaseprice, decimal buffer,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesAnnexCreate (arrangementvehiclesids, interioraddonid, exterioraddonid, optionaddonids, quantity, annexnum, purchaseprice, buffer,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAnnexCreate (DataTable arrangementvehiclesids, int interioraddonid, int exterioraddonid, DataTable optionaddonids, int quantity, string annexnum, decimal purchaseprice, decimal buffer,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__ANNEX_CREATE"); 
  q.q2u(sc, "@arrangementvehiclesids", "eids", arrangementvehiclesids);
  q.q2i(sc, "@interioraddonid", interioraddonid);
  q.q2i(sc, "@exterioraddonid", exterioraddonid);
  q.q2u(sc, "@optionaddonids", "eids", optionaddonids);
  q.q2i(sc, "@quantity", quantity);
  q.q2s(sc, "@annexnum", annexnum);
  q.q2e(sc, "@purchaseprice", purchaseprice);
  q.q2e(sc, "@buffer", buffer);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesAnnexPaste (string globaltablename, DataTable map) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesAnnexPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAnnexPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesAnnexPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAnnexPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesAnnexPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAnnexPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__ANNEX_PASTE"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesAtVendorPaste (string globaltablename, DataTable map) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesAtVendorPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAtVendorPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesAtVendorPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAtVendorPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesAtVendorPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesAtVendorPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__AT_VENDOR_PASTE"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesBeeAutoSet (DataTable arrangementvehicleids, int renttype) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesBeeAutoSet (arrangementvehicleids, renttype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesBeeAutoSet (DataTable arrangementvehicleids, int renttype,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesBeeAutoSet (arrangementvehicleids, renttype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesBeeAutoSet (DataTable arrangementvehicleids, int renttype,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesBeeAutoSet (arrangementvehicleids, renttype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesBeeAutoSet (DataTable arrangementvehicleids, int renttype,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__BEE_AUTO_SET"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2i(sc, "@renttype", renttype);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesCostPaste (string globaltablename, DataTable map) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesCostPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesCostPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesCostPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesCostPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesCostPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesCostPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__COST_PASTE"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesDatesUpdate (DataTable suppliercontractvehiclesids, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int holdperiod, int documentholdperiod, DateTime loadingfromsupplierat, int registrationperiod, DateTime loadingday, bool changevehicleatvendor, bool changeplannedpayment, int transportationperiod) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesDatesUpdate (suppliercontractvehiclesids, vehiclesatvendor, plannedpaymentat, preparationperiod, holdperiod, documentholdperiod, loadingfromsupplierat, registrationperiod, loadingday, changevehicleatvendor, changeplannedpayment, transportationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesDatesUpdate (DataTable suppliercontractvehiclesids, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int holdperiod, int documentholdperiod, DateTime loadingfromsupplierat, int registrationperiod, DateTime loadingday, bool changevehicleatvendor, bool changeplannedpayment, int transportationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesDatesUpdate (suppliercontractvehiclesids, vehiclesatvendor, plannedpaymentat, preparationperiod, holdperiod, documentholdperiod, loadingfromsupplierat, registrationperiod, loadingday, changevehicleatvendor, changeplannedpayment, transportationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesDatesUpdate (DataTable suppliercontractvehiclesids, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int holdperiod, int documentholdperiod, DateTime loadingfromsupplierat, int registrationperiod, DateTime loadingday, bool changevehicleatvendor, bool changeplannedpayment, int transportationperiod,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesDatesUpdate (suppliercontractvehiclesids, vehiclesatvendor, plannedpaymentat, preparationperiod, holdperiod, documentholdperiod, loadingfromsupplierat, registrationperiod, loadingday, changevehicleatvendor, changeplannedpayment, transportationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesDatesUpdate (DataTable suppliercontractvehiclesids, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int holdperiod, int documentholdperiod, DateTime loadingfromsupplierat, int registrationperiod, DateTime loadingday, bool changevehicleatvendor, bool changeplannedpayment, int transportationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__DATES_UPDATE"); 
  q.q2u(sc, "@suppliercontractvehiclesids", "eids", suppliercontractvehiclesids);
  q.q2d(sc, "@vehiclesatvendor", vehiclesatvendor);
  q.q2d(sc, "@plannedpaymentat", plannedpaymentat);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2d(sc, "@loadingfromsupplierat", loadingfromsupplierat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2b(sc, "@changevehicleatvendor", changevehicleatvendor);
  q.q2b(sc, "@changeplannedpayment", changeplannedpayment);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesInvoiceSentDateSet (DataTable arrangementvehicleids, DateTime dt) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesInvoiceSentDateSet (arrangementvehicleids, dt,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesInvoiceSentDateSet (DataTable arrangementvehicleids, DateTime dt,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesInvoiceSentDateSet (arrangementvehicleids, dt,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesInvoiceSentDateSet (DataTable arrangementvehicleids, DateTime dt,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesInvoiceSentDateSet (arrangementvehicleids, dt,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesInvoiceSentDateSet (DataTable arrangementvehicleids, DateTime dt,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__INVOICE_SENT_DATE_SET"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2d(sc, "@dt", dt);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesIsreadySet2 (DataTable arrangementvehicleids, bool isreadyforpayment) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesIsreadySet2 (arrangementvehicleids, isreadyforpayment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesIsreadySet2 (DataTable arrangementvehicleids, bool isreadyforpayment,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesIsreadySet2 (arrangementvehicleids, isreadyforpayment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesIsreadySet2 (DataTable arrangementvehicleids, bool isreadyforpayment,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesIsreadySet2 (arrangementvehicleids, isreadyforpayment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesIsreadySet2 (DataTable arrangementvehicleids, bool isreadyforpayment,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__ISREADY_SET2"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2b(sc, "@isreadyforpayment", isreadyforpayment);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesIsreadyValidate (DataTable arrangementvehicleids, bool isreadyforpayment) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesIsreadyValidate (arrangementvehicleids, isreadyforpayment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesIsreadyValidate (DataTable arrangementvehicleids, bool isreadyforpayment,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesIsreadyValidate (arrangementvehicleids, isreadyforpayment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesIsreadyValidate (DataTable arrangementvehicleids, bool isreadyforpayment,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesIsreadyValidate (arrangementvehicleids, isreadyforpayment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesIsreadyValidate (DataTable arrangementvehicleids, bool isreadyforpayment,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__ISREADY_VALIDATE"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2b(sc, "@isreadyforpayment", isreadyforpayment);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesMoveToNew (DataTable ids, string dealtype, decimal newprice, int newsellerid, decimal hm) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesMoveToNew (ids, dealtype, newprice, newsellerid, hm,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesMoveToNew (DataTable ids, string dealtype, decimal newprice, int newsellerid, decimal hm,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesMoveToNew (ids, dealtype, newprice, newsellerid, hm,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesMoveToNew (DataTable ids, string dealtype, decimal newprice, int newsellerid, decimal hm,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesMoveToNew (ids, dealtype, newprice, newsellerid, hm,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesMoveToNew (DataTable ids, string dealtype, decimal newprice, int newsellerid, decimal hm,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__MOVE_TO_NEW"); 
  q.q2u(sc, "@ids", "eids", ids);
  q.q2s(sc, "@dealtype", dealtype);
  q.q2e(sc, "@newprice", newprice);
  q.q2i(sc, "@newsellerid", newsellerid);
  q.q2e(sc, "@hm", hm);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesSupplierContractIdGet (DataTable arrangementvehicleids, ref int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesSupplierContractIdGet (arrangementvehicleids, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierContractIdGet (DataTable arrangementvehicleids, ref int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesSupplierContractIdGet (arrangementvehicleids, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierContractIdGet (DataTable arrangementvehicleids, ref int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesSupplierContractIdGet (arrangementvehicleids, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierContractIdGet (DataTable arrangementvehicleids, ref int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__SUPPLIER_CONTRACT_ID_GET"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   suppliercontractid = q.gi(sc,"@suppliercontractid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesSupplierVehicleLoadsUnpaidVw (DataTable arrangementvehicleids, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesSupplierVehicleLoadsUnpaidVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierVehicleLoadsUnpaidVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesSupplierVehicleLoadsUnpaidVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierVehicleLoadsUnpaidVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesSupplierVehicleLoadsUnpaidVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierVehicleLoadsUnpaidVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES__SUPPLIER_VEHICLE_LOADS_UNPAID_vw"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesSupplierAddressesAdd (DataTable arrangementvehicleids, int countryid, string address, string note, string addresstype, string phone, string email) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesSupplierAddressesAdd (arrangementvehicleids, countryid, address, note, addresstype, phone, email,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierAddressesAdd (DataTable arrangementvehicleids, int countryid, string address, string note, string addresstype, string phone, string email,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesSupplierAddressesAdd (arrangementvehicleids, countryid, address, note, addresstype, phone, email,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierAddressesAdd (DataTable arrangementvehicleids, int countryid, string address, string note, string addresstype, string phone, string email,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesSupplierAddressesAdd (arrangementvehicleids, countryid, address, note, addresstype, phone, email,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierAddressesAdd (DataTable arrangementvehicleids, int countryid, string address, string note, string addresstype, string phone, string email,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES_SUPPLIER_ADDRESSES___ADD"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2i(sc, "@countryid", countryid);
  q.q2s(sc, "@address", address);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@addresstype", addresstype);
  q.q2s(sc, "@phone", phone);
  q.q2s(sc, "@email", email);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesSupplierAddressesVw (DataTable arrangementvehicleids, ref int supplierid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesSupplierAddressesVw (arrangementvehicleids, ref supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierAddressesVw (DataTable arrangementvehicleids, ref int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesSupplierAddressesVw (arrangementvehicleids, ref supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierAddressesVw (DataTable arrangementvehicleids, ref int supplierid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesSupplierAddressesVw (arrangementvehicleids, ref supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesSupplierAddressesVw (DataTable arrangementvehicleids, ref int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES_SUPPLIER_ADDRESSES_vw"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2i(sc, "@supplierid", supplierid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   supplierid = q.gi(sc,"@supplierid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementVehiclesVw (int arrangementid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementVehiclesVw (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesVw (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementVehiclesVw (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesVw (int arrangementid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementVehiclesVw (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementVehiclesVw (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENT_VEHICLES_vw"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ArrangementsHistoryVw (int viewindex, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ArrangementsHistoryVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementsHistoryVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ArrangementsHistoryVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementsHistoryVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ArrangementsHistoryVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ArrangementsHistoryVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ARRANGEMENTS_HISTORY_vw"); 
  q.q2i(sc, "@viewindex", viewindex);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandAdd (string code, string name, string note, bool optionsasfreetext, int modelcodelen, string optionscodelen, int pditype, string importername, string importeraddress, string importerregno) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandAdd (code, name, note, optionsasfreetext, modelcodelen, optionscodelen, pditype, importername, importeraddress, importerregno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandAdd (string code, string name, string note, bool optionsasfreetext, int modelcodelen, string optionscodelen, int pditype, string importername, string importeraddress, string importerregno,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandAdd (code, name, note, optionsasfreetext, modelcodelen, optionscodelen, pditype, importername, importeraddress, importerregno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandAdd (string code, string name, string note, bool optionsasfreetext, int modelcodelen, string optionscodelen, int pditype, string importername, string importeraddress, string importerregno,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandAdd (code, name, note, optionsasfreetext, modelcodelen, optionscodelen, pditype, importername, importeraddress, importerregno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandAdd (string code, string name, string note, bool optionsasfreetext, int modelcodelen, string optionscodelen, int pditype, string importername, string importeraddress, string importerregno,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND__ADD"); 
  q.q2s(sc, "@code", code);
  q.q2s(sc, "@name", name);
  q.q2s(sc, "@note", note);
  q.q2b(sc, "@optionsasfreetext", optionsasfreetext);
  q.q2i(sc, "@modelcodelen", modelcodelen);
  q.q2s(sc, "@optionscodelen", optionscodelen);
  q.q2i(sc, "@pditype", pditype);
  q.q2s(sc, "@importername", importername);
  q.q2s(sc, "@importeraddress", importeraddress);
  q.q2s(sc, "@importerregno", importerregno);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandDelete (int brandid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandDelete (brandid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandDelete (int brandid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandDelete (brandid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandDelete (int brandid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandDelete (brandid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandDelete (int brandid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND__DELETE"); 
  q.q2i(sc, "@brandid", brandid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandGet (int brandid, ref string code, ref string name, ref string note, ref bool optionsasfreetext, ref int modelcodelen, ref string optionscodelen, ref int pditype, ref string importername, ref string importeraddress, ref string importerregno) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandGet (brandid, ref code, ref name, ref note, ref optionsasfreetext, ref modelcodelen, ref optionscodelen, ref pditype, ref importername, ref importeraddress, ref importerregno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandGet (int brandid, ref string code, ref string name, ref string note, ref bool optionsasfreetext, ref int modelcodelen, ref string optionscodelen, ref int pditype, ref string importername, ref string importeraddress, ref string importerregno,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandGet (brandid, ref code, ref name, ref note, ref optionsasfreetext, ref modelcodelen, ref optionscodelen, ref pditype, ref importername, ref importeraddress, ref importerregno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandGet (int brandid, ref string code, ref string name, ref string note, ref bool optionsasfreetext, ref int modelcodelen, ref string optionscodelen, ref int pditype, ref string importername, ref string importeraddress, ref string importerregno,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandGet (brandid, ref code, ref name, ref note, ref optionsasfreetext, ref modelcodelen, ref optionscodelen, ref pditype, ref importername, ref importeraddress, ref importerregno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandGet (int brandid, ref string code, ref string name, ref string note, ref bool optionsasfreetext, ref int modelcodelen, ref string optionscodelen, ref int pditype, ref string importername, ref string importeraddress, ref string importerregno,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND__GET"); 
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@code", code);
  q.q2s(sc, "@name", name);
  q.q2s(sc, "@note", note);
  q.q2b(sc, "@optionsasfreetext", optionsasfreetext);
  q.q2i(sc, "@modelcodelen", modelcodelen);
  q.q2s(sc, "@optionscodelen", optionscodelen);
  q.q2i(sc, "@pditype", pditype);
  q.q2s(sc, "@importername", importername);
  q.q2s(sc, "@importeraddress", importeraddress);
  q.q2s(sc, "@importerregno", importerregno);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   code = q.gs(sc,"@code");
   name = q.gs(sc,"@name");
   note = q.gs(sc,"@note");
   optionsasfreetext = q.gb(sc,"@optionsasfreetext");
   modelcodelen = q.gi(sc,"@modelcodelen");
   optionscodelen = q.gs(sc,"@optionscodelen");
   pditype = q.gi(sc,"@pditype");
   importername = q.gs(sc,"@importername");
   importeraddress = q.gs(sc,"@importeraddress");
   importerregno = q.gs(sc,"@importerregno");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandInfoGet (int brandid, ref string code, ref string name, ref bool optionsasfreetext, ref int modelcodelen, ref int pditype) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandInfoGet (brandid, ref code, ref name, ref optionsasfreetext, ref modelcodelen, ref pditype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandInfoGet (int brandid, ref string code, ref string name, ref bool optionsasfreetext, ref int modelcodelen, ref int pditype,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandInfoGet (brandid, ref code, ref name, ref optionsasfreetext, ref modelcodelen, ref pditype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandInfoGet (int brandid, ref string code, ref string name, ref bool optionsasfreetext, ref int modelcodelen, ref int pditype,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandInfoGet (brandid, ref code, ref name, ref optionsasfreetext, ref modelcodelen, ref pditype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandInfoGet (int brandid, ref string code, ref string name, ref bool optionsasfreetext, ref int modelcodelen, ref int pditype,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND__INFO_GET"); 
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@code", code);
  q.q2s(sc, "@name", name);
  q.q2b(sc, "@optionsasfreetext", optionsasfreetext);
  q.q2i(sc, "@modelcodelen", modelcodelen);
  q.q2i(sc, "@pditype", pditype);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   code = q.gs(sc,"@code");
   name = q.gs(sc,"@name");
   optionsasfreetext = q.gb(sc,"@optionsasfreetext");
   modelcodelen = q.gi(sc,"@modelcodelen");
   pditype = q.gi(sc,"@pditype");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandUpdate (int brandid, string code, string name, string note, bool optionsasfreetext, int modelcodelen, string optionscodelen, int pditype, string importername, string importeraddress, string importerregno) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandUpdate (brandid, code, name, note, optionsasfreetext, modelcodelen, optionscodelen, pditype, importername, importeraddress, importerregno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandUpdate (int brandid, string code, string name, string note, bool optionsasfreetext, int modelcodelen, string optionscodelen, int pditype, string importername, string importeraddress, string importerregno,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandUpdate (brandid, code, name, note, optionsasfreetext, modelcodelen, optionscodelen, pditype, importername, importeraddress, importerregno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandUpdate (int brandid, string code, string name, string note, bool optionsasfreetext, int modelcodelen, string optionscodelen, int pditype, string importername, string importeraddress, string importerregno,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandUpdate (brandid, code, name, note, optionsasfreetext, modelcodelen, optionscodelen, pditype, importername, importeraddress, importerregno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandUpdate (int brandid, string code, string name, string note, bool optionsasfreetext, int modelcodelen, string optionscodelen, int pditype, string importername, string importeraddress, string importerregno,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND__UPDATE"); 
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@code", code);
  q.q2s(sc, "@name", name);
  q.q2s(sc, "@note", note);
  q.q2b(sc, "@optionsasfreetext", optionsasfreetext);
  q.q2i(sc, "@modelcodelen", modelcodelen);
  q.q2s(sc, "@optionscodelen", optionscodelen);
  q.q2i(sc, "@pditype", pditype);
  q.q2s(sc, "@importername", importername);
  q.q2s(sc, "@importeraddress", importeraddress);
  q.q2s(sc, "@importerregno", importerregno);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandModelAdd (int brandid, string modelcode, string name, string insurancedescription, string fuel, int qtyintruck, string enginecapacity, string weight) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandModelAdd (brandid, modelcode, name, insurancedescription, fuel, qtyintruck, enginecapacity, weight,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelAdd (int brandid, string modelcode, string name, string insurancedescription, string fuel, int qtyintruck, string enginecapacity, string weight,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandModelAdd (brandid, modelcode, name, insurancedescription, fuel, qtyintruck, enginecapacity, weight,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelAdd (int brandid, string modelcode, string name, string insurancedescription, string fuel, int qtyintruck, string enginecapacity, string weight,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandModelAdd (brandid, modelcode, name, insurancedescription, fuel, qtyintruck, enginecapacity, weight,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelAdd (int brandid, string modelcode, string name, string insurancedescription, string fuel, int qtyintruck, string enginecapacity, string weight,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND_MODEL__ADD"); 
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@name", name);
  q.q2s(sc, "@insurancedescription", insurancedescription);
  q.q2s(sc, "@fuel", fuel);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2s(sc, "@enginecapacity", enginecapacity);
  q.q2s(sc, "@weight", weight);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandModelDelete (int brandmodelnameid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandModelDelete (brandmodelnameid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelDelete (int brandmodelnameid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandModelDelete (brandmodelnameid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelDelete (int brandmodelnameid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandModelDelete (brandmodelnameid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelDelete (int brandmodelnameid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND_MODEL__DELETE"); 
  q.q2i(sc, "@brandmodelnameid", brandmodelnameid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandModelUpdate (int brandmodelid, string modelcode, string name, string insurancedescription, string fuel, int qtyintruck, string enginecapacity, string weight) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandModelUpdate (brandmodelid, modelcode, name, insurancedescription, fuel, qtyintruck, enginecapacity, weight,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelUpdate (int brandmodelid, string modelcode, string name, string insurancedescription, string fuel, int qtyintruck, string enginecapacity, string weight,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandModelUpdate (brandmodelid, modelcode, name, insurancedescription, fuel, qtyintruck, enginecapacity, weight,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelUpdate (int brandmodelid, string modelcode, string name, string insurancedescription, string fuel, int qtyintruck, string enginecapacity, string weight,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandModelUpdate (brandmodelid, modelcode, name, insurancedescription, fuel, qtyintruck, enginecapacity, weight,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelUpdate (int brandmodelid, string modelcode, string name, string insurancedescription, string fuel, int qtyintruck, string enginecapacity, string weight,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND_MODEL__UPDATE"); 
  q.q2i(sc, "@brandmodelid", brandmodelid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@name", name);
  q.q2s(sc, "@insurancedescription", insurancedescription);
  q.q2s(sc, "@fuel", fuel);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2s(sc, "@enginecapacity", enginecapacity);
  q.q2s(sc, "@weight", weight);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandModelNameFind (int brandid, string modelcode, ref string modelname) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandModelNameFind (brandid, modelcode, ref modelname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelNameFind (int brandid, string modelcode, ref string modelname,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandModelNameFind (brandid, modelcode, ref modelname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelNameFind (int brandid, string modelcode, ref string modelname,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandModelNameFind (brandid, modelcode, ref modelname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelNameFind (int brandid, string modelcode, ref string modelname,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND_MODEL_NAME__FIND"); 
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@modelname", modelname);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   modelname = q.gs(sc,"@modelname");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandModelShortnameAdd (int brandid, string modelcode, string shortname) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandModelShortnameAdd (brandid, modelcode, shortname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameAdd (int brandid, string modelcode, string shortname,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandModelShortnameAdd (brandid, modelcode, shortname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameAdd (int brandid, string modelcode, string shortname,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandModelShortnameAdd (brandid, modelcode, shortname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameAdd (int brandid, string modelcode, string shortname,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND_MODEL_SHORTNAME__ADD"); 
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@shortname", shortname);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandModelShortnameDelete (int brandmodelshortnameid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandModelShortnameDelete (brandmodelshortnameid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameDelete (int brandmodelshortnameid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandModelShortnameDelete (brandmodelshortnameid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameDelete (int brandmodelshortnameid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandModelShortnameDelete (brandmodelshortnameid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameDelete (int brandmodelshortnameid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND_MODEL_SHORTNAME__DELETE"); 
  q.q2i(sc, "@brandmodelshortnameid", brandmodelshortnameid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandModelShortnameFind (int brandid, string modelcode, ref string shortname) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandModelShortnameFind (brandid, modelcode, ref shortname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameFind (int brandid, string modelcode, ref string shortname,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandModelShortnameFind (brandid, modelcode, ref shortname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameFind (int brandid, string modelcode, ref string shortname,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandModelShortnameFind (brandid, modelcode, ref shortname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameFind (int brandid, string modelcode, ref string shortname,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND_MODEL_SHORTNAME__FIND"); 
  q.q2i(sc, "@brandid", brandid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@shortname", shortname);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   shortname = q.gs(sc,"@shortname");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandModelShortnameUpdate (int brandmodelshortnameid, string modelcode, string shortname) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandModelShortnameUpdate (brandmodelshortnameid, modelcode, shortname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameUpdate (int brandmodelshortnameid, string modelcode, string shortname,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandModelShortnameUpdate (brandmodelshortnameid, modelcode, shortname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameUpdate (int brandmodelshortnameid, string modelcode, string shortname,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandModelShortnameUpdate (brandmodelshortnameid, modelcode, shortname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnameUpdate (int brandmodelshortnameid, string modelcode, string shortname,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND_MODEL_SHORTNAME__UPDATE"); 
  q.q2i(sc, "@brandmodelshortnameid", brandmodelshortnameid);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2s(sc, "@shortname", shortname);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandModelShortnamesVw (int brandid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandModelShortnamesVw (brandid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnamesVw (int brandid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandModelShortnamesVw (brandid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnamesVw (int brandid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandModelShortnamesVw (brandid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelShortnamesVw (int brandid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND_MODEL_SHORTNAMES_vw"); 
  q.q2i(sc, "@brandid", brandid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandModelsVw (int brandid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandModelsVw (brandid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelsVw (int brandid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandModelsVw (brandid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelsVw (int brandid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandModelsVw (brandid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandModelsVw (int brandid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRAND_MODELS_vw"); 
  q.q2i(sc, "@brandid", brandid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandsAllVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandsAllVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandsAllVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandsAllVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandsAllVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandsAllVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandsAllVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRANDS_ALL_vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandsVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandsVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRANDS_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool BrandsVwq (bool dropdown, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return BrandsVwq (dropdown, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandsVwq (bool dropdown, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return BrandsVwq (dropdown, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandsVwq (bool dropdown, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return BrandsVwq (dropdown, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool BrandsVwq (bool dropdown, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.BRANDS_vwq"); 
  q.q2b(sc, "@dropdown", dropdown);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ClientAddQuick (string name, string phone, string contact, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ClientAddQuick (name, phone, contact, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ClientAddQuick (string name, string phone, string contact, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ClientAddQuick (name, phone, contact, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ClientAddQuick (string name, string phone, string contact, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ClientAddQuick (name, phone, contact, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ClientAddQuick (string name, string phone, string contact, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.CLIENT__ADD_QUICK"); 
  q.q2s(sc, "@name", name);
  q.q2s(sc, "@phone", phone);
  q.q2s(sc, "@contact", contact);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ClientInfoGet (int clientid, ref string name) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ClientInfoGet (clientid, ref name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ClientInfoGet (int clientid, ref string name,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ClientInfoGet (clientid, ref name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ClientInfoGet (int clientid, ref string name,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ClientInfoGet (clientid, ref name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ClientInfoGet (int clientid, ref string name,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.CLIENT__INFO_GET"); 
  q.q2i(sc, "@clientid", clientid);
  q.q2s(sc, "@name", name);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   name = q.gs(sc,"@name");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ClientsActiveVwq (bool showall, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ClientsActiveVwq (showall, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ClientsActiveVwq (bool showall, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ClientsActiveVwq (showall, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ClientsActiveVwq (bool showall, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ClientsActiveVwq (showall, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ClientsActiveVwq (bool showall, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.CLIENTS_ACTIVE_vwq"); 
  q.q2b(sc, "@showall", showall);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool CompanyGroupsVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return CompanyGroupsVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CompanyGroupsVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return CompanyGroupsVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CompanyGroupsVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return CompanyGroupsVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CompanyGroupsVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.COMPANY_GROUPS_vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ContractDocumentsSendSet2 (int contractheaderid, string emailto, string subject) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ContractDocumentsSendSet2 (contractheaderid, emailto, subject,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractDocumentsSendSet2 (int contractheaderid, string emailto, string subject,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ContractDocumentsSendSet2 (contractheaderid, emailto, subject,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractDocumentsSendSet2 (int contractheaderid, string emailto, string subject,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ContractDocumentsSendSet2 (contractheaderid, emailto, subject,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractDocumentsSendSet2 (int contractheaderid, string emailto, string subject,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.CONTRACT_DOCUMENTS__SEND_SET2"); 
  q.q2i(sc, "@contractheaderid", contractheaderid);
  q.q2s(sc, "@emailto", emailto);
  q.q2s(sc, "@subject", subject);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ContractHeaderNoteGet (int contractheaderid, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ContractHeaderNoteGet (contractheaderid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractHeaderNoteGet (int contractheaderid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ContractHeaderNoteGet (contractheaderid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractHeaderNoteGet (int contractheaderid, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ContractHeaderNoteGet (contractheaderid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractHeaderNoteGet (int contractheaderid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.CONTRACT_HEADER__NOTE_GET"); 
  q.q2i(sc, "@contractheaderid", contractheaderid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ContractHeaderNoteSet (int contractheaderid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ContractHeaderNoteSet (contractheaderid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractHeaderNoteSet (int contractheaderid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ContractHeaderNoteSet (contractheaderid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractHeaderNoteSet (int contractheaderid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ContractHeaderNoteSet (contractheaderid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractHeaderNoteSet (int contractheaderid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.CONTRACT_HEADER__NOTE_SET"); 
  q.q2i(sc, "@contractheaderid", contractheaderid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ContractItemNoteSet (int contractitemid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ContractItemNoteSet (contractitemid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractItemNoteSet (int contractitemid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ContractItemNoteSet (contractitemid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractItemNoteSet (int contractitemid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ContractItemNoteSet (contractitemid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ContractItemNoteSet (int contractitemid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.CONTRACT_ITEM__NOTE_SET"); 
  q.q2i(sc, "@contractitemid", contractitemid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool CountriesActiveVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return CountriesActiveVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountriesActiveVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return CountriesActiveVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountriesActiveVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return CountriesActiveVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountriesActiveVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.COUNTRIES_ACTIVE_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool CountriesVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return CountriesVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountriesVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return CountriesVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountriesVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return CountriesVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountriesVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.COUNTRIES_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool CountriesVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return CountriesVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountriesVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return CountriesVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountriesVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return CountriesVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountriesVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.COUNTRIES_vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool CountryPhoneCodeGet (int countryid, ref string phone) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return CountryPhoneCodeGet (countryid, ref phone,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountryPhoneCodeGet (int countryid, ref string phone,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return CountryPhoneCodeGet (countryid, ref phone,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountryPhoneCodeGet (int countryid, ref string phone,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return CountryPhoneCodeGet (countryid, ref phone,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CountryPhoneCodeGet (int countryid, ref string phone,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.COUNTRY__PHONE_CODE_GET"); 
  q.q2i(sc, "@countryid", countryid);
  q.q2s(sc, "@phone", phone);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   phone = q.gs(sc,"@phone");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool CurrenciesVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return CurrenciesVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CurrenciesVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return CurrenciesVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CurrenciesVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return CurrenciesVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CurrenciesVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.CURRENCIES__vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool CurrenciesActiveVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return CurrenciesActiveVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CurrenciesActiveVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return CurrenciesActiveVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CurrenciesActiveVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return CurrenciesActiveVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CurrenciesActiveVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.CURRENCIES_ACTIVE_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool CurrenciesVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return CurrenciesVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CurrenciesVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return CurrenciesVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CurrenciesVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return CurrenciesVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool CurrenciesVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.CURRENCIES_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool DocumentOpenGet (int documentid, ref string fn, ref byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return DocumentOpenGet (documentid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool DocumentOpenGet (int documentid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return DocumentOpenGet (documentid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool DocumentOpenGet (int documentid, ref string fn, ref byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return DocumentOpenGet (documentid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool DocumentOpenGet (int documentid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.DOCUMENT__OPEN_GET"); 
  q.q2i(sc, "@documentid", documentid);
  q.q2s(sc, "@fn", fn);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   fn = q.gs(sc,"@fn");
   body = q.ga(sc,"@body");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool EmailAttachmentBodyGet (int emailpartid, ref byte[] file, ref string fn) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return EmailAttachmentBodyGet (emailpartid, ref file, ref fn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EmailAttachmentBodyGet (int emailpartid, ref byte[] file, ref string fn,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return EmailAttachmentBodyGet (emailpartid, ref file, ref fn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EmailAttachmentBodyGet (int emailpartid, ref byte[] file, ref string fn,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return EmailAttachmentBodyGet (emailpartid, ref file, ref fn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EmailAttachmentBodyGet (int emailpartid, ref byte[] file, ref string fn,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.EMAIL__ATTACHMENT_BODY_GET"); 
  q.q2i(sc, "@emailpartid", emailpartid);
  q.q2a(sc, "@file", file);
  q.q2s(sc, "@fn", fn);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   file = q.ga(sc,"@file");
   fn = q.gs(sc,"@fn");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool EmailAttachmentsVw (int emailid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return EmailAttachmentsVw (emailid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EmailAttachmentsVw (int emailid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return EmailAttachmentsVw (emailid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EmailAttachmentsVw (int emailid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return EmailAttachmentsVw (emailid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EmailAttachmentsVw (int emailid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.EMAIL__ATTACHMENTS_vw"); 
  q.q2i(sc, "@emailid", emailid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool EmailGet (int emailid, ref string sender, ref string emailfrom, ref string emailto, ref string emailcc, ref string subject, ref DateTime receivedat, ref string body, ref int bodyformat) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return EmailGet (emailid, ref sender, ref emailfrom, ref emailto, ref emailcc, ref subject, ref receivedat, ref body, ref bodyformat,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EmailGet (int emailid, ref string sender, ref string emailfrom, ref string emailto, ref string emailcc, ref string subject, ref DateTime receivedat, ref string body, ref int bodyformat,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return EmailGet (emailid, ref sender, ref emailfrom, ref emailto, ref emailcc, ref subject, ref receivedat, ref body, ref bodyformat,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EmailGet (int emailid, ref string sender, ref string emailfrom, ref string emailto, ref string emailcc, ref string subject, ref DateTime receivedat, ref string body, ref int bodyformat,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return EmailGet (emailid, ref sender, ref emailfrom, ref emailto, ref emailcc, ref subject, ref receivedat, ref body, ref bodyformat,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EmailGet (int emailid, ref string sender, ref string emailfrom, ref string emailto, ref string emailcc, ref string subject, ref DateTime receivedat, ref string body, ref int bodyformat,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.EMAIL__GET"); 
  q.q2i(sc, "@emailid", emailid);
  q.q2s(sc, "@sender", sender);
  q.q2s(sc, "@emailfrom", emailfrom);
  q.q2s(sc, "@emailto", emailto);
  q.q2s(sc, "@emailcc", emailcc);
  q.q2s(sc, "@subject", subject);
  q.q2dt(sc, "@receivedat", receivedat);
  q.q2s(sc, "@body", body);
  q.q2i(sc, "@bodyformat", bodyformat);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   sender = q.gs(sc,"@sender");
   emailfrom = q.gs(sc,"@emailfrom");
   emailto = q.gs(sc,"@emailto");
   emailcc = q.gs(sc,"@emailcc");
   subject = q.gs(sc,"@subject");
   receivedat = q.gdt(sc,"@receivedat");
   body = q.gs(sc,"@body");
   bodyformat = q.gi(sc,"@bodyformat");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool Environment (ref bool utc) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return Environment (ref utc,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool Environment (ref bool utc,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return Environment (ref utc,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool Environment (ref bool utc,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return Environment (ref utc,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool Environment (ref bool utc,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.ENVIRONMENT"); 
  q.q2b(sc, "@utc", utc);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   utc = q.gb(sc,"@utc");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool EvaCompaniesVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return EvaCompaniesVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EvaCompaniesVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return EvaCompaniesVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EvaCompaniesVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return EvaCompaniesVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool EvaCompaniesVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.EVA_COMPANIES_vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ExcelColMapVw (string task, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ExcelColMapVw (task, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ExcelColMapVw (string task, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ExcelColMapVw (task, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ExcelColMapVw (string task, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ExcelColMapVw (task, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ExcelColMapVw (string task, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.EXCEL_COL_MAP_vw"); 
  q.q2s(sc, "@task", task);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ExcelColumnMapVw (byte[] xls, string worksheet, ref string worksheets, ref int firstdatarow, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ExcelColumnMapVw (xls, worksheet, ref worksheets, ref firstdatarow, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ExcelColumnMapVw (byte[] xls, string worksheet, ref string worksheets, ref int firstdatarow, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ExcelColumnMapVw (xls, worksheet, ref worksheets, ref firstdatarow, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ExcelColumnMapVw (byte[] xls, string worksheet, ref string worksheets, ref int firstdatarow, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ExcelColumnMapVw (xls, worksheet, ref worksheets, ref firstdatarow, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ExcelColumnMapVw (byte[] xls, string worksheet, ref string worksheets, ref int firstdatarow, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.EXCEL_COLUMN_MAP_vw"); 
  q.q2a(sc, "@xls", xls);
  q.q2s(sc, "@worksheet", worksheet);
  q.q2s(sc, "@worksheets", worksheets);
  q.q2i(sc, "@firstdatarow", firstdatarow);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   worksheets = q.gs(sc,"@worksheets");
   firstdatarow = q.gi(sc,"@firstdatarow");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool FactoryArrangementVehiclesProcessingVw (bool optionsfreetext, int viewindex, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return FactoryArrangementVehiclesProcessingVw (optionsfreetext, viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryArrangementVehiclesProcessingVw (bool optionsfreetext, int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return FactoryArrangementVehiclesProcessingVw (optionsfreetext, viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryArrangementVehiclesProcessingVw (bool optionsfreetext, int viewindex, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return FactoryArrangementVehiclesProcessingVw (optionsfreetext, viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryArrangementVehiclesProcessingVw (bool optionsfreetext, int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.FACTORY_ARRANGEMENT_VEHICLES_PROCESSING_vw"); 
  q.q2b(sc, "@optionsfreetext", optionsfreetext);
  q.q2i(sc, "@viewindex", viewindex);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool FactoryVehiclesCancelledVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return FactoryVehiclesCancelledVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryVehiclesCancelledVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return FactoryVehiclesCancelledVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryVehiclesCancelledVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return FactoryVehiclesCancelledVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryVehiclesCancelledVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.FACTORY_VEHICLES_CANCELLED_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool FactoryVehiclesContractedVw (int viewindex, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return FactoryVehiclesContractedVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryVehiclesContractedVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return FactoryVehiclesContractedVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryVehiclesContractedVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return FactoryVehiclesContractedVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryVehiclesContractedVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.FACTORY_VEHICLES_CONTRACTED_vw"); 
  q.q2i(sc, "@viewindex", viewindex);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool FactoryVehiclesProducedVw (int viewindex, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return FactoryVehiclesProducedVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryVehiclesProducedVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return FactoryVehiclesProducedVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryVehiclesProducedVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return FactoryVehiclesProducedVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool FactoryVehiclesProducedVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.FACTORY_VEHICLES_PRODUCED_vw"); 
  q.q2i(sc, "@viewindex", viewindex);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool GridColumnsVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return GridColumnsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool GridColumnsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return GridColumnsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool GridColumnsVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return GridColumnsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool GridColumnsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.GRID_COLUMNS_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool InfoGetVw (bool showall, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return InfoGetVw (showall, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool InfoGetVw (bool showall, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return InfoGetVw (showall, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool InfoGetVw (bool showall, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return InfoGetVw (showall, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool InfoGetVw (bool showall, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.INFO_GET_vw"); 
  q.q2b(sc, "@showall", showall);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureDealsVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureDealsVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureDealsVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureDealsVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureDealsVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureDealsVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureDealsVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_DEALS__vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOmMarkAsPaidToVendor (DateTime date, DataTable ids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOmMarkAsPaidToVendor (date, ids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmMarkAsPaidToVendor (DateTime date, DataTable ids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOmMarkAsPaidToVendor (date, ids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmMarkAsPaidToVendor (DateTime date, DataTable ids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOmMarkAsPaidToVendor (date, ids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmMarkAsPaidToVendor (DateTime date, DataTable ids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_OM_MARK_AS_PAID_TO_VENDOR"); 
  q.q2d(sc, "@date", date);
  q.q2u(sc, "@ids", "eids", ids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOmMarkPlannedPaymentToVendor (DateTime date, DataTable ids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOmMarkPlannedPaymentToVendor (date, ids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmMarkPlannedPaymentToVendor (DateTime date, DataTable ids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOmMarkPlannedPaymentToVendor (date, ids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmMarkPlannedPaymentToVendor (DateTime date, DataTable ids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOmMarkPlannedPaymentToVendor (date, ids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmMarkPlannedPaymentToVendor (DateTime date, DataTable ids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_OM_MARK_PLANNED_PAYMENT_TO_VENDOR"); 
  q.q2d(sc, "@date", date);
  q.q2u(sc, "@ids", "eids", ids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOmOrderReturn (int contractitemid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOmOrderReturn (contractitemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmOrderReturn (int contractitemid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOmOrderReturn (contractitemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmOrderReturn (int contractitemid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOmOrderReturn (contractitemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmOrderReturn (int contractitemid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_OM_ORDER__RETURN"); 
  q.q2i(sc, "@contractitemid", contractitemid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOmOrdersReturn (DataTable manufactureordercontractitemids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOmOrdersReturn (manufactureordercontractitemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmOrdersReturn (DataTable manufactureordercontractitemids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOmOrdersReturn (manufactureordercontractitemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmOrdersReturn (DataTable manufactureordercontractitemids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOmOrdersReturn (manufactureordercontractitemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmOrdersReturn (DataTable manufactureordercontractitemids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_OM_ORDERS__RETURN"); 
  q.q2u(sc, "@manufactureordercontractitemids", "eids", manufactureordercontractitemids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOmOrdersReturnToBuffer (DataTable manufactureordercontractitemids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOmOrdersReturnToBuffer (manufactureordercontractitemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmOrdersReturnToBuffer (DataTable manufactureordercontractitemids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOmOrdersReturnToBuffer (manufactureordercontractitemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmOrdersReturnToBuffer (DataTable manufactureordercontractitemids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOmOrdersReturnToBuffer (manufactureordercontractitemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmOrdersReturnToBuffer (DataTable manufactureordercontractitemids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_OM_ORDERS_RETURN_TO_BUFFER"); 
  q.q2u(sc, "@manufactureordercontractitemids", "eids", manufactureordercontractitemids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOmVehiclesDataPaste (string globaltablename, DataTable map) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOmVehiclesDataPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmVehiclesDataPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOmVehiclesDataPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmVehiclesDataPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOmVehiclesDataPaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmVehiclesDataPaste (string globaltablename, DataTable map,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_OM_VEHICLES_DATA_PASTE"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOmVehiclesMileagePaste (string globaltablename, DataTable map) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOmVehiclesMileagePaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmVehiclesMileagePaste (string globaltablename, DataTable map,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOmVehiclesMileagePaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmVehiclesMileagePaste (string globaltablename, DataTable map,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOmVehiclesMileagePaste (globaltablename, map,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOmVehiclesMileagePaste (string globaltablename, DataTable map,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_OM_VEHICLES_MILEAGE_PASTE"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOrderContractItemArrangementsClose (DataTable manufactureordercontractitemids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOrderContractItemArrangementsClose (manufactureordercontractitemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrderContractItemArrangementsClose (DataTable manufactureordercontractitemids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOrderContractItemArrangementsClose (manufactureordercontractitemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrderContractItemArrangementsClose (DataTable manufactureordercontractitemids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOrderContractItemArrangementsClose (manufactureordercontractitemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrderContractItemArrangementsClose (DataTable manufactureordercontractitemids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_ORDER_CONTRACT_ITEM_ARRANGEMENTS__CLOSE"); 
  q.q2u(sc, "@manufactureordercontractitemids", "eids", manufactureordercontractitemids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOrdersCollectAll (bool optionsfreetext, bool includerevokeditems) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOrdersCollectAll (optionsfreetext, includerevokeditems,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersCollectAll (bool optionsfreetext, bool includerevokeditems,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOrdersCollectAll (optionsfreetext, includerevokeditems,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersCollectAll (bool optionsfreetext, bool includerevokeditems,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOrdersCollectAll (optionsfreetext, includerevokeditems,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersCollectAll (bool optionsfreetext, bool includerevokeditems,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_ORDERS__COLLECT_ALL"); 
  q.q2b(sc, "@optionsfreetext", optionsfreetext);
  q.q2b(sc, "@includerevokeditems", includerevokeditems);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOrdersHistoryVw (bool optionsfreetext, int viewindex, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOrdersHistoryVw (optionsfreetext, viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersHistoryVw (bool optionsfreetext, int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOrdersHistoryVw (optionsfreetext, viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersHistoryVw (bool optionsfreetext, int viewindex, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOrdersHistoryVw (optionsfreetext, viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersHistoryVw (bool optionsfreetext, int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_ORDERS_HISTORY_vw"); 
  q.q2b(sc, "@optionsfreetext", optionsfreetext);
  q.q2i(sc, "@viewindex", viewindex);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOrdersProcessingVw (bool optionsfreetext, int viewindex, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOrdersProcessingVw (optionsfreetext, viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersProcessingVw (bool optionsfreetext, int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOrdersProcessingVw (optionsfreetext, viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersProcessingVw (bool optionsfreetext, int viewindex, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOrdersProcessingVw (optionsfreetext, viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersProcessingVw (bool optionsfreetext, int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_ORDERS_PROCESSING_vw"); 
  q.q2b(sc, "@optionsfreetext", optionsfreetext);
  q.q2i(sc, "@viewindex", viewindex);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOrdersReadyExcelExportVw (DataTable manufactureordercontractitemids, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOrdersReadyExcelExportVw (manufactureordercontractitemids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersReadyExcelExportVw (DataTable manufactureordercontractitemids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOrdersReadyExcelExportVw (manufactureordercontractitemids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersReadyExcelExportVw (DataTable manufactureordercontractitemids, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOrdersReadyExcelExportVw (manufactureordercontractitemids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersReadyExcelExportVw (DataTable manufactureordercontractitemids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_ORDERS_READY_EXCEL_EXPORT_vw"); 
  q.q2u(sc, "@manufactureordercontractitemids", "eids", manufactureordercontractitemids);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOrdersReadyExcelSendVw (DataTable manufactureordercontractitemids, ref string emailto, ref int requestno, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOrdersReadyExcelSendVw (manufactureordercontractitemids, ref emailto, ref requestno, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersReadyExcelSendVw (DataTable manufactureordercontractitemids, ref string emailto, ref int requestno, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOrdersReadyExcelSendVw (manufactureordercontractitemids, ref emailto, ref requestno, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersReadyExcelSendVw (DataTable manufactureordercontractitemids, ref string emailto, ref int requestno, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOrdersReadyExcelSendVw (manufactureordercontractitemids, ref emailto, ref requestno, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersReadyExcelSendVw (DataTable manufactureordercontractitemids, ref string emailto, ref int requestno, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_ORDERS_READY_EXCEL_SEND_vw"); 
  q.q2u(sc, "@manufactureordercontractitemids", "eids", manufactureordercontractitemids);
  q.q2s(sc, "@emailto", emailto);
  q.q2i(sc, "@requestno", requestno);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   emailto = q.gs(sc,"@emailto");
   requestno = q.gi(sc,"@requestno");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ManufactureOrdersReadyVw (int viewindex, bool optionsfreetext, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ManufactureOrdersReadyVw (viewindex, optionsfreetext, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersReadyVw (int viewindex, bool optionsfreetext, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ManufactureOrdersReadyVw (viewindex, optionsfreetext, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersReadyVw (int viewindex, bool optionsfreetext, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ManufactureOrdersReadyVw (viewindex, optionsfreetext, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ManufactureOrdersReadyVw (int viewindex, bool optionsfreetext, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MANUFACTURE_ORDERS_READY_vw"); 
  q.q2i(sc, "@viewindex", viewindex);
  q.q2b(sc, "@optionsfreetext", optionsfreetext);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ModelsByArrangementVwq (int arrangementid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ModelsByArrangementVwq (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ModelsByArrangementVwq (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ModelsByArrangementVwq (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ModelsByArrangementVwq (int arrangementid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ModelsByArrangementVwq (arrangementid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ModelsByArrangementVwq (int arrangementid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MODELS_BY_ARRANGEMENT_vwq"); 
  q.q2i(sc, "@arrangementid", arrangementid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ModelsVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ModelsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ModelsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ModelsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ModelsVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ModelsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ModelsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.MODELS_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool NoteAdd (int ownerid, int purposeid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return NoteAdd (ownerid, purposeid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool NoteAdd (int ownerid, int purposeid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return NoteAdd (ownerid, purposeid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool NoteAdd (int ownerid, int purposeid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return NoteAdd (ownerid, purposeid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool NoteAdd (int ownerid, int purposeid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.NOTE_ADD"); 
  q.q2i(sc, "@ownerid", ownerid);
  q.q2i(sc, "@purposeid", purposeid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool NoteDelete (int noteid, int purposeid, int ownerid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return NoteDelete (noteid, purposeid, ownerid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool NoteDelete (int noteid, int purposeid, int ownerid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return NoteDelete (noteid, purposeid, ownerid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool NoteDelete (int noteid, int purposeid, int ownerid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return NoteDelete (noteid, purposeid, ownerid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool NoteDelete (int noteid, int purposeid, int ownerid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.NOTE_DELETE"); 
  q.q2i(sc, "@noteid", noteid);
  q.q2i(sc, "@purposeid", purposeid);
  q.q2i(sc, "@ownerid", ownerid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool NotesVw (int ownerid, int purpose, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return NotesVw (ownerid, purpose, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool NotesVw (int ownerid, int purpose, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return NotesVw (ownerid, purpose, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool NotesVw (int ownerid, int purpose, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return NotesVw (ownerid, purpose, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool NotesVw (int ownerid, int purpose, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.NOTES_vw"); 
  q.q2i(sc, "@ownerid", ownerid);
  q.q2i(sc, "@purpose", purpose);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool OverviewVehiclesVw (int viewindex, bool showall, int companygroup, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return OverviewVehiclesVw (viewindex, showall, companygroup, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool OverviewVehiclesVw (int viewindex, bool showall, int companygroup, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return OverviewVehiclesVw (viewindex, showall, companygroup, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool OverviewVehiclesVw (int viewindex, bool showall, int companygroup, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return OverviewVehiclesVw (viewindex, showall, companygroup, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool OverviewVehiclesVw (int viewindex, bool showall, int companygroup, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.OVERVIEW_VEHICLES_vw"); 
  q.q2i(sc, "@viewindex", viewindex);
  q.q2b(sc, "@showall", showall);
  q.q2i(sc, "@companygroup", companygroup);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool PasteDataColumnFormatSet (string globaltablename, string column, int formatindx) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return PasteDataColumnFormatSet (globaltablename, column, formatindx,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool PasteDataColumnFormatSet (string globaltablename, string column, int formatindx,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return PasteDataColumnFormatSet (globaltablename, column, formatindx,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool PasteDataColumnFormatSet (string globaltablename, string column, int formatindx,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return PasteDataColumnFormatSet (globaltablename, column, formatindx,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool PasteDataColumnFormatSet (string globaltablename, string column, int formatindx,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.PASTE_DATA__COLUMN_FORMAT_SET"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2s(sc, "@column", column);
  q.q2i(sc, "@formatindx", formatindx);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool PastePreviewVw (string fulltext, bool firstrowheader, ref string globaltablename, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return PastePreviewVw (fulltext, firstrowheader, ref globaltablename, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool PastePreviewVw (string fulltext, bool firstrowheader, ref string globaltablename, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return PastePreviewVw (fulltext, firstrowheader, ref globaltablename, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool PastePreviewVw (string fulltext, bool firstrowheader, ref string globaltablename, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return PastePreviewVw (fulltext, firstrowheader, ref globaltablename, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool PastePreviewVw (string fulltext, bool firstrowheader, ref string globaltablename, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.PASTE_PREVIEW_vw"); 
  q.q2s(sc, "@fulltext", fulltext);
  q.q2b(sc, "@firstrowheader", firstrowheader);
  q.q2s(sc, "@globaltablename", globaltablename);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   globaltablename = q.gs(sc,"@globaltablename");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool PurchasersVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return PurchasersVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool PurchasersVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return PurchasersVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool PurchasersVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return PurchasersVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool PurchasersVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.PURCHASERS_vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool QuoteNoteGet (int quoteid, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return QuoteNoteGet (quoteid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool QuoteNoteGet (int quoteid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return QuoteNoteGet (quoteid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool QuoteNoteGet (int quoteid, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return QuoteNoteGet (quoteid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool QuoteNoteGet (int quoteid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.QUOTE__NOTE_GET"); 
  q.q2i(sc, "@quoteid", quoteid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool QuoteNoteSet (int quoteid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return QuoteNoteSet (quoteid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool QuoteNoteSet (int quoteid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return QuoteNoteSet (quoteid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool QuoteNoteSet (int quoteid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return QuoteNoteSet (quoteid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool QuoteNoteSet (int quoteid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.QUOTE_NOTE__SET"); 
  q.q2i(sc, "@quoteid", quoteid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool ReggistrationTaxClientsVwq (DataTable arrangeementvehicleids, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return ReggistrationTaxClientsVwq (arrangeementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ReggistrationTaxClientsVwq (DataTable arrangeementvehicleids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return ReggistrationTaxClientsVwq (arrangeementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ReggistrationTaxClientsVwq (DataTable arrangeementvehicleids, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return ReggistrationTaxClientsVwq (arrangeementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool ReggistrationTaxClientsVwq (DataTable arrangeementvehicleids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.REGGISTRATION_TAX_CLIENTS_vwq"); 
  q.q2u(sc, "@arrangeementvehicleids", "eids", arrangeementvehicleids);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool RegistrationTaxTransportationConfirmationPdf2Vw (DataTable arrangementvehicleids, int clientid, ref string email, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return RegistrationTaxTransportationConfirmationPdf2Vw (arrangementvehicleids, clientid, ref email, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool RegistrationTaxTransportationConfirmationPdf2Vw (DataTable arrangementvehicleids, int clientid, ref string email, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return RegistrationTaxTransportationConfirmationPdf2Vw (arrangementvehicleids, clientid, ref email, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool RegistrationTaxTransportationConfirmationPdf2Vw (DataTable arrangementvehicleids, int clientid, ref string email, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return RegistrationTaxTransportationConfirmationPdf2Vw (arrangementvehicleids, clientid, ref email, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool RegistrationTaxTransportationConfirmationPdf2Vw (DataTable arrangementvehicleids, int clientid, ref string email, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.REGISTRATION_TAX_TRANSPORTATION_CONFIRMATION_PDF2_vw"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2i(sc, "@clientid", clientid);
  q.q2s(sc, "@email", email);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   email = q.gs(sc,"@email");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool RegistrationTaxTransportationConfirmationSignedFileOpenVw (DataTable arrangementvehicleids, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return RegistrationTaxTransportationConfirmationSignedFileOpenVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool RegistrationTaxTransportationConfirmationSignedFileOpenVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return RegistrationTaxTransportationConfirmationSignedFileOpenVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool RegistrationTaxTransportationConfirmationSignedFileOpenVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return RegistrationTaxTransportationConfirmationSignedFileOpenVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool RegistrationTaxTransportationConfirmationSignedFileOpenVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.REGISTRATION_TAX_TRANSPORTATION_CONFIRMATION_SIGNED_FILE_OPEN_vw"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SellerInfoGet (int sellerid, ref string name) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SellerInfoGet (sellerid, ref name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellerInfoGet (int sellerid, ref string name,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SellerInfoGet (sellerid, ref name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellerInfoGet (int sellerid, ref string name,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SellerInfoGet (sellerid, ref name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellerInfoGet (int sellerid, ref string name,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SELLER__INFO_GET"); 
  q.q2i(sc, "@sellerid", sellerid);
  q.q2s(sc, "@name", name);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   name = q.gs(sc,"@name");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SellerInfoGet2 (int sellerid, ref string name, ref decimal registrationcost, ref decimal storagecost, ref decimal cashcostpercent, ref int registrationperiod) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SellerInfoGet2 (sellerid, ref name, ref registrationcost, ref storagecost, ref cashcostpercent, ref registrationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellerInfoGet2 (int sellerid, ref string name, ref decimal registrationcost, ref decimal storagecost, ref decimal cashcostpercent, ref int registrationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SellerInfoGet2 (sellerid, ref name, ref registrationcost, ref storagecost, ref cashcostpercent, ref registrationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellerInfoGet2 (int sellerid, ref string name, ref decimal registrationcost, ref decimal storagecost, ref decimal cashcostpercent, ref int registrationperiod,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SellerInfoGet2 (sellerid, ref name, ref registrationcost, ref storagecost, ref cashcostpercent, ref registrationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellerInfoGet2 (int sellerid, ref string name, ref decimal registrationcost, ref decimal storagecost, ref decimal cashcostpercent, ref int registrationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SELLER__INFO_GET2"); 
  q.q2i(sc, "@sellerid", sellerid);
  q.q2s(sc, "@name", name);
  q.q2e(sc, "@registrationcost", registrationcost);
  q.q2e(sc, "@storagecost", storagecost);
  q.q2e(sc, "@cashcostpercent", cashcostpercent);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   name = q.gs(sc,"@name");
   registrationcost = q.ge(sc,"@registrationcost");
   storagecost = q.ge(sc,"@storagecost");
   cashcostpercent = q.ge(sc,"@cashcostpercent");
   registrationperiod = q.gi(sc,"@registrationperiod");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SellerRegistrationCostGet2 (int sellerid, ref decimal registrationcost, ref int registrationperiod) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SellerRegistrationCostGet2 (sellerid, ref registrationcost, ref registrationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellerRegistrationCostGet2 (int sellerid, ref decimal registrationcost, ref int registrationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SellerRegistrationCostGet2 (sellerid, ref registrationcost, ref registrationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellerRegistrationCostGet2 (int sellerid, ref decimal registrationcost, ref int registrationperiod,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SellerRegistrationCostGet2 (sellerid, ref registrationcost, ref registrationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellerRegistrationCostGet2 (int sellerid, ref decimal registrationcost, ref int registrationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SELLER__REGISTRATION_COST_GET2"); 
  q.q2i(sc, "@sellerid", sellerid);
  q.q2e(sc, "@registrationcost", registrationcost);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   registrationcost = q.ge(sc,"@registrationcost");
   registrationperiod = q.gi(sc,"@registrationperiod");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SellersVwq (bool forbinding, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SellersVwq (forbinding, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellersVwq (bool forbinding, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SellersVwq (forbinding, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellersVwq (bool forbinding, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SellersVwq (forbinding, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SellersVwq (bool forbinding, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SELLERS_vwq"); 
  q.q2b(sc, "@forbinding", forbinding);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool StaffPermissionsGet (ref int ribbonappmode, ref bool issalesperson, ref bool issalemanager, ref bool islogisticmanager, ref bool istruckperson, ref bool isregistrationperson, ref bool isaccountingperson, ref bool ispurchasemanager, ref bool issupplyoffermanager, ref bool isstaffmanager, ref bool ispurchasepersonfca, ref bool ispaymentsperson, ref bool isforeignaccountingperson, ref string defaultview) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return StaffPermissionsGet (ref ribbonappmode, ref issalesperson, ref issalemanager, ref islogisticmanager, ref istruckperson, ref isregistrationperson, ref isaccountingperson, ref ispurchasemanager, ref issupplyoffermanager, ref isstaffmanager, ref ispurchasepersonfca, ref ispaymentsperson, ref isforeignaccountingperson, ref defaultview,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffPermissionsGet (ref int ribbonappmode, ref bool issalesperson, ref bool issalemanager, ref bool islogisticmanager, ref bool istruckperson, ref bool isregistrationperson, ref bool isaccountingperson, ref bool ispurchasemanager, ref bool issupplyoffermanager, ref bool isstaffmanager, ref bool ispurchasepersonfca, ref bool ispaymentsperson, ref bool isforeignaccountingperson, ref string defaultview,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return StaffPermissionsGet (ref ribbonappmode, ref issalesperson, ref issalemanager, ref islogisticmanager, ref istruckperson, ref isregistrationperson, ref isaccountingperson, ref ispurchasemanager, ref issupplyoffermanager, ref isstaffmanager, ref ispurchasepersonfca, ref ispaymentsperson, ref isforeignaccountingperson, ref defaultview,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffPermissionsGet (ref int ribbonappmode, ref bool issalesperson, ref bool issalemanager, ref bool islogisticmanager, ref bool istruckperson, ref bool isregistrationperson, ref bool isaccountingperson, ref bool ispurchasemanager, ref bool issupplyoffermanager, ref bool isstaffmanager, ref bool ispurchasepersonfca, ref bool ispaymentsperson, ref bool isforeignaccountingperson, ref string defaultview,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return StaffPermissionsGet (ref ribbonappmode, ref issalesperson, ref issalemanager, ref islogisticmanager, ref istruckperson, ref isregistrationperson, ref isaccountingperson, ref ispurchasemanager, ref issupplyoffermanager, ref isstaffmanager, ref ispurchasepersonfca, ref ispaymentsperson, ref isforeignaccountingperson, ref defaultview,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffPermissionsGet (ref int ribbonappmode, ref bool issalesperson, ref bool issalemanager, ref bool islogisticmanager, ref bool istruckperson, ref bool isregistrationperson, ref bool isaccountingperson, ref bool ispurchasemanager, ref bool issupplyoffermanager, ref bool isstaffmanager, ref bool ispurchasepersonfca, ref bool ispaymentsperson, ref bool isforeignaccountingperson, ref string defaultview,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.STAFF__PERMISSIONS_GET"); 
  q.q2i(sc, "@ribbonappmode", ribbonappmode);
  q.q2b(sc, "@issalesperson", issalesperson);
  q.q2b(sc, "@issalemanager", issalemanager);
  q.q2b(sc, "@islogisticmanager", islogisticmanager);
  q.q2b(sc, "@istruckperson", istruckperson);
  q.q2b(sc, "@isregistrationperson", isregistrationperson);
  q.q2b(sc, "@isaccountingperson", isaccountingperson);
  q.q2b(sc, "@ispurchasemanager", ispurchasemanager);
  q.q2b(sc, "@issupplyoffermanager", issupplyoffermanager);
  q.q2b(sc, "@isstaffmanager", isstaffmanager);
  q.q2b(sc, "@ispurchasepersonfca", ispurchasepersonfca);
  q.q2b(sc, "@ispaymentsperson", ispaymentsperson);
  q.q2b(sc, "@isforeignaccountingperson", isforeignaccountingperson);
  q.q2s(sc, "@defaultview", defaultview);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   ribbonappmode = q.gi(sc,"@ribbonappmode");
   issalesperson = q.gb(sc,"@issalesperson");
   issalemanager = q.gb(sc,"@issalemanager");
   islogisticmanager = q.gb(sc,"@islogisticmanager");
   istruckperson = q.gb(sc,"@istruckperson");
   isregistrationperson = q.gb(sc,"@isregistrationperson");
   isaccountingperson = q.gb(sc,"@isaccountingperson");
   ispurchasemanager = q.gb(sc,"@ispurchasemanager");
   issupplyoffermanager = q.gb(sc,"@issupplyoffermanager");
   isstaffmanager = q.gb(sc,"@isstaffmanager");
   ispurchasepersonfca = q.gb(sc,"@ispurchasepersonfca");
   ispaymentsperson = q.gb(sc,"@ispaymentsperson");
   isforeignaccountingperson = q.gb(sc,"@isforeignaccountingperson");
   defaultview = q.gs(sc,"@defaultview");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool StaffArrangementManager (ref bool ismanager) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return StaffArrangementManager (ref ismanager,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffArrangementManager (ref bool ismanager,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return StaffArrangementManager (ref ismanager,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffArrangementManager (ref bool ismanager,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return StaffArrangementManager (ref ismanager,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffArrangementManager (ref bool ismanager,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.STAFF_ARRANGEMENT_MANAGER"); 
  q.q2b(sc, "@ismanager", ismanager);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   ismanager = q.gb(sc,"@ismanager");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool StaffSalesManagerVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return StaffSalesManagerVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffSalesManagerVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return StaffSalesManagerVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffSalesManagerVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return StaffSalesManagerVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffSalesManagerVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.STAFF_SALES_MANAGER_vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool StaffVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return StaffVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return StaffVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return StaffVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool StaffVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.STAFF_vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SuplierBoardArrangementAdditionalNoteGet (int suplierid, ref string additionalnote) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SuplierBoardArrangementAdditionalNoteGet (suplierid, ref additionalnote,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuplierBoardArrangementAdditionalNoteGet (int suplierid, ref string additionalnote,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SuplierBoardArrangementAdditionalNoteGet (suplierid, ref additionalnote,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuplierBoardArrangementAdditionalNoteGet (int suplierid, ref string additionalnote,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SuplierBoardArrangementAdditionalNoteGet (suplierid, ref additionalnote,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuplierBoardArrangementAdditionalNoteGet (int suplierid, ref string additionalnote,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPLIER_BOARD_ARRANGEMENT__ADDITIONAL_NOTE_GET"); 
  q.q2i(sc, "@suplierid", suplierid);
  q.q2s(sc, "@additionalnote", additionalnote);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   additionalnote = q.gs(sc,"@additionalnote");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SuplierBoardArrangementAdditionalNoteSet (int suplierboarditemid, string additionalnote) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SuplierBoardArrangementAdditionalNoteSet (suplierboarditemid, additionalnote,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuplierBoardArrangementAdditionalNoteSet (int suplierboarditemid, string additionalnote,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SuplierBoardArrangementAdditionalNoteSet (suplierboarditemid, additionalnote,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuplierBoardArrangementAdditionalNoteSet (int suplierboarditemid, string additionalnote,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SuplierBoardArrangementAdditionalNoteSet (suplierboarditemid, additionalnote,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuplierBoardArrangementAdditionalNoteSet (int suplierboarditemid, string additionalnote,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPLIER_BOARD_ARRANGEMENT__ADDITIONAL_NOTE_SET"); 
  q.q2i(sc, "@suplierboarditemid", suplierboarditemid);
  q.q2s(sc, "@additionalnote", additionalnote);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierAdd (string name, string regno, string vatno, string contact, string address, string email, string phone, string note, string suppliertype, int sellerid, int staffid, int countryid, string mailingaddress, string directorname, decimal creditlimit, int companygroupid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierAdd (name, regno, vatno, contact, address, email, phone, note, suppliertype, sellerid, staffid, countryid, mailingaddress, directorname, creditlimit, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAdd (string name, string regno, string vatno, string contact, string address, string email, string phone, string note, string suppliertype, int sellerid, int staffid, int countryid, string mailingaddress, string directorname, decimal creditlimit, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierAdd (name, regno, vatno, contact, address, email, phone, note, suppliertype, sellerid, staffid, countryid, mailingaddress, directorname, creditlimit, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAdd (string name, string regno, string vatno, string contact, string address, string email, string phone, string note, string suppliertype, int sellerid, int staffid, int countryid, string mailingaddress, string directorname, decimal creditlimit, int companygroupid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierAdd (name, regno, vatno, contact, address, email, phone, note, suppliertype, sellerid, staffid, countryid, mailingaddress, directorname, creditlimit, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAdd (string name, string regno, string vatno, string contact, string address, string email, string phone, string note, string suppliertype, int sellerid, int staffid, int countryid, string mailingaddress, string directorname, decimal creditlimit, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER__ADD"); 
  q.q2s(sc, "@name", name);
  q.q2s(sc, "@regno", regno);
  q.q2s(sc, "@vatno", vatno);
  q.q2s(sc, "@contact", contact);
  q.q2s(sc, "@address", address);
  q.q2s(sc, "@email", email);
  q.q2s(sc, "@phone", phone);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@suppliertype", suppliertype);
  q.q2i(sc, "@sellerid", sellerid);
  q.q2i(sc, "@staffid", staffid);
  q.q2i(sc, "@countryid", countryid);
  q.q2s(sc, "@mailingaddress", mailingaddress);
  q.q2s(sc, "@directorname", directorname);
  q.q2e(sc, "@creditlimit", creditlimit);
  q.q2i(sc, "@companygroupid", companygroupid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierCreditReportSet (DataTable supplierids, string st) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierCreditReportSet (supplierids, st,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierCreditReportSet (DataTable supplierids, string st,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierCreditReportSet (supplierids, st,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierCreditReportSet (DataTable supplierids, string st,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierCreditReportSet (supplierids, st,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierCreditReportSet (DataTable supplierids, string st,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER__CREDIT_REPORT_SET"); 
  q.q2u(sc, "@supplierids", "eids", supplierids);
  q.q2s(sc, "@st", st);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierDelete (int supplierid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierDelete (supplierid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierDelete (int supplierid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierDelete (supplierid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierDelete (int supplierid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierDelete (supplierid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierDelete (int supplierid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER__DELETE"); 
  q.q2i(sc, "@supplierid", supplierid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierIsconfirmedUpdate (int supplierid, bool isconfirmed) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierIsconfirmedUpdate (supplierid, isconfirmed,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIsconfirmedUpdate (int supplierid, bool isconfirmed,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierIsconfirmedUpdate (supplierid, isconfirmed,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIsconfirmedUpdate (int supplierid, bool isconfirmed,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierIsconfirmedUpdate (supplierid, isconfirmed,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIsconfirmedUpdate (int supplierid, bool isconfirmed,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER__ISCONFIRMED_UPDATE"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2b(sc, "@isconfirmed", isconfirmed);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierNoteGet (int supplierid, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierNoteGet (supplierid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierNoteGet (int supplierid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierNoteGet (supplierid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierNoteGet (int supplierid, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierNoteGet (supplierid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierNoteGet (int supplierid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER__NOTE_GET"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierNoteSet (int supplierid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierNoteSet (supplierid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierNoteSet (int supplierid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierNoteSet (supplierid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierNoteSet (int supplierid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierNoteSet (supplierid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierNoteSet (int supplierid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER__NOTE_SET"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierUpdate (int supplierid, string name, string regno, string vatno, string contact, string address, string email, string phone, string note, string suppliertype, int sellerid, int staffid, int countryid, string mailingaddress, string director, decimal creditlimit, int companygroupid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierUpdate (supplierid, name, regno, vatno, contact, address, email, phone, note, suppliertype, sellerid, staffid, countryid, mailingaddress, director, creditlimit, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierUpdate (int supplierid, string name, string regno, string vatno, string contact, string address, string email, string phone, string note, string suppliertype, int sellerid, int staffid, int countryid, string mailingaddress, string director, decimal creditlimit, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierUpdate (supplierid, name, regno, vatno, contact, address, email, phone, note, suppliertype, sellerid, staffid, countryid, mailingaddress, director, creditlimit, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierUpdate (int supplierid, string name, string regno, string vatno, string contact, string address, string email, string phone, string note, string suppliertype, int sellerid, int staffid, int countryid, string mailingaddress, string director, decimal creditlimit, int companygroupid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierUpdate (supplierid, name, regno, vatno, contact, address, email, phone, note, suppliertype, sellerid, staffid, countryid, mailingaddress, director, creditlimit, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierUpdate (int supplierid, string name, string regno, string vatno, string contact, string address, string email, string phone, string note, string suppliertype, int sellerid, int staffid, int countryid, string mailingaddress, string director, decimal creditlimit, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER__UPDATE"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2s(sc, "@name", name);
  q.q2s(sc, "@regno", regno);
  q.q2s(sc, "@vatno", vatno);
  q.q2s(sc, "@contact", contact);
  q.q2s(sc, "@address", address);
  q.q2s(sc, "@email", email);
  q.q2s(sc, "@phone", phone);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@suppliertype", suppliertype);
  q.q2i(sc, "@sellerid", sellerid);
  q.q2i(sc, "@staffid", staffid);
  q.q2i(sc, "@countryid", countryid);
  q.q2s(sc, "@mailingaddress", mailingaddress);
  q.q2s(sc, "@director", director);
  q.q2e(sc, "@creditlimit", creditlimit);
  q.q2i(sc, "@companygroupid", companygroupid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVatValidate (int supplierid, ref bool valid, ref string viesname, ref string viesaddress) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVatValidate (supplierid, ref valid, ref viesname, ref viesaddress,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVatValidate (int supplierid, ref bool valid, ref string viesname, ref string viesaddress,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVatValidate (supplierid, ref valid, ref viesname, ref viesaddress,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVatValidate (int supplierid, ref bool valid, ref string viesname, ref string viesaddress,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVatValidate (supplierid, ref valid, ref viesname, ref viesaddress,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVatValidate (int supplierid, ref bool valid, ref string viesname, ref string viesaddress,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER__VAT_VALIDATE"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2b(sc, "@valid", valid);
  q.q2s(sc, "@viesname", viesname);
  q.q2s(sc, "@viesaddress", viesaddress);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   valid = q.gb(sc,"@valid");
   viesname = q.gs(sc,"@viesname");
   viesaddress = q.gs(sc,"@viesaddress");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierAddressAdd (int supplierid, int countryid, string address, string note, string addresstype, string phone, string email, string postalcode) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierAddressAdd (supplierid, countryid, address, note, addresstype, phone, email, postalcode,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressAdd (int supplierid, int countryid, string address, string note, string addresstype, string phone, string email, string postalcode,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierAddressAdd (supplierid, countryid, address, note, addresstype, phone, email, postalcode,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressAdd (int supplierid, int countryid, string address, string note, string addresstype, string phone, string email, string postalcode,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierAddressAdd (supplierid, countryid, address, note, addresstype, phone, email, postalcode,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressAdd (int supplierid, int countryid, string address, string note, string addresstype, string phone, string email, string postalcode,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_ADDRESS__ADD"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@countryid", countryid);
  q.q2s(sc, "@address", address);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@addresstype", addresstype);
  q.q2s(sc, "@phone", phone);
  q.q2s(sc, "@email", email);
  q.q2s(sc, "@postalcode", postalcode);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierAddressGet (int supplieraddressid, ref int countryid, ref string address, ref string note, ref string addresstype, ref string phone, ref string email, ref string postalcode) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierAddressGet (supplieraddressid, ref countryid, ref address, ref note, ref addresstype, ref phone, ref email, ref postalcode,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressGet (int supplieraddressid, ref int countryid, ref string address, ref string note, ref string addresstype, ref string phone, ref string email, ref string postalcode,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierAddressGet (supplieraddressid, ref countryid, ref address, ref note, ref addresstype, ref phone, ref email, ref postalcode,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressGet (int supplieraddressid, ref int countryid, ref string address, ref string note, ref string addresstype, ref string phone, ref string email, ref string postalcode,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierAddressGet (supplieraddressid, ref countryid, ref address, ref note, ref addresstype, ref phone, ref email, ref postalcode,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressGet (int supplieraddressid, ref int countryid, ref string address, ref string note, ref string addresstype, ref string phone, ref string email, ref string postalcode,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_ADDRESS__GET"); 
  q.q2i(sc, "@supplieraddressid", supplieraddressid);
  q.q2i(sc, "@countryid", countryid);
  q.q2s(sc, "@address", address);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@addresstype", addresstype);
  q.q2s(sc, "@phone", phone);
  q.q2s(sc, "@email", email);
  q.q2s(sc, "@postalcode", postalcode);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   countryid = q.gi(sc,"@countryid");
   address = q.gs(sc,"@address");
   note = q.gs(sc,"@note");
   addresstype = q.gs(sc,"@addresstype");
   phone = q.gs(sc,"@phone");
   email = q.gs(sc,"@email");
   postalcode = q.gs(sc,"@postalcode");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierAddressNewGet (int supplierid, ref string phone) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierAddressNewGet (supplierid, ref phone,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressNewGet (int supplierid, ref string phone,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierAddressNewGet (supplierid, ref phone,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressNewGet (int supplierid, ref string phone,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierAddressNewGet (supplierid, ref phone,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressNewGet (int supplierid, ref string phone,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_ADDRESS__NEW_GET"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2s(sc, "@phone", phone);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   phone = q.gs(sc,"@phone");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierAddressNoteGet (int supplieraddressid, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierAddressNoteGet (supplieraddressid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressNoteGet (int supplieraddressid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierAddressNoteGet (supplieraddressid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressNoteGet (int supplieraddressid, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierAddressNoteGet (supplieraddressid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressNoteGet (int supplieraddressid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_ADDRESS__NOTE_GET"); 
  q.q2i(sc, "@supplieraddressid", supplieraddressid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierAddressNoteSet (int supplieraddressid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierAddressNoteSet (supplieraddressid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressNoteSet (int supplieraddressid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierAddressNoteSet (supplieraddressid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressNoteSet (int supplieraddressid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierAddressNoteSet (supplieraddressid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressNoteSet (int supplieraddressid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_ADDRESS__NOTE_SET"); 
  q.q2i(sc, "@supplieraddressid", supplieraddressid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierAddressUpdate (int supplieraddressid, int countryid, string address, string note, string addresstype, string phone, string email, string postalcode) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierAddressUpdate (supplieraddressid, countryid, address, note, addresstype, phone, email, postalcode,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressUpdate (int supplieraddressid, int countryid, string address, string note, string addresstype, string phone, string email, string postalcode,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierAddressUpdate (supplieraddressid, countryid, address, note, addresstype, phone, email, postalcode,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressUpdate (int supplieraddressid, int countryid, string address, string note, string addresstype, string phone, string email, string postalcode,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierAddressUpdate (supplieraddressid, countryid, address, note, addresstype, phone, email, postalcode,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressUpdate (int supplieraddressid, int countryid, string address, string note, string addresstype, string phone, string email, string postalcode,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_ADDRESS__UPDATE"); 
  q.q2i(sc, "@supplieraddressid", supplieraddressid);
  q.q2i(sc, "@countryid", countryid);
  q.q2s(sc, "@address", address);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@addresstype", addresstype);
  q.q2s(sc, "@phone", phone);
  q.q2s(sc, "@email", email);
  q.q2s(sc, "@postalcode", postalcode);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierAddressesDelete (DataTable supplieraddressids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierAddressesDelete (supplieraddressids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressesDelete (DataTable supplieraddressids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierAddressesDelete (supplieraddressids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressesDelete (DataTable supplieraddressids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierAddressesDelete (supplieraddressids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressesDelete (DataTable supplieraddressids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_ADDRESSES__DELETE"); 
  q.q2u(sc, "@supplieraddressids", "eids", supplieraddressids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierAddressesVw (int supplierid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierAddressesVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressesVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierAddressesVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressesVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierAddressesVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierAddressesVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_ADDRESSES_vw"); 
  q.q2i(sc, "@supplierid", supplierid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardCurrFxrateTodayGet (int supplierboardid, int currencyid, int paycurrencyid, ref decimal todayfxrate) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardCurrFxrateTodayGet (supplierboardid, currencyid, paycurrencyid, ref todayfxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardCurrFxrateTodayGet (int supplierboardid, int currencyid, int paycurrencyid, ref decimal todayfxrate,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardCurrFxrateTodayGet (supplierboardid, currencyid, paycurrencyid, ref todayfxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardCurrFxrateTodayGet (int supplierboardid, int currencyid, int paycurrencyid, ref decimal todayfxrate,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardCurrFxrateTodayGet (supplierboardid, currencyid, paycurrencyid, ref todayfxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardCurrFxrateTodayGet (int supplierboardid, int currencyid, int paycurrencyid, ref decimal todayfxrate,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD__CURR_FXRATE_TODAY_GET"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2i(sc, "@paycurrencyid", paycurrencyid);
  q.q2e(sc, "@todayfxrate", todayfxrate);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   todayfxrate = q.ge(sc,"@todayfxrate");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardCurrOfferGet (int supplierboardid, int newcurrencyid, int newpaycurrencyid, ref decimal fxrate, ref decimal convperc, ref decimal hedgeperc, ref decimal vatriskbuff) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardCurrOfferGet (supplierboardid, newcurrencyid, newpaycurrencyid, ref fxrate, ref convperc, ref hedgeperc, ref vatriskbuff,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardCurrOfferGet (int supplierboardid, int newcurrencyid, int newpaycurrencyid, ref decimal fxrate, ref decimal convperc, ref decimal hedgeperc, ref decimal vatriskbuff,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardCurrOfferGet (supplierboardid, newcurrencyid, newpaycurrencyid, ref fxrate, ref convperc, ref hedgeperc, ref vatriskbuff,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardCurrOfferGet (int supplierboardid, int newcurrencyid, int newpaycurrencyid, ref decimal fxrate, ref decimal convperc, ref decimal hedgeperc, ref decimal vatriskbuff,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardCurrOfferGet (supplierboardid, newcurrencyid, newpaycurrencyid, ref fxrate, ref convperc, ref hedgeperc, ref vatriskbuff,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardCurrOfferGet (int supplierboardid, int newcurrencyid, int newpaycurrencyid, ref decimal fxrate, ref decimal convperc, ref decimal hedgeperc, ref decimal vatriskbuff,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD__CURR_OFFER_GET"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@newcurrencyid", newcurrencyid);
  q.q2i(sc, "@newpaycurrencyid", newpaycurrencyid);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@convperc", convperc);
  q.q2e(sc, "@hedgeperc", hedgeperc);
  q.q2e(sc, "@vatriskbuff", vatriskbuff);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   fxrate = q.ge(sc,"@fxrate");
   convperc = q.ge(sc,"@convperc");
   hedgeperc = q.ge(sc,"@hedgeperc");
   vatriskbuff = q.ge(sc,"@vatriskbuff");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardFxOfferGet (int contractcurrencyid, int topaycurrencyid, decimal contractamount, decimal vatamount, decimal hedgecostperc, decimal convcostperc, decimal vatriskperc, ref decimal fxrate, ref decimal convcost, ref decimal hedgecost, ref decimal topayamount, ref decimal vatriskbuffer) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardFxOfferGet (contractcurrencyid, topaycurrencyid, contractamount, vatamount, hedgecostperc, convcostperc, vatriskperc, ref fxrate, ref convcost, ref hedgecost, ref topayamount, ref vatriskbuffer,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFxOfferGet (int contractcurrencyid, int topaycurrencyid, decimal contractamount, decimal vatamount, decimal hedgecostperc, decimal convcostperc, decimal vatriskperc, ref decimal fxrate, ref decimal convcost, ref decimal hedgecost, ref decimal topayamount, ref decimal vatriskbuffer,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardFxOfferGet (contractcurrencyid, topaycurrencyid, contractamount, vatamount, hedgecostperc, convcostperc, vatriskperc, ref fxrate, ref convcost, ref hedgecost, ref topayamount, ref vatriskbuffer,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFxOfferGet (int contractcurrencyid, int topaycurrencyid, decimal contractamount, decimal vatamount, decimal hedgecostperc, decimal convcostperc, decimal vatriskperc, ref decimal fxrate, ref decimal convcost, ref decimal hedgecost, ref decimal topayamount, ref decimal vatriskbuffer,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardFxOfferGet (contractcurrencyid, topaycurrencyid, contractamount, vatamount, hedgecostperc, convcostperc, vatriskperc, ref fxrate, ref convcost, ref hedgecost, ref topayamount, ref vatriskbuffer,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFxOfferGet (int contractcurrencyid, int topaycurrencyid, decimal contractamount, decimal vatamount, decimal hedgecostperc, decimal convcostperc, decimal vatriskperc, ref decimal fxrate, ref decimal convcost, ref decimal hedgecost, ref decimal topayamount, ref decimal vatriskbuffer,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD__FX_OFFER_GET"); 
  q.q2i(sc, "@contractcurrencyid", contractcurrencyid);
  q.q2i(sc, "@topaycurrencyid", topaycurrencyid);
  q.q2e(sc, "@contractamount", contractamount);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2e(sc, "@hedgecostperc", hedgecostperc);
  q.q2e(sc, "@convcostperc", convcostperc);
  q.q2e(sc, "@vatriskperc", vatriskperc);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@convcost", convcost);
  q.q2e(sc, "@hedgecost", hedgecost);
  q.q2e(sc, "@topayamount", topayamount);
  q.q2e(sc, "@vatriskbuffer", vatriskbuffer);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   fxrate = q.ge(sc,"@fxrate");
   convcost = q.ge(sc,"@convcost");
   hedgecost = q.ge(sc,"@hedgecost");
   topayamount = q.ge(sc,"@topayamount");
   vatriskbuffer = q.ge(sc,"@vatriskbuffer");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardImport (string globaltablename, DataTable map, string arrangementtype, int suppboardid, bool isnew, ref int supplierboardid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardImport (globaltablename, map, arrangementtype, suppboardid, isnew, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardImport (string globaltablename, DataTable map, string arrangementtype, int suppboardid, bool isnew, ref int supplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardImport (globaltablename, map, arrangementtype, suppboardid, isnew, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardImport (string globaltablename, DataTable map, string arrangementtype, int suppboardid, bool isnew, ref int supplierboardid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardImport (globaltablename, map, arrangementtype, suppboardid, isnew, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardImport (string globaltablename, DataTable map, string arrangementtype, int suppboardid, bool isnew, ref int supplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD__IMPORT"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  q.q2s(sc, "@arrangementtype", arrangementtype);
  q.q2i(sc, "@suppboardid", suppboardid);
  q.q2b(sc, "@isnew", isnew);
  q.q2i(sc, "@supplierboardid", supplierboardid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   supplierboardid = q.gi(sc,"@supplierboardid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardImport2 (string globaltablename, DataTable map, string arrangementtype, int suppboardid, bool isnew, ref int supplierboardid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardImport2 (globaltablename, map, arrangementtype, suppboardid, isnew, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardImport2 (string globaltablename, DataTable map, string arrangementtype, int suppboardid, bool isnew, ref int supplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardImport2 (globaltablename, map, arrangementtype, suppboardid, isnew, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardImport2 (string globaltablename, DataTable map, string arrangementtype, int suppboardid, bool isnew, ref int supplierboardid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardImport2 (globaltablename, map, arrangementtype, suppboardid, isnew, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardImport2 (string globaltablename, DataTable map, string arrangementtype, int suppboardid, bool isnew, ref int supplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD__IMPORT2"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  q.q2s(sc, "@arrangementtype", arrangementtype);
  q.q2i(sc, "@suppboardid", suppboardid);
  q.q2b(sc, "@isnew", isnew);
  q.q2i(sc, "@supplierboardid", supplierboardid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   supplierboardid = q.gi(sc,"@supplierboardid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardInfoCurrGet (int supplierboardid, ref DateTime dt, ref string currencycode, ref decimal fxrate, ref decimal fixedfxrate) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardInfoCurrGet (supplierboardid, ref dt, ref currencycode, ref fxrate, ref fixedfxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardInfoCurrGet (int supplierboardid, ref DateTime dt, ref string currencycode, ref decimal fxrate, ref decimal fixedfxrate,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardInfoCurrGet (supplierboardid, ref dt, ref currencycode, ref fxrate, ref fixedfxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardInfoCurrGet (int supplierboardid, ref DateTime dt, ref string currencycode, ref decimal fxrate, ref decimal fixedfxrate,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardInfoCurrGet (supplierboardid, ref dt, ref currencycode, ref fxrate, ref fixedfxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardInfoCurrGet (int supplierboardid, ref DateTime dt, ref string currencycode, ref decimal fxrate, ref decimal fixedfxrate,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD__INFO_CURR_GET"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2d(sc, "@dt", dt);
  q.q2s(sc, "@currencycode", currencycode);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@fixedfxrate", fixedfxrate);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   dt = q.gd(sc,"@dt");
   currencycode = q.gs(sc,"@currencycode");
   fxrate = q.ge(sc,"@fxrate");
   fixedfxrate = q.ge(sc,"@fixedfxrate");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardInfoGet2 (int supplierboardid, ref string arrangementtype, ref string num, ref string suppliername, ref string dealtag) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardInfoGet2 (supplierboardid, ref arrangementtype, ref num, ref suppliername, ref dealtag,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardInfoGet2 (int supplierboardid, ref string arrangementtype, ref string num, ref string suppliername, ref string dealtag,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardInfoGet2 (supplierboardid, ref arrangementtype, ref num, ref suppliername, ref dealtag,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardInfoGet2 (int supplierboardid, ref string arrangementtype, ref string num, ref string suppliername, ref string dealtag,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardInfoGet2 (supplierboardid, ref arrangementtype, ref num, ref suppliername, ref dealtag,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardInfoGet2 (int supplierboardid, ref string arrangementtype, ref string num, ref string suppliername, ref string dealtag,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD__INFO_GET2"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2s(sc, "@arrangementtype", arrangementtype);
  q.q2s(sc, "@num", num);
  q.q2s(sc, "@suppliername", suppliername);
  q.q2s(sc, "@dealtag", dealtag);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   arrangementtype = q.gs(sc,"@arrangementtype");
   num = q.gs(sc,"@num");
   suppliername = q.gs(sc,"@suppliername");
   dealtag = q.gs(sc,"@dealtag");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardPropertiesGet (int supplierboardid, ref string dealtag, ref int sellerid, ref string sellername, ref int supplierid, ref string suppliername, ref decimal recommendedminmargin, ref decimal transportcost, ref string fromcountry, ref string fromyard, ref string tocountry, ref string toyard, ref string approxavailablein, ref decimal registrationcost, ref int pdi, ref int currencyid, ref decimal contractamount, ref decimal vatperc, ref decimal vatamount, ref decimal buffercost, ref int paycurrencyid, ref decimal topayamount, ref decimal fxrate, ref decimal hedgecostperc, ref decimal conversationcostperc, ref decimal vatriskbuffer, ref decimal vatriskbufferperc, ref string note, ref DateTime validtill, ref int holdperiod, ref int preparationperiod, ref decimal cashcost, ref decimal storagecost, ref decimal cashcostpercent, ref int storagecostdays, ref decimal fxrateforpricing, ref int quantity, ref decimal storagecosttotal, ref int registrationperiod) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardPropertiesGet (supplierboardid, ref dealtag, ref sellerid, ref sellername, ref supplierid, ref suppliername, ref recommendedminmargin, ref transportcost, ref fromcountry, ref fromyard, ref tocountry, ref toyard, ref approxavailablein, ref registrationcost, ref pdi, ref currencyid, ref contractamount, ref vatperc, ref vatamount, ref buffercost, ref paycurrencyid, ref topayamount, ref fxrate, ref hedgecostperc, ref conversationcostperc, ref vatriskbuffer, ref vatriskbufferperc, ref note, ref validtill, ref holdperiod, ref preparationperiod, ref cashcost, ref storagecost, ref cashcostpercent, ref storagecostdays, ref fxrateforpricing, ref quantity, ref storagecosttotal, ref registrationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardPropertiesGet (int supplierboardid, ref string dealtag, ref int sellerid, ref string sellername, ref int supplierid, ref string suppliername, ref decimal recommendedminmargin, ref decimal transportcost, ref string fromcountry, ref string fromyard, ref string tocountry, ref string toyard, ref string approxavailablein, ref decimal registrationcost, ref int pdi, ref int currencyid, ref decimal contractamount, ref decimal vatperc, ref decimal vatamount, ref decimal buffercost, ref int paycurrencyid, ref decimal topayamount, ref decimal fxrate, ref decimal hedgecostperc, ref decimal conversationcostperc, ref decimal vatriskbuffer, ref decimal vatriskbufferperc, ref string note, ref DateTime validtill, ref int holdperiod, ref int preparationperiod, ref decimal cashcost, ref decimal storagecost, ref decimal cashcostpercent, ref int storagecostdays, ref decimal fxrateforpricing, ref int quantity, ref decimal storagecosttotal, ref int registrationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardPropertiesGet (supplierboardid, ref dealtag, ref sellerid, ref sellername, ref supplierid, ref suppliername, ref recommendedminmargin, ref transportcost, ref fromcountry, ref fromyard, ref tocountry, ref toyard, ref approxavailablein, ref registrationcost, ref pdi, ref currencyid, ref contractamount, ref vatperc, ref vatamount, ref buffercost, ref paycurrencyid, ref topayamount, ref fxrate, ref hedgecostperc, ref conversationcostperc, ref vatriskbuffer, ref vatriskbufferperc, ref note, ref validtill, ref holdperiod, ref preparationperiod, ref cashcost, ref storagecost, ref cashcostpercent, ref storagecostdays, ref fxrateforpricing, ref quantity, ref storagecosttotal, ref registrationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardPropertiesGet (int supplierboardid, ref string dealtag, ref int sellerid, ref string sellername, ref int supplierid, ref string suppliername, ref decimal recommendedminmargin, ref decimal transportcost, ref string fromcountry, ref string fromyard, ref string tocountry, ref string toyard, ref string approxavailablein, ref decimal registrationcost, ref int pdi, ref int currencyid, ref decimal contractamount, ref decimal vatperc, ref decimal vatamount, ref decimal buffercost, ref int paycurrencyid, ref decimal topayamount, ref decimal fxrate, ref decimal hedgecostperc, ref decimal conversationcostperc, ref decimal vatriskbuffer, ref decimal vatriskbufferperc, ref string note, ref DateTime validtill, ref int holdperiod, ref int preparationperiod, ref decimal cashcost, ref decimal storagecost, ref decimal cashcostpercent, ref int storagecostdays, ref decimal fxrateforpricing, ref int quantity, ref decimal storagecosttotal, ref int registrationperiod,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardPropertiesGet (supplierboardid, ref dealtag, ref sellerid, ref sellername, ref supplierid, ref suppliername, ref recommendedminmargin, ref transportcost, ref fromcountry, ref fromyard, ref tocountry, ref toyard, ref approxavailablein, ref registrationcost, ref pdi, ref currencyid, ref contractamount, ref vatperc, ref vatamount, ref buffercost, ref paycurrencyid, ref topayamount, ref fxrate, ref hedgecostperc, ref conversationcostperc, ref vatriskbuffer, ref vatriskbufferperc, ref note, ref validtill, ref holdperiod, ref preparationperiod, ref cashcost, ref storagecost, ref cashcostpercent, ref storagecostdays, ref fxrateforpricing, ref quantity, ref storagecosttotal, ref registrationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardPropertiesGet (int supplierboardid, ref string dealtag, ref int sellerid, ref string sellername, ref int supplierid, ref string suppliername, ref decimal recommendedminmargin, ref decimal transportcost, ref string fromcountry, ref string fromyard, ref string tocountry, ref string toyard, ref string approxavailablein, ref decimal registrationcost, ref int pdi, ref int currencyid, ref decimal contractamount, ref decimal vatperc, ref decimal vatamount, ref decimal buffercost, ref int paycurrencyid, ref decimal topayamount, ref decimal fxrate, ref decimal hedgecostperc, ref decimal conversationcostperc, ref decimal vatriskbuffer, ref decimal vatriskbufferperc, ref string note, ref DateTime validtill, ref int holdperiod, ref int preparationperiod, ref decimal cashcost, ref decimal storagecost, ref decimal cashcostpercent, ref int storagecostdays, ref decimal fxrateforpricing, ref int quantity, ref decimal storagecosttotal, ref int registrationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD__PROPERTIES_GET"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2s(sc, "@dealtag", dealtag);
  q.q2i(sc, "@sellerid", sellerid);
  q.q2s(sc, "@sellername", sellername);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2s(sc, "@suppliername", suppliername);
  q.q2e(sc, "@recommendedminmargin", recommendedminmargin);
  q.q2e(sc, "@transportcost", transportcost);
  q.q2s(sc, "@fromcountry", fromcountry);
  q.q2s(sc, "@fromyard", fromyard);
  q.q2s(sc, "@tocountry", tocountry);
  q.q2s(sc, "@toyard", toyard);
  q.q2s(sc, "@approxavailablein", approxavailablein);
  q.q2e(sc, "@registrationcost", registrationcost);
  q.q2i(sc, "@pdi", pdi);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@contractamount", contractamount);
  q.q2e(sc, "@vatperc", vatperc);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2e(sc, "@buffercost", buffercost);
  q.q2i(sc, "@paycurrencyid", paycurrencyid);
  q.q2e(sc, "@topayamount", topayamount);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@hedgecostperc", hedgecostperc);
  q.q2e(sc, "@conversationcostperc", conversationcostperc);
  q.q2e(sc, "@vatriskbuffer", vatriskbuffer);
  q.q2e(sc, "@vatriskbufferperc", vatriskbufferperc);
  q.q2s(sc, "@note", note);
  q.q2d(sc, "@validtill", validtill);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2e(sc, "@cashcost", cashcost);
  q.q2e(sc, "@storagecost", storagecost);
  q.q2e(sc, "@cashcostpercent", cashcostpercent);
  q.q2i(sc, "@storagecostdays", storagecostdays);
  q.q2e(sc, "@fxrateforpricing", fxrateforpricing);
  q.q2i(sc, "@quantity", quantity);
  q.q2e(sc, "@storagecosttotal", storagecosttotal);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   dealtag = q.gs(sc,"@dealtag");
   sellerid = q.gi(sc,"@sellerid");
   sellername = q.gs(sc,"@sellername");
   supplierid = q.gi(sc,"@supplierid");
   suppliername = q.gs(sc,"@suppliername");
   recommendedminmargin = q.ge(sc,"@recommendedminmargin");
   transportcost = q.ge(sc,"@transportcost");
   fromcountry = q.gs(sc,"@fromcountry");
   fromyard = q.gs(sc,"@fromyard");
   tocountry = q.gs(sc,"@tocountry");
   toyard = q.gs(sc,"@toyard");
   approxavailablein = q.gs(sc,"@approxavailablein");
   registrationcost = q.ge(sc,"@registrationcost");
   pdi = q.gi(sc,"@pdi");
   currencyid = q.gi(sc,"@currencyid");
   contractamount = q.ge(sc,"@contractamount");
   vatperc = q.ge(sc,"@vatperc");
   vatamount = q.ge(sc,"@vatamount");
   buffercost = q.ge(sc,"@buffercost");
   paycurrencyid = q.gi(sc,"@paycurrencyid");
   topayamount = q.ge(sc,"@topayamount");
   fxrate = q.ge(sc,"@fxrate");
   hedgecostperc = q.ge(sc,"@hedgecostperc");
   conversationcostperc = q.ge(sc,"@conversationcostperc");
   vatriskbuffer = q.ge(sc,"@vatriskbuffer");
   vatriskbufferperc = q.ge(sc,"@vatriskbufferperc");
   note = q.gs(sc,"@note");
   validtill = q.gd(sc,"@validtill");
   holdperiod = q.gi(sc,"@holdperiod");
   preparationperiod = q.gi(sc,"@preparationperiod");
   cashcost = q.ge(sc,"@cashcost");
   storagecost = q.ge(sc,"@storagecost");
   cashcostpercent = q.ge(sc,"@cashcostpercent");
   storagecostdays = q.gi(sc,"@storagecostdays");
   fxrateforpricing = q.ge(sc,"@fxrateforpricing");
   quantity = q.gi(sc,"@quantity");
   storagecosttotal = q.ge(sc,"@storagecosttotal");
   registrationperiod = q.gi(sc,"@registrationperiod");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardPropertiesSet (int supplierboardid, string dealtag, int sellerid, int supplierid, decimal recommendedmargin, string tocountry, string toyard, string fromcountry, string fromyard, decimal pdi, decimal registration, int currencyid, decimal vatperc, decimal vatamount, decimal buffer, int topaycurrencyid, decimal topayamount, decimal fxrate, decimal convertcostperc, decimal hedgecostperc, decimal vatriskbuffer, decimal vatriskbufferperc, DateTime validtill, decimal exchrateforpricing, int holdperiod, int preparationperiod, decimal cashcost, decimal storagecost, decimal cashcostpercent, decimal fxrateforpricing, decimal storagecosttotal, int registrationperiod, decimal vehiclesstoragecost) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardPropertiesSet (supplierboardid, dealtag, sellerid, supplierid, recommendedmargin, tocountry, toyard, fromcountry, fromyard, pdi, registration, currencyid, vatperc, vatamount, buffer, topaycurrencyid, topayamount, fxrate, convertcostperc, hedgecostperc, vatriskbuffer, vatriskbufferperc, validtill, exchrateforpricing, holdperiod, preparationperiod, cashcost, storagecost, cashcostpercent, fxrateforpricing, storagecosttotal, registrationperiod, vehiclesstoragecost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardPropertiesSet (int supplierboardid, string dealtag, int sellerid, int supplierid, decimal recommendedmargin, string tocountry, string toyard, string fromcountry, string fromyard, decimal pdi, decimal registration, int currencyid, decimal vatperc, decimal vatamount, decimal buffer, int topaycurrencyid, decimal topayamount, decimal fxrate, decimal convertcostperc, decimal hedgecostperc, decimal vatriskbuffer, decimal vatriskbufferperc, DateTime validtill, decimal exchrateforpricing, int holdperiod, int preparationperiod, decimal cashcost, decimal storagecost, decimal cashcostpercent, decimal fxrateforpricing, decimal storagecosttotal, int registrationperiod, decimal vehiclesstoragecost,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardPropertiesSet (supplierboardid, dealtag, sellerid, supplierid, recommendedmargin, tocountry, toyard, fromcountry, fromyard, pdi, registration, currencyid, vatperc, vatamount, buffer, topaycurrencyid, topayamount, fxrate, convertcostperc, hedgecostperc, vatriskbuffer, vatriskbufferperc, validtill, exchrateforpricing, holdperiod, preparationperiod, cashcost, storagecost, cashcostpercent, fxrateforpricing, storagecosttotal, registrationperiod, vehiclesstoragecost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardPropertiesSet (int supplierboardid, string dealtag, int sellerid, int supplierid, decimal recommendedmargin, string tocountry, string toyard, string fromcountry, string fromyard, decimal pdi, decimal registration, int currencyid, decimal vatperc, decimal vatamount, decimal buffer, int topaycurrencyid, decimal topayamount, decimal fxrate, decimal convertcostperc, decimal hedgecostperc, decimal vatriskbuffer, decimal vatriskbufferperc, DateTime validtill, decimal exchrateforpricing, int holdperiod, int preparationperiod, decimal cashcost, decimal storagecost, decimal cashcostpercent, decimal fxrateforpricing, decimal storagecosttotal, int registrationperiod, decimal vehiclesstoragecost,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardPropertiesSet (supplierboardid, dealtag, sellerid, supplierid, recommendedmargin, tocountry, toyard, fromcountry, fromyard, pdi, registration, currencyid, vatperc, vatamount, buffer, topaycurrencyid, topayamount, fxrate, convertcostperc, hedgecostperc, vatriskbuffer, vatriskbufferperc, validtill, exchrateforpricing, holdperiod, preparationperiod, cashcost, storagecost, cashcostpercent, fxrateforpricing, storagecosttotal, registrationperiod, vehiclesstoragecost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardPropertiesSet (int supplierboardid, string dealtag, int sellerid, int supplierid, decimal recommendedmargin, string tocountry, string toyard, string fromcountry, string fromyard, decimal pdi, decimal registration, int currencyid, decimal vatperc, decimal vatamount, decimal buffer, int topaycurrencyid, decimal topayamount, decimal fxrate, decimal convertcostperc, decimal hedgecostperc, decimal vatriskbuffer, decimal vatriskbufferperc, DateTime validtill, decimal exchrateforpricing, int holdperiod, int preparationperiod, decimal cashcost, decimal storagecost, decimal cashcostpercent, decimal fxrateforpricing, decimal storagecosttotal, int registrationperiod, decimal vehiclesstoragecost,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD__PROPERTIES_SET"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2s(sc, "@dealtag", dealtag);
  q.q2i(sc, "@sellerid", sellerid);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2e(sc, "@recommendedmargin", recommendedmargin);
  q.q2s(sc, "@tocountry", tocountry);
  q.q2s(sc, "@toyard", toyard);
  q.q2s(sc, "@fromcountry", fromcountry);
  q.q2s(sc, "@fromyard", fromyard);
  q.q2e(sc, "@pdi", pdi);
  q.q2e(sc, "@registration", registration);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@vatperc", vatperc);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2e(sc, "@buffer", buffer);
  q.q2i(sc, "@topaycurrencyid", topaycurrencyid);
  q.q2e(sc, "@topayamount", topayamount);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@convertcostperc", convertcostperc);
  q.q2e(sc, "@hedgecostperc", hedgecostperc);
  q.q2e(sc, "@vatriskbuffer", vatriskbuffer);
  q.q2e(sc, "@vatriskbufferperc", vatriskbufferperc);
  q.q2d(sc, "@validtill", validtill);
  q.q2e(sc, "@exchrateforpricing", exchrateforpricing);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2e(sc, "@cashcost", cashcost);
  q.q2e(sc, "@storagecost", storagecost);
  q.q2e(sc, "@cashcostpercent", cashcostpercent);
  q.q2e(sc, "@fxrateforpricing", fxrateforpricing);
  q.q2e(sc, "@storagecosttotal", storagecosttotal);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2e(sc, "@vehiclesstoragecost", vehiclesstoragecost);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardPurchaseRequestSentSet2 (DataTable manufactureordercontractitemids, int requestno) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardPurchaseRequestSentSet2 (manufactureordercontractitemids, requestno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardPurchaseRequestSentSet2 (DataTable manufactureordercontractitemids, int requestno,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardPurchaseRequestSentSet2 (manufactureordercontractitemids, requestno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardPurchaseRequestSentSet2 (DataTable manufactureordercontractitemids, int requestno,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardPurchaseRequestSentSet2 (manufactureordercontractitemids, requestno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardPurchaseRequestSentSet2 (DataTable manufactureordercontractitemids, int requestno,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD__PURCHASE_REQUEST_SENT_SET2"); 
  q.q2u(sc, "@manufactureordercontractitemids", "eids", manufactureordercontractitemids);
  q.q2i(sc, "@requestno", requestno);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardAddonAdd (int supplierboardid, int addonid, string optiontype) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardAddonAdd (supplierboardid, addonid, optiontype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonAdd (int supplierboardid, int addonid, string optiontype,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardAddonAdd (supplierboardid, addonid, optiontype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonAdd (int supplierboardid, int addonid, string optiontype,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardAddonAdd (supplierboardid, addonid, optiontype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonAdd (int supplierboardid, int addonid, string optiontype,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ADDON__ADD"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@addonid", addonid);
  q.q2s(sc, "@optiontype", optiontype);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardAddonDelete (int supplierboardid, int addonid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardAddonDelete (supplierboardid, addonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonDelete (int supplierboardid, int addonid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardAddonDelete (supplierboardid, addonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonDelete (int supplierboardid, int addonid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardAddonDelete (supplierboardid, addonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonDelete (int supplierboardid, int addonid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ADDON__DELETE"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@addonid", addonid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardAddonsAddVwq (int supplierboardid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardAddonsAddVwq (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonsAddVwq (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardAddonsAddVwq (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonsAddVwq (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardAddonsAddVwq (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonsAddVwq (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ADDONS_ADD_vwq"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardAddonsVw (int supplierboardid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardAddonsVw (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonsVw (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardAddonsVw (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonsVw (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardAddonsVw (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardAddonsVw (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ADDONS_vw"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardContractsVwq (int supplierboardid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardContractsVwq (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardContractsVwq (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardContractsVwq (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardContractsVwq (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardContractsVwq (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardContractsVwq (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_CONTRACTS_vwq"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardFileDirectoriesVw (int supplierboardid, int parentid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardFileDirectoriesVw (supplierboardid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoriesVw (int supplierboardid, int parentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardFileDirectoriesVw (supplierboardid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoriesVw (int supplierboardid, int parentid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardFileDirectoriesVw (supplierboardid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoriesVw (int supplierboardid, int parentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_FILE__DIRECTORIES_vw"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@parentid", parentid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardFileDirectoryDelete (int supplierboardid, int supplierboardfileid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardFileDirectoryDelete (supplierboardid, supplierboardfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoryDelete (int supplierboardid, int supplierboardfileid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardFileDirectoryDelete (supplierboardid, supplierboardfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoryDelete (int supplierboardid, int supplierboardfileid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardFileDirectoryDelete (supplierboardid, supplierboardfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoryDelete (int supplierboardid, int supplierboardfileid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_FILE__DIRECTORY_DELETE"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@supplierboardfileid", supplierboardfileid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardFileDirectoryNew (int supplierboardid, int parentid, ref int newid, ref string newname) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardFileDirectoryNew (supplierboardid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoryNew (int supplierboardid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardFileDirectoryNew (supplierboardid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoryNew (int supplierboardid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardFileDirectoryNew (supplierboardid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoryNew (int supplierboardid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_FILE__DIRECTORY_NEW"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@parentid", parentid);
  q.q2i(sc, "@newid", newid);
  q.q2s(sc, "@newname", newname);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   newid = q.gi(sc,"@newid");
   newname = q.gs(sc,"@newname");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardFileDirectoryRename (int supplierboardid, int supplierboardfileid, string name) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardFileDirectoryRename (supplierboardid, supplierboardfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoryRename (int supplierboardid, int supplierboardfileid, string name,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardFileDirectoryRename (supplierboardid, supplierboardfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoryRename (int supplierboardid, int supplierboardfileid, string name,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardFileDirectoryRename (supplierboardid, supplierboardfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileDirectoryRename (int supplierboardid, int supplierboardfileid, string name,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_FILE__DIRECTORY_RENAME"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@supplierboardfileid", supplierboardfileid);
  q.q2s(sc, "@name", name);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardFileFileAdd (int supplierboardid, int dirsupplierboardfileid, string fn, string ext, byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardFileFileAdd (supplierboardid, dirsupplierboardfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileAdd (int supplierboardid, int dirsupplierboardfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardFileFileAdd (supplierboardid, dirsupplierboardfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileAdd (int supplierboardid, int dirsupplierboardfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardFileFileAdd (supplierboardid, dirsupplierboardfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileAdd (int supplierboardid, int dirsupplierboardfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_FILE__FILE_ADD"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@dirsupplierboardfileid", dirsupplierboardfileid);
  q.q2s(sc, "@fn", fn);
  q.q2s(sc, "@ext", ext);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardFileFileDelete (int supplierboardid, int supplierboardfileid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardFileFileDelete (supplierboardid, supplierboardfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileDelete (int supplierboardid, int supplierboardfileid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardFileFileDelete (supplierboardid, supplierboardfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileDelete (int supplierboardid, int supplierboardfileid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardFileFileDelete (supplierboardid, supplierboardfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileDelete (int supplierboardid, int supplierboardfileid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_FILE__FILE_DELETE"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@supplierboardfileid", supplierboardfileid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardFileFileInfoGet (int supplierboardid, int supplierboardfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardFileFileInfoGet (supplierboardid, supplierboardfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileInfoGet (int supplierboardid, int supplierboardfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardFileFileInfoGet (supplierboardid, supplierboardfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileInfoGet (int supplierboardid, int supplierboardfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardFileFileInfoGet (supplierboardid, supplierboardfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileInfoGet (int supplierboardid, int supplierboardfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_FILE__FILE_INFO_GET"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@supplierboardfileid", supplierboardfileid);
  q.q2s(sc, "@name", name);
  q.q2dt(sc, "@uploaded", uploaded);
  q.q2s(sc, "@type", type);
  q.q2i(sc, "@size", size);
  q.q2s(sc, "@uploadedby", uploadedby);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   name = q.gs(sc,"@name");
   uploaded = q.gdt(sc,"@uploaded");
   type = q.gs(sc,"@type");
   size = q.gi(sc,"@size");
   uploadedby = q.gs(sc,"@uploadedby");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardFileFileOpenGet (int supplierboardid, int supplierboardfileid, ref string fn, ref byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardFileFileOpenGet (supplierboardid, supplierboardfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileOpenGet (int supplierboardid, int supplierboardfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardFileFileOpenGet (supplierboardid, supplierboardfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileOpenGet (int supplierboardid, int supplierboardfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardFileFileOpenGet (supplierboardid, supplierboardfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileOpenGet (int supplierboardid, int supplierboardfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_FILE__FILE_OPEN_GET"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@supplierboardfileid", supplierboardfileid);
  q.q2s(sc, "@fn", fn);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   fn = q.gs(sc,"@fn");
   body = q.ga(sc,"@body");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardFileFileRename (int supplierboardid, int supplierboardfileid, string newfn) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardFileFileRename (supplierboardid, supplierboardfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileRename (int supplierboardid, int supplierboardfileid, string newfn,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardFileFileRename (supplierboardid, supplierboardfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileRename (int supplierboardid, int supplierboardfileid, string newfn,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardFileFileRename (supplierboardid, supplierboardfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFileRename (int supplierboardid, int supplierboardfileid, string newfn,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_FILE__FILE_RENAME"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@supplierboardfileid", supplierboardfileid);
  q.q2s(sc, "@newfn", newfn);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardFileFilesVw (int supplierboardid, int supplierboardfileid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardFileFilesVw (supplierboardid, supplierboardfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFilesVw (int supplierboardid, int supplierboardfileid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardFileFilesVw (supplierboardid, supplierboardfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFilesVw (int supplierboardid, int supplierboardfileid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardFileFilesVw (supplierboardid, supplierboardfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardFileFilesVw (int supplierboardid, int supplierboardfileid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_FILE__FILES_vw"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@supplierboardfileid", supplierboardfileid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemArrangementGet (int supplierboarditem, ref int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemArrangementGet (supplierboarditem, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemArrangementGet (int supplierboarditem, ref int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemArrangementGet (supplierboarditem, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemArrangementGet (int supplierboarditem, ref int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemArrangementGet (supplierboarditem, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemArrangementGet (int supplierboarditem, ref int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM__ARRANGEMENT_GET"); 
  q.q2i(sc, "@supplierboarditem", supplierboarditem);
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   arrangementid = q.gi(sc,"@arrangementid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemEquipmentGet (int supplierboarditemid, ref string equipment) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemEquipmentGet (supplierboarditemid, ref equipment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemEquipmentGet (int supplierboarditemid, ref string equipment,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemEquipmentGet (supplierboarditemid, ref equipment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemEquipmentGet (int supplierboarditemid, ref string equipment,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemEquipmentGet (supplierboarditemid, ref equipment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemEquipmentGet (int supplierboarditemid, ref string equipment,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM__EQUIPMENT_GET"); 
  q.q2i(sc, "@supplierboarditemid", supplierboarditemid);
  q.q2s(sc, "@equipment", equipment);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   equipment = q.gs(sc,"@equipment");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemEquipmentSet (int supplierboarditemid, string equipment) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemEquipmentSet (supplierboarditemid, equipment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemEquipmentSet (int supplierboarditemid, string equipment,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemEquipmentSet (supplierboarditemid, equipment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemEquipmentSet (int supplierboarditemid, string equipment,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemEquipmentSet (supplierboarditemid, equipment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemEquipmentSet (int supplierboarditemid, string equipment,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM__EQUIPMENT_SET"); 
  q.q2i(sc, "@supplierboarditemid", supplierboarditemid);
  q.q2s(sc, "@equipment", equipment);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemNoteGet (int supplierboarditemid, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemNoteGet (supplierboarditemid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemNoteGet (int supplierboarditemid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemNoteGet (supplierboarditemid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemNoteGet (int supplierboarditemid, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemNoteGet (supplierboarditemid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemNoteGet (int supplierboarditemid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM__NOTE_GET"); 
  q.q2i(sc, "@supplierboarditemid", supplierboarditemid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemNoteSet (int supplierboarditemid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemNoteSet (supplierboarditemid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemNoteSet (int supplierboarditemid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemNoteSet (supplierboarditemid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemNoteSet (int supplierboarditemid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemNoteSet (supplierboarditemid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemNoteSet (int supplierboarditemid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM__NOTE_SET"); 
  q.q2i(sc, "@supplierboarditemid", supplierboarditemid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemUpdate (int supplierboarditemid, int quantity, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemUpdate (supplierboarditemid, quantity, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemUpdate (int supplierboarditemid, int quantity, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemUpdate (supplierboarditemid, quantity, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemUpdate (int supplierboarditemid, int quantity, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemUpdate (supplierboarditemid, quantity, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemUpdate (int supplierboarditemid, int quantity, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM__UPDATE"); 
  q.q2i(sc, "@supplierboarditemid", supplierboarditemid);
  q.q2i(sc, "@quantity", quantity);
  q.q2e(sc, "@baseprice", baseprice);
  q.q2e(sc, "@buffer", buffer);
  q.q2e(sc, "@transport", transport);
  q.q2e(sc, "@registration", registration);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2d(sc, "@eta", eta);
  q.q2e(sc, "@storagecost", storagecost);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@wltp", wltp);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2i(sc, "@mileage", mileage);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2e(sc, "@damage", damage);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemUpdate8 (int supplierboarditemid, int quantity, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemUpdate8 (supplierboarditemid, quantity, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemUpdate8 (int supplierboarditemid, int quantity, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemUpdate8 (supplierboarditemid, quantity, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemUpdate8 (int supplierboarditemid, int quantity, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemUpdate8 (supplierboarditemid, quantity, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemUpdate8 (int supplierboarditemid, int quantity, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM__UPDATE8"); 
  q.q2i(sc, "@supplierboarditemid", supplierboarditemid);
  q.q2i(sc, "@quantity", quantity);
  q.q2e(sc, "@baseprice", baseprice);
  q.q2e(sc, "@buffer", buffer);
  q.q2e(sc, "@transport", transport);
  q.q2e(sc, "@registration", registration);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2d(sc, "@eta", eta);
  q.q2e(sc, "@storagecost", storagecost);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@wltp", wltp);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2i(sc, "@mileage", mileage);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2e(sc, "@damage", damage);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemAddonAdd (int supplierboarditemid, int addonid, string optiontype) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemAddonAdd (supplierboarditemid, addonid, optiontype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonAdd (int supplierboarditemid, int addonid, string optiontype,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemAddonAdd (supplierboarditemid, addonid, optiontype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonAdd (int supplierboarditemid, int addonid, string optiontype,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemAddonAdd (supplierboarditemid, addonid, optiontype,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonAdd (int supplierboarditemid, int addonid, string optiontype,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM_ADDON_ADD"); 
  q.q2i(sc, "@supplierboarditemid", supplierboarditemid);
  q.q2i(sc, "@addonid", addonid);
  q.q2s(sc, "@optiontype", optiontype);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemAddonDelete (int supplierboarditemaddonid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemAddonDelete (supplierboarditemaddonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonDelete (int supplierboarditemaddonid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemAddonDelete (supplierboarditemaddonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonDelete (int supplierboarditemaddonid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemAddonDelete (supplierboarditemaddonid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonDelete (int supplierboarditemaddonid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM_ADDON_DELETE"); 
  q.q2i(sc, "@supplierboarditemaddonid", supplierboarditemaddonid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemAddonsRemoveVwq (int supplierboarditemid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemAddonsRemoveVwq (supplierboarditemid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonsRemoveVwq (int supplierboarditemid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemAddonsRemoveVwq (supplierboarditemid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonsRemoveVwq (int supplierboarditemid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemAddonsRemoveVwq (supplierboarditemid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonsRemoveVwq (int supplierboarditemid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM_ADDONS_REMOVE_vwq"); 
  q.q2i(sc, "@supplierboarditemid", supplierboarditemid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemAddonsVw (int supplierboardid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemAddonsVw (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonsVw (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemAddonsVw (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonsVw (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemAddonsVw (supplierboardid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonsVw (int supplierboardid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM_ADDONS_vw"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemAddonsVwq (int supplierboarditemid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemAddonsVwq (supplierboarditemid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonsVwq (int supplierboarditemid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemAddonsVwq (supplierboarditemid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonsVwq (int supplierboarditemid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemAddonsVwq (supplierboarditemid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemAddonsVwq (int supplierboarditemid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM_ADDONS_vwq"); 
  q.q2i(sc, "@supplierboarditemid", supplierboarditemid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemPropertiesGet (DataTable supplierboarditemids, ref decimal baseprice, ref decimal buffer, ref decimal transport, ref decimal registration, ref int qtyintruck, ref DateTime eta, ref decimal storagecost, ref string modelname, ref string wltp, ref string modelcode, ref int mileage, ref DateTime firstregistration, ref decimal damage) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemPropertiesGet (supplierboarditemids, ref baseprice, ref buffer, ref transport, ref registration, ref qtyintruck, ref eta, ref storagecost, ref modelname, ref wltp, ref modelcode, ref mileage, ref firstregistration, ref damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemPropertiesGet (DataTable supplierboarditemids, ref decimal baseprice, ref decimal buffer, ref decimal transport, ref decimal registration, ref int qtyintruck, ref DateTime eta, ref decimal storagecost, ref string modelname, ref string wltp, ref string modelcode, ref int mileage, ref DateTime firstregistration, ref decimal damage,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemPropertiesGet (supplierboarditemids, ref baseprice, ref buffer, ref transport, ref registration, ref qtyintruck, ref eta, ref storagecost, ref modelname, ref wltp, ref modelcode, ref mileage, ref firstregistration, ref damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemPropertiesGet (DataTable supplierboarditemids, ref decimal baseprice, ref decimal buffer, ref decimal transport, ref decimal registration, ref int qtyintruck, ref DateTime eta, ref decimal storagecost, ref string modelname, ref string wltp, ref string modelcode, ref int mileage, ref DateTime firstregistration, ref decimal damage,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemPropertiesGet (supplierboarditemids, ref baseprice, ref buffer, ref transport, ref registration, ref qtyintruck, ref eta, ref storagecost, ref modelname, ref wltp, ref modelcode, ref mileage, ref firstregistration, ref damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemPropertiesGet (DataTable supplierboarditemids, ref decimal baseprice, ref decimal buffer, ref decimal transport, ref decimal registration, ref int qtyintruck, ref DateTime eta, ref decimal storagecost, ref string modelname, ref string wltp, ref string modelcode, ref int mileage, ref DateTime firstregistration, ref decimal damage,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM_PROPERTIES__GET"); 
  q.q2u(sc, "@supplierboarditemids", "eids", supplierboarditemids);
  q.q2e(sc, "@baseprice", baseprice);
  q.q2e(sc, "@buffer", buffer);
  q.q2e(sc, "@transport", transport);
  q.q2e(sc, "@registration", registration);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2d(sc, "@eta", eta);
  q.q2e(sc, "@storagecost", storagecost);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@wltp", wltp);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2i(sc, "@mileage", mileage);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2e(sc, "@damage", damage);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   baseprice = q.ge(sc,"@baseprice");
   buffer = q.ge(sc,"@buffer");
   transport = q.ge(sc,"@transport");
   registration = q.ge(sc,"@registration");
   qtyintruck = q.gi(sc,"@qtyintruck");
   eta = q.gd(sc,"@eta");
   storagecost = q.ge(sc,"@storagecost");
   modelname = q.gs(sc,"@modelname");
   wltp = q.gs(sc,"@wltp");
   modelcode = q.gs(sc,"@modelcode");
   mileage = q.gi(sc,"@mileage");
   firstregistration = q.gd(sc,"@firstregistration");
   damage = q.ge(sc,"@damage");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemPropertiesUpdate (DataTable supplierboarditemids, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemPropertiesUpdate (supplierboarditemids, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemPropertiesUpdate (DataTable supplierboarditemids, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemPropertiesUpdate (supplierboarditemids, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemPropertiesUpdate (DataTable supplierboarditemids, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemPropertiesUpdate (supplierboarditemids, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemPropertiesUpdate (DataTable supplierboarditemids, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM_PROPERTIES__UPDATE"); 
  q.q2u(sc, "@supplierboarditemids", "eids", supplierboarditemids);
  q.q2e(sc, "@baseprice", baseprice);
  q.q2e(sc, "@buffer", buffer);
  q.q2e(sc, "@transport", transport);
  q.q2e(sc, "@registration", registration);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2d(sc, "@eta", eta);
  q.q2e(sc, "@storagecost", storagecost);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@wltp", wltp);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2i(sc, "@mileage", mileage);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2e(sc, "@damage", damage);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemPropertiesUpdate2 (DataTable supplierboarditemids, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage, string availabletoaddnote, string remarksnote, string basicequipmentnote) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemPropertiesUpdate2 (supplierboarditemids, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage, availabletoaddnote, remarksnote, basicequipmentnote,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemPropertiesUpdate2 (DataTable supplierboarditemids, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage, string availabletoaddnote, string remarksnote, string basicequipmentnote,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemPropertiesUpdate2 (supplierboarditemids, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage, availabletoaddnote, remarksnote, basicequipmentnote,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemPropertiesUpdate2 (DataTable supplierboarditemids, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage, string availabletoaddnote, string remarksnote, string basicequipmentnote,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemPropertiesUpdate2 (supplierboarditemids, baseprice, buffer, transport, registration, qtyintruck, eta, storagecost, modelname, wltp, modelcode, mileage, firstregistration, damage, availabletoaddnote, remarksnote, basicequipmentnote,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemPropertiesUpdate2 (DataTable supplierboarditemids, decimal baseprice, decimal buffer, decimal transport, decimal registration, int qtyintruck, DateTime eta, decimal storagecost, string modelname, string wltp, string modelcode, int mileage, DateTime firstregistration, decimal damage, string availabletoaddnote, string remarksnote, string basicequipmentnote,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM_PROPERTIES__UPDATE2"); 
  q.q2u(sc, "@supplierboarditemids", "eids", supplierboarditemids);
  q.q2e(sc, "@baseprice", baseprice);
  q.q2e(sc, "@buffer", buffer);
  q.q2e(sc, "@transport", transport);
  q.q2e(sc, "@registration", registration);
  q.q2i(sc, "@qtyintruck", qtyintruck);
  q.q2d(sc, "@eta", eta);
  q.q2e(sc, "@storagecost", storagecost);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@wltp", wltp);
  q.q2s(sc, "@modelcode", modelcode);
  q.q2i(sc, "@mileage", mileage);
  q.q2d(sc, "@firstregistration", firstregistration);
  q.q2e(sc, "@damage", damage);
  q.q2s(sc, "@availabletoaddnote", availabletoaddnote);
  q.q2s(sc, "@remarksnote", remarksnote);
  q.q2s(sc, "@basicequipmentnote", basicequipmentnote);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemSupplierSet (int supplierboardid, int supplierid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemSupplierSet (supplierboardid, supplierid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemSupplierSet (int supplierboardid, int supplierid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemSupplierSet (supplierboardid, supplierid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemSupplierSet (int supplierboardid, int supplierid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemSupplierSet (supplierboardid, supplierid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemSupplierSet (int supplierboardid, int supplierid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM_SUPPLIER_SET"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@supplierid", supplierid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemVehicleVinSet (int supplierboarditemvehicleid, string vin) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemVehicleVinSet (supplierboarditemvehicleid, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemVehicleVinSet (int supplierboarditemvehicleid, string vin,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemVehicleVinSet (supplierboarditemvehicleid, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemVehicleVinSet (int supplierboarditemvehicleid, string vin,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemVehicleVinSet (supplierboarditemvehicleid, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemVehicleVinSet (int supplierboarditemvehicleid, string vin,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM_VEHICLE__VIN_SET"); 
  q.q2i(sc, "@supplierboarditemvehicleid", supplierboarditemvehicleid);
  q.q2s(sc, "@vin", vin);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemVehiclesVw (int supplierboarditemid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemVehiclesVw (supplierboarditemid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemVehiclesVw (int supplierboarditemid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemVehiclesVw (supplierboarditemid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemVehiclesVw (int supplierboarditemid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemVehiclesVw (supplierboarditemid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemVehiclesVw (int supplierboarditemid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEM_VEHICLES_vw"); 
  q.q2i(sc, "@supplierboarditemid", supplierboarditemid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemsDuplicate (int supplierboardid, DataTable supplierboarditemids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemsDuplicate (supplierboardid, supplierboarditemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemsDuplicate (int supplierboardid, DataTable supplierboarditemids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemsDuplicate (supplierboardid, supplierboarditemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemsDuplicate (int supplierboardid, DataTable supplierboarditemids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemsDuplicate (supplierboardid, supplierboarditemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemsDuplicate (int supplierboardid, DataTable supplierboarditemids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEMS__DUPLICATE"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2u(sc, "@supplierboarditemids", "eids", supplierboarditemids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemsArrangementsCreate (DataTable supplierboarditemids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemsArrangementsCreate (supplierboarditemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemsArrangementsCreate (DataTable supplierboarditemids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemsArrangementsCreate (supplierboarditemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemsArrangementsCreate (DataTable supplierboarditemids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemsArrangementsCreate (supplierboarditemids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemsArrangementsCreate (DataTable supplierboarditemids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEMS_ARRANGEMENTS_CREATE"); 
  q.q2u(sc, "@supplierboarditemids", "eids", supplierboarditemids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardItemsVw (int supplierboardid, decimal usecurrencyexchangerate, ref int supplierboardnum, ref string contractcurrencycode, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardItemsVw (supplierboardid, usecurrencyexchangerate, ref supplierboardnum, ref contractcurrencycode, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemsVw (int supplierboardid, decimal usecurrencyexchangerate, ref int supplierboardnum, ref string contractcurrencycode, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardItemsVw (supplierboardid, usecurrencyexchangerate, ref supplierboardnum, ref contractcurrencycode, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemsVw (int supplierboardid, decimal usecurrencyexchangerate, ref int supplierboardnum, ref string contractcurrencycode, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardItemsVw (supplierboardid, usecurrencyexchangerate, ref supplierboardnum, ref contractcurrencycode, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardItemsVw (int supplierboardid, decimal usecurrencyexchangerate, ref int supplierboardnum, ref string contractcurrencycode, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_ITEMS_vw"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2e(sc, "@usecurrencyexchangerate", usecurrencyexchangerate);
  q.q2i(sc, "@supplierboardnum", supplierboardnum);
  q.q2s(sc, "@contractcurrencycode", contractcurrencycode);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   supplierboardnum = q.gi(sc,"@supplierboardnum");
   contractcurrencycode = q.gs(sc,"@contractcurrencycode");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardModelAdd (int supplierboardid, int brandmodelnameid, string arrangementtype, ref int newsupplierboardid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardModelAdd (supplierboardid, brandmodelnameid, arrangementtype, ref newsupplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardModelAdd (int supplierboardid, int brandmodelnameid, string arrangementtype, ref int newsupplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardModelAdd (supplierboardid, brandmodelnameid, arrangementtype, ref newsupplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardModelAdd (int supplierboardid, int brandmodelnameid, string arrangementtype, ref int newsupplierboardid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardModelAdd (supplierboardid, brandmodelnameid, arrangementtype, ref newsupplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardModelAdd (int supplierboardid, int brandmodelnameid, string arrangementtype, ref int newsupplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_MODEL_ADD"); 
  q.q2i(sc, "@supplierboardid", supplierboardid);
  q.q2i(sc, "@brandmodelnameid", brandmodelnameid);
  q.q2s(sc, "@arrangementtype", arrangementtype);
  q.q2i(sc, "@newsupplierboardid", newsupplierboardid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   newsupplierboardid = q.gi(sc,"@newsupplierboardid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardModelDelete (int supplierboarditemid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardModelDelete (supplierboarditemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardModelDelete (int supplierboarditemid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardModelDelete (supplierboarditemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardModelDelete (int supplierboarditemid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardModelDelete (supplierboarditemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardModelDelete (int supplierboarditemid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_MODEL_DELETE"); 
  q.q2i(sc, "@supplierboarditemid", supplierboarditemid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardModelsOmVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardModelsOmVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardModelsOmVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardModelsOmVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardModelsOmVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardModelsOmVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardModelsOmVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_MODELS_OM_vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardSellersVwq (bool forbinding, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardSellersVwq (forbinding, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardSellersVwq (bool forbinding, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardSellersVwq (forbinding, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardSellersVwq (bool forbinding, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardSellersVwq (forbinding, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardSellersVwq (bool forbinding, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_SELLERS_vwq"); 
  q.q2b(sc, "@forbinding", forbinding);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardSupplierSet (DataTable supplierboardids, int supplierid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardSupplierSet (supplierboardids, supplierid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardSupplierSet (DataTable supplierboardids, int supplierid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardSupplierSet (supplierboardids, supplierid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardSupplierSet (DataTable supplierboardids, int supplierid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardSupplierSet (supplierboardids, supplierid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardSupplierSet (DataTable supplierboardids, int supplierid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_SUPPLIER_SET"); 
  q.q2u(sc, "@supplierboardids", "eids", supplierboardids);
  q.q2i(sc, "@supplierid", supplierid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardSuppliersVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardSuppliersVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardSuppliersVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardSuppliersVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardSuppliersVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardSuppliersVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardSuppliersVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_SUPPLIERS_vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardVw (int viewindex, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardVw (viewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardVw (int viewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARD_vw"); 
  q.q2i(sc, "@viewindex", viewindex);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardsCopy (DataTable supplierboardids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardsCopy (supplierboardids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardsCopy (DataTable supplierboardids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardsCopy (supplierboardids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardsCopy (DataTable supplierboardids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardsCopy (supplierboardids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardsCopy (DataTable supplierboardids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARDS__COPY"); 
  q.q2u(sc, "@supplierboardids", "eids", supplierboardids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierBoardsMerge (DataTable supplierboardids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierBoardsMerge (supplierboardids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardsMerge (DataTable supplierboardids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierBoardsMerge (supplierboardids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardsMerge (DataTable supplierboardids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierBoardsMerge (supplierboardids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierBoardsMerge (DataTable supplierboardids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_BOARDS__MERGE"); 
  q.q2u(sc, "@supplierboardids", "eids", supplierboardids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractAdvancePrepaymentGet (int suppliercontractid, ref decimal advanceprepayment) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractAdvancePrepaymentGet (suppliercontractid, ref advanceprepayment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractAdvancePrepaymentGet (int suppliercontractid, ref decimal advanceprepayment,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractAdvancePrepaymentGet (suppliercontractid, ref advanceprepayment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractAdvancePrepaymentGet (int suppliercontractid, ref decimal advanceprepayment,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractAdvancePrepaymentGet (suppliercontractid, ref advanceprepayment,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractAdvancePrepaymentGet (int suppliercontractid, ref decimal advanceprepayment,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__ADVANCE_PREPAYMENT_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2e(sc, "@advanceprepayment", advanceprepayment);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   advanceprepayment = q.ge(sc,"@advanceprepayment");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractAmountsGet (int suppliercontractid, ref decimal amount, ref decimal vatamount, ref decimal totalamount) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractAmountsGet (suppliercontractid, ref amount, ref vatamount, ref totalamount,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractAmountsGet (int suppliercontractid, ref decimal amount, ref decimal vatamount, ref decimal totalamount,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractAmountsGet (suppliercontractid, ref amount, ref vatamount, ref totalamount,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractAmountsGet (int suppliercontractid, ref decimal amount, ref decimal vatamount, ref decimal totalamount,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractAmountsGet (suppliercontractid, ref amount, ref vatamount, ref totalamount,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractAmountsGet (int suppliercontractid, ref decimal amount, ref decimal vatamount, ref decimal totalamount,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__AMOUNTS_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2e(sc, "@totalamount", totalamount);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   amount = q.ge(sc,"@amount");
   vatamount = q.ge(sc,"@vatamount");
   totalamount = q.ge(sc,"@totalamount");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractArrangementVehiclesVwq (int suppliercontractid, int suppliervehicleloadid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractArrangementVehiclesVwq (suppliercontractid, suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractArrangementVehiclesVwq (int suppliercontractid, int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractArrangementVehiclesVwq (suppliercontractid, suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractArrangementVehiclesVwq (int suppliercontractid, int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractArrangementVehiclesVwq (suppliercontractid, suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractArrangementVehiclesVwq (int suppliercontractid, int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__ARRANGEMENT_VEHICLES_vwq"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractBoardIdGet (int suppliercontractid, ref int supplierboardid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractBoardIdGet (suppliercontractid, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractBoardIdGet (int suppliercontractid, ref int supplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractBoardIdGet (suppliercontractid, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractBoardIdGet (int suppliercontractid, ref int supplierboardid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractBoardIdGet (suppliercontractid, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractBoardIdGet (int suppliercontractid, ref int supplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__BOARD_ID_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@supplierboardid", supplierboardid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   supplierboardid = q.gi(sc,"@supplierboardid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractBoardIdGetFromArrangementVehicle (int arrangementvehicleid, ref int supplierboardid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractBoardIdGetFromArrangementVehicle (arrangementvehicleid, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractBoardIdGetFromArrangementVehicle (int arrangementvehicleid, ref int supplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractBoardIdGetFromArrangementVehicle (arrangementvehicleid, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractBoardIdGetFromArrangementVehicle (int arrangementvehicleid, ref int supplierboardid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractBoardIdGetFromArrangementVehicle (arrangementvehicleid, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractBoardIdGetFromArrangementVehicle (int arrangementvehicleid, ref int supplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__BOARD_ID_GET_FROM_ARRANGEMENT_VEHICLE"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2i(sc, "@supplierboardid", supplierboardid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   supplierboardid = q.gi(sc,"@supplierboardid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractBoardIdGetFromManufactureOrder (int manufactureordercontractitemid, ref int supplierboardid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractBoardIdGetFromManufactureOrder (manufactureordercontractitemid, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractBoardIdGetFromManufactureOrder (int manufactureordercontractitemid, ref int supplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractBoardIdGetFromManufactureOrder (manufactureordercontractitemid, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractBoardIdGetFromManufactureOrder (int manufactureordercontractitemid, ref int supplierboardid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractBoardIdGetFromManufactureOrder (manufactureordercontractitemid, ref supplierboardid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractBoardIdGetFromManufactureOrder (int manufactureordercontractitemid, ref int supplierboardid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__BOARD_ID_GET_FROM_MANUFACTURE_ORDER"); 
  q.q2i(sc, "@manufactureordercontractitemid", manufactureordercontractitemid);
  q.q2i(sc, "@supplierboardid", supplierboardid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   supplierboardid = q.gi(sc,"@supplierboardid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractCancel2 (int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractCancel2 (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractCancel2 (int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractCancel2 (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractCancel2 (int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractCancel2 (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractCancel2 (int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__CANCEL2"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractContractItemsAdd (string num, DateTime dt, int purchaserid, int supplierid, int pickupcountry, decimal advanceprepayment, decimal advanceprepaymentperc, bool vatincluded, decimal vatamount, decimal vatperc, string note, string modelname, string ordertype, string documentsinfo, string hedgeno, DataTable manufactureordercontractitemids, decimal fxrate, DateTime plannedproductionat, int registrationperiod, int holdperiod, DateTime estimatedat, bool delaydeduction, decimal exchrateforpricing, decimal amount, decimal totalamount, int quantity, int paycurrencyid, DateTime prepaymentdt, int documentholdperiod, bool deliveringtoclient, bool deliveringtoyard, int yardcountryid, int regperiod, DateTime loadingfromsupplierat, decimal conversationcostperc, bool registrationincluded, bool pdiincluded, int registrationcountryid, int transportationperiod, int staffid, string invoicesavailableafterpayment, bool issupplierhold, int companygroupid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractContractItemsAdd (num, dt, purchaserid, supplierid, pickupcountry, advanceprepayment, advanceprepaymentperc, vatincluded, vatamount, vatperc, note, modelname, ordertype, documentsinfo, hedgeno, manufactureordercontractitemids, fxrate, plannedproductionat, registrationperiod, holdperiod, estimatedat, delaydeduction, exchrateforpricing, amount, totalamount, quantity, paycurrencyid, prepaymentdt, documentholdperiod, deliveringtoclient, deliveringtoyard, yardcountryid, regperiod, loadingfromsupplierat, conversationcostperc, registrationincluded, pdiincluded, registrationcountryid, transportationperiod, staffid, invoicesavailableafterpayment, issupplierhold, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractContractItemsAdd (string num, DateTime dt, int purchaserid, int supplierid, int pickupcountry, decimal advanceprepayment, decimal advanceprepaymentperc, bool vatincluded, decimal vatamount, decimal vatperc, string note, string modelname, string ordertype, string documentsinfo, string hedgeno, DataTable manufactureordercontractitemids, decimal fxrate, DateTime plannedproductionat, int registrationperiod, int holdperiod, DateTime estimatedat, bool delaydeduction, decimal exchrateforpricing, decimal amount, decimal totalamount, int quantity, int paycurrencyid, DateTime prepaymentdt, int documentholdperiod, bool deliveringtoclient, bool deliveringtoyard, int yardcountryid, int regperiod, DateTime loadingfromsupplierat, decimal conversationcostperc, bool registrationincluded, bool pdiincluded, int registrationcountryid, int transportationperiod, int staffid, string invoicesavailableafterpayment, bool issupplierhold, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractContractItemsAdd (num, dt, purchaserid, supplierid, pickupcountry, advanceprepayment, advanceprepaymentperc, vatincluded, vatamount, vatperc, note, modelname, ordertype, documentsinfo, hedgeno, manufactureordercontractitemids, fxrate, plannedproductionat, registrationperiod, holdperiod, estimatedat, delaydeduction, exchrateforpricing, amount, totalamount, quantity, paycurrencyid, prepaymentdt, documentholdperiod, deliveringtoclient, deliveringtoyard, yardcountryid, regperiod, loadingfromsupplierat, conversationcostperc, registrationincluded, pdiincluded, registrationcountryid, transportationperiod, staffid, invoicesavailableafterpayment, issupplierhold, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractContractItemsAdd (string num, DateTime dt, int purchaserid, int supplierid, int pickupcountry, decimal advanceprepayment, decimal advanceprepaymentperc, bool vatincluded, decimal vatamount, decimal vatperc, string note, string modelname, string ordertype, string documentsinfo, string hedgeno, DataTable manufactureordercontractitemids, decimal fxrate, DateTime plannedproductionat, int registrationperiod, int holdperiod, DateTime estimatedat, bool delaydeduction, decimal exchrateforpricing, decimal amount, decimal totalamount, int quantity, int paycurrencyid, DateTime prepaymentdt, int documentholdperiod, bool deliveringtoclient, bool deliveringtoyard, int yardcountryid, int regperiod, DateTime loadingfromsupplierat, decimal conversationcostperc, bool registrationincluded, bool pdiincluded, int registrationcountryid, int transportationperiod, int staffid, string invoicesavailableafterpayment, bool issupplierhold, int companygroupid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractContractItemsAdd (num, dt, purchaserid, supplierid, pickupcountry, advanceprepayment, advanceprepaymentperc, vatincluded, vatamount, vatperc, note, modelname, ordertype, documentsinfo, hedgeno, manufactureordercontractitemids, fxrate, plannedproductionat, registrationperiod, holdperiod, estimatedat, delaydeduction, exchrateforpricing, amount, totalamount, quantity, paycurrencyid, prepaymentdt, documentholdperiod, deliveringtoclient, deliveringtoyard, yardcountryid, regperiod, loadingfromsupplierat, conversationcostperc, registrationincluded, pdiincluded, registrationcountryid, transportationperiod, staffid, invoicesavailableafterpayment, issupplierhold, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractContractItemsAdd (string num, DateTime dt, int purchaserid, int supplierid, int pickupcountry, decimal advanceprepayment, decimal advanceprepaymentperc, bool vatincluded, decimal vatamount, decimal vatperc, string note, string modelname, string ordertype, string documentsinfo, string hedgeno, DataTable manufactureordercontractitemids, decimal fxrate, DateTime plannedproductionat, int registrationperiod, int holdperiod, DateTime estimatedat, bool delaydeduction, decimal exchrateforpricing, decimal amount, decimal totalamount, int quantity, int paycurrencyid, DateTime prepaymentdt, int documentholdperiod, bool deliveringtoclient, bool deliveringtoyard, int yardcountryid, int regperiod, DateTime loadingfromsupplierat, decimal conversationcostperc, bool registrationincluded, bool pdiincluded, int registrationcountryid, int transportationperiod, int staffid, string invoicesavailableafterpayment, bool issupplierhold, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__CONTRACT_ITEMS_ADD"); 
  q.q2s(sc, "@num", num);
  q.q2d(sc, "@dt", dt);
  q.q2i(sc, "@purchaserid", purchaserid);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@pickupcountry", pickupcountry);
  q.q2e(sc, "@advanceprepayment", advanceprepayment);
  q.q2e(sc, "@advanceprepaymentperc", advanceprepaymentperc);
  q.q2b(sc, "@vatincluded", vatincluded);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2e(sc, "@vatperc", vatperc);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@ordertype", ordertype);
  q.q2s(sc, "@documentsinfo", documentsinfo);
  q.q2s(sc, "@hedgeno", hedgeno);
  q.q2u(sc, "@manufactureordercontractitemids", "eids", manufactureordercontractitemids);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2d(sc, "@plannedproductionat", plannedproductionat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2d(sc, "@estimatedat", estimatedat);
  q.q2b(sc, "@delaydeduction", delaydeduction);
  q.q2e(sc, "@exchrateforpricing", exchrateforpricing);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@totalamount", totalamount);
  q.q2i(sc, "@quantity", quantity);
  q.q2i(sc, "@paycurrencyid", paycurrencyid);
  q.q2d(sc, "@prepaymentdt", prepaymentdt);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2b(sc, "@deliveringtoclient", deliveringtoclient);
  q.q2b(sc, "@deliveringtoyard", deliveringtoyard);
  q.q2i(sc, "@yardcountryid", yardcountryid);
  q.q2i(sc, "@regperiod", regperiod);
  q.q2d(sc, "@loadingfromsupplierat", loadingfromsupplierat);
  q.q2e(sc, "@conversationcostperc", conversationcostperc);
  q.q2b(sc, "@registrationincluded", registrationincluded);
  q.q2b(sc, "@pdiincluded", pdiincluded);
  q.q2i(sc, "@registrationcountryid", registrationcountryid);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  q.q2i(sc, "@staffid", staffid);
  q.q2s(sc, "@invoicesavailableafterpayment", invoicesavailableafterpayment);
  q.q2b(sc, "@issupplierhold", issupplierhold);
  q.q2i(sc, "@companygroupid", companygroupid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractDelete (int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractDelete (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractDelete (int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractDelete (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractDelete (int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractDelete (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractDelete (int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__DELETE"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractIdGetFromManufactureOrder (int manufactureordercontractitemid, ref int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractIdGetFromManufactureOrder (manufactureordercontractitemid, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractIdGetFromManufactureOrder (int manufactureordercontractitemid, ref int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractIdGetFromManufactureOrder (manufactureordercontractitemid, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractIdGetFromManufactureOrder (int manufactureordercontractitemid, ref int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractIdGetFromManufactureOrder (manufactureordercontractitemid, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractIdGetFromManufactureOrder (int manufactureordercontractitemid, ref int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__ID_GET_FROM_MANUFACTURE_ORDER"); 
  q.q2i(sc, "@manufactureordercontractitemid", manufactureordercontractitemid);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   suppliercontractid = q.gi(sc,"@suppliercontractid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractInfoGet (int suppliercontractid, ref DateTime plannedproductionat, ref int registrationperiod, ref int holdperiod, ref int documentholdperiod, ref int regperiod, ref DateTime loadingfromsupplierat) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractInfoGet (suppliercontractid, ref plannedproductionat, ref registrationperiod, ref holdperiod, ref documentholdperiod, ref regperiod, ref loadingfromsupplierat,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractInfoGet (int suppliercontractid, ref DateTime plannedproductionat, ref int registrationperiod, ref int holdperiod, ref int documentholdperiod, ref int regperiod, ref DateTime loadingfromsupplierat,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractInfoGet (suppliercontractid, ref plannedproductionat, ref registrationperiod, ref holdperiod, ref documentholdperiod, ref regperiod, ref loadingfromsupplierat,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractInfoGet (int suppliercontractid, ref DateTime plannedproductionat, ref int registrationperiod, ref int holdperiod, ref int documentholdperiod, ref int regperiod, ref DateTime loadingfromsupplierat,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractInfoGet (suppliercontractid, ref plannedproductionat, ref registrationperiod, ref holdperiod, ref documentholdperiod, ref regperiod, ref loadingfromsupplierat,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractInfoGet (int suppliercontractid, ref DateTime plannedproductionat, ref int registrationperiod, ref int holdperiod, ref int documentholdperiod, ref int regperiod, ref DateTime loadingfromsupplierat,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__INFO_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2d(sc, "@plannedproductionat", plannedproductionat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2i(sc, "@regperiod", regperiod);
  q.q2d(sc, "@loadingfromsupplierat", loadingfromsupplierat);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   plannedproductionat = q.gd(sc,"@plannedproductionat");
   registrationperiod = q.gi(sc,"@registrationperiod");
   holdperiod = q.gi(sc,"@holdperiod");
   documentholdperiod = q.gi(sc,"@documentholdperiod");
   regperiod = q.gi(sc,"@regperiod");
   loadingfromsupplierat = q.gd(sc,"@loadingfromsupplierat");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractInfoRenewedSet (int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractInfoRenewedSet (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractInfoRenewedSet (int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractInfoRenewedSet (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractInfoRenewedSet (int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractInfoRenewedSet (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractInfoRenewedSet (int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__INFO_RENEWED_SET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractInlineUpdate (int suppliercontractid, DateTime hedgedeadline) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractInlineUpdate (suppliercontractid, hedgedeadline,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractInlineUpdate (int suppliercontractid, DateTime hedgedeadline,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractInlineUpdate (suppliercontractid, hedgedeadline,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractInlineUpdate (int suppliercontractid, DateTime hedgedeadline,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractInlineUpdate (suppliercontractid, hedgedeadline,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractInlineUpdate (int suppliercontractid, DateTime hedgedeadline,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__INLINE_UPDATE"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2d(sc, "@hedgedeadline", hedgedeadline);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractIssignedUpdate (int suppliercontractid, bool issigned) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractIssignedUpdate (suppliercontractid, issigned,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractIssignedUpdate (int suppliercontractid, bool issigned,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractIssignedUpdate (suppliercontractid, issigned,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractIssignedUpdate (int suppliercontractid, bool issigned,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractIssignedUpdate (suppliercontractid, issigned,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractIssignedUpdate (int suppliercontractid, bool issigned,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__ISSIGNED_UPDATE"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2b(sc, "@issigned", issigned);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractManufactureOrderNewGet (DataTable manufactureordercontractitemids, ref string num, ref DateTime dt, ref int purchaserid, ref string purchaser, ref int supplierid, ref string supplier, ref decimal amount, ref bool vatincluded, ref decimal vatperc, ref decimal vatamount, ref string modelname, ref int quantity, ref string ordertype, ref int currencyid, ref int registrationperiod, ref int holdperiod, ref decimal fxrate, ref string fromyard, ref string toyard, ref int fromcountry, ref string tocountry, ref int paycurrencyid, ref decimal conversationcostperc, ref bool registrationincluded, ref bool pdiincluded, ref int registrationcountryid, ref string managername, ref int staffid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractManufactureOrderNewGet (manufactureordercontractitemids, ref num, ref dt, ref purchaserid, ref purchaser, ref supplierid, ref supplier, ref amount, ref vatincluded, ref vatperc, ref vatamount, ref modelname, ref quantity, ref ordertype, ref currencyid, ref registrationperiod, ref holdperiod, ref fxrate, ref fromyard, ref toyard, ref fromcountry, ref tocountry, ref paycurrencyid, ref conversationcostperc, ref registrationincluded, ref pdiincluded, ref registrationcountryid, ref managername, ref staffid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractManufactureOrderNewGet (DataTable manufactureordercontractitemids, ref string num, ref DateTime dt, ref int purchaserid, ref string purchaser, ref int supplierid, ref string supplier, ref decimal amount, ref bool vatincluded, ref decimal vatperc, ref decimal vatamount, ref string modelname, ref int quantity, ref string ordertype, ref int currencyid, ref int registrationperiod, ref int holdperiod, ref decimal fxrate, ref string fromyard, ref string toyard, ref int fromcountry, ref string tocountry, ref int paycurrencyid, ref decimal conversationcostperc, ref bool registrationincluded, ref bool pdiincluded, ref int registrationcountryid, ref string managername, ref int staffid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractManufactureOrderNewGet (manufactureordercontractitemids, ref num, ref dt, ref purchaserid, ref purchaser, ref supplierid, ref supplier, ref amount, ref vatincluded, ref vatperc, ref vatamount, ref modelname, ref quantity, ref ordertype, ref currencyid, ref registrationperiod, ref holdperiod, ref fxrate, ref fromyard, ref toyard, ref fromcountry, ref tocountry, ref paycurrencyid, ref conversationcostperc, ref registrationincluded, ref pdiincluded, ref registrationcountryid, ref managername, ref staffid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractManufactureOrderNewGet (DataTable manufactureordercontractitemids, ref string num, ref DateTime dt, ref int purchaserid, ref string purchaser, ref int supplierid, ref string supplier, ref decimal amount, ref bool vatincluded, ref decimal vatperc, ref decimal vatamount, ref string modelname, ref int quantity, ref string ordertype, ref int currencyid, ref int registrationperiod, ref int holdperiod, ref decimal fxrate, ref string fromyard, ref string toyard, ref int fromcountry, ref string tocountry, ref int paycurrencyid, ref decimal conversationcostperc, ref bool registrationincluded, ref bool pdiincluded, ref int registrationcountryid, ref string managername, ref int staffid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractManufactureOrderNewGet (manufactureordercontractitemids, ref num, ref dt, ref purchaserid, ref purchaser, ref supplierid, ref supplier, ref amount, ref vatincluded, ref vatperc, ref vatamount, ref modelname, ref quantity, ref ordertype, ref currencyid, ref registrationperiod, ref holdperiod, ref fxrate, ref fromyard, ref toyard, ref fromcountry, ref tocountry, ref paycurrencyid, ref conversationcostperc, ref registrationincluded, ref pdiincluded, ref registrationcountryid, ref managername, ref staffid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractManufactureOrderNewGet (DataTable manufactureordercontractitemids, ref string num, ref DateTime dt, ref int purchaserid, ref string purchaser, ref int supplierid, ref string supplier, ref decimal amount, ref bool vatincluded, ref decimal vatperc, ref decimal vatamount, ref string modelname, ref int quantity, ref string ordertype, ref int currencyid, ref int registrationperiod, ref int holdperiod, ref decimal fxrate, ref string fromyard, ref string toyard, ref int fromcountry, ref string tocountry, ref int paycurrencyid, ref decimal conversationcostperc, ref bool registrationincluded, ref bool pdiincluded, ref int registrationcountryid, ref string managername, ref int staffid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__MANUFACTURE_ORDER_NEW_GET"); 
  q.q2u(sc, "@manufactureordercontractitemids", "eids", manufactureordercontractitemids);
  q.q2s(sc, "@num", num);
  q.q2dt(sc, "@dt", dt);
  q.q2i(sc, "@purchaserid", purchaserid);
  q.q2s(sc, "@purchaser", purchaser);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2s(sc, "@supplier", supplier);
  q.q2e(sc, "@amount", amount);
  q.q2b(sc, "@vatincluded", vatincluded);
  q.q2e(sc, "@vatperc", vatperc);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2s(sc, "@modelname", modelname);
  q.q2i(sc, "@quantity", quantity);
  q.q2s(sc, "@ordertype", ordertype);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2s(sc, "@fromyard", fromyard);
  q.q2s(sc, "@toyard", toyard);
  q.q2i(sc, "@fromcountry", fromcountry);
  q.q2s(sc, "@tocountry", tocountry);
  q.q2i(sc, "@paycurrencyid", paycurrencyid);
  q.q2e(sc, "@conversationcostperc", conversationcostperc);
  q.q2b(sc, "@registrationincluded", registrationincluded);
  q.q2b(sc, "@pdiincluded", pdiincluded);
  q.q2i(sc, "@registrationcountryid", registrationcountryid);
  q.q2s(sc, "@managername", managername);
  q.q2i(sc, "@staffid", staffid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   num = q.gs(sc,"@num");
   dt = q.gdt(sc,"@dt");
   purchaserid = q.gi(sc,"@purchaserid");
   purchaser = q.gs(sc,"@purchaser");
   supplierid = q.gi(sc,"@supplierid");
   supplier = q.gs(sc,"@supplier");
   amount = q.ge(sc,"@amount");
   vatincluded = q.gb(sc,"@vatincluded");
   vatperc = q.ge(sc,"@vatperc");
   vatamount = q.ge(sc,"@vatamount");
   modelname = q.gs(sc,"@modelname");
   quantity = q.gi(sc,"@quantity");
   ordertype = q.gs(sc,"@ordertype");
   currencyid = q.gi(sc,"@currencyid");
   registrationperiod = q.gi(sc,"@registrationperiod");
   holdperiod = q.gi(sc,"@holdperiod");
   fxrate = q.ge(sc,"@fxrate");
   fromyard = q.gs(sc,"@fromyard");
   toyard = q.gs(sc,"@toyard");
   fromcountry = q.gi(sc,"@fromcountry");
   tocountry = q.gs(sc,"@tocountry");
   paycurrencyid = q.gi(sc,"@paycurrencyid");
   conversationcostperc = q.ge(sc,"@conversationcostperc");
   registrationincluded = q.gb(sc,"@registrationincluded");
   pdiincluded = q.gb(sc,"@pdiincluded");
   registrationcountryid = q.gi(sc,"@registrationcountryid");
   managername = q.gs(sc,"@managername");
   staffid = q.gi(sc,"@staffid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentsApply (int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentsApply (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentsApply (int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentsApply (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentsApply (int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentsApply (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentsApply (int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__PAYMENTS_APPLY"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPropertiesGet (int suppliercontractid, ref decimal conversionmarginpercent, ref decimal fxrate) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPropertiesGet (suppliercontractid, ref conversionmarginpercent, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesGet (int suppliercontractid, ref decimal conversionmarginpercent, ref decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPropertiesGet (suppliercontractid, ref conversionmarginpercent, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesGet (int suppliercontractid, ref decimal conversionmarginpercent, ref decimal fxrate,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPropertiesGet (suppliercontractid, ref conversionmarginpercent, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesGet (int suppliercontractid, ref decimal conversionmarginpercent, ref decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__PROPERTIES_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2e(sc, "@conversionmarginpercent", conversionmarginpercent);
  q.q2e(sc, "@fxrate", fxrate);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   conversionmarginpercent = q.ge(sc,"@conversionmarginpercent");
   fxrate = q.ge(sc,"@fxrate");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPropertiesGet2 (int suppliercontractid, ref decimal conversionmarginpercent, ref decimal fxrate, ref decimal cashcost) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPropertiesGet2 (suppliercontractid, ref conversionmarginpercent, ref fxrate, ref cashcost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesGet2 (int suppliercontractid, ref decimal conversionmarginpercent, ref decimal fxrate, ref decimal cashcost,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPropertiesGet2 (suppliercontractid, ref conversionmarginpercent, ref fxrate, ref cashcost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesGet2 (int suppliercontractid, ref decimal conversionmarginpercent, ref decimal fxrate, ref decimal cashcost,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPropertiesGet2 (suppliercontractid, ref conversionmarginpercent, ref fxrate, ref cashcost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesGet2 (int suppliercontractid, ref decimal conversionmarginpercent, ref decimal fxrate, ref decimal cashcost,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__PROPERTIES_GET2"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2e(sc, "@conversionmarginpercent", conversionmarginpercent);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@cashcost", cashcost);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   conversionmarginpercent = q.ge(sc,"@conversionmarginpercent");
   fxrate = q.ge(sc,"@fxrate");
   cashcost = q.ge(sc,"@cashcost");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPropertiesSet (int suppliercontractid, decimal conversionmarginpercent, decimal fxrate) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPropertiesSet (suppliercontractid, conversionmarginpercent, fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesSet (int suppliercontractid, decimal conversionmarginpercent, decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPropertiesSet (suppliercontractid, conversionmarginpercent, fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesSet (int suppliercontractid, decimal conversionmarginpercent, decimal fxrate,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPropertiesSet (suppliercontractid, conversionmarginpercent, fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesSet (int suppliercontractid, decimal conversionmarginpercent, decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__PROPERTIES_SET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2e(sc, "@conversionmarginpercent", conversionmarginpercent);
  q.q2e(sc, "@fxrate", fxrate);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPropertiesSet2 (int suppliercontractid, decimal conversionmarginpercent, decimal fxrate, decimal cashcost) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPropertiesSet2 (suppliercontractid, conversionmarginpercent, fxrate, cashcost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesSet2 (int suppliercontractid, decimal conversionmarginpercent, decimal fxrate, decimal cashcost,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPropertiesSet2 (suppliercontractid, conversionmarginpercent, fxrate, cashcost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesSet2 (int suppliercontractid, decimal conversionmarginpercent, decimal fxrate, decimal cashcost,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPropertiesSet2 (suppliercontractid, conversionmarginpercent, fxrate, cashcost,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPropertiesSet2 (int suppliercontractid, decimal conversionmarginpercent, decimal fxrate, decimal cashcost,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__PROPERTIES_SET2"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2e(sc, "@conversionmarginpercent", conversionmarginpercent);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@cashcost", cashcost);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractRegistrationInfoGet (int suppliercontractid, ref int registrationcountryid, ref int regperiod) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractRegistrationInfoGet (suppliercontractid, ref registrationcountryid, ref regperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractRegistrationInfoGet (int suppliercontractid, ref int registrationcountryid, ref int regperiod,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractRegistrationInfoGet (suppliercontractid, ref registrationcountryid, ref regperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractRegistrationInfoGet (int suppliercontractid, ref int registrationcountryid, ref int regperiod,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractRegistrationInfoGet (suppliercontractid, ref registrationcountryid, ref regperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractRegistrationInfoGet (int suppliercontractid, ref int registrationcountryid, ref int regperiod,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__REGISTRATION_INFO_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@registrationcountryid", registrationcountryid);
  q.q2i(sc, "@regperiod", regperiod);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   registrationcountryid = q.gi(sc,"@registrationcountryid");
   regperiod = q.gi(sc,"@regperiod");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractStatusGet (int suppliercontractid, ref string st) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractStatusGet (suppliercontractid, ref st,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractStatusGet (int suppliercontractid, ref string st,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractStatusGet (suppliercontractid, ref st,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractStatusGet (int suppliercontractid, ref string st,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractStatusGet (suppliercontractid, ref st,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractStatusGet (int suppliercontractid, ref string st,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__STATUS_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2s(sc, "@st", st);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   st = q.gs(sc,"@st");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractStatusSet (int suppliercontractid, string st) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractStatusSet (suppliercontractid, st,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractStatusSet (int suppliercontractid, string st,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractStatusSet (suppliercontractid, st,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractStatusSet (int suppliercontractid, string st,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractStatusSet (suppliercontractid, st,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractStatusSet (int suppliercontractid, string st,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__STATUS_SET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2s(sc, "@st", st);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractUpdate (int suppliercontractid, string num, DateTime dt, int purchaserid, int supplierid, int pickupcountry, decimal advanceprepayment, decimal advanceprepaymentperc, bool vatincluded, decimal vatamount, decimal vatperc, string note, string modelname, string ordertype, string documentsinfo, string hedgeno, DateTime plannedproductionat, int registrationperiod, int holdperiod, DateTime estimatedat, bool delaydeduction, decimal amount, DateTime prepaymentdt, int documentholdperiod, bool deliveringtoclient, bool deliveringtoyard, int yardcountryid, int regperiod, DateTime loadingfromsupplierat, decimal conversationcostperc, bool registrationincluded, bool pdiincluded, int registrationcountryid, int transportationperiod, int staffid, string invoicesavailableafterpayment, bool issupplierhold, int companygroupid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractUpdate (suppliercontractid, num, dt, purchaserid, supplierid, pickupcountry, advanceprepayment, advanceprepaymentperc, vatincluded, vatamount, vatperc, note, modelname, ordertype, documentsinfo, hedgeno, plannedproductionat, registrationperiod, holdperiod, estimatedat, delaydeduction, amount, prepaymentdt, documentholdperiod, deliveringtoclient, deliveringtoyard, yardcountryid, regperiod, loadingfromsupplierat, conversationcostperc, registrationincluded, pdiincluded, registrationcountryid, transportationperiod, staffid, invoicesavailableafterpayment, issupplierhold, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractUpdate (int suppliercontractid, string num, DateTime dt, int purchaserid, int supplierid, int pickupcountry, decimal advanceprepayment, decimal advanceprepaymentperc, bool vatincluded, decimal vatamount, decimal vatperc, string note, string modelname, string ordertype, string documentsinfo, string hedgeno, DateTime plannedproductionat, int registrationperiod, int holdperiod, DateTime estimatedat, bool delaydeduction, decimal amount, DateTime prepaymentdt, int documentholdperiod, bool deliveringtoclient, bool deliveringtoyard, int yardcountryid, int regperiod, DateTime loadingfromsupplierat, decimal conversationcostperc, bool registrationincluded, bool pdiincluded, int registrationcountryid, int transportationperiod, int staffid, string invoicesavailableafterpayment, bool issupplierhold, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractUpdate (suppliercontractid, num, dt, purchaserid, supplierid, pickupcountry, advanceprepayment, advanceprepaymentperc, vatincluded, vatamount, vatperc, note, modelname, ordertype, documentsinfo, hedgeno, plannedproductionat, registrationperiod, holdperiod, estimatedat, delaydeduction, amount, prepaymentdt, documentholdperiod, deliveringtoclient, deliveringtoyard, yardcountryid, regperiod, loadingfromsupplierat, conversationcostperc, registrationincluded, pdiincluded, registrationcountryid, transportationperiod, staffid, invoicesavailableafterpayment, issupplierhold, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractUpdate (int suppliercontractid, string num, DateTime dt, int purchaserid, int supplierid, int pickupcountry, decimal advanceprepayment, decimal advanceprepaymentperc, bool vatincluded, decimal vatamount, decimal vatperc, string note, string modelname, string ordertype, string documentsinfo, string hedgeno, DateTime plannedproductionat, int registrationperiod, int holdperiod, DateTime estimatedat, bool delaydeduction, decimal amount, DateTime prepaymentdt, int documentholdperiod, bool deliveringtoclient, bool deliveringtoyard, int yardcountryid, int regperiod, DateTime loadingfromsupplierat, decimal conversationcostperc, bool registrationincluded, bool pdiincluded, int registrationcountryid, int transportationperiod, int staffid, string invoicesavailableafterpayment, bool issupplierhold, int companygroupid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractUpdate (suppliercontractid, num, dt, purchaserid, supplierid, pickupcountry, advanceprepayment, advanceprepaymentperc, vatincluded, vatamount, vatperc, note, modelname, ordertype, documentsinfo, hedgeno, plannedproductionat, registrationperiod, holdperiod, estimatedat, delaydeduction, amount, prepaymentdt, documentholdperiod, deliveringtoclient, deliveringtoyard, yardcountryid, regperiod, loadingfromsupplierat, conversationcostperc, registrationincluded, pdiincluded, registrationcountryid, transportationperiod, staffid, invoicesavailableafterpayment, issupplierhold, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractUpdate (int suppliercontractid, string num, DateTime dt, int purchaserid, int supplierid, int pickupcountry, decimal advanceprepayment, decimal advanceprepaymentperc, bool vatincluded, decimal vatamount, decimal vatperc, string note, string modelname, string ordertype, string documentsinfo, string hedgeno, DateTime plannedproductionat, int registrationperiod, int holdperiod, DateTime estimatedat, bool delaydeduction, decimal amount, DateTime prepaymentdt, int documentholdperiod, bool deliveringtoclient, bool deliveringtoyard, int yardcountryid, int regperiod, DateTime loadingfromsupplierat, decimal conversationcostperc, bool registrationincluded, bool pdiincluded, int registrationcountryid, int transportationperiod, int staffid, string invoicesavailableafterpayment, bool issupplierhold, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__UPDATE"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2s(sc, "@num", num);
  q.q2d(sc, "@dt", dt);
  q.q2i(sc, "@purchaserid", purchaserid);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@pickupcountry", pickupcountry);
  q.q2e(sc, "@advanceprepayment", advanceprepayment);
  q.q2e(sc, "@advanceprepaymentperc", advanceprepaymentperc);
  q.q2b(sc, "@vatincluded", vatincluded);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2e(sc, "@vatperc", vatperc);
  q.q2s(sc, "@note", note);
  q.q2s(sc, "@modelname", modelname);
  q.q2s(sc, "@ordertype", ordertype);
  q.q2s(sc, "@documentsinfo", documentsinfo);
  q.q2s(sc, "@hedgeno", hedgeno);
  q.q2d(sc, "@plannedproductionat", plannedproductionat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2d(sc, "@estimatedat", estimatedat);
  q.q2b(sc, "@delaydeduction", delaydeduction);
  q.q2e(sc, "@amount", amount);
  q.q2d(sc, "@prepaymentdt", prepaymentdt);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2b(sc, "@deliveringtoclient", deliveringtoclient);
  q.q2b(sc, "@deliveringtoyard", deliveringtoyard);
  q.q2i(sc, "@yardcountryid", yardcountryid);
  q.q2i(sc, "@regperiod", regperiod);
  q.q2d(sc, "@loadingfromsupplierat", loadingfromsupplierat);
  q.q2e(sc, "@conversationcostperc", conversationcostperc);
  q.q2b(sc, "@registrationincluded", registrationincluded);
  q.q2b(sc, "@pdiincluded", pdiincluded);
  q.q2i(sc, "@registrationcountryid", registrationcountryid);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  q.q2i(sc, "@staffid", staffid);
  q.q2s(sc, "@invoicesavailableafterpayment", invoicesavailableafterpayment);
  q.q2b(sc, "@issupplierhold", issupplierhold);
  q.q2i(sc, "@companygroupid", companygroupid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehicleAtVendorGet (DataTable arrangementvehicleids, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref bool registrationincluded) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehicleAtVendorGet (arrangementvehicleids, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref registrationincluded,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleAtVendorGet (DataTable arrangementvehicleids, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref bool registrationincluded,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehicleAtVendorGet (arrangementvehicleids, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref registrationincluded,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleAtVendorGet (DataTable arrangementvehicleids, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref bool registrationincluded,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehicleAtVendorGet (arrangementvehicleids, ref plannedproductionat, ref plannedpaymentat, ref preparationperiod, ref holdperiod, ref documentholdperiod, ref loadingday, ref loadingfromsupplierat, ref registrationperiod, ref transportationperiod, ref registrationincluded,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleAtVendorGet (DataTable arrangementvehicleids, ref DateTime plannedproductionat, ref DateTime plannedpaymentat, ref int preparationperiod, ref int holdperiod, ref int documentholdperiod, ref DateTime loadingday, ref DateTime loadingfromsupplierat, ref int registrationperiod, ref int transportationperiod, ref bool registrationincluded,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__VEHICLE_AT_VENDOR_GET"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2d(sc, "@plannedproductionat", plannedproductionat);
  q.q2d(sc, "@plannedpaymentat", plannedpaymentat);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2d(sc, "@loadingfromsupplierat", loadingfromsupplierat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  q.q2b(sc, "@registrationincluded", registrationincluded);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   plannedproductionat = q.gd(sc,"@plannedproductionat");
   plannedpaymentat = q.gd(sc,"@plannedpaymentat");
   preparationperiod = q.gi(sc,"@preparationperiod");
   holdperiod = q.gi(sc,"@holdperiod");
   documentholdperiod = q.gi(sc,"@documentholdperiod");
   loadingday = q.gd(sc,"@loadingday");
   loadingfromsupplierat = q.gd(sc,"@loadingfromsupplierat");
   registrationperiod = q.gi(sc,"@registrationperiod");
   transportationperiod = q.gi(sc,"@transportationperiod");
   registrationincluded = q.gb(sc,"@registrationincluded");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehicleDelete (int arrangementvehicleid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehicleDelete (arrangementvehicleid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleDelete (int arrangementvehicleid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehicleDelete (arrangementvehicleid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleDelete (int arrangementvehicleid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehicleDelete (arrangementvehicleid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleDelete (int arrangementvehicleid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__VEHICLE_DELETE"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehiclesAtVendorPaste (string globaltablename, DataTable map, int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehiclesAtVendorPaste (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesAtVendorPaste (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehiclesAtVendorPaste (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesAtVendorPaste (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehiclesAtVendorPaste (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesAtVendorPaste (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__VEHICLES_AT_VENDOR_PASTE"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehiclesCancel (DataTable avids, int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehiclesCancel (avids, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesCancel (DataTable avids, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehiclesCancel (avids, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesCancel (DataTable avids, int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehiclesCancel (avids, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesCancel (DataTable avids, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__VEHICLES_CANCEL"); 
  q.q2u(sc, "@avids", "eids", avids);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehiclesRemove (DataTable avids, int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehiclesRemove (avids, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesRemove (DataTable avids, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehiclesRemove (avids, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesRemove (DataTable avids, int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehiclesRemove (avids, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesRemove (DataTable avids, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__VEHICLES_REMOVE"); 
  q.q2u(sc, "@avids", "eids", avids);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehiclesVinClear (DataTable avids, int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehiclesVinClear (avids, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesVinClear (DataTable avids, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehiclesVinClear (avids, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesVinClear (DataTable avids, int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehiclesVinClear (avids, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesVinClear (DataTable avids, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__VEHICLES_VIN_CLEAR"); 
  q.q2u(sc, "@avids", "eids", avids);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractWriteOffAdd (int suppliercontractpaymentid, int suppliercontractid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amountbalance, decimal vatamountbalance, decimal totalamountbalance, decimal euramountbalance, decimal eurvatamountbalance, int suppliervehicleloadid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractWriteOffAdd (suppliercontractpaymentid, suppliercontractid, documenttype, documentno, dt, currencyid, amountbalance, vatamountbalance, totalamountbalance, euramountbalance, eurvatamountbalance, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractWriteOffAdd (int suppliercontractpaymentid, int suppliercontractid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amountbalance, decimal vatamountbalance, decimal totalamountbalance, decimal euramountbalance, decimal eurvatamountbalance, int suppliervehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractWriteOffAdd (suppliercontractpaymentid, suppliercontractid, documenttype, documentno, dt, currencyid, amountbalance, vatamountbalance, totalamountbalance, euramountbalance, eurvatamountbalance, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractWriteOffAdd (int suppliercontractpaymentid, int suppliercontractid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amountbalance, decimal vatamountbalance, decimal totalamountbalance, decimal euramountbalance, decimal eurvatamountbalance, int suppliervehicleloadid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractWriteOffAdd (suppliercontractpaymentid, suppliercontractid, documenttype, documentno, dt, currencyid, amountbalance, vatamountbalance, totalamountbalance, euramountbalance, eurvatamountbalance, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractWriteOffAdd (int suppliercontractpaymentid, int suppliercontractid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amountbalance, decimal vatamountbalance, decimal totalamountbalance, decimal euramountbalance, decimal eurvatamountbalance, int suppliervehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__WRITE_OFF_ADD"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2s(sc, "@documenttype", documenttype);
  q.q2s(sc, "@documentno", documentno);
  q.q2d(sc, "@dt", dt);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@amountbalance", amountbalance);
  q.q2e(sc, "@vatamountbalance", vatamountbalance);
  q.q2e(sc, "@totalamountbalance", totalamountbalance);
  q.q2e(sc, "@euramountbalance", euramountbalance);
  q.q2e(sc, "@eurvatamountbalance", eurvatamountbalance);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractWriteOffNewGet (int suppliercontractpaymentid, int suppliercontractid, ref string documenttype, ref string documentno, ref DateTime dt, ref int currencyid, ref string currencycode, ref decimal amountbalance, ref decimal vatamountbalance, ref decimal totalamountbalance, ref decimal euramountbalance, ref decimal eurvatamountbalance, ref decimal eurtotalamountbalance, ref decimal fxrate) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractWriteOffNewGet (suppliercontractpaymentid, suppliercontractid, ref documenttype, ref documentno, ref dt, ref currencyid, ref currencycode, ref amountbalance, ref vatamountbalance, ref totalamountbalance, ref euramountbalance, ref eurvatamountbalance, ref eurtotalamountbalance, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractWriteOffNewGet (int suppliercontractpaymentid, int suppliercontractid, ref string documenttype, ref string documentno, ref DateTime dt, ref int currencyid, ref string currencycode, ref decimal amountbalance, ref decimal vatamountbalance, ref decimal totalamountbalance, ref decimal euramountbalance, ref decimal eurvatamountbalance, ref decimal eurtotalamountbalance, ref decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractWriteOffNewGet (suppliercontractpaymentid, suppliercontractid, ref documenttype, ref documentno, ref dt, ref currencyid, ref currencycode, ref amountbalance, ref vatamountbalance, ref totalamountbalance, ref euramountbalance, ref eurvatamountbalance, ref eurtotalamountbalance, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractWriteOffNewGet (int suppliercontractpaymentid, int suppliercontractid, ref string documenttype, ref string documentno, ref DateTime dt, ref int currencyid, ref string currencycode, ref decimal amountbalance, ref decimal vatamountbalance, ref decimal totalamountbalance, ref decimal euramountbalance, ref decimal eurvatamountbalance, ref decimal eurtotalamountbalance, ref decimal fxrate,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractWriteOffNewGet (suppliercontractpaymentid, suppliercontractid, ref documenttype, ref documentno, ref dt, ref currencyid, ref currencycode, ref amountbalance, ref vatamountbalance, ref totalamountbalance, ref euramountbalance, ref eurvatamountbalance, ref eurtotalamountbalance, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractWriteOffNewGet (int suppliercontractpaymentid, int suppliercontractid, ref string documenttype, ref string documentno, ref DateTime dt, ref int currencyid, ref string currencycode, ref decimal amountbalance, ref decimal vatamountbalance, ref decimal totalamountbalance, ref decimal euramountbalance, ref decimal eurvatamountbalance, ref decimal eurtotalamountbalance, ref decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT__WRITE_OFF_NEW_GET"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2s(sc, "@documenttype", documenttype);
  q.q2s(sc, "@documentno", documentno);
  q.q2d(sc, "@dt", dt);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2s(sc, "@currencycode", currencycode);
  q.q2e(sc, "@amountbalance", amountbalance);
  q.q2e(sc, "@vatamountbalance", vatamountbalance);
  q.q2e(sc, "@totalamountbalance", totalamountbalance);
  q.q2e(sc, "@euramountbalance", euramountbalance);
  q.q2e(sc, "@eurvatamountbalance", eurvatamountbalance);
  q.q2e(sc, "@eurtotalamountbalance", eurtotalamountbalance);
  q.q2e(sc, "@fxrate", fxrate);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   documenttype = q.gs(sc,"@documenttype");
   documentno = q.gs(sc,"@documentno");
   dt = q.gd(sc,"@dt");
   currencyid = q.gi(sc,"@currencyid");
   currencycode = q.gs(sc,"@currencycode");
   amountbalance = q.ge(sc,"@amountbalance");
   vatamountbalance = q.ge(sc,"@vatamountbalance");
   totalamountbalance = q.ge(sc,"@totalamountbalance");
   euramountbalance = q.ge(sc,"@euramountbalance");
   eurvatamountbalance = q.ge(sc,"@eurvatamountbalance");
   eurtotalamountbalance = q.ge(sc,"@eurtotalamountbalance");
   fxrate = q.ge(sc,"@fxrate");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractFileDirectoriesVw (int suppliercontractid, int parentid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractFileDirectoriesVw (suppliercontractid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoriesVw (int suppliercontractid, int parentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractFileDirectoriesVw (suppliercontractid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoriesVw (int suppliercontractid, int parentid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractFileDirectoriesVw (suppliercontractid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoriesVw (int suppliercontractid, int parentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_FILE__DIRECTORIES_vw"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@parentid", parentid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractFileDirectoryDelete (int suppliercontractid, int suppliercontractfileid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractFileDirectoryDelete (suppliercontractid, suppliercontractfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoryDelete (int suppliercontractid, int suppliercontractfileid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractFileDirectoryDelete (suppliercontractid, suppliercontractfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoryDelete (int suppliercontractid, int suppliercontractfileid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractFileDirectoryDelete (suppliercontractid, suppliercontractfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoryDelete (int suppliercontractid, int suppliercontractfileid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_FILE__DIRECTORY_DELETE"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliercontractfileid", suppliercontractfileid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractFileDirectoryNew (int suppliercontractid, int parentid, ref int newid, ref string newname) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractFileDirectoryNew (suppliercontractid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoryNew (int suppliercontractid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractFileDirectoryNew (suppliercontractid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoryNew (int suppliercontractid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractFileDirectoryNew (suppliercontractid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoryNew (int suppliercontractid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_FILE__DIRECTORY_NEW"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@parentid", parentid);
  q.q2i(sc, "@newid", newid);
  q.q2s(sc, "@newname", newname);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   newid = q.gi(sc,"@newid");
   newname = q.gs(sc,"@newname");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractFileDirectoryRename (int suppliercontractid, int suppliercontractfileid, string name) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractFileDirectoryRename (suppliercontractid, suppliercontractfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoryRename (int suppliercontractid, int suppliercontractfileid, string name,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractFileDirectoryRename (suppliercontractid, suppliercontractfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoryRename (int suppliercontractid, int suppliercontractfileid, string name,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractFileDirectoryRename (suppliercontractid, suppliercontractfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileDirectoryRename (int suppliercontractid, int suppliercontractfileid, string name,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_FILE__DIRECTORY_RENAME"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliercontractfileid", suppliercontractfileid);
  q.q2s(sc, "@name", name);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractFileFileAdd (int suppliercontractid, int dirsuppliercontractfileid, string fn, string ext, byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractFileFileAdd (suppliercontractid, dirsuppliercontractfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileAdd (int suppliercontractid, int dirsuppliercontractfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractFileFileAdd (suppliercontractid, dirsuppliercontractfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileAdd (int suppliercontractid, int dirsuppliercontractfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractFileFileAdd (suppliercontractid, dirsuppliercontractfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileAdd (int suppliercontractid, int dirsuppliercontractfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_FILE__FILE_ADD"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@dirsuppliercontractfileid", dirsuppliercontractfileid);
  q.q2s(sc, "@fn", fn);
  q.q2s(sc, "@ext", ext);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractFileFileDelete (int suppliercontractid, int suppliercontractfileid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractFileFileDelete (suppliercontractid, suppliercontractfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileDelete (int suppliercontractid, int suppliercontractfileid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractFileFileDelete (suppliercontractid, suppliercontractfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileDelete (int suppliercontractid, int suppliercontractfileid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractFileFileDelete (suppliercontractid, suppliercontractfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileDelete (int suppliercontractid, int suppliercontractfileid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_FILE__FILE_DELETE"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliercontractfileid", suppliercontractfileid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractFileFileInfoGet (int suppliercontractid, int suppliercontractfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractFileFileInfoGet (suppliercontractid, suppliercontractfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileInfoGet (int suppliercontractid, int suppliercontractfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractFileFileInfoGet (suppliercontractid, suppliercontractfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileInfoGet (int suppliercontractid, int suppliercontractfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractFileFileInfoGet (suppliercontractid, suppliercontractfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileInfoGet (int suppliercontractid, int suppliercontractfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_FILE__FILE_INFO_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliercontractfileid", suppliercontractfileid);
  q.q2s(sc, "@name", name);
  q.q2dt(sc, "@uploaded", uploaded);
  q.q2s(sc, "@type", type);
  q.q2i(sc, "@size", size);
  q.q2s(sc, "@uploadedby", uploadedby);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   name = q.gs(sc,"@name");
   uploaded = q.gdt(sc,"@uploaded");
   type = q.gs(sc,"@type");
   size = q.gi(sc,"@size");
   uploadedby = q.gs(sc,"@uploadedby");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractFileFileOpenGet (int suppliercontractid, int suppliercontractfileid, ref string fn, ref byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractFileFileOpenGet (suppliercontractid, suppliercontractfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileOpenGet (int suppliercontractid, int suppliercontractfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractFileFileOpenGet (suppliercontractid, suppliercontractfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileOpenGet (int suppliercontractid, int suppliercontractfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractFileFileOpenGet (suppliercontractid, suppliercontractfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileOpenGet (int suppliercontractid, int suppliercontractfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_FILE__FILE_OPEN_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliercontractfileid", suppliercontractfileid);
  q.q2s(sc, "@fn", fn);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   fn = q.gs(sc,"@fn");
   body = q.ga(sc,"@body");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractFileFileRename (int suppliercontractid, int suppliercontractfileid, string newfn) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractFileFileRename (suppliercontractid, suppliercontractfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileRename (int suppliercontractid, int suppliercontractfileid, string newfn,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractFileFileRename (suppliercontractid, suppliercontractfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileRename (int suppliercontractid, int suppliercontractfileid, string newfn,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractFileFileRename (suppliercontractid, suppliercontractfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFileRename (int suppliercontractid, int suppliercontractfileid, string newfn,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_FILE__FILE_RENAME"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliercontractfileid", suppliercontractfileid);
  q.q2s(sc, "@newfn", newfn);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractFileFilesVw (int suppliercontractid, int suppliercontractfileid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractFileFilesVw (suppliercontractid, suppliercontractfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFilesVw (int suppliercontractid, int suppliercontractfileid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractFileFilesVw (suppliercontractid, suppliercontractfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFilesVw (int suppliercontractid, int suppliercontractfileid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractFileFilesVw (suppliercontractid, suppliercontractfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractFileFilesVw (int suppliercontractid, int suppliercontractfileid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_FILE__FILES_vw"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliercontractfileid", suppliercontractfileid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemArrangementGet (int suppliercontractitemid, ref int arrangementid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemArrangementGet (suppliercontractitemid, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemArrangementGet (int suppliercontractitemid, ref int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemArrangementGet (suppliercontractitemid, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemArrangementGet (int suppliercontractitemid, ref int arrangementid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemArrangementGet (suppliercontractitemid, ref arrangementid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemArrangementGet (int suppliercontractitemid, ref int arrangementid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEM__ARRANGEMENT_GET"); 
  q.q2i(sc, "@suppliercontractitemid", suppliercontractitemid);
  q.q2i(sc, "@arrangementid", arrangementid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   arrangementid = q.gi(sc,"@arrangementid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemBuyamountUpdate (int suppliercontractitemid, decimal buyamount) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemBuyamountUpdate (suppliercontractitemid, buyamount,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemBuyamountUpdate (int suppliercontractitemid, decimal buyamount,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemBuyamountUpdate (suppliercontractitemid, buyamount,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemBuyamountUpdate (int suppliercontractitemid, decimal buyamount,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemBuyamountUpdate (suppliercontractitemid, buyamount,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemBuyamountUpdate (int suppliercontractitemid, decimal buyamount,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEM__BUYAMOUNT_UPDATE"); 
  q.q2i(sc, "@suppliercontractitemid", suppliercontractitemid);
  q.q2e(sc, "@buyamount", buyamount);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemCostsUpdate (int suppliercontractitemid, decimal buffer, decimal registration, decimal transport) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemCostsUpdate (suppliercontractitemid, buffer, registration, transport,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemCostsUpdate (int suppliercontractitemid, decimal buffer, decimal registration, decimal transport,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemCostsUpdate (suppliercontractitemid, buffer, registration, transport,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemCostsUpdate (int suppliercontractitemid, decimal buffer, decimal registration, decimal transport,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemCostsUpdate (suppliercontractitemid, buffer, registration, transport,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemCostsUpdate (int suppliercontractitemid, decimal buffer, decimal registration, decimal transport,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEM__COSTS_UPDATE"); 
  q.q2i(sc, "@suppliercontractitemid", suppliercontractitemid);
  q.q2e(sc, "@buffer", buffer);
  q.q2e(sc, "@registration", registration);
  q.q2e(sc, "@transport", transport);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemDatesUpdate (int suppliercontractitemid, DateTime plannedproductionat, int registrationperiod, int holdperiod, ref DateTime estimatedat) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemDatesUpdate (suppliercontractitemid, plannedproductionat, registrationperiod, holdperiod, ref estimatedat,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemDatesUpdate (int suppliercontractitemid, DateTime plannedproductionat, int registrationperiod, int holdperiod, ref DateTime estimatedat,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemDatesUpdate (suppliercontractitemid, plannedproductionat, registrationperiod, holdperiod, ref estimatedat,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemDatesUpdate (int suppliercontractitemid, DateTime plannedproductionat, int registrationperiod, int holdperiod, ref DateTime estimatedat,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemDatesUpdate (suppliercontractitemid, plannedproductionat, registrationperiod, holdperiod, ref estimatedat,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemDatesUpdate (int suppliercontractitemid, DateTime plannedproductionat, int registrationperiod, int holdperiod, ref DateTime estimatedat,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEM__DATES_UPDATE"); 
  q.q2i(sc, "@suppliercontractitemid", suppliercontractitemid);
  q.q2d(sc, "@plannedproductionat", plannedproductionat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2d(sc, "@estimatedat", estimatedat);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   estimatedat = q.gd(sc,"@estimatedat");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemDelete (int suppliercontractitemid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemDelete (suppliercontractitemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemDelete (int suppliercontractitemid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemDelete (suppliercontractitemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemDelete (int suppliercontractitemid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemDelete (suppliercontractitemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemDelete (int suppliercontractitemid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEM__DELETE"); 
  q.q2i(sc, "@suppliercontractitemid", suppliercontractitemid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemNoteGet (int suppliercontractitemid, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemNoteGet (suppliercontractitemid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemNoteGet (int suppliercontractitemid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemNoteGet (suppliercontractitemid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemNoteGet (int suppliercontractitemid, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemNoteGet (suppliercontractitemid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemNoteGet (int suppliercontractitemid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEM__NOTE_GET"); 
  q.q2i(sc, "@suppliercontractitemid", suppliercontractitemid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemNoteSet (int suppliercontractitemid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemNoteSet (suppliercontractitemid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemNoteSet (int suppliercontractitemid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemNoteSet (suppliercontractitemid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemNoteSet (int suppliercontractitemid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemNoteSet (suppliercontractitemid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemNoteSet (int suppliercontractitemid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEM__NOTE_SET"); 
  q.q2i(sc, "@suppliercontractitemid", suppliercontractitemid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemVehiclesAssign (DataTable arrangmentvehicleids, int suppliercontractid, int suppliercontractitemid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemVehiclesAssign (arrangmentvehicleids, suppliercontractid, suppliercontractitemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemVehiclesAssign (DataTable arrangmentvehicleids, int suppliercontractid, int suppliercontractitemid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemVehiclesAssign (arrangmentvehicleids, suppliercontractid, suppliercontractitemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemVehiclesAssign (DataTable arrangmentvehicleids, int suppliercontractid, int suppliercontractitemid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemVehiclesAssign (arrangmentvehicleids, suppliercontractid, suppliercontractitemid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemVehiclesAssign (DataTable arrangmentvehicleids, int suppliercontractid, int suppliercontractitemid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEM__VEHICLES_ASSIGN"); 
  q.q2u(sc, "@arrangmentvehicleids", "eids", arrangmentvehicleids);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliercontractitemid", suppliercontractitemid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsAnnexCreate (DataTable suppliercontractitemids, int interioraddonid, int exterioraddonid, DataTable optionaddonids, int quantity, string annexnum) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsAnnexCreate (suppliercontractitemids, interioraddonid, exterioraddonid, optionaddonids, quantity, annexnum,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsAnnexCreate (DataTable suppliercontractitemids, int interioraddonid, int exterioraddonid, DataTable optionaddonids, int quantity, string annexnum,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsAnnexCreate (suppliercontractitemids, interioraddonid, exterioraddonid, optionaddonids, quantity, annexnum,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsAnnexCreate (DataTable suppliercontractitemids, int interioraddonid, int exterioraddonid, DataTable optionaddonids, int quantity, string annexnum,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsAnnexCreate (suppliercontractitemids, interioraddonid, exterioraddonid, optionaddonids, quantity, annexnum,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsAnnexCreate (DataTable suppliercontractitemids, int interioraddonid, int exterioraddonid, DataTable optionaddonids, int quantity, string annexnum,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS__ANNEX_CREATE"); 
  q.q2u(sc, "@suppliercontractitemids", "eids", suppliercontractitemids);
  q.q2i(sc, "@interioraddonid", interioraddonid);
  q.q2i(sc, "@exterioraddonid", exterioraddonid);
  q.q2u(sc, "@optionaddonids", "eids", optionaddonids);
  q.q2i(sc, "@quantity", quantity);
  q.q2s(sc, "@annexnum", annexnum);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsArrangementsCreateOwnstock (int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsArrangementsCreateOwnstock (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsArrangementsCreateOwnstock (int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsArrangementsCreateOwnstock (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsArrangementsCreateOwnstock (int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsArrangementsCreateOwnstock (suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsArrangementsCreateOwnstock (int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS__ARRANGEMENTS_CREATE_OWNSTOCK"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsDatesUpdate (DataTable suppliercontractitemids, int suppliercontractid, DateTime vehiclesatvendor, int preparationperiod, int holdperiod, DateTime loadingday) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsDatesUpdate (suppliercontractitemids, suppliercontractid, vehiclesatvendor, preparationperiod, holdperiod, loadingday,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsDatesUpdate (DataTable suppliercontractitemids, int suppliercontractid, DateTime vehiclesatvendor, int preparationperiod, int holdperiod, DateTime loadingday,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsDatesUpdate (suppliercontractitemids, suppliercontractid, vehiclesatvendor, preparationperiod, holdperiod, loadingday,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsDatesUpdate (DataTable suppliercontractitemids, int suppliercontractid, DateTime vehiclesatvendor, int preparationperiod, int holdperiod, DateTime loadingday,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsDatesUpdate (suppliercontractitemids, suppliercontractid, vehiclesatvendor, preparationperiod, holdperiod, loadingday,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsDatesUpdate (DataTable suppliercontractitemids, int suppliercontractid, DateTime vehiclesatvendor, int preparationperiod, int holdperiod, DateTime loadingday,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS__DATES_UPDATE"); 
  q.q2u(sc, "@suppliercontractitemids", "eids", suppliercontractitemids);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2d(sc, "@vehiclesatvendor", vehiclesatvendor);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2d(sc, "@loadingday", loadingday);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsDetailsUpdate (DataTable supplierboarditemids, decimal netweight, int countryid, string tariffno) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsDetailsUpdate (supplierboarditemids, netweight, countryid, tariffno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsDetailsUpdate (DataTable supplierboarditemids, decimal netweight, int countryid, string tariffno,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsDetailsUpdate (supplierboarditemids, netweight, countryid, tariffno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsDetailsUpdate (DataTable supplierboarditemids, decimal netweight, int countryid, string tariffno,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsDetailsUpdate (supplierboarditemids, netweight, countryid, tariffno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsDetailsUpdate (DataTable supplierboarditemids, decimal netweight, int countryid, string tariffno,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS__DETAILS_UPDATE"); 
  q.q2u(sc, "@supplierboarditemids", "eids", supplierboarditemids);
  q.q2e(sc, "@netweight", netweight);
  q.q2i(sc, "@countryid", countryid);
  q.q2s(sc, "@tariffno", tariffno);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsHasDifferentDatesGet (int suppliercontractid, ref bool hasdifferentdates) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsHasDifferentDatesGet (suppliercontractid, ref hasdifferentdates,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsHasDifferentDatesGet (int suppliercontractid, ref bool hasdifferentdates,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsHasDifferentDatesGet (suppliercontractid, ref hasdifferentdates,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsHasDifferentDatesGet (int suppliercontractid, ref bool hasdifferentdates,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsHasDifferentDatesGet (suppliercontractid, ref hasdifferentdates,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsHasDifferentDatesGet (int suppliercontractid, ref bool hasdifferentdates,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS__HAS_DIFFERENT_DATES_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2b(sc, "@hasdifferentdates", hasdifferentdates);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   hasdifferentdates = q.gb(sc,"@hasdifferentdates");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsHasDifferentDatesGet2 (int suppliercontractid, ref bool hasdifferentdates, ref bool ismanualholdingperiodset) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsHasDifferentDatesGet2 (suppliercontractid, ref hasdifferentdates, ref ismanualholdingperiodset,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsHasDifferentDatesGet2 (int suppliercontractid, ref bool hasdifferentdates, ref bool ismanualholdingperiodset,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsHasDifferentDatesGet2 (suppliercontractid, ref hasdifferentdates, ref ismanualholdingperiodset,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsHasDifferentDatesGet2 (int suppliercontractid, ref bool hasdifferentdates, ref bool ismanualholdingperiodset,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsHasDifferentDatesGet2 (suppliercontractid, ref hasdifferentdates, ref ismanualholdingperiodset,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsHasDifferentDatesGet2 (int suppliercontractid, ref bool hasdifferentdates, ref bool ismanualholdingperiodset,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS__HAS_DIFFERENT_DATES_GET2"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2b(sc, "@hasdifferentdates", hasdifferentdates);
  q.q2b(sc, "@ismanualholdingperiodset", ismanualholdingperiodset);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   hasdifferentdates = q.gb(sc,"@hasdifferentdates");
   ismanualholdingperiodset = q.gb(sc,"@ismanualholdingperiodset");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsOptionsVw (DataTable suppliercontractitemids, ref string interiorcode, ref string exteriorcode, ref int interiorid, ref int exteriorid, ref string intdescription, ref string extdescription, ref int quantity, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsOptionsVw (suppliercontractitemids, ref interiorcode, ref exteriorcode, ref interiorid, ref exteriorid, ref intdescription, ref extdescription, ref quantity, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsOptionsVw (DataTable suppliercontractitemids, ref string interiorcode, ref string exteriorcode, ref int interiorid, ref int exteriorid, ref string intdescription, ref string extdescription, ref int quantity, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsOptionsVw (suppliercontractitemids, ref interiorcode, ref exteriorcode, ref interiorid, ref exteriorid, ref intdescription, ref extdescription, ref quantity, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsOptionsVw (DataTable suppliercontractitemids, ref string interiorcode, ref string exteriorcode, ref int interiorid, ref int exteriorid, ref string intdescription, ref string extdescription, ref int quantity, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsOptionsVw (suppliercontractitemids, ref interiorcode, ref exteriorcode, ref interiorid, ref exteriorid, ref intdescription, ref extdescription, ref quantity, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsOptionsVw (DataTable suppliercontractitemids, ref string interiorcode, ref string exteriorcode, ref int interiorid, ref int exteriorid, ref string intdescription, ref string extdescription, ref int quantity, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS__OPTIONS_vw"); 
  q.q2u(sc, "@suppliercontractitemids", "eids", suppliercontractitemids);
  q.q2s(sc, "@interiorcode", interiorcode);
  q.q2s(sc, "@exteriorcode", exteriorcode);
  q.q2i(sc, "@interiorid", interiorid);
  q.q2i(sc, "@exteriorid", exteriorid);
  q.q2s(sc, "@intdescription", intdescription);
  q.q2s(sc, "@extdescription", extdescription);
  q.q2i(sc, "@quantity", quantity);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   interiorcode = q.gs(sc,"@interiorcode");
   exteriorcode = q.gs(sc,"@exteriorcode");
   interiorid = q.gi(sc,"@interiorid");
   exteriorid = q.gi(sc,"@exteriorid");
   intdescription = q.gs(sc,"@intdescription");
   extdescription = q.gs(sc,"@extdescription");
   quantity = q.gi(sc,"@quantity");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsVehicleCostPaste (string globaltablename, DataTable map, int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsVehicleCostPaste (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehicleCostPaste (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsVehicleCostPaste (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehicleCostPaste (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsVehicleCostPaste (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehicleCostPaste (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS__VEHICLE_COST_PASTE"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsVehiclesOrderNosOverwrite (string globaltablename, DataTable map, int suppliercontractid, DataTable suppliercontractitemsids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsVehiclesOrderNosOverwrite (globaltablename, map, suppliercontractid, suppliercontractitemsids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehiclesOrderNosOverwrite (string globaltablename, DataTable map, int suppliercontractid, DataTable suppliercontractitemsids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsVehiclesOrderNosOverwrite (globaltablename, map, suppliercontractid, suppliercontractitemsids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehiclesOrderNosOverwrite (string globaltablename, DataTable map, int suppliercontractid, DataTable suppliercontractitemsids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsVehiclesOrderNosOverwrite (globaltablename, map, suppliercontractid, suppliercontractitemsids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehiclesOrderNosOverwrite (string globaltablename, DataTable map, int suppliercontractid, DataTable suppliercontractitemsids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS__VEHICLES_ORDER_NOS_OVERWRITE"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2u(sc, "@suppliercontractitemsids", "eids", suppliercontractitemsids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsVehiclesOrdernoDummyCreate (int suppliercontractid, DataTable suppliercontractitemsids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsVehiclesOrdernoDummyCreate (suppliercontractid, suppliercontractitemsids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehiclesOrdernoDummyCreate (int suppliercontractid, DataTable suppliercontractitemsids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsVehiclesOrdernoDummyCreate (suppliercontractid, suppliercontractitemsids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehiclesOrdernoDummyCreate (int suppliercontractid, DataTable suppliercontractitemsids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsVehiclesOrdernoDummyCreate (suppliercontractid, suppliercontractitemsids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehiclesOrdernoDummyCreate (int suppliercontractid, DataTable suppliercontractitemsids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS__VEHICLES_ORDERNO_DUMMY_CREATE"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2u(sc, "@suppliercontractitemsids", "eids", suppliercontractitemsids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsVehiclesPaste (string globaltablename, DataTable map, int suppliercontractid, DataTable suppliercontractitemsids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsVehiclesPaste (globaltablename, map, suppliercontractid, suppliercontractitemsids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehiclesPaste (string globaltablename, DataTable map, int suppliercontractid, DataTable suppliercontractitemsids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsVehiclesPaste (globaltablename, map, suppliercontractid, suppliercontractitemsids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehiclesPaste (string globaltablename, DataTable map, int suppliercontractid, DataTable suppliercontractitemsids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsVehiclesPaste (globaltablename, map, suppliercontractid, suppliercontractitemsids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVehiclesPaste (string globaltablename, DataTable map, int suppliercontractid, DataTable suppliercontractitemsids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS__VEHICLES_PASTE"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2u(sc, "@suppliercontractitemsids", "eids", suppliercontractitemsids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsVw (int suppliercontractid, ref bool allowedit, ref string contractcurrencycode, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsVw (suppliercontractid, ref allowedit, ref contractcurrencycode, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVw (int suppliercontractid, ref bool allowedit, ref string contractcurrencycode, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsVw (suppliercontractid, ref allowedit, ref contractcurrencycode, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVw (int suppliercontractid, ref bool allowedit, ref string contractcurrencycode, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsVw (suppliercontractid, ref allowedit, ref contractcurrencycode, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVw (int suppliercontractid, ref bool allowedit, ref string contractcurrencycode, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS_vw"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2b(sc, "@allowedit", allowedit);
  q.q2s(sc, "@contractcurrencycode", contractcurrencycode);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   allowedit = q.gb(sc,"@allowedit");
   contractcurrencycode = q.gs(sc,"@contractcurrencycode");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractItemsVwq (DataTable arrangementvehicleids, int suppliercontractid, int viewindex, ref int newviewindex, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractItemsVwq (arrangementvehicleids, suppliercontractid, viewindex, ref newviewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVwq (DataTable arrangementvehicleids, int suppliercontractid, int viewindex, ref int newviewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractItemsVwq (arrangementvehicleids, suppliercontractid, viewindex, ref newviewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVwq (DataTable arrangementvehicleids, int suppliercontractid, int viewindex, ref int newviewindex, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractItemsVwq (arrangementvehicleids, suppliercontractid, viewindex, ref newviewindex, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractItemsVwq (DataTable arrangementvehicleids, int suppliercontractid, int viewindex, ref int newviewindex, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_ITEMS_vwq"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@viewindex", viewindex);
  q.q2i(sc, "@newviewindex", newviewindex);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   newviewindex = q.gi(sc,"@newviewindex");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractManagersVw (int supplierid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractManagersVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractManagersVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractManagersVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractManagersVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractManagersVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractManagersVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_MANAGERS_vw"); 
  q.q2i(sc, "@supplierid", supplierid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentAdd (int suppliercontractid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amount, string note, decimal vatamount, string paymenttype, int quantity, DataTable arrangementvehicles, decimal amountineur, decimal vatamountineur, decimal fxrate, decimal totalamount, int paycurrencyid, decimal payamount, decimal payvatamount, decimal paytotalamount, int suppliervehicleloadid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentAdd (suppliercontractid, documenttype, documentno, dt, currencyid, amount, note, vatamount, paymenttype, quantity, arrangementvehicles, amountineur, vatamountineur, fxrate, totalamount, paycurrencyid, payamount, payvatamount, paytotalamount, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentAdd (int suppliercontractid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amount, string note, decimal vatamount, string paymenttype, int quantity, DataTable arrangementvehicles, decimal amountineur, decimal vatamountineur, decimal fxrate, decimal totalamount, int paycurrencyid, decimal payamount, decimal payvatamount, decimal paytotalamount, int suppliervehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentAdd (suppliercontractid, documenttype, documentno, dt, currencyid, amount, note, vatamount, paymenttype, quantity, arrangementvehicles, amountineur, vatamountineur, fxrate, totalamount, paycurrencyid, payamount, payvatamount, paytotalamount, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentAdd (int suppliercontractid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amount, string note, decimal vatamount, string paymenttype, int quantity, DataTable arrangementvehicles, decimal amountineur, decimal vatamountineur, decimal fxrate, decimal totalamount, int paycurrencyid, decimal payamount, decimal payvatamount, decimal paytotalamount, int suppliervehicleloadid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentAdd (suppliercontractid, documenttype, documentno, dt, currencyid, amount, note, vatamount, paymenttype, quantity, arrangementvehicles, amountineur, vatamountineur, fxrate, totalamount, paycurrencyid, payamount, payvatamount, paytotalamount, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentAdd (int suppliercontractid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amount, string note, decimal vatamount, string paymenttype, int quantity, DataTable arrangementvehicles, decimal amountineur, decimal vatamountineur, decimal fxrate, decimal totalamount, int paycurrencyid, decimal payamount, decimal payvatamount, decimal paytotalamount, int suppliervehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__ADD"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2s(sc, "@documenttype", documenttype);
  q.q2s(sc, "@documentno", documentno);
  q.q2d(sc, "@dt", dt);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@amount", amount);
  q.q2s(sc, "@note", note);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2s(sc, "@paymenttype", paymenttype);
  q.q2i(sc, "@quantity", quantity);
  q.q2u(sc, "@arrangementvehicles", "earrangementvehicles", arrangementvehicles);
  q.q2e(sc, "@amountineur", amountineur);
  q.q2e(sc, "@vatamountineur", vatamountineur);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@totalamount", totalamount);
  q.q2i(sc, "@paycurrencyid", paycurrencyid);
  q.q2e(sc, "@payamount", payamount);
  q.q2e(sc, "@payvatamount", payvatamount);
  q.q2e(sc, "@paytotalamount", paytotalamount);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentArrangementVehiclesVwq (int suppliercontractpaymentid, int suppliercontractid, int suppliervehicleloadid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentArrangementVehiclesVwq (suppliercontractpaymentid, suppliercontractid, suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentArrangementVehiclesVwq (int suppliercontractpaymentid, int suppliercontractid, int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentArrangementVehiclesVwq (suppliercontractpaymentid, suppliercontractid, suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentArrangementVehiclesVwq (int suppliercontractpaymentid, int suppliercontractid, int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentArrangementVehiclesVwq (suppliercontractpaymentid, suppliercontractid, suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentArrangementVehiclesVwq (int suppliercontractpaymentid, int suppliercontractid, int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__ARRANGEMENT_VEHICLES_vwq"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentCreditMemoNewGet (int suppliercontractid, ref int currencyid, ref int paycurrencyid, ref decimal fxrate, ref decimal amount, ref decimal vatamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal totalamount, ref decimal paytotalamount, ref decimal vatperc, ref string documentno, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentCreditMemoNewGet (suppliercontractid, ref currencyid, ref paycurrencyid, ref fxrate, ref amount, ref vatamount, ref amountineur, ref vatamountineur, ref payamount, ref payvatamount, ref totalamount, ref paytotalamount, ref vatperc, ref documentno, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentCreditMemoNewGet (int suppliercontractid, ref int currencyid, ref int paycurrencyid, ref decimal fxrate, ref decimal amount, ref decimal vatamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal totalamount, ref decimal paytotalamount, ref decimal vatperc, ref string documentno, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentCreditMemoNewGet (suppliercontractid, ref currencyid, ref paycurrencyid, ref fxrate, ref amount, ref vatamount, ref amountineur, ref vatamountineur, ref payamount, ref payvatamount, ref totalamount, ref paytotalamount, ref vatperc, ref documentno, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentCreditMemoNewGet (int suppliercontractid, ref int currencyid, ref int paycurrencyid, ref decimal fxrate, ref decimal amount, ref decimal vatamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal totalamount, ref decimal paytotalamount, ref decimal vatperc, ref string documentno, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentCreditMemoNewGet (suppliercontractid, ref currencyid, ref paycurrencyid, ref fxrate, ref amount, ref vatamount, ref amountineur, ref vatamountineur, ref payamount, ref payvatamount, ref totalamount, ref paytotalamount, ref vatperc, ref documentno, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentCreditMemoNewGet (int suppliercontractid, ref int currencyid, ref int paycurrencyid, ref decimal fxrate, ref decimal amount, ref decimal vatamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal totalamount, ref decimal paytotalamount, ref decimal vatperc, ref string documentno, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__CREDIT_MEMO_NEW_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2i(sc, "@paycurrencyid", paycurrencyid);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2e(sc, "@amountineur", amountineur);
  q.q2e(sc, "@vatamountineur", vatamountineur);
  q.q2e(sc, "@payamount", payamount);
  q.q2e(sc, "@payvatamount", payvatamount);
  q.q2e(sc, "@totalamount", totalamount);
  q.q2e(sc, "@paytotalamount", paytotalamount);
  q.q2e(sc, "@vatperc", vatperc);
  q.q2s(sc, "@documentno", documentno);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   currencyid = q.gi(sc,"@currencyid");
   paycurrencyid = q.gi(sc,"@paycurrencyid");
   fxrate = q.ge(sc,"@fxrate");
   amount = q.ge(sc,"@amount");
   vatamount = q.ge(sc,"@vatamount");
   amountineur = q.ge(sc,"@amountineur");
   vatamountineur = q.ge(sc,"@vatamountineur");
   payamount = q.ge(sc,"@payamount");
   payvatamount = q.ge(sc,"@payvatamount");
   totalamount = q.ge(sc,"@totalamount");
   paytotalamount = q.ge(sc,"@paytotalamount");
   vatperc = q.ge(sc,"@vatperc");
   documentno = q.gs(sc,"@documentno");
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentDelete (int suppliercontractpaymentid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentDelete (suppliercontractpaymentid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentDelete (int suppliercontractpaymentid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentDelete (suppliercontractpaymentid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentDelete (int suppliercontractpaymentid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentDelete (suppliercontractpaymentid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentDelete (int suppliercontractpaymentid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__DELETE"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentEmailGet (int suppliercontractpaymentid, decimal payamount, decimal payvatamount, ref string emailto, ref string subject, ref string body, ref byte[] filebody, ref string filename) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentEmailGet (suppliercontractpaymentid, payamount, payvatamount, ref emailto, ref subject, ref body, ref filebody, ref filename,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentEmailGet (int suppliercontractpaymentid, decimal payamount, decimal payvatamount, ref string emailto, ref string subject, ref string body, ref byte[] filebody, ref string filename,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentEmailGet (suppliercontractpaymentid, payamount, payvatamount, ref emailto, ref subject, ref body, ref filebody, ref filename,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentEmailGet (int suppliercontractpaymentid, decimal payamount, decimal payvatamount, ref string emailto, ref string subject, ref string body, ref byte[] filebody, ref string filename,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentEmailGet (suppliercontractpaymentid, payamount, payvatamount, ref emailto, ref subject, ref body, ref filebody, ref filename,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentEmailGet (int suppliercontractpaymentid, decimal payamount, decimal payvatamount, ref string emailto, ref string subject, ref string body, ref byte[] filebody, ref string filename,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__EMAIL_GET"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2e(sc, "@payamount", payamount);
  q.q2e(sc, "@payvatamount", payvatamount);
  q.q2s(sc, "@emailto", emailto);
  q.q2s(sc, "@subject", subject);
  q.q2s(sc, "@body", body);
  q.q2a(sc, "@filebody", filebody);
  q.q2s(sc, "@filename", filename);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   emailto = q.gs(sc,"@emailto");
   subject = q.gs(sc,"@subject");
   body = q.gs(sc,"@body");
   filebody = q.ga(sc,"@filebody");
   filename = q.gs(sc,"@filename");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentGet (int suppliercontractpaymentid, ref string documenttype, ref string documentno, ref DateTime dt, ref int currencyid, ref decimal amount, ref string note, ref decimal vatamount, ref string proformafilename, ref string invoicefilename, ref string paymenttype, ref int quantity, ref decimal amountineur, ref decimal vatamountineur, ref decimal fxrate, ref decimal totalamount, ref int paycurrencyid, ref decimal payamount, ref decimal payvatamount, ref decimal paytotalamount, ref bool isproformasent, ref bool ispaymentassigned, ref decimal vatperc, ref bool isreopened) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentGet (suppliercontractpaymentid, ref documenttype, ref documentno, ref dt, ref currencyid, ref amount, ref note, ref vatamount, ref proformafilename, ref invoicefilename, ref paymenttype, ref quantity, ref amountineur, ref vatamountineur, ref fxrate, ref totalamount, ref paycurrencyid, ref payamount, ref payvatamount, ref paytotalamount, ref isproformasent, ref ispaymentassigned, ref vatperc, ref isreopened,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentGet (int suppliercontractpaymentid, ref string documenttype, ref string documentno, ref DateTime dt, ref int currencyid, ref decimal amount, ref string note, ref decimal vatamount, ref string proformafilename, ref string invoicefilename, ref string paymenttype, ref int quantity, ref decimal amountineur, ref decimal vatamountineur, ref decimal fxrate, ref decimal totalamount, ref int paycurrencyid, ref decimal payamount, ref decimal payvatamount, ref decimal paytotalamount, ref bool isproformasent, ref bool ispaymentassigned, ref decimal vatperc, ref bool isreopened,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentGet (suppliercontractpaymentid, ref documenttype, ref documentno, ref dt, ref currencyid, ref amount, ref note, ref vatamount, ref proformafilename, ref invoicefilename, ref paymenttype, ref quantity, ref amountineur, ref vatamountineur, ref fxrate, ref totalamount, ref paycurrencyid, ref payamount, ref payvatamount, ref paytotalamount, ref isproformasent, ref ispaymentassigned, ref vatperc, ref isreopened,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentGet (int suppliercontractpaymentid, ref string documenttype, ref string documentno, ref DateTime dt, ref int currencyid, ref decimal amount, ref string note, ref decimal vatamount, ref string proformafilename, ref string invoicefilename, ref string paymenttype, ref int quantity, ref decimal amountineur, ref decimal vatamountineur, ref decimal fxrate, ref decimal totalamount, ref int paycurrencyid, ref decimal payamount, ref decimal payvatamount, ref decimal paytotalamount, ref bool isproformasent, ref bool ispaymentassigned, ref decimal vatperc, ref bool isreopened,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentGet (suppliercontractpaymentid, ref documenttype, ref documentno, ref dt, ref currencyid, ref amount, ref note, ref vatamount, ref proformafilename, ref invoicefilename, ref paymenttype, ref quantity, ref amountineur, ref vatamountineur, ref fxrate, ref totalamount, ref paycurrencyid, ref payamount, ref payvatamount, ref paytotalamount, ref isproformasent, ref ispaymentassigned, ref vatperc, ref isreopened,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentGet (int suppliercontractpaymentid, ref string documenttype, ref string documentno, ref DateTime dt, ref int currencyid, ref decimal amount, ref string note, ref decimal vatamount, ref string proformafilename, ref string invoicefilename, ref string paymenttype, ref int quantity, ref decimal amountineur, ref decimal vatamountineur, ref decimal fxrate, ref decimal totalamount, ref int paycurrencyid, ref decimal payamount, ref decimal payvatamount, ref decimal paytotalamount, ref bool isproformasent, ref bool ispaymentassigned, ref decimal vatperc, ref bool isreopened,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__GET"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2s(sc, "@documenttype", documenttype);
  q.q2s(sc, "@documentno", documentno);
  q.q2d(sc, "@dt", dt);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@amount", amount);
  q.q2s(sc, "@note", note);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2s(sc, "@proformafilename", proformafilename);
  q.q2s(sc, "@invoicefilename", invoicefilename);
  q.q2s(sc, "@paymenttype", paymenttype);
  q.q2i(sc, "@quantity", quantity);
  q.q2e(sc, "@amountineur", amountineur);
  q.q2e(sc, "@vatamountineur", vatamountineur);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@totalamount", totalamount);
  q.q2i(sc, "@paycurrencyid", paycurrencyid);
  q.q2e(sc, "@payamount", payamount);
  q.q2e(sc, "@payvatamount", payvatamount);
  q.q2e(sc, "@paytotalamount", paytotalamount);
  q.q2b(sc, "@isproformasent", isproformasent);
  q.q2b(sc, "@ispaymentassigned", ispaymentassigned);
  q.q2e(sc, "@vatperc", vatperc);
  q.q2b(sc, "@isreopened", isreopened);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   documenttype = q.gs(sc,"@documenttype");
   documentno = q.gs(sc,"@documentno");
   dt = q.gd(sc,"@dt");
   currencyid = q.gi(sc,"@currencyid");
   amount = q.ge(sc,"@amount");
   note = q.gs(sc,"@note");
   vatamount = q.ge(sc,"@vatamount");
   proformafilename = q.gs(sc,"@proformafilename");
   invoicefilename = q.gs(sc,"@invoicefilename");
   paymenttype = q.gs(sc,"@paymenttype");
   quantity = q.gi(sc,"@quantity");
   amountineur = q.ge(sc,"@amountineur");
   vatamountineur = q.ge(sc,"@vatamountineur");
   fxrate = q.ge(sc,"@fxrate");
   totalamount = q.ge(sc,"@totalamount");
   paycurrencyid = q.gi(sc,"@paycurrencyid");
   payamount = q.ge(sc,"@payamount");
   payvatamount = q.ge(sc,"@payvatamount");
   paytotalamount = q.ge(sc,"@paytotalamount");
   isproformasent = q.gb(sc,"@isproformasent");
   ispaymentassigned = q.gb(sc,"@ispaymentassigned");
   vatperc = q.ge(sc,"@vatperc");
   isreopened = q.gb(sc,"@isreopened");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentInvoiceBodyGet (int suppliercontractpaymentid, ref string fn, ref byte[] b) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentInvoiceBodyGet (suppliercontractpaymentid, ref fn, ref b,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentInvoiceBodyGet (int suppliercontractpaymentid, ref string fn, ref byte[] b,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentInvoiceBodyGet (suppliercontractpaymentid, ref fn, ref b,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentInvoiceBodyGet (int suppliercontractpaymentid, ref string fn, ref byte[] b,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentInvoiceBodyGet (suppliercontractpaymentid, ref fn, ref b,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentInvoiceBodyGet (int suppliercontractpaymentid, ref string fn, ref byte[] b,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__INVOICE_BODY_GET"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2s(sc, "@fn", fn);
  q.q2a(sc, "@b", b);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   fn = q.gs(sc,"@fn");
   b = q.ga(sc,"@b");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentNewGet (int suppliercontractid, int suppliervehicleloadid, bool iscreditmemo, ref int currencyid, ref int paycurrencyid, ref bool isfirstpayment, ref decimal fxrate, ref decimal amount, ref decimal vatamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal totalamount, ref decimal paytotalamount, ref decimal vatperc, ref string documentno) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentNewGet (suppliercontractid, suppliervehicleloadid, iscreditmemo, ref currencyid, ref paycurrencyid, ref isfirstpayment, ref fxrate, ref amount, ref vatamount, ref amountineur, ref vatamountineur, ref payamount, ref payvatamount, ref totalamount, ref paytotalamount, ref vatperc, ref documentno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentNewGet (int suppliercontractid, int suppliervehicleloadid, bool iscreditmemo, ref int currencyid, ref int paycurrencyid, ref bool isfirstpayment, ref decimal fxrate, ref decimal amount, ref decimal vatamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal totalamount, ref decimal paytotalamount, ref decimal vatperc, ref string documentno,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentNewGet (suppliercontractid, suppliervehicleloadid, iscreditmemo, ref currencyid, ref paycurrencyid, ref isfirstpayment, ref fxrate, ref amount, ref vatamount, ref amountineur, ref vatamountineur, ref payamount, ref payvatamount, ref totalamount, ref paytotalamount, ref vatperc, ref documentno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentNewGet (int suppliercontractid, int suppliervehicleloadid, bool iscreditmemo, ref int currencyid, ref int paycurrencyid, ref bool isfirstpayment, ref decimal fxrate, ref decimal amount, ref decimal vatamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal totalamount, ref decimal paytotalamount, ref decimal vatperc, ref string documentno,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentNewGet (suppliercontractid, suppliervehicleloadid, iscreditmemo, ref currencyid, ref paycurrencyid, ref isfirstpayment, ref fxrate, ref amount, ref vatamount, ref amountineur, ref vatamountineur, ref payamount, ref payvatamount, ref totalamount, ref paytotalamount, ref vatperc, ref documentno,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentNewGet (int suppliercontractid, int suppliervehicleloadid, bool iscreditmemo, ref int currencyid, ref int paycurrencyid, ref bool isfirstpayment, ref decimal fxrate, ref decimal amount, ref decimal vatamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal totalamount, ref decimal paytotalamount, ref decimal vatperc, ref string documentno,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__NEW_GET"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2b(sc, "@iscreditmemo", iscreditmemo);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2i(sc, "@paycurrencyid", paycurrencyid);
  q.q2b(sc, "@isfirstpayment", isfirstpayment);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2e(sc, "@amountineur", amountineur);
  q.q2e(sc, "@vatamountineur", vatamountineur);
  q.q2e(sc, "@payamount", payamount);
  q.q2e(sc, "@payvatamount", payvatamount);
  q.q2e(sc, "@totalamount", totalamount);
  q.q2e(sc, "@paytotalamount", paytotalamount);
  q.q2e(sc, "@vatperc", vatperc);
  q.q2s(sc, "@documentno", documentno);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   currencyid = q.gi(sc,"@currencyid");
   paycurrencyid = q.gi(sc,"@paycurrencyid");
   isfirstpayment = q.gb(sc,"@isfirstpayment");
   fxrate = q.ge(sc,"@fxrate");
   amount = q.ge(sc,"@amount");
   vatamount = q.ge(sc,"@vatamount");
   amountineur = q.ge(sc,"@amountineur");
   vatamountineur = q.ge(sc,"@vatamountineur");
   payamount = q.ge(sc,"@payamount");
   payvatamount = q.ge(sc,"@payvatamount");
   totalamount = q.ge(sc,"@totalamount");
   paytotalamount = q.ge(sc,"@paytotalamount");
   vatperc = q.ge(sc,"@vatperc");
   documentno = q.gs(sc,"@documentno");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentNoteGet (int suppliercontractpaymentid, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentNoteGet (suppliercontractpaymentid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentNoteGet (int suppliercontractpaymentid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentNoteGet (suppliercontractpaymentid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentNoteGet (int suppliercontractpaymentid, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentNoteGet (suppliercontractpaymentid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentNoteGet (int suppliercontractpaymentid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__NOTE_GET"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentNoteSet (int suppliercontractpaymentid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentNoteSet (suppliercontractpaymentid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentNoteSet (int suppliercontractpaymentid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentNoteSet (suppliercontractpaymentid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentNoteSet (int suppliercontractpaymentid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentNoteSet (suppliercontractpaymentid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentNoteSet (int suppliercontractpaymentid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__NOTE_SET"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentProformaBodyGet (int suppliercontractpaymentid, ref string fn, ref byte[] b) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentProformaBodyGet (suppliercontractpaymentid, ref fn, ref b,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentProformaBodyGet (int suppliercontractpaymentid, ref string fn, ref byte[] b,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentProformaBodyGet (suppliercontractpaymentid, ref fn, ref b,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentProformaBodyGet (int suppliercontractpaymentid, ref string fn, ref byte[] b,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentProformaBodyGet (suppliercontractpaymentid, ref fn, ref b,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentProformaBodyGet (int suppliercontractpaymentid, ref string fn, ref byte[] b,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__PROFORMA_BODY_GET"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2s(sc, "@fn", fn);
  q.q2a(sc, "@b", b);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   fn = q.gs(sc,"@fn");
   b = q.ga(sc,"@b");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentProformaBodyUpload (int suppliercontractpaymentid, string fn, string ext, byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentProformaBodyUpload (suppliercontractpaymentid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentProformaBodyUpload (int suppliercontractpaymentid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentProformaBodyUpload (suppliercontractpaymentid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentProformaBodyUpload (int suppliercontractpaymentid, string fn, string ext, byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentProformaBodyUpload (suppliercontractpaymentid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentProformaBodyUpload (int suppliercontractpaymentid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__PROFORMA_BODY_UPLOAD"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2s(sc, "@fn", fn);
  q.q2s(sc, "@ext", ext);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentProformaSentSet (int suppliercontractpaymentid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentProformaSentSet (suppliercontractpaymentid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentProformaSentSet (int suppliercontractpaymentid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentProformaSentSet (suppliercontractpaymentid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentProformaSentSet (int suppliercontractpaymentid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentProformaSentSet (suppliercontractpaymentid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentProformaSentSet (int suppliercontractpaymentid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__PROFORMA_SENT_SET"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentUpdate (int suppliercontractpaymentid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amount, string note, decimal vatamount, string paymenttype, int quantity, DataTable arrangementvehicles, decimal amountineur, decimal vatamountineur, decimal fxrate, decimal totalamount, int paycurrencyid, decimal payamount, decimal payvatamount, decimal paytotalamount, int suppliervehicleloadid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentUpdate (suppliercontractpaymentid, documenttype, documentno, dt, currencyid, amount, note, vatamount, paymenttype, quantity, arrangementvehicles, amountineur, vatamountineur, fxrate, totalamount, paycurrencyid, payamount, payvatamount, paytotalamount, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentUpdate (int suppliercontractpaymentid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amount, string note, decimal vatamount, string paymenttype, int quantity, DataTable arrangementvehicles, decimal amountineur, decimal vatamountineur, decimal fxrate, decimal totalamount, int paycurrencyid, decimal payamount, decimal payvatamount, decimal paytotalamount, int suppliervehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentUpdate (suppliercontractpaymentid, documenttype, documentno, dt, currencyid, amount, note, vatamount, paymenttype, quantity, arrangementvehicles, amountineur, vatamountineur, fxrate, totalamount, paycurrencyid, payamount, payvatamount, paytotalamount, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentUpdate (int suppliercontractpaymentid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amount, string note, decimal vatamount, string paymenttype, int quantity, DataTable arrangementvehicles, decimal amountineur, decimal vatamountineur, decimal fxrate, decimal totalamount, int paycurrencyid, decimal payamount, decimal payvatamount, decimal paytotalamount, int suppliervehicleloadid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentUpdate (suppliercontractpaymentid, documenttype, documentno, dt, currencyid, amount, note, vatamount, paymenttype, quantity, arrangementvehicles, amountineur, vatamountineur, fxrate, totalamount, paycurrencyid, payamount, payvatamount, paytotalamount, suppliervehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentUpdate (int suppliercontractpaymentid, string documenttype, string documentno, DateTime dt, int currencyid, decimal amount, string note, decimal vatamount, string paymenttype, int quantity, DataTable arrangementvehicles, decimal amountineur, decimal vatamountineur, decimal fxrate, decimal totalamount, int paycurrencyid, decimal payamount, decimal payvatamount, decimal paytotalamount, int suppliervehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT__UPDATE"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2s(sc, "@documenttype", documenttype);
  q.q2s(sc, "@documentno", documentno);
  q.q2d(sc, "@dt", dt);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@amount", amount);
  q.q2s(sc, "@note", note);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2s(sc, "@paymenttype", paymenttype);
  q.q2i(sc, "@quantity", quantity);
  q.q2u(sc, "@arrangementvehicles", "earrangementvehicles", arrangementvehicles);
  q.q2e(sc, "@amountineur", amountineur);
  q.q2e(sc, "@vatamountineur", vatamountineur);
  q.q2e(sc, "@fxrate", fxrate);
  q.q2e(sc, "@totalamount", totalamount);
  q.q2i(sc, "@paycurrencyid", paycurrencyid);
  q.q2e(sc, "@payamount", payamount);
  q.q2e(sc, "@payvatamount", payvatamount);
  q.q2e(sc, "@paytotalamount", paytotalamount);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentVehiclesAmountsGet (int suppliercontractpaymentid, DataTable arrangmentvehicleids, int suppliervehicleloadid, ref decimal amount, ref decimal vatamount, ref decimal totalamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal paytotalamount) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentVehiclesAmountsGet (suppliercontractpaymentid, arrangmentvehicleids, suppliervehicleloadid, ref amount, ref vatamount, ref totalamount, ref amountineur, ref vatamountineur, ref payamount, ref payvatamount, ref paytotalamount,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentVehiclesAmountsGet (int suppliercontractpaymentid, DataTable arrangmentvehicleids, int suppliervehicleloadid, ref decimal amount, ref decimal vatamount, ref decimal totalamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal paytotalamount,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentVehiclesAmountsGet (suppliercontractpaymentid, arrangmentvehicleids, suppliervehicleloadid, ref amount, ref vatamount, ref totalamount, ref amountineur, ref vatamountineur, ref payamount, ref payvatamount, ref paytotalamount,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentVehiclesAmountsGet (int suppliercontractpaymentid, DataTable arrangmentvehicleids, int suppliervehicleloadid, ref decimal amount, ref decimal vatamount, ref decimal totalamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal paytotalamount,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentVehiclesAmountsGet (suppliercontractpaymentid, arrangmentvehicleids, suppliervehicleloadid, ref amount, ref vatamount, ref totalamount, ref amountineur, ref vatamountineur, ref payamount, ref payvatamount, ref paytotalamount,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentVehiclesAmountsGet (int suppliercontractpaymentid, DataTable arrangmentvehicleids, int suppliervehicleloadid, ref decimal amount, ref decimal vatamount, ref decimal totalamount, ref decimal amountineur, ref decimal vatamountineur, ref decimal payamount, ref decimal payvatamount, ref decimal paytotalamount,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENT_VEHICLES__AMOUNTS_GET"); 
  q.q2i(sc, "@suppliercontractpaymentid", suppliercontractpaymentid);
  q.q2u(sc, "@arrangmentvehicleids", "earrangementvehicles", arrangmentvehicleids);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@vatamount", vatamount);
  q.q2e(sc, "@totalamount", totalamount);
  q.q2e(sc, "@amountineur", amountineur);
  q.q2e(sc, "@vatamountineur", vatamountineur);
  q.q2e(sc, "@payamount", payamount);
  q.q2e(sc, "@payvatamount", payvatamount);
  q.q2e(sc, "@paytotalamount", paytotalamount);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   amount = q.ge(sc,"@amount");
   vatamount = q.ge(sc,"@vatamount");
   totalamount = q.ge(sc,"@totalamount");
   amountineur = q.ge(sc,"@amountineur");
   vatamountineur = q.ge(sc,"@vatamountineur");
   payamount = q.ge(sc,"@payamount");
   payvatamount = q.ge(sc,"@payvatamount");
   paytotalamount = q.ge(sc,"@paytotalamount");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractPaymentsVw (int suppliercontractid, ref bool haspaymentassigned, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractPaymentsVw (suppliercontractid, ref haspaymentassigned, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentsVw (int suppliercontractid, ref bool haspaymentassigned, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractPaymentsVw (suppliercontractid, ref haspaymentassigned, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentsVw (int suppliercontractid, ref bool haspaymentassigned, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractPaymentsVw (suppliercontractid, ref haspaymentassigned, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractPaymentsVw (int suppliercontractid, ref bool haspaymentassigned, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_PAYMENTS_vw"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2b(sc, "@haspaymentassigned", haspaymentassigned);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   haspaymentassigned = q.gb(sc,"@haspaymentassigned");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehicleQuotaImport (string globaltablename, DataTable map, int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehicleQuotaImport (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleQuotaImport (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehicleQuotaImport (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleQuotaImport (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehicleQuotaImport (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleQuotaImport (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_VEHICLE__QUOTA_IMPORT"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehicleStockImport (string globaltablename, DataTable map, int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehicleStockImport (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleStockImport (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehicleStockImport (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleStockImport (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehicleStockImport (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleStockImport (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_VEHICLE__STOCK_IMPORT"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehicleLoadsNewVw (int suppliercontractid, int suppliervehicleloadid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehicleLoadsNewVw (suppliercontractid, suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleLoadsNewVw (int suppliercontractid, int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehicleLoadsNewVw (suppliercontractid, suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleLoadsNewVw (int suppliercontractid, int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehicleLoadsNewVw (suppliercontractid, suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleLoadsNewVw (int suppliercontractid, int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_VEHICLE_LOADS_NEW_vw"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehicleLoadsVw (int suppliercontractid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehicleLoadsVw (suppliercontractid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleLoadsVw (int suppliercontractid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehicleLoadsVw (suppliercontractid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleLoadsVw (int suppliercontractid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehicleLoadsVw (suppliercontractid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleLoadsVw (int suppliercontractid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_VEHICLE_LOADS_vw"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehiclePaste (int suppliercontractid, string columnsstring, string clipboarddata) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehiclePaste (suppliercontractid, columnsstring, clipboarddata,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclePaste (int suppliercontractid, string columnsstring, string clipboarddata,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehiclePaste (suppliercontractid, columnsstring, clipboarddata,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclePaste (int suppliercontractid, string columnsstring, string clipboarddata,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehiclePaste (suppliercontractid, columnsstring, clipboarddata,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclePaste (int suppliercontractid, string columnsstring, string clipboarddata,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_VEHICLE_PASTE"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2s(sc, "@columnsstring", columnsstring);
  q.q2s(sc, "@clipboarddata", clipboarddata);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehiclePasteQuota (int suppliercontractid, string columnsstring, string clipboarddata) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehiclePasteQuota (suppliercontractid, columnsstring, clipboarddata,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclePasteQuota (int suppliercontractid, string columnsstring, string clipboarddata,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehiclePasteQuota (suppliercontractid, columnsstring, clipboarddata,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclePasteQuota (int suppliercontractid, string columnsstring, string clipboarddata,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehiclePasteQuota (suppliercontractid, columnsstring, clipboarddata,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclePasteQuota (int suppliercontractid, string columnsstring, string clipboarddata,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_VEHICLE_PASTE_QUOTA"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2s(sc, "@columnsstring", columnsstring);
  q.q2s(sc, "@clipboarddata", clipboarddata);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehicleVinUpdate (DataTable vehicles, string vin) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehicleVinUpdate (vehicles, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleVinUpdate (DataTable vehicles, string vin,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehicleVinUpdate (vehicles, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleVinUpdate (DataTable vehicles, string vin,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehicleVinUpdate (vehicles, vin,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehicleVinUpdate (DataTable vehicles, string vin,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_VEHICLE_VIN_UPDATE"); 
  q.q2u(sc, "@vehicles", "eids", vehicles);
  q.q2s(sc, "@vin", vin);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehiclesDatesUpdate (DataTable suppliercontractvehiclesids, int suppliercontractid, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int holdperiod, int documentholdperiod, DateTime loadingfromsupplierat, int registrationperiod, DateTime loadingday, bool changevehicleatvendor, bool changeplannedpayment, int transportationperiod) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehiclesDatesUpdate (suppliercontractvehiclesids, suppliercontractid, vehiclesatvendor, plannedpaymentat, preparationperiod, holdperiod, documentholdperiod, loadingfromsupplierat, registrationperiod, loadingday, changevehicleatvendor, changeplannedpayment, transportationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesDatesUpdate (DataTable suppliercontractvehiclesids, int suppliercontractid, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int holdperiod, int documentholdperiod, DateTime loadingfromsupplierat, int registrationperiod, DateTime loadingday, bool changevehicleatvendor, bool changeplannedpayment, int transportationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehiclesDatesUpdate (suppliercontractvehiclesids, suppliercontractid, vehiclesatvendor, plannedpaymentat, preparationperiod, holdperiod, documentholdperiod, loadingfromsupplierat, registrationperiod, loadingday, changevehicleatvendor, changeplannedpayment, transportationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesDatesUpdate (DataTable suppliercontractvehiclesids, int suppliercontractid, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int holdperiod, int documentholdperiod, DateTime loadingfromsupplierat, int registrationperiod, DateTime loadingday, bool changevehicleatvendor, bool changeplannedpayment, int transportationperiod,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehiclesDatesUpdate (suppliercontractvehiclesids, suppliercontractid, vehiclesatvendor, plannedpaymentat, preparationperiod, holdperiod, documentholdperiod, loadingfromsupplierat, registrationperiod, loadingday, changevehicleatvendor, changeplannedpayment, transportationperiod,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesDatesUpdate (DataTable suppliercontractvehiclesids, int suppliercontractid, DateTime vehiclesatvendor, DateTime plannedpaymentat, int preparationperiod, int holdperiod, int documentholdperiod, DateTime loadingfromsupplierat, int registrationperiod, DateTime loadingday, bool changevehicleatvendor, bool changeplannedpayment, int transportationperiod,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_VEHICLES__DATES_UPDATE"); 
  q.q2u(sc, "@suppliercontractvehiclesids", "eids", suppliercontractvehiclesids);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2d(sc, "@vehiclesatvendor", vehiclesatvendor);
  q.q2d(sc, "@plannedpaymentat", plannedpaymentat);
  q.q2i(sc, "@preparationperiod", preparationperiod);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2i(sc, "@documentholdperiod", documentholdperiod);
  q.q2d(sc, "@loadingfromsupplierat", loadingfromsupplierat);
  q.q2i(sc, "@registrationperiod", registrationperiod);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2b(sc, "@changevehicleatvendor", changevehicleatvendor);
  q.q2b(sc, "@changeplannedpayment", changeplannedpayment);
  q.q2i(sc, "@transportationperiod", transportationperiod);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehiclesOptionsVw (DataTable arrangementvehicleids, ref string interiorcode, ref string exteriorcode, ref int interiorid, ref int exteriorid, ref string intdescription, ref string extdescription, ref int quantity, ref decimal purchaseprice, ref decimal buffer, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehiclesOptionsVw (arrangementvehicleids, ref interiorcode, ref exteriorcode, ref interiorid, ref exteriorid, ref intdescription, ref extdescription, ref quantity, ref purchaseprice, ref buffer, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesOptionsVw (DataTable arrangementvehicleids, ref string interiorcode, ref string exteriorcode, ref int interiorid, ref int exteriorid, ref string intdescription, ref string extdescription, ref int quantity, ref decimal purchaseprice, ref decimal buffer, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehiclesOptionsVw (arrangementvehicleids, ref interiorcode, ref exteriorcode, ref interiorid, ref exteriorid, ref intdescription, ref extdescription, ref quantity, ref purchaseprice, ref buffer, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesOptionsVw (DataTable arrangementvehicleids, ref string interiorcode, ref string exteriorcode, ref int interiorid, ref int exteriorid, ref string intdescription, ref string extdescription, ref int quantity, ref decimal purchaseprice, ref decimal buffer, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehiclesOptionsVw (arrangementvehicleids, ref interiorcode, ref exteriorcode, ref interiorid, ref exteriorid, ref intdescription, ref extdescription, ref quantity, ref purchaseprice, ref buffer, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesOptionsVw (DataTable arrangementvehicleids, ref string interiorcode, ref string exteriorcode, ref int interiorid, ref int exteriorid, ref string intdescription, ref string extdescription, ref int quantity, ref decimal purchaseprice, ref decimal buffer, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_VEHICLES__OPTIONS_vw"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2s(sc, "@interiorcode", interiorcode);
  q.q2s(sc, "@exteriorcode", exteriorcode);
  q.q2i(sc, "@interiorid", interiorid);
  q.q2i(sc, "@exteriorid", exteriorid);
  q.q2s(sc, "@intdescription", intdescription);
  q.q2s(sc, "@extdescription", extdescription);
  q.q2i(sc, "@quantity", quantity);
  q.q2e(sc, "@purchaseprice", purchaseprice);
  q.q2e(sc, "@buffer", buffer);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   interiorcode = q.gs(sc,"@interiorcode");
   exteriorcode = q.gs(sc,"@exteriorcode");
   interiorid = q.gi(sc,"@interiorid");
   exteriorid = q.gi(sc,"@exteriorid");
   intdescription = q.gs(sc,"@intdescription");
   extdescription = q.gs(sc,"@extdescription");
   quantity = q.gi(sc,"@quantity");
   purchaseprice = q.ge(sc,"@purchaseprice");
   buffer = q.ge(sc,"@buffer");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehiclesVinUpdate (string globaltablename, DataTable map, int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehiclesVinUpdate (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesVinUpdate (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehiclesVinUpdate (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesVinUpdate (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehiclesVinUpdate (globaltablename, map, suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesVinUpdate (string globaltablename, DataTable map, int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_VEHICLES_VIN_UPDATE"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractVehiclesVw (int suppliercontractid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractVehiclesVw (suppliercontractid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesVw (int suppliercontractid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractVehiclesVw (suppliercontractid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesVw (int suppliercontractid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractVehiclesVw (suppliercontractid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractVehiclesVw (int suppliercontractid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACT_VEHICLES_vw"); 
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractsHedgeInfoPaste (string globaltablename, DataTable map, DataTable suppliercontractids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractsHedgeInfoPaste (globaltablename, map, suppliercontractids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractsHedgeInfoPaste (string globaltablename, DataTable map, DataTable suppliercontractids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractsHedgeInfoPaste (globaltablename, map, suppliercontractids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractsHedgeInfoPaste (string globaltablename, DataTable map, DataTable suppliercontractids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractsHedgeInfoPaste (globaltablename, map, suppliercontractids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractsHedgeInfoPaste (string globaltablename, DataTable map, DataTable suppliercontractids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACTS__HEDGE_INFO_PASTE"); 
  q.q2s(sc, "@globaltablename", globaltablename);
  q.q2u(sc, "@map", "eexcelcolmap", map);
  q.q2u(sc, "@suppliercontractids", "eids", suppliercontractids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractsOwnershipTransfer (DataTable suppliercontractids, int newstaffid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractsOwnershipTransfer (suppliercontractids, newstaffid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractsOwnershipTransfer (DataTable suppliercontractids, int newstaffid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractsOwnershipTransfer (suppliercontractids, newstaffid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractsOwnershipTransfer (DataTable suppliercontractids, int newstaffid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractsOwnershipTransfer (suppliercontractids, newstaffid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractsOwnershipTransfer (DataTable suppliercontractids, int newstaffid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACTS__OWNERSHIP_TRANSFER"); 
  q.q2u(sc, "@suppliercontractids", "eids", suppliercontractids);
  q.q2i(sc, "@newstaffid", newstaffid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierContractsVw (int supplierid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierContractsVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractsVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierContractsVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractsVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierContractsVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierContractsVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_CONTRACTS_vw"); 
  q.q2i(sc, "@supplierid", supplierid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierFileDirectoriesVw (int supplierid, int parentid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierFileDirectoriesVw (supplierid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoriesVw (int supplierid, int parentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierFileDirectoriesVw (supplierid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoriesVw (int supplierid, int parentid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierFileDirectoriesVw (supplierid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoriesVw (int supplierid, int parentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_FILE__DIRECTORIES_vw"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@parentid", parentid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierFileDirectoryDelete (int supplierid, int supplierfileid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierFileDirectoryDelete (supplierid, supplierfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoryDelete (int supplierid, int supplierfileid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierFileDirectoryDelete (supplierid, supplierfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoryDelete (int supplierid, int supplierfileid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierFileDirectoryDelete (supplierid, supplierfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoryDelete (int supplierid, int supplierfileid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_FILE__DIRECTORY_DELETE"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@supplierfileid", supplierfileid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierFileDirectoryNew (int supplierid, int parentid, ref int newid, ref string newname) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierFileDirectoryNew (supplierid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoryNew (int supplierid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierFileDirectoryNew (supplierid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoryNew (int supplierid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierFileDirectoryNew (supplierid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoryNew (int supplierid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_FILE__DIRECTORY_NEW"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@parentid", parentid);
  q.q2i(sc, "@newid", newid);
  q.q2s(sc, "@newname", newname);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   newid = q.gi(sc,"@newid");
   newname = q.gs(sc,"@newname");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierFileDirectoryRename (int supplierid, int supplierfileid, string name) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierFileDirectoryRename (supplierid, supplierfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoryRename (int supplierid, int supplierfileid, string name,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierFileDirectoryRename (supplierid, supplierfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoryRename (int supplierid, int supplierfileid, string name,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierFileDirectoryRename (supplierid, supplierfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileDirectoryRename (int supplierid, int supplierfileid, string name,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_FILE__DIRECTORY_RENAME"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@supplierfileid", supplierfileid);
  q.q2s(sc, "@name", name);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierFileFileAdd (int supplierid, int dirsupplierfileid, string fn, string ext, byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierFileFileAdd (supplierid, dirsupplierfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileAdd (int supplierid, int dirsupplierfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierFileFileAdd (supplierid, dirsupplierfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileAdd (int supplierid, int dirsupplierfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierFileFileAdd (supplierid, dirsupplierfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileAdd (int supplierid, int dirsupplierfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_FILE__FILE_ADD"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@dirsupplierfileid", dirsupplierfileid);
  q.q2s(sc, "@fn", fn);
  q.q2s(sc, "@ext", ext);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierFileFileDelete (int supplierid, int supplierfileid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierFileFileDelete (supplierid, supplierfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileDelete (int supplierid, int supplierfileid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierFileFileDelete (supplierid, supplierfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileDelete (int supplierid, int supplierfileid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierFileFileDelete (supplierid, supplierfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileDelete (int supplierid, int supplierfileid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_FILE__FILE_DELETE"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@supplierfileid", supplierfileid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierFileFileInfoGet (int supplierid, int supplierfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierFileFileInfoGet (supplierid, supplierfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileInfoGet (int supplierid, int supplierfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierFileFileInfoGet (supplierid, supplierfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileInfoGet (int supplierid, int supplierfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierFileFileInfoGet (supplierid, supplierfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileInfoGet (int supplierid, int supplierfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_FILE__FILE_INFO_GET"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@supplierfileid", supplierfileid);
  q.q2s(sc, "@name", name);
  q.q2dt(sc, "@uploaded", uploaded);
  q.q2s(sc, "@type", type);
  q.q2i(sc, "@size", size);
  q.q2s(sc, "@uploadedby", uploadedby);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   name = q.gs(sc,"@name");
   uploaded = q.gdt(sc,"@uploaded");
   type = q.gs(sc,"@type");
   size = q.gi(sc,"@size");
   uploadedby = q.gs(sc,"@uploadedby");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierFileFileOpenGet (int supplierid, int supplierfileid, ref string fn, ref byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierFileFileOpenGet (supplierid, supplierfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileOpenGet (int supplierid, int supplierfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierFileFileOpenGet (supplierid, supplierfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileOpenGet (int supplierid, int supplierfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierFileFileOpenGet (supplierid, supplierfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileOpenGet (int supplierid, int supplierfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_FILE__FILE_OPEN_GET"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@supplierfileid", supplierfileid);
  q.q2s(sc, "@fn", fn);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   fn = q.gs(sc,"@fn");
   body = q.ga(sc,"@body");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierFileFileRename (int supplierid, int supplierfileid, string newfn) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierFileFileRename (supplierid, supplierfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileRename (int supplierid, int supplierfileid, string newfn,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierFileFileRename (supplierid, supplierfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileRename (int supplierid, int supplierfileid, string newfn,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierFileFileRename (supplierid, supplierfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFileRename (int supplierid, int supplierfileid, string newfn,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_FILE__FILE_RENAME"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@supplierfileid", supplierfileid);
  q.q2s(sc, "@newfn", newfn);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierFileFilesVw (int supplierid, int supplierfileid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierFileFilesVw (supplierid, supplierfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFilesVw (int supplierid, int supplierfileid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierFileFilesVw (supplierid, supplierfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFilesVw (int supplierid, int supplierfileid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierFileFilesVw (supplierid, supplierfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFileFilesVw (int supplierid, int supplierfileid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_FILE__FILES_vw"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@supplierfileid", supplierfileid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierFollowupsVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierFollowupsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFollowupsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierFollowupsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFollowupsVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierFollowupsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierFollowupsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_FOLLOWUPS_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierIbanAdd2 (int supplierid, string iban, string prtybankname, string prtybankswift) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierIbanAdd2 (supplierid, iban, prtybankname, prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanAdd2 (int supplierid, string iban, string prtybankname, string prtybankswift,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierIbanAdd2 (supplierid, iban, prtybankname, prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanAdd2 (int supplierid, string iban, string prtybankname, string prtybankswift,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierIbanAdd2 (supplierid, iban, prtybankname, prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanAdd2 (int supplierid, string iban, string prtybankname, string prtybankswift,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_IBAN__ADD2"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2s(sc, "@iban", iban);
  q.q2s(sc, "@prtybankname", prtybankname);
  q.q2s(sc, "@prtybankswift", prtybankswift);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierIbanDelete (int supplieribanid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierIbanDelete (supplieribanid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanDelete (int supplieribanid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierIbanDelete (supplieribanid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanDelete (int supplieribanid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierIbanDelete (supplieribanid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanDelete (int supplieribanid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_IBAN__DELETE"); 
  q.q2i(sc, "@supplieribanid", supplieribanid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierIbanGet2 (int supplierbanid, ref string iban, ref string prtybankname, ref string prtybankswift) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierIbanGet2 (supplierbanid, ref iban, ref prtybankname, ref prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanGet2 (int supplierbanid, ref string iban, ref string prtybankname, ref string prtybankswift,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierIbanGet2 (supplierbanid, ref iban, ref prtybankname, ref prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanGet2 (int supplierbanid, ref string iban, ref string prtybankname, ref string prtybankswift,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierIbanGet2 (supplierbanid, ref iban, ref prtybankname, ref prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanGet2 (int supplierbanid, ref string iban, ref string prtybankname, ref string prtybankswift,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_IBAN__GET2"); 
  q.q2i(sc, "@supplierbanid", supplierbanid);
  q.q2s(sc, "@iban", iban);
  q.q2s(sc, "@prtybankname", prtybankname);
  q.q2s(sc, "@prtybankswift", prtybankswift);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   iban = q.gs(sc,"@iban");
   prtybankname = q.gs(sc,"@prtybankname");
   prtybankswift = q.gs(sc,"@prtybankswift");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierIbanInfoGet (string iban, ref string prtybankname, ref string prtybankswift) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierIbanInfoGet (iban, ref prtybankname, ref prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanInfoGet (string iban, ref string prtybankname, ref string prtybankswift,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierIbanInfoGet (iban, ref prtybankname, ref prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanInfoGet (string iban, ref string prtybankname, ref string prtybankswift,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierIbanInfoGet (iban, ref prtybankname, ref prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanInfoGet (string iban, ref string prtybankname, ref string prtybankswift,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_IBAN__INFO_GET"); 
  q.q2s(sc, "@iban", iban);
  q.q2s(sc, "@prtybankname", prtybankname);
  q.q2s(sc, "@prtybankswift", prtybankswift);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   prtybankname = q.gs(sc,"@prtybankname");
   prtybankswift = q.gs(sc,"@prtybankswift");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierIbanUpdate2 (int supplieribanid, string iban, string prtybankname, string prtybankswift) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierIbanUpdate2 (supplieribanid, iban, prtybankname, prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanUpdate2 (int supplieribanid, string iban, string prtybankname, string prtybankswift,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierIbanUpdate2 (supplieribanid, iban, prtybankname, prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanUpdate2 (int supplieribanid, string iban, string prtybankname, string prtybankswift,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierIbanUpdate2 (supplieribanid, iban, prtybankname, prtybankswift,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbanUpdate2 (int supplieribanid, string iban, string prtybankname, string prtybankswift,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_IBAN__UPDATE2"); 
  q.q2i(sc, "@supplieribanid", supplieribanid);
  q.q2s(sc, "@iban", iban);
  q.q2s(sc, "@prtybankname", prtybankname);
  q.q2s(sc, "@prtybankswift", prtybankswift);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierIbansVw (int supplierid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierIbansVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbansVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierIbansVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbansVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierIbansVw (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierIbansVw (int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_IBANS_vw"); 
  q.q2i(sc, "@supplierid", supplierid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierInfoGet (int supplierid, ref string name) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierInfoGet (supplierid, ref name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierInfoGet (int supplierid, ref string name,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierInfoGet (supplierid, ref name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierInfoGet (int supplierid, ref string name,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierInfoGet (supplierid, ref name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierInfoGet (int supplierid, ref string name,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_INFO_GET"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2s(sc, "@name", name);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   name = q.gs(sc,"@name");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierStaffsAdd (int supplierid, DataTable staffids, ref string staffname) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierStaffsAdd (supplierid, staffids, ref staffname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierStaffsAdd (int supplierid, DataTable staffids, ref string staffname,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierStaffsAdd (supplierid, staffids, ref staffname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierStaffsAdd (int supplierid, DataTable staffids, ref string staffname,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierStaffsAdd (supplierid, staffids, ref staffname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierStaffsAdd (int supplierid, DataTable staffids, ref string staffname,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_STAFFS__ADD"); 
  q.q2i(sc, "@supplierid", supplierid);
  q.q2u(sc, "@staffids", "eids", staffids);
  q.q2s(sc, "@staffname", staffname);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   staffname = q.gs(sc,"@staffname");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierStaffsSelectVwq (int supplierid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierStaffsSelectVwq (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierStaffsSelectVwq (int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierStaffsSelectVwq (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierStaffsSelectVwq (int supplierid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierStaffsSelectVwq (supplierid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierStaffsSelectVwq (int supplierid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_STAFFS_SELECT_vwq"); 
  q.q2i(sc, "@supplierid", supplierid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadAdd (DataTable arrangementvehicleids, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, int supplierid, int loadnum, int quantity, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadAdd (arrangementvehicleids, pickupcountryid, pickupaddress, currencyid, amount, balance, note, supplierid, loadnum, quantity, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadAdd (DataTable arrangementvehicleids, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, int supplierid, int loadnum, int quantity, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadAdd (arrangementvehicleids, pickupcountryid, pickupaddress, currencyid, amount, balance, note, supplierid, loadnum, quantity, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadAdd (DataTable arrangementvehicleids, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, int supplierid, int loadnum, int quantity, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadAdd (arrangementvehicleids, pickupcountryid, pickupaddress, currencyid, amount, balance, note, supplierid, loadnum, quantity, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadAdd (DataTable arrangementvehicleids, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, int supplierid, int loadnum, int quantity, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__ADD"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2i(sc, "@pickupcountryid", pickupcountryid);
  q.q2s(sc, "@pickupaddress", pickupaddress);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@balance", balance);
  q.q2s(sc, "@note", note);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@loadnum", loadnum);
  q.q2i(sc, "@quantity", quantity);
  q.q2b(sc, "@deliveringtoclient", deliveringtoclient);
  q.q2b(sc, "@deliveringtoyard", deliveringtoyard);
  q.q2i(sc, "@deliverycountryid", deliverycountryid);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2s(sc, "@postalcode", postalcode);
  q.q2i(sc, "@companygroupid", companygroupid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadAdd2 (DataTable arrangementvehicleids, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, int supplierid, int loadnum, int quantity, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid, decimal fxrate) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadAdd2 (arrangementvehicleids, pickupcountryid, pickupaddress, currencyid, amount, balance, note, supplierid, loadnum, quantity, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid, fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadAdd2 (DataTable arrangementvehicleids, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, int supplierid, int loadnum, int quantity, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid, decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadAdd2 (arrangementvehicleids, pickupcountryid, pickupaddress, currencyid, amount, balance, note, supplierid, loadnum, quantity, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid, fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadAdd2 (DataTable arrangementvehicleids, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, int supplierid, int loadnum, int quantity, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid, decimal fxrate,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadAdd2 (arrangementvehicleids, pickupcountryid, pickupaddress, currencyid, amount, balance, note, supplierid, loadnum, quantity, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid, fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadAdd2 (DataTable arrangementvehicleids, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, int supplierid, int loadnum, int quantity, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid, decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__ADD2"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2i(sc, "@pickupcountryid", pickupcountryid);
  q.q2s(sc, "@pickupaddress", pickupaddress);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@balance", balance);
  q.q2s(sc, "@note", note);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@loadnum", loadnum);
  q.q2i(sc, "@quantity", quantity);
  q.q2b(sc, "@deliveringtoclient", deliveringtoclient);
  q.q2b(sc, "@deliveringtoyard", deliveringtoyard);
  q.q2i(sc, "@deliverycountryid", deliverycountryid);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2s(sc, "@postalcode", postalcode);
  q.q2i(sc, "@companygroupid", companygroupid);
  q.q2e(sc, "@fxrate", fxrate);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadGet (int suppliervehicleloadid, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref int holdperiod, ref string pickupaddinfo, ref int holdingcountryid, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int deliverycountryid, ref string note, ref DateTime loadingday, ref DateTime plannedloadingday, ref bool isproformasent, ref bool isproformapaid, ref string postalcode, ref int companygroupid, ref decimal fxrate) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadGet (suppliervehicleloadid, ref num, ref suppliername, ref supplierid, ref pickupcountryid, ref pickupaddress, ref currencyid, ref amount, ref balance, ref holdperiod, ref pickupaddinfo, ref holdingcountryid, ref suppliercontractid, ref suppliercontractnum, ref quantity, ref deliveringtoclient, ref deliveringtoyard, ref deliverycountryid, ref note, ref loadingday, ref plannedloadingday, ref isproformasent, ref isproformapaid, ref postalcode, ref companygroupid, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadGet (int suppliervehicleloadid, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref int holdperiod, ref string pickupaddinfo, ref int holdingcountryid, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int deliverycountryid, ref string note, ref DateTime loadingday, ref DateTime plannedloadingday, ref bool isproformasent, ref bool isproformapaid, ref string postalcode, ref int companygroupid, ref decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadGet (suppliervehicleloadid, ref num, ref suppliername, ref supplierid, ref pickupcountryid, ref pickupaddress, ref currencyid, ref amount, ref balance, ref holdperiod, ref pickupaddinfo, ref holdingcountryid, ref suppliercontractid, ref suppliercontractnum, ref quantity, ref deliveringtoclient, ref deliveringtoyard, ref deliverycountryid, ref note, ref loadingday, ref plannedloadingday, ref isproformasent, ref isproformapaid, ref postalcode, ref companygroupid, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadGet (int suppliervehicleloadid, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref int holdperiod, ref string pickupaddinfo, ref int holdingcountryid, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int deliverycountryid, ref string note, ref DateTime loadingday, ref DateTime plannedloadingday, ref bool isproformasent, ref bool isproformapaid, ref string postalcode, ref int companygroupid, ref decimal fxrate,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadGet (suppliervehicleloadid, ref num, ref suppliername, ref supplierid, ref pickupcountryid, ref pickupaddress, ref currencyid, ref amount, ref balance, ref holdperiod, ref pickupaddinfo, ref holdingcountryid, ref suppliercontractid, ref suppliercontractnum, ref quantity, ref deliveringtoclient, ref deliveringtoyard, ref deliverycountryid, ref note, ref loadingday, ref plannedloadingday, ref isproformasent, ref isproformapaid, ref postalcode, ref companygroupid, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadGet (int suppliervehicleloadid, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref int holdperiod, ref string pickupaddinfo, ref int holdingcountryid, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int deliverycountryid, ref string note, ref DateTime loadingday, ref DateTime plannedloadingday, ref bool isproformasent, ref bool isproformapaid, ref string postalcode, ref int companygroupid, ref decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__GET"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2s(sc, "@num", num);
  q.q2s(sc, "@suppliername", suppliername);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@pickupcountryid", pickupcountryid);
  q.q2s(sc, "@pickupaddress", pickupaddress);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@balance", balance);
  q.q2i(sc, "@holdperiod", holdperiod);
  q.q2s(sc, "@pickupaddinfo", pickupaddinfo);
  q.q2i(sc, "@holdingcountryid", holdingcountryid);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2s(sc, "@suppliercontractnum", suppliercontractnum);
  q.q2i(sc, "@quantity", quantity);
  q.q2b(sc, "@deliveringtoclient", deliveringtoclient);
  q.q2b(sc, "@deliveringtoyard", deliveringtoyard);
  q.q2i(sc, "@deliverycountryid", deliverycountryid);
  q.q2s(sc, "@note", note);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2d(sc, "@plannedloadingday", plannedloadingday);
  q.q2b(sc, "@isproformasent", isproformasent);
  q.q2b(sc, "@isproformapaid", isproformapaid);
  q.q2s(sc, "@postalcode", postalcode);
  q.q2i(sc, "@companygroupid", companygroupid);
  q.q2e(sc, "@fxrate", fxrate);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   num = q.gs(sc,"@num");
   suppliername = q.gs(sc,"@suppliername");
   supplierid = q.gi(sc,"@supplierid");
   pickupcountryid = q.gi(sc,"@pickupcountryid");
   pickupaddress = q.gs(sc,"@pickupaddress");
   currencyid = q.gi(sc,"@currencyid");
   amount = q.ge(sc,"@amount");
   balance = q.ge(sc,"@balance");
   holdperiod = q.gi(sc,"@holdperiod");
   pickupaddinfo = q.gs(sc,"@pickupaddinfo");
   holdingcountryid = q.gi(sc,"@holdingcountryid");
   suppliercontractid = q.gi(sc,"@suppliercontractid");
   suppliercontractnum = q.gs(sc,"@suppliercontractnum");
   quantity = q.gi(sc,"@quantity");
   deliveringtoclient = q.gb(sc,"@deliveringtoclient");
   deliveringtoyard = q.gb(sc,"@deliveringtoyard");
   deliverycountryid = q.gi(sc,"@deliverycountryid");
   note = q.gs(sc,"@note");
   loadingday = q.gd(sc,"@loadingday");
   plannedloadingday = q.gd(sc,"@plannedloadingday");
   isproformasent = q.gb(sc,"@isproformasent");
   isproformapaid = q.gb(sc,"@isproformapaid");
   postalcode = q.gs(sc,"@postalcode");
   companygroupid = q.gi(sc,"@companygroupid");
   fxrate = q.ge(sc,"@fxrate");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadInfoGet (int suppliervehicleloadid, ref decimal amount, ref decimal balance, ref int quantity) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadInfoGet (suppliervehicleloadid, ref amount, ref balance, ref quantity,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadInfoGet (int suppliervehicleloadid, ref decimal amount, ref decimal balance, ref int quantity,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadInfoGet (suppliervehicleloadid, ref amount, ref balance, ref quantity,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadInfoGet (int suppliervehicleloadid, ref decimal amount, ref decimal balance, ref int quantity,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadInfoGet (suppliervehicleloadid, ref amount, ref balance, ref quantity,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadInfoGet (int suppliervehicleloadid, ref decimal amount, ref decimal balance, ref int quantity,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__INFO_GET"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@balance", balance);
  q.q2i(sc, "@quantity", quantity);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   amount = q.ge(sc,"@amount");
   balance = q.ge(sc,"@balance");
   quantity = q.gi(sc,"@quantity");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadIsreopenedUpdate (int suppliervehicleloadid, bool isreopened) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadIsreopenedUpdate (suppliervehicleloadid, isreopened,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadIsreopenedUpdate (int suppliervehicleloadid, bool isreopened,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadIsreopenedUpdate (suppliervehicleloadid, isreopened,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadIsreopenedUpdate (int suppliervehicleloadid, bool isreopened,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadIsreopenedUpdate (suppliervehicleloadid, isreopened,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadIsreopenedUpdate (int suppliervehicleloadid, bool isreopened,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__ISREOPENED_UPDATE"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2b(sc, "@isreopened", isreopened);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadNewGet (DataTable arrangementvehicleids, int suppliervehicleloadid, ref int loadnum, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref string note, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int yardcountryid, ref DateTime loadingday, ref int companygroupid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadNewGet (arrangementvehicleids, suppliervehicleloadid, ref loadnum, ref num, ref suppliername, ref supplierid, ref pickupcountryid, ref pickupaddress, ref currencyid, ref amount, ref balance, ref note, ref suppliercontractid, ref suppliercontractnum, ref quantity, ref deliveringtoclient, ref deliveringtoyard, ref yardcountryid, ref loadingday, ref companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNewGet (DataTable arrangementvehicleids, int suppliervehicleloadid, ref int loadnum, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref string note, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int yardcountryid, ref DateTime loadingday, ref int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadNewGet (arrangementvehicleids, suppliervehicleloadid, ref loadnum, ref num, ref suppliername, ref supplierid, ref pickupcountryid, ref pickupaddress, ref currencyid, ref amount, ref balance, ref note, ref suppliercontractid, ref suppliercontractnum, ref quantity, ref deliveringtoclient, ref deliveringtoyard, ref yardcountryid, ref loadingday, ref companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNewGet (DataTable arrangementvehicleids, int suppliervehicleloadid, ref int loadnum, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref string note, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int yardcountryid, ref DateTime loadingday, ref int companygroupid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadNewGet (arrangementvehicleids, suppliervehicleloadid, ref loadnum, ref num, ref suppliername, ref supplierid, ref pickupcountryid, ref pickupaddress, ref currencyid, ref amount, ref balance, ref note, ref suppliercontractid, ref suppliercontractnum, ref quantity, ref deliveringtoclient, ref deliveringtoyard, ref yardcountryid, ref loadingday, ref companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNewGet (DataTable arrangementvehicleids, int suppliervehicleloadid, ref int loadnum, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref string note, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int yardcountryid, ref DateTime loadingday, ref int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__NEW_GET"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@loadnum", loadnum);
  q.q2s(sc, "@num", num);
  q.q2s(sc, "@suppliername", suppliername);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@pickupcountryid", pickupcountryid);
  q.q2s(sc, "@pickupaddress", pickupaddress);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@balance", balance);
  q.q2s(sc, "@note", note);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2s(sc, "@suppliercontractnum", suppliercontractnum);
  q.q2i(sc, "@quantity", quantity);
  q.q2b(sc, "@deliveringtoclient", deliveringtoclient);
  q.q2b(sc, "@deliveringtoyard", deliveringtoyard);
  q.q2i(sc, "@yardcountryid", yardcountryid);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2i(sc, "@companygroupid", companygroupid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   loadnum = q.gi(sc,"@loadnum");
   num = q.gs(sc,"@num");
   suppliername = q.gs(sc,"@suppliername");
   supplierid = q.gi(sc,"@supplierid");
   pickupcountryid = q.gi(sc,"@pickupcountryid");
   pickupaddress = q.gs(sc,"@pickupaddress");
   currencyid = q.gi(sc,"@currencyid");
   amount = q.ge(sc,"@amount");
   balance = q.ge(sc,"@balance");
   note = q.gs(sc,"@note");
   suppliercontractid = q.gi(sc,"@suppliercontractid");
   suppliercontractnum = q.gs(sc,"@suppliercontractnum");
   quantity = q.gi(sc,"@quantity");
   deliveringtoclient = q.gb(sc,"@deliveringtoclient");
   deliveringtoyard = q.gb(sc,"@deliveringtoyard");
   yardcountryid = q.gi(sc,"@yardcountryid");
   loadingday = q.gd(sc,"@loadingday");
   companygroupid = q.gi(sc,"@companygroupid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadNewGet2 (DataTable arrangementvehicleids, int suppliervehicleloadid, ref int loadnum, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref string note, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int yardcountryid, ref DateTime loadingday, ref int companygroupid, ref decimal fxrate) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadNewGet2 (arrangementvehicleids, suppliervehicleloadid, ref loadnum, ref num, ref suppliername, ref supplierid, ref pickupcountryid, ref pickupaddress, ref currencyid, ref amount, ref balance, ref note, ref suppliercontractid, ref suppliercontractnum, ref quantity, ref deliveringtoclient, ref deliveringtoyard, ref yardcountryid, ref loadingday, ref companygroupid, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNewGet2 (DataTable arrangementvehicleids, int suppliervehicleloadid, ref int loadnum, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref string note, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int yardcountryid, ref DateTime loadingday, ref int companygroupid, ref decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadNewGet2 (arrangementvehicleids, suppliervehicleloadid, ref loadnum, ref num, ref suppliername, ref supplierid, ref pickupcountryid, ref pickupaddress, ref currencyid, ref amount, ref balance, ref note, ref suppliercontractid, ref suppliercontractnum, ref quantity, ref deliveringtoclient, ref deliveringtoyard, ref yardcountryid, ref loadingday, ref companygroupid, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNewGet2 (DataTable arrangementvehicleids, int suppliervehicleloadid, ref int loadnum, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref string note, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int yardcountryid, ref DateTime loadingday, ref int companygroupid, ref decimal fxrate,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadNewGet2 (arrangementvehicleids, suppliervehicleloadid, ref loadnum, ref num, ref suppliername, ref supplierid, ref pickupcountryid, ref pickupaddress, ref currencyid, ref amount, ref balance, ref note, ref suppliercontractid, ref suppliercontractnum, ref quantity, ref deliveringtoclient, ref deliveringtoyard, ref yardcountryid, ref loadingday, ref companygroupid, ref fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNewGet2 (DataTable arrangementvehicleids, int suppliervehicleloadid, ref int loadnum, ref string num, ref string suppliername, ref int supplierid, ref int pickupcountryid, ref string pickupaddress, ref int currencyid, ref decimal amount, ref decimal balance, ref string note, ref int suppliercontractid, ref string suppliercontractnum, ref int quantity, ref bool deliveringtoclient, ref bool deliveringtoyard, ref int yardcountryid, ref DateTime loadingday, ref int companygroupid, ref decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__NEW_GET2"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@loadnum", loadnum);
  q.q2s(sc, "@num", num);
  q.q2s(sc, "@suppliername", suppliername);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@pickupcountryid", pickupcountryid);
  q.q2s(sc, "@pickupaddress", pickupaddress);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@balance", balance);
  q.q2s(sc, "@note", note);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  q.q2s(sc, "@suppliercontractnum", suppliercontractnum);
  q.q2i(sc, "@quantity", quantity);
  q.q2b(sc, "@deliveringtoclient", deliveringtoclient);
  q.q2b(sc, "@deliveringtoyard", deliveringtoyard);
  q.q2i(sc, "@yardcountryid", yardcountryid);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2i(sc, "@companygroupid", companygroupid);
  q.q2e(sc, "@fxrate", fxrate);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   loadnum = q.gi(sc,"@loadnum");
   num = q.gs(sc,"@num");
   suppliername = q.gs(sc,"@suppliername");
   supplierid = q.gi(sc,"@supplierid");
   pickupcountryid = q.gi(sc,"@pickupcountryid");
   pickupaddress = q.gs(sc,"@pickupaddress");
   currencyid = q.gi(sc,"@currencyid");
   amount = q.ge(sc,"@amount");
   balance = q.ge(sc,"@balance");
   note = q.gs(sc,"@note");
   suppliercontractid = q.gi(sc,"@suppliercontractid");
   suppliercontractnum = q.gs(sc,"@suppliercontractnum");
   quantity = q.gi(sc,"@quantity");
   deliveringtoclient = q.gb(sc,"@deliveringtoclient");
   deliveringtoyard = q.gb(sc,"@deliveringtoyard");
   yardcountryid = q.gi(sc,"@yardcountryid");
   loadingday = q.gd(sc,"@loadingday");
   companygroupid = q.gi(sc,"@companygroupid");
   fxrate = q.ge(sc,"@fxrate");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadNoteGet (int suppliervehicleloadid, ref string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadNoteGet (suppliervehicleloadid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNoteGet (int suppliervehicleloadid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadNoteGet (suppliervehicleloadid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNoteGet (int suppliervehicleloadid, ref string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadNoteGet (suppliervehicleloadid, ref note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNoteGet (int suppliervehicleloadid, ref string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__NOTE_GET"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   note = q.gs(sc,"@note");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadNoteSet (int suppliervehicleloadid, string note) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadNoteSet (suppliervehicleloadid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNoteSet (int suppliervehicleloadid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadNoteSet (suppliervehicleloadid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNoteSet (int suppliervehicleloadid, string note,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadNoteSet (suppliervehicleloadid, note,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNoteSet (int suppliervehicleloadid, string note,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__NOTE_SET"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2s(sc, "@note", note);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadNumGet (int suppliervehicleloadid, ref string num) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadNumGet (suppliervehicleloadid, ref num,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNumGet (int suppliervehicleloadid, ref string num,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadNumGet (suppliervehicleloadid, ref num,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNumGet (int suppliervehicleloadid, ref string num,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadNumGet (suppliervehicleloadid, ref num,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadNumGet (int suppliervehicleloadid, ref string num,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__NUM_GET"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2s(sc, "@num", num);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   num = q.gs(sc,"@num");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadUpdate (int suppliervehicleloadid, int supplierid, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadUpdate (suppliervehicleloadid, supplierid, pickupcountryid, pickupaddress, currencyid, amount, balance, note, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadUpdate (int suppliervehicleloadid, int supplierid, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadUpdate (suppliervehicleloadid, supplierid, pickupcountryid, pickupaddress, currencyid, amount, balance, note, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadUpdate (int suppliervehicleloadid, int supplierid, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadUpdate (suppliervehicleloadid, supplierid, pickupcountryid, pickupaddress, currencyid, amount, balance, note, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadUpdate (int suppliervehicleloadid, int supplierid, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__UPDATE"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@pickupcountryid", pickupcountryid);
  q.q2s(sc, "@pickupaddress", pickupaddress);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@balance", balance);
  q.q2s(sc, "@note", note);
  q.q2b(sc, "@deliveringtoclient", deliveringtoclient);
  q.q2b(sc, "@deliveringtoyard", deliveringtoyard);
  q.q2i(sc, "@deliverycountryid", deliverycountryid);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2s(sc, "@postalcode", postalcode);
  q.q2i(sc, "@companygroupid", companygroupid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadUpdate2 (int suppliervehicleloadid, int supplierid, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid, decimal fxrate) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadUpdate2 (suppliervehicleloadid, supplierid, pickupcountryid, pickupaddress, currencyid, amount, balance, note, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid, fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadUpdate2 (int suppliervehicleloadid, int supplierid, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid, decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadUpdate2 (suppliervehicleloadid, supplierid, pickupcountryid, pickupaddress, currencyid, amount, balance, note, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid, fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadUpdate2 (int suppliervehicleloadid, int supplierid, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid, decimal fxrate,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadUpdate2 (suppliervehicleloadid, supplierid, pickupcountryid, pickupaddress, currencyid, amount, balance, note, deliveringtoclient, deliveringtoyard, deliverycountryid, loadingday, postalcode, companygroupid, fxrate,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadUpdate2 (int suppliervehicleloadid, int supplierid, int pickupcountryid, string pickupaddress, int currencyid, decimal amount, decimal balance, string note, bool deliveringtoclient, bool deliveringtoyard, int deliverycountryid, DateTime loadingday, string postalcode, int companygroupid, decimal fxrate,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__UPDATE2"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@supplierid", supplierid);
  q.q2i(sc, "@pickupcountryid", pickupcountryid);
  q.q2s(sc, "@pickupaddress", pickupaddress);
  q.q2i(sc, "@currencyid", currencyid);
  q.q2e(sc, "@amount", amount);
  q.q2e(sc, "@balance", balance);
  q.q2s(sc, "@note", note);
  q.q2b(sc, "@deliveringtoclient", deliveringtoclient);
  q.q2b(sc, "@deliveringtoyard", deliveringtoyard);
  q.q2i(sc, "@deliverycountryid", deliverycountryid);
  q.q2d(sc, "@loadingday", loadingday);
  q.q2s(sc, "@postalcode", postalcode);
  q.q2i(sc, "@companygroupid", companygroupid);
  q.q2e(sc, "@fxrate", fxrate);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadVehiclesUnassign (DataTable arrangementvehicleids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadVehiclesUnassign (arrangementvehicleids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesUnassign (DataTable arrangementvehicleids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadVehiclesUnassign (arrangementvehicleids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesUnassign (DataTable arrangementvehicleids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadVehiclesUnassign (arrangementvehicleids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesUnassign (DataTable arrangementvehicleids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD__VEHICLES_UNASSIGN"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadArrangementVehicleIdsVw (int suppliervehicleloadid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadArrangementVehicleIdsVw (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadArrangementVehicleIdsVw (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadArrangementVehicleIdsVw (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadArrangementVehicleIdsVw (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadArrangementVehicleIdsVw (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadArrangementVehicleIdsVw (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_ARRANGEMENT_VEHICLE_IDS_vw"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadFileDirectoriesVw (int suppliervehicleloadid, int parentid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadFileDirectoriesVw (suppliervehicleloadid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoriesVw (int suppliervehicleloadid, int parentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadFileDirectoriesVw (suppliervehicleloadid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoriesVw (int suppliervehicleloadid, int parentid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadFileDirectoriesVw (suppliervehicleloadid, parentid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoriesVw (int suppliervehicleloadid, int parentid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_FILE__DIRECTORIES_vw"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@parentid", parentid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadFileDirectoryDelete (int suppliervehicleloadid, int suppliervehicleloadfileid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadFileDirectoryDelete (suppliervehicleloadid, suppliervehicleloadfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoryDelete (int suppliervehicleloadid, int suppliervehicleloadfileid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadFileDirectoryDelete (suppliervehicleloadid, suppliervehicleloadfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoryDelete (int suppliervehicleloadid, int suppliervehicleloadfileid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadFileDirectoryDelete (suppliervehicleloadid, suppliervehicleloadfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoryDelete (int suppliervehicleloadid, int suppliervehicleloadfileid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_FILE__DIRECTORY_DELETE"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@suppliervehicleloadfileid", suppliervehicleloadfileid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadFileDirectoryNew (int suppliervehicleloadid, int parentid, ref int newid, ref string newname) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadFileDirectoryNew (suppliervehicleloadid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoryNew (int suppliervehicleloadid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadFileDirectoryNew (suppliervehicleloadid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoryNew (int suppliervehicleloadid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadFileDirectoryNew (suppliervehicleloadid, parentid, ref newid, ref newname,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoryNew (int suppliervehicleloadid, int parentid, ref int newid, ref string newname,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_FILE__DIRECTORY_NEW"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@parentid", parentid);
  q.q2i(sc, "@newid", newid);
  q.q2s(sc, "@newname", newname);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   newid = q.gi(sc,"@newid");
   newname = q.gs(sc,"@newname");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadFileDirectoryRename (int suppliervehicleloadid, int suppliervehicleloadfileid, string name) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadFileDirectoryRename (suppliervehicleloadid, suppliervehicleloadfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoryRename (int suppliervehicleloadid, int suppliervehicleloadfileid, string name,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadFileDirectoryRename (suppliervehicleloadid, suppliervehicleloadfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoryRename (int suppliervehicleloadid, int suppliervehicleloadfileid, string name,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadFileDirectoryRename (suppliervehicleloadid, suppliervehicleloadfileid, name,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileDirectoryRename (int suppliervehicleloadid, int suppliervehicleloadfileid, string name,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_FILE__DIRECTORY_RENAME"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@suppliervehicleloadfileid", suppliervehicleloadfileid);
  q.q2s(sc, "@name", name);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadFileFileAdd (int suppliervehicleloadid, int dirsuppliervehicleloadfileid, string fn, string ext, byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadFileFileAdd (suppliervehicleloadid, dirsuppliervehicleloadfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileAdd (int suppliervehicleloadid, int dirsuppliervehicleloadfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadFileFileAdd (suppliervehicleloadid, dirsuppliervehicleloadfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileAdd (int suppliervehicleloadid, int dirsuppliervehicleloadfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadFileFileAdd (suppliervehicleloadid, dirsuppliervehicleloadfileid, fn, ext, body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileAdd (int suppliervehicleloadid, int dirsuppliervehicleloadfileid, string fn, string ext, byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_FILE__FILE_ADD"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@dirsuppliervehicleloadfileid", dirsuppliervehicleloadfileid);
  q.q2s(sc, "@fn", fn);
  q.q2s(sc, "@ext", ext);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadFileFileDelete (int suppliervehicleloadid, int suppliervehicleloadfileid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadFileFileDelete (suppliervehicleloadid, suppliervehicleloadfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileDelete (int suppliervehicleloadid, int suppliervehicleloadfileid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadFileFileDelete (suppliervehicleloadid, suppliervehicleloadfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileDelete (int suppliervehicleloadid, int suppliervehicleloadfileid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadFileFileDelete (suppliervehicleloadid, suppliervehicleloadfileid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileDelete (int suppliervehicleloadid, int suppliervehicleloadfileid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_FILE__FILE_DELETE"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@suppliervehicleloadfileid", suppliervehicleloadfileid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadFileFileInfoGet (int suppliervehicleloadid, int suppliervehicleloadfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadFileFileInfoGet (suppliervehicleloadid, suppliervehicleloadfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileInfoGet (int suppliervehicleloadid, int suppliervehicleloadfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadFileFileInfoGet (suppliervehicleloadid, suppliervehicleloadfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileInfoGet (int suppliervehicleloadid, int suppliervehicleloadfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadFileFileInfoGet (suppliervehicleloadid, suppliervehicleloadfileid, ref name, ref uploaded, ref type, ref size, ref uploadedby,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileInfoGet (int suppliervehicleloadid, int suppliervehicleloadfileid, ref string name, ref DateTime uploaded, ref string type, ref int size, ref string uploadedby,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_FILE__FILE_INFO_GET"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@suppliervehicleloadfileid", suppliervehicleloadfileid);
  q.q2s(sc, "@name", name);
  q.q2dt(sc, "@uploaded", uploaded);
  q.q2s(sc, "@type", type);
  q.q2i(sc, "@size", size);
  q.q2s(sc, "@uploadedby", uploadedby);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   name = q.gs(sc,"@name");
   uploaded = q.gdt(sc,"@uploaded");
   type = q.gs(sc,"@type");
   size = q.gi(sc,"@size");
   uploadedby = q.gs(sc,"@uploadedby");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadFileFileOpenGet (int suppliervehicleloadid, int suppliervehicleloadfileid, ref string fn, ref byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadFileFileOpenGet (suppliervehicleloadid, suppliervehicleloadfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileOpenGet (int suppliervehicleloadid, int suppliervehicleloadfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadFileFileOpenGet (suppliervehicleloadid, suppliervehicleloadfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileOpenGet (int suppliervehicleloadid, int suppliervehicleloadfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadFileFileOpenGet (suppliervehicleloadid, suppliervehicleloadfileid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileOpenGet (int suppliervehicleloadid, int suppliervehicleloadfileid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_FILE__FILE_OPEN_GET"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@suppliervehicleloadfileid", suppliervehicleloadfileid);
  q.q2s(sc, "@fn", fn);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   fn = q.gs(sc,"@fn");
   body = q.ga(sc,"@body");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadFileFileRename (int suppliervehicleloadid, int suppliervehicleloadfileid, string newfn) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadFileFileRename (suppliervehicleloadid, suppliervehicleloadfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileRename (int suppliervehicleloadid, int suppliervehicleloadfileid, string newfn,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadFileFileRename (suppliervehicleloadid, suppliervehicleloadfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileRename (int suppliervehicleloadid, int suppliervehicleloadfileid, string newfn,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadFileFileRename (suppliervehicleloadid, suppliervehicleloadfileid, newfn,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFileRename (int suppliervehicleloadid, int suppliervehicleloadfileid, string newfn,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_FILE__FILE_RENAME"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@suppliervehicleloadfileid", suppliervehicleloadfileid);
  q.q2s(sc, "@newfn", newfn);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadFileFilesVw (int suppliervehicleloadid, int suppliervehicleloadfileid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadFileFilesVw (suppliervehicleloadid, suppliervehicleloadfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFilesVw (int suppliervehicleloadid, int suppliervehicleloadfileid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadFileFilesVw (suppliervehicleloadid, suppliervehicleloadfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFilesVw (int suppliervehicleloadid, int suppliervehicleloadfileid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadFileFilesVw (suppliervehicleloadid, suppliervehicleloadfileid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadFileFilesVw (int suppliervehicleloadid, int suppliervehicleloadfileid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_FILE__FILES_vw"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  q.q2i(sc, "@suppliervehicleloadfileid", suppliervehicleloadfileid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadPaymentsVw (int suppliervehicleloadid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadPaymentsVw (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadPaymentsVw (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadPaymentsVw (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadPaymentsVw (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadPaymentsVw (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadPaymentsVw (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_PAYMENTS_vw"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadVehiclesNewVw (DataTable arrangementvehicleids, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadVehiclesNewVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesNewVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadVehiclesNewVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesNewVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadVehiclesNewVw (arrangementvehicleids, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesNewVw (DataTable arrangementvehicleids, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_VEHICLES_NEW_vw"); 
  q.q2u(sc, "@arrangementvehicleids", "eids", arrangementvehicleids);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadVehiclesVw (int suppliervehicleloadid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadVehiclesVw (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesVw (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadVehiclesVw (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesVw (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadVehiclesVw (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesVw (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_VEHICLES_vw"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadVehiclesVwq (int suppliervehicleloadid, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadVehiclesVwq (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesVwq (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadVehiclesVwq (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesVwq (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadVehiclesVwq (suppliervehicleloadid, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadVehiclesVwq (int suppliervehicleloadid, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOAD_VEHICLES_vwq"); 
  q.q2i(sc, "@suppliervehicleloadid", suppliervehicleloadid);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadsDelete (DataTable suppliervehicleloadids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadsDelete (suppliervehicleloadids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsDelete (DataTable suppliervehicleloadids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadsDelete (suppliervehicleloadids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsDelete (DataTable suppliervehicleloadids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadsDelete (suppliervehicleloadids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsDelete (DataTable suppliervehicleloadids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOADS__DELETE"); 
  q.q2u(sc, "@suppliervehicleloadids", "eids", suppliervehicleloadids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadsMerge (DataTable suppliervehicleloadids, ref string num) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadsMerge (suppliervehicleloadids, ref num,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsMerge (DataTable suppliervehicleloadids, ref string num,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadsMerge (suppliervehicleloadids, ref num,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsMerge (DataTable suppliervehicleloadids, ref string num,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadsMerge (suppliervehicleloadids, ref num,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsMerge (DataTable suppliervehicleloadids, ref string num,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOADS__MERGE"); 
  q.q2u(sc, "@suppliervehicleloadids", "eids", suppliervehicleloadids);
  q.q2s(sc, "@num", num);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   num = q.gs(sc,"@num");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadsPaidVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadsPaidVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsPaidVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadsPaidVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsPaidVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadsPaidVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsPaidVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOADS_PAID_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadsUnpaidVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadsUnpaidVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsUnpaidVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadsUnpaidVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsUnpaidVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadsUnpaidVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsUnpaidVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOADS_UNPAID_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SupplierVehicleLoadsVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SupplierVehicleLoadsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SupplierVehicleLoadsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SupplierVehicleLoadsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SupplierVehicleLoadsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIER_VEHICLE_LOADS_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SuppliersActiveVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SuppliersActiveVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersActiveVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SuppliersActiveVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersActiveVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SuppliersActiveVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersActiveVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIERS_ACTIVE_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SuppliersActiveVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SuppliersActiveVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersActiveVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SuppliersActiveVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersActiveVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SuppliersActiveVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersActiveVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIERS_ACTIVE_vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SuppliersContractsVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SuppliersContractsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersContractsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SuppliersContractsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersContractsVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SuppliersContractsVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersContractsVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIERS_CONTRACTS_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SuppliersProspectVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SuppliersProspectVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersProspectVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SuppliersProspectVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersProspectVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SuppliersProspectVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersProspectVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIERS_PROSPECT_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SuppliersStaffsOwnershipTransfer (DataTable supplierids, DataTable newstaffids) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SuppliersStaffsOwnershipTransfer (supplierids, newstaffids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersStaffsOwnershipTransfer (DataTable supplierids, DataTable newstaffids,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SuppliersStaffsOwnershipTransfer (supplierids, newstaffids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersStaffsOwnershipTransfer (DataTable supplierids, DataTable newstaffids,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SuppliersStaffsOwnershipTransfer (supplierids, newstaffids,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersStaffsOwnershipTransfer (DataTable supplierids, DataTable newstaffids,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIERS_STAFFS__OWNERSHIP_TRANSFER"); 
  q.q2u(sc, "@supplierids", "eids", supplierids);
  q.q2u(sc, "@newstaffids", "eids", newstaffids);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SuppliersVw (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SuppliersVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SuppliersVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersVw (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SuppliersVw (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersVw (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIERS_vw"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool SuppliersVwq (out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return SuppliersVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return SuppliersVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersVwq (out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return SuppliersVwq (out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool SuppliersVwq (out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.SUPPLIERS_vwq"); 
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool TransportationConfirmationOpenGet (int arrangementvehicleid, ref string fn, ref byte[] body) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return TransportationConfirmationOpenGet (arrangementvehicleid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool TransportationConfirmationOpenGet (int arrangementvehicleid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return TransportationConfirmationOpenGet (arrangementvehicleid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool TransportationConfirmationOpenGet (int arrangementvehicleid, ref string fn, ref byte[] body,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return TransportationConfirmationOpenGet (arrangementvehicleid, ref fn, ref body,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool TransportationConfirmationOpenGet (int arrangementvehicleid, ref string fn, ref byte[] body,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.TRANSPORTATION_CONFIRMATION_OPEN_GET"); 
  q.q2i(sc, "@arrangementvehicleid", arrangementvehicleid);
  q.q2s(sc, "@fn", fn);
  q.q2a(sc, "@body", body);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   fn = q.gs(sc,"@fn");
   body = q.ga(sc,"@body");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool TruckInvoiceInformationEmailGetVw (int truckid, int contractheaderid, ref string emailto, ref string subject, ref string body, out DataTable tb) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return TruckInvoiceInformationEmailGetVw (truckid, contractheaderid, ref emailto, ref subject, ref body, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool TruckInvoiceInformationEmailGetVw (int truckid, int contractheaderid, ref string emailto, ref string subject, ref string body, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return TruckInvoiceInformationEmailGetVw (truckid, contractheaderid, ref emailto, ref subject, ref body, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool TruckInvoiceInformationEmailGetVw (int truckid, int contractheaderid, ref string emailto, ref string subject, ref string body, out DataTable tb,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return TruckInvoiceInformationEmailGetVw (truckid, contractheaderid, ref emailto, ref subject, ref body, out tb,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool TruckInvoiceInformationEmailGetVw (int truckid, int contractheaderid, ref string emailto, ref string subject, ref string body, out DataTable tb,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.TRUCK__INVOICE_INFORMATION_EMAIL_GET_vw"); 
  q.q2i(sc, "@truckid", truckid);
  q.q2i(sc, "@contractheaderid", contractheaderid);
  q.q2s(sc, "@emailto", emailto);
  q.q2s(sc, "@subject", subject);
  q.q2s(sc, "@body", body);
  tb = new DataTable("t");
  if (sc==null) { return false; }
  SqlDataAdapter sda = new SqlDataAdapter(sc);
  sda.SelectCommand.CommandTimeout = 0;
  try {
    sda.Fill(tb);
    r = true;
  } catch (Exception e) {
    if (bSupressErrorMessage) {
      error = q.ErrorTextGet(e);
    } else {
      q.ErrorShow(e);
    }
    r = false;
  }
  sda.Dispose(); sda = null;
  if (r) {
    RETURN_VALUE = q.gi(sc);
   emailto = q.gs(sc,"@emailto");
   subject = q.gs(sc,"@subject");
   body = q.gs(sc,"@body");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool UserConnectionInfoGet (ref string connectioninfo, string appversion) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return UserConnectionInfoGet (ref connectioninfo, appversion,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool UserConnectionInfoGet (ref string connectioninfo, string appversion,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return UserConnectionInfoGet (ref connectioninfo, appversion,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool UserConnectionInfoGet (ref string connectioninfo, string appversion,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return UserConnectionInfoGet (ref connectioninfo, appversion,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool UserConnectionInfoGet (ref string connectioninfo, string appversion,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.USER_CONNECTION_INFO_GET"); 
  q.q2s(sc, "@connectioninfo", connectioninfo);
  q.q2s(sc, "@appversion", appversion);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   connectioninfo = q.gs(sc,"@connectioninfo");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool VehicleInfoGetShort (int vehicleid, ref int contractheaderid, ref int arrangementid, ref int clientid, ref int vehicleloadid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return VehicleInfoGetShort (vehicleid, ref contractheaderid, ref arrangementid, ref clientid, ref vehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleInfoGetShort (int vehicleid, ref int contractheaderid, ref int arrangementid, ref int clientid, ref int vehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return VehicleInfoGetShort (vehicleid, ref contractheaderid, ref arrangementid, ref clientid, ref vehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleInfoGetShort (int vehicleid, ref int contractheaderid, ref int arrangementid, ref int clientid, ref int vehicleloadid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return VehicleInfoGetShort (vehicleid, ref contractheaderid, ref arrangementid, ref clientid, ref vehicleloadid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleInfoGetShort (int vehicleid, ref int contractheaderid, ref int arrangementid, ref int clientid, ref int vehicleloadid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.VEHICLE__INFO_GET_SHORT"); 
  q.q2i(sc, "@vehicleid", vehicleid);
  q.q2i(sc, "@contractheaderid", contractheaderid);
  q.q2i(sc, "@arrangementid", arrangementid);
  q.q2i(sc, "@clientid", clientid);
  q.q2i(sc, "@vehicleloadid", vehicleloadid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   contractheaderid = q.gi(sc,"@contractheaderid");
   arrangementid = q.gi(sc,"@arrangementid");
   clientid = q.gi(sc,"@clientid");
   vehicleloadid = q.gi(sc,"@vehicleloadid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool VehicleSupplierContractGet (int vehicleid, ref int suppliercontractid) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return VehicleSupplierContractGet (vehicleid, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleSupplierContractGet (int vehicleid, ref int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return VehicleSupplierContractGet (vehicleid, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleSupplierContractGet (int vehicleid, ref int suppliercontractid,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return VehicleSupplierContractGet (vehicleid, ref suppliercontractid,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleSupplierContractGet (int vehicleid, ref int suppliercontractid,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.VEHICLE__SUPPLIER_CONTRACT_GET"); 
  q.q2i(sc, "@vehicleid", vehicleid);
  q.q2i(sc, "@suppliercontractid", suppliercontractid);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   suppliercontractid = q.gi(sc,"@suppliercontractid");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool VehicleYardGet (int vehicleid, ref string yard, ref bool ismanualyard) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return VehicleYardGet (vehicleid, ref yard, ref ismanualyard,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleYardGet (int vehicleid, ref string yard, ref bool ismanualyard,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return VehicleYardGet (vehicleid, ref yard, ref ismanualyard,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleYardGet (int vehicleid, ref string yard, ref bool ismanualyard,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return VehicleYardGet (vehicleid, ref yard, ref ismanualyard,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleYardGet (int vehicleid, ref string yard, ref bool ismanualyard,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.VEHICLE__YARD_GET"); 
  q.q2i(sc, "@vehicleid", vehicleid);
  q.q2s(sc, "@yard", yard);
  q.q2b(sc, "@ismanualyard", ismanualyard);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
   yard = q.gs(sc,"@yard");
   ismanualyard = q.gb(sc,"@ismanualyard");
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool VehicleYardSet (int vehicleid, string yard, bool removemanualflag) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return VehicleYardSet (vehicleid, yard, removemanualflag,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleYardSet (int vehicleid, string yard, bool removemanualflag,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return VehicleYardSet (vehicleid, yard, removemanualflag,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleYardSet (int vehicleid, string yard, bool removemanualflag,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return VehicleYardSet (vehicleid, yard, removemanualflag,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleYardSet (int vehicleid, string yard, bool removemanualflag,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.VEHICLE__YARD_SET"); 
  q.q2i(sc, "@vehicleid", vehicleid);
  q.q2s(sc, "@yard", yard);
  q.q2b(sc, "@removemanualflag", removemanualflag);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool VehicleLoadProformaSendSet (int vehicleloadid, string emailto, string subject, decimal percent) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return VehicleLoadProformaSendSet (vehicleloadid, emailto, subject, percent,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleLoadProformaSendSet (int vehicleloadid, string emailto, string subject, decimal percent,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return VehicleLoadProformaSendSet (vehicleloadid, emailto, subject, percent,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleLoadProformaSendSet (int vehicleloadid, string emailto, string subject, decimal percent,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return VehicleLoadProformaSendSet (vehicleloadid, emailto, subject, percent,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehicleLoadProformaSendSet (int vehicleloadid, string emailto, string subject, decimal percent,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.VEHICLE_LOAD__PROFORMA_SEND_SET"); 
  q.q2i(sc, "@vehicleloadid", vehicleloadid);
  q.q2s(sc, "@emailto", emailto);
  q.q2s(sc, "@subject", subject);
  q.q2e(sc, "@percent", percent);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
public static bool VehiclesYardSet (DataTable vehicleids, string yard, bool removemanualflag) {
  int RETURN_VALUE = -1;
  bool bSupressErrorMessage = false;
  string error="";

  return VehiclesYardSet (vehicleids, yard, removemanualflag,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehiclesYardSet (DataTable vehicleids, string yard, bool removemanualflag,ref int RETURN_VALUE, bool bSupressErrorMessage) {
  RETURN_VALUE = -1;
  string error="";

  return VehiclesYardSet (vehicleids, yard, removemanualflag,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehiclesYardSet (DataTable vehicleids, string yard, bool removemanualflag,ref int RETURN_VALUE, ref string error) {
  RETURN_VALUE = -1;
  bool bSupressErrorMessage = true;
  error="";

  return VehiclesYardSet (vehicleids, yard, removemanualflag,ref RETURN_VALUE,bSupressErrorMessage,ref error);
}
public static bool VehiclesYardSet (DataTable vehicleids, string yard, bool removemanualflag,ref int RETURN_VALUE, bool bSupressErrorMessage, ref string error) {
  error = "";
  bool r = false;

  SqlCommand sc = q.e("a15.VEHICLES__YARD_SET"); 
  q.q2u(sc, "@vehicleids", "eids", vehicleids);
  q.q2s(sc, "@yard", yard);
  q.q2b(sc, "@removemanualflag", removemanualflag);
  if (sc==null) { return false; }
  if (bSupressErrorMessage) {
    r = q.x(sc, ref error);
  } else {
    r = q.x(sc);
  }
  if (r) {
    RETURN_VALUE = q.gi(sc);
  }
  sc.Dispose();sc=null;
  return r;
}
}
