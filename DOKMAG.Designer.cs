
namespace _4DOKMAG
{
    partial class DOKMAG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.gitHubBarList = new DevExpress.XtraBars.BarListItem();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dOKMAGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._4DOK_MAGDataSet = new _4DOKMAG._4DOK_MAGDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_DOKMAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNUMER_KLIENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAZWA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNETTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRUTTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.dOKMAGTableAdapter = new _4DOKMAG._4DOK_MAGDataSetTableAdapters.DOKMAGTableAdapter();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fKDOKMAGASORTDOKMAGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOKMAG_ASORTTableAdapter = new _4DOKMAG._4DOK_MAGDataSetTableAdapters.DOKMAG_ASORTTableAdapter();
            this.colID_DOKMAG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_DOKMAG_ASORT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAZWA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colILOSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNETTO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRUTTO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOKMAGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._4DOK_MAGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabFormContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDOKMAGASORTDOKMAGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.gitHubBarList});
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.MaxTabWidth = 400;
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.Pages.Add(this.tabFormPage2);
            this.tabFormControl1.SelectedPage = this.tabFormPage2;
            this.tabFormControl1.Size = new System.Drawing.Size(800, 71);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.TitleItemLinks.Add(this.gitHubBarList);
            // 
            // gitHubBarList
            // 
            this.gitHubBarList.Caption = "GitHub";
            this.gitHubBarList.Id = 0;
            this.gitHubBarList.Name = "gitHubBarList";
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Dokumenty magazynowe";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.gridControl1);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 71);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(800, 379);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dOKMAGBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dOKMAGBindingSource
            // 
            this.dOKMAGBindingSource.DataMember = "DOKMAG";
            this.dOKMAGBindingSource.DataSource = this._4DOK_MAGDataSet;
            // 
            // _4DOK_MAGDataSet
            // 
            this._4DOK_MAGDataSet.DataSetName = "_4DOK_MAGDataSet";
            this._4DOK_MAGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_DOKMAG,
            this.colDATA,
            this.colNUMER_KLIENTA,
            this.colNAZWA,
            this.colNETTO,
            this.colBRUTTO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID_DOKMAG
            // 
            this.colID_DOKMAG.FieldName = "ID_DOKMAG";
            this.colID_DOKMAG.Name = "colID_DOKMAG";
            // 
            // colDATA
            // 
            this.colDATA.FieldName = "DATA";
            this.colDATA.Name = "colDATA";
            this.colDATA.Visible = true;
            this.colDATA.VisibleIndex = 0;
            // 
            // colNUMER_KLIENTA
            // 
            this.colNUMER_KLIENTA.FieldName = "NUMER_KLIENTA";
            this.colNUMER_KLIENTA.Name = "colNUMER_KLIENTA";
            this.colNUMER_KLIENTA.Visible = true;
            this.colNUMER_KLIENTA.VisibleIndex = 1;
            // 
            // colNAZWA
            // 
            this.colNAZWA.FieldName = "NAZWA";
            this.colNAZWA.Name = "colNAZWA";
            this.colNAZWA.Visible = true;
            this.colNAZWA.VisibleIndex = 2;
            // 
            // colNETTO
            // 
            this.colNETTO.FieldName = "NETTO";
            this.colNETTO.Name = "colNETTO";
            this.colNETTO.Visible = true;
            this.colNETTO.VisibleIndex = 3;
            // 
            // colBRUTTO
            // 
            this.colBRUTTO.FieldName = "BRUTTO";
            this.colBRUTTO.Name = "colBRUTTO";
            this.colBRUTTO.Visible = true;
            this.colBRUTTO.VisibleIndex = 4;
            // 
            // tabFormPage2
            // 
            this.tabFormPage2.ContentContainer = this.tabFormContentContainer2;
            this.tabFormPage2.Name = "tabFormPage2";
            this.tabFormPage2.Text = "Asortyment dokumentu magazynowego";
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Controls.Add(this.gridControl2);
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 71);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(800, 379);
            this.tabFormContentContainer2.TabIndex = 2;
            // 
            // dOKMAGTableAdapter
            // 
            this.dOKMAGTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.fKDOKMAGASORTDOKMAGBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(800, 200);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_DOKMAG1,
            this.colID_DOKMAG_ASORT,
            this.colNAZWA1,
            this.colILOSC,
            this.colNETTO1,
            this.colBRUTTO1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // fKDOKMAGASORTDOKMAGBindingSource
            // 
            this.fKDOKMAGASORTDOKMAGBindingSource.DataMember = "FK_DOKMAG_ASORT_DOKMAG";
            this.fKDOKMAGASORTDOKMAGBindingSource.DataSource = this.dOKMAGBindingSource;
            // 
            // dOKMAG_ASORTTableAdapter
            // 
            this.dOKMAG_ASORTTableAdapter.ClearBeforeFill = true;
            // 
            // colID_DOKMAG1
            // 
            this.colID_DOKMAG1.FieldName = "ID_DOKMAG";
            this.colID_DOKMAG1.Name = "colID_DOKMAG1";
            // 
            // colID_DOKMAG_ASORT
            // 
            this.colID_DOKMAG_ASORT.FieldName = "ID_DOKMAG_ASORT";
            this.colID_DOKMAG_ASORT.Name = "colID_DOKMAG_ASORT";
            // 
            // colNAZWA1
            // 
            this.colNAZWA1.FieldName = "NAZWA";
            this.colNAZWA1.Name = "colNAZWA1";
            this.colNAZWA1.Visible = true;
            this.colNAZWA1.VisibleIndex = 0;
            // 
            // colILOSC
            // 
            this.colILOSC.FieldName = "ILOSC";
            this.colILOSC.Name = "colILOSC";
            this.colILOSC.Visible = true;
            this.colILOSC.VisibleIndex = 1;
            // 
            // colNETTO1
            // 
            this.colNETTO1.FieldName = "NETTO";
            this.colNETTO1.Name = "colNETTO1";
            this.colNETTO1.Visible = true;
            this.colNETTO1.VisibleIndex = 2;
            // 
            // colBRUTTO1
            // 
            this.colBRUTTO1.FieldName = "BRUTTO";
            this.colBRUTTO1.Name = "colBRUTTO1";
            this.colBRUTTO1.Visible = true;
            this.colBRUTTO1.VisibleIndex = 3;
            // 
            // DOKMAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabFormContentContainer2);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "DOKMAG";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Test rekrutacyjny   ";
            this.Load += new System.EventHandler(this.DOKMAG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOKMAGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._4DOK_MAGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabFormContentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDOKMAGASORTDOKMAGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.BarListItem gitHubBarList;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private _4DOK_MAGDataSet _4DOK_MAGDataSet;
        private System.Windows.Forms.BindingSource dOKMAGBindingSource;
        private _4DOK_MAGDataSetTableAdapters.DOKMAGTableAdapter dOKMAGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DOKMAG;
        private DevExpress.XtraGrid.Columns.GridColumn colDATA;
        private DevExpress.XtraGrid.Columns.GridColumn colNUMER_KLIENTA;
        private DevExpress.XtraGrid.Columns.GridColumn colNAZWA;
        private DevExpress.XtraGrid.Columns.GridColumn colNETTO;
        private DevExpress.XtraGrid.Columns.GridColumn colBRUTTO;
        private DevExpress.XtraBars.TabFormPage tabFormPage2;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource fKDOKMAGASORTDOKMAGBindingSource;
        private _4DOK_MAGDataSetTableAdapters.DOKMAG_ASORTTableAdapter dOKMAG_ASORTTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DOKMAG1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DOKMAG_ASORT;
        private DevExpress.XtraGrid.Columns.GridColumn colNAZWA1;
        private DevExpress.XtraGrid.Columns.GridColumn colILOSC;
        private DevExpress.XtraGrid.Columns.GridColumn colNETTO1;
        private DevExpress.XtraGrid.Columns.GridColumn colBRUTTO1;
    }
}

