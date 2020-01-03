﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace HISMedTypeManage.Rpt {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dsHisMedInOrderStatistic : DataSet {
        
        private element1DataTable tableelement1;
        
        public dsHisMedInOrderStatistic() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsHisMedInOrderStatistic(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["element1"] != null)) {
                    this.Tables.Add(new element1DataTable(ds.Tables["element1"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public element1DataTable element1 {
            get {
                return this.tableelement1;
            }
        }
        
        public override DataSet Clone() {
            dsHisMedInOrderStatistic cln = ((dsHisMedInOrderStatistic)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["element1"] != null)) {
                this.Tables.Add(new element1DataTable(ds.Tables["element1"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableelement1 = ((element1DataTable)(this.Tables["element1"]));
            if ((this.tableelement1 != null)) {
                this.tableelement1.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsHisMedInOrderStatistic";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/dsHisMedInOrderStatistic.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableelement1 = new element1DataTable();
            this.Tables.Add(this.tableelement1);
        }
        
        private bool ShouldSerializeelement1() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void element1RowChangeEventHandler(object sender, element1RowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class element1DataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnDOCID_VCHR;
            
            private DataColumn columnTOLMNY_MNY;
            
            private DataColumn columnVENDORNAME_VCHR;
            
            private DataColumn columnSEQUENCEID;
            
            internal element1DataTable() : 
                    base("element1") {
                this.InitClass();
            }
            
            internal element1DataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn DOCID_VCHRColumn {
                get {
                    return this.columnDOCID_VCHR;
                }
            }
            
            internal DataColumn TOLMNY_MNYColumn {
                get {
                    return this.columnTOLMNY_MNY;
                }
            }
            
            internal DataColumn VENDORNAME_VCHRColumn {
                get {
                    return this.columnVENDORNAME_VCHR;
                }
            }
            
            internal DataColumn SEQUENCEIDColumn {
                get {
                    return this.columnSEQUENCEID;
                }
            }
            
            public element1Row this[int index] {
                get {
                    return ((element1Row)(this.Rows[index]));
                }
            }
            
            public event element1RowChangeEventHandler element1RowChanged;
            
            public event element1RowChangeEventHandler element1RowChanging;
            
            public event element1RowChangeEventHandler element1RowDeleted;
            
            public event element1RowChangeEventHandler element1RowDeleting;
            
            public void Addelement1Row(element1Row row) {
                this.Rows.Add(row);
            }
            
            public element1Row Addelement1Row(string DOCID_VCHR, System.Single TOLMNY_MNY, string VENDORNAME_VCHR, string SEQUENCEID) {
                element1Row rowelement1Row = ((element1Row)(this.NewRow()));
                rowelement1Row.ItemArray = new object[] {
                        DOCID_VCHR,
                        TOLMNY_MNY,
                        VENDORNAME_VCHR,
                        SEQUENCEID};
                this.Rows.Add(rowelement1Row);
                return rowelement1Row;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                element1DataTable cln = ((element1DataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new element1DataTable();
            }
            
            internal void InitVars() {
                this.columnDOCID_VCHR = this.Columns["DOCID_VCHR"];
                this.columnTOLMNY_MNY = this.Columns["TOLMNY_MNY"];
                this.columnVENDORNAME_VCHR = this.Columns["VENDORNAME_VCHR"];
                this.columnSEQUENCEID = this.Columns["SEQUENCEID"];
            }
            
            private void InitClass() {
                this.columnDOCID_VCHR = new DataColumn("DOCID_VCHR", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDOCID_VCHR);
                this.columnTOLMNY_MNY = new DataColumn("TOLMNY_MNY", typeof(System.Single), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTOLMNY_MNY);
                this.columnVENDORNAME_VCHR = new DataColumn("VENDORNAME_VCHR", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnVENDORNAME_VCHR);
                this.columnSEQUENCEID = new DataColumn("SEQUENCEID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSEQUENCEID);
            }
            
            public element1Row Newelement1Row() {
                return ((element1Row)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new element1Row(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(element1Row);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.element1RowChanged != null)) {
                    this.element1RowChanged(this, new element1RowChangeEvent(((element1Row)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.element1RowChanging != null)) {
                    this.element1RowChanging(this, new element1RowChangeEvent(((element1Row)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.element1RowDeleted != null)) {
                    this.element1RowDeleted(this, new element1RowChangeEvent(((element1Row)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.element1RowDeleting != null)) {
                    this.element1RowDeleting(this, new element1RowChangeEvent(((element1Row)(e.Row)), e.Action));
                }
            }
            
            public void Removeelement1Row(element1Row row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class element1Row : DataRow {
            
            private element1DataTable tableelement1;
            
            internal element1Row(DataRowBuilder rb) : 
                    base(rb) {
                this.tableelement1 = ((element1DataTable)(this.Table));
            }
            
            public string DOCID_VCHR {
                get {
                    try {
                        return ((string)(this[this.tableelement1.DOCID_VCHRColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    }
                }
                set {
                    this[this.tableelement1.DOCID_VCHRColumn] = value;
                }
            }
            
            public System.Single TOLMNY_MNY {
                get {
                    try {
                        return ((System.Single)(this[this.tableelement1.TOLMNY_MNYColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    }
                }
                set {
                    this[this.tableelement1.TOLMNY_MNYColumn] = value;
                }
            }
            
            public string VENDORNAME_VCHR {
                get {
                    try {
                        return ((string)(this[this.tableelement1.VENDORNAME_VCHRColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    }
                }
                set {
                    this[this.tableelement1.VENDORNAME_VCHRColumn] = value;
                }
            }
            
            public string SEQUENCEID {
                get {
                    try {
                        return ((string)(this[this.tableelement1.SEQUENCEIDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    }
                }
                set {
                    this[this.tableelement1.SEQUENCEIDColumn] = value;
                }
            }
            
            public bool IsDOCID_VCHRNull() {
                return this.IsNull(this.tableelement1.DOCID_VCHRColumn);
            }
            
            public void SetDOCID_VCHRNull() {
                this[this.tableelement1.DOCID_VCHRColumn] = System.Convert.DBNull;
            }
            
            public bool IsTOLMNY_MNYNull() {
                return this.IsNull(this.tableelement1.TOLMNY_MNYColumn);
            }
            
            public void SetTOLMNY_MNYNull() {
                this[this.tableelement1.TOLMNY_MNYColumn] = System.Convert.DBNull;
            }
            
            public bool IsVENDORNAME_VCHRNull() {
                return this.IsNull(this.tableelement1.VENDORNAME_VCHRColumn);
            }
            
            public void SetVENDORNAME_VCHRNull() {
                this[this.tableelement1.VENDORNAME_VCHRColumn] = System.Convert.DBNull;
            }
            
            public bool IsSEQUENCEIDNull() {
                return this.IsNull(this.tableelement1.SEQUENCEIDColumn);
            }
            
            public void SetSEQUENCEIDNull() {
                this[this.tableelement1.SEQUENCEIDColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class element1RowChangeEvent : EventArgs {
            
            private element1Row eventRow;
            
            private DataRowAction eventAction;
            
            public element1RowChangeEvent(element1Row row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public element1Row Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
