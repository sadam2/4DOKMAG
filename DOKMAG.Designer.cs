
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridViewDOKMAG_ASORT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_DOKMAG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_DOKMAG_ASORT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAZWA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colILOSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNETTO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRUTTO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDOKMAG = new DevExpress.XtraGrid.GridControl();
            this.dOKMAGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._4DOK_MAGDataSet = new _4DOKMAG._4DOK_MAGDataSet();
            this.gridViewDOKMAG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_DOKMAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNUMER_KLIENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAZWA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNETTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRUTTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.gitHubBarList = new DevExpress.XtraBars.BarListItem();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.ReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.fKDOKMAGASORTDOKMAGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOKMAGTableAdapter = new _4DOKMAG._4DOK_MAGDataSetTableAdapters.DOKMAGTableAdapter();
            this.dOKMAG_ASORTTableAdapter = new _4DOKMAG._4DOK_MAGDataSetTableAdapters.DOKMAG_ASORTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDOKMAG_ASORT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDOKMAG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOKMAGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._4DOK_MAGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDOKMAG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            this.tabFormContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKDOKMAGASORTDOKMAGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewDOKMAG_ASORT
            // 
            this.gridViewDOKMAG_ASORT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_DOKMAG1,
            this.colID_DOKMAG_ASORT,
            this.colNAZWA1,
            this.colILOSC,
            this.colNETTO1,
            this.colBRUTTO1});
            this.gridViewDOKMAG_ASORT.GridControl = this.gridDOKMAG;
            this.gridViewDOKMAG_ASORT.GroupPanelText = "Przenieś tu nagłówek kolumny, aby według niej pogrupować";
            this.gridViewDOKMAG_ASORT.Name = "gridViewDOKMAG_ASORT";
            this.gridViewDOKMAG_ASORT.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewDOKMAG_ASORT_ValidatingEditor);
            // 
            // colID_DOKMAG1
            // 
            this.colID_DOKMAG1.FieldName = "ID_DOKMAG";
            this.colID_DOKMAG1.Name = "colID_DOKMAG1";
            this.colID_DOKMAG1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
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
            this.colILOSC.DisplayFormat.FormatString = "#,##0.000";
            this.colILOSC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colILOSC.FieldName = "ILOSC";
            this.colILOSC.Name = "colILOSC";
            this.colILOSC.OptionsColumn.FixedWidth = true;
            this.colILOSC.Visible = true;
            this.colILOSC.VisibleIndex = 1;
            // 
            // colNETTO1
            // 
            this.colNETTO1.DisplayFormat.FormatString = "#,##0.00";
            this.colNETTO1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNETTO1.FieldName = "NETTO";
            this.colNETTO1.Name = "colNETTO1";
            this.colNETTO1.OptionsColumn.FixedWidth = true;
            this.colNETTO1.Visible = true;
            this.colNETTO1.VisibleIndex = 2;
            // 
            // colBRUTTO1
            // 
            this.colBRUTTO1.DisplayFormat.FormatString = "#,##0.00";
            this.colBRUTTO1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBRUTTO1.FieldName = "BRUTTO";
            this.colBRUTTO1.Name = "colBRUTTO1";
            this.colBRUTTO1.OptionsColumn.FixedWidth = true;
            this.colBRUTTO1.Visible = true;
            this.colBRUTTO1.VisibleIndex = 3;
            // 
            // gridDOKMAG
            // 
            this.gridDOKMAG.DataSource = this.dOKMAGBindingSource;
            this.gridDOKMAG.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridViewDOKMAG_ASORT;
            gridLevelNode1.RelationName = "FK_DOKMAG_ASORT_DOKMAG";
            this.gridDOKMAG.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridDOKMAG.Location = new System.Drawing.Point(0, 0);
            this.gridDOKMAG.MainView = this.gridViewDOKMAG;
            this.gridDOKMAG.Name = "gridDOKMAG";
            this.gridDOKMAG.Size = new System.Drawing.Size(1013, 559);
            this.gridDOKMAG.TabIndex = 1;
            this.gridDOKMAG.UseEmbeddedNavigator = true;
            this.gridDOKMAG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDOKMAG,
            this.gridViewDOKMAG_ASORT});
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
            // gridViewDOKMAG
            // 
            this.gridViewDOKMAG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_DOKMAG,
            this.colDATA,
            this.colNUMER_KLIENTA,
            this.colNAZWA,
            this.colNETTO,
            this.colBRUTTO});
            this.gridViewDOKMAG.GridControl = this.gridDOKMAG;
            this.gridViewDOKMAG.GroupPanelText = "Przenieś tu nagłówek kolumny, aby według niej pogrupować";
            this.gridViewDOKMAG.Name = "gridViewDOKMAG";
            this.gridViewDOKMAG.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewDOKMAG.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewDOKMAG.PreviewFieldName = "NAZWA";
            this.gridViewDOKMAG.MasterRowExpanding += new DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventHandler(this.gridViewDOKMAG_MasterRowExpanding);
            this.gridViewDOKMAG.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridViewDOKMAG_RowDeleting);
            this.gridViewDOKMAG.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewDOKMAG_ValidatingEditor);
            // 
            // colID_DOKMAG
            // 
            this.colID_DOKMAG.FieldName = "ID_DOKMAG";
            this.colID_DOKMAG.Name = "colID_DOKMAG";
            this.colID_DOKMAG.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            // 
            // colDATA
            // 
            this.colDATA.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colDATA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDATA.FieldName = "DATA";
            this.colDATA.Name = "colDATA";
            this.colDATA.OptionsColumn.FixedWidth = true;
            this.colDATA.Visible = true;
            this.colDATA.VisibleIndex = 0;
            this.colDATA.Width = 120;
            // 
            // colNUMER_KLIENTA
            // 
            this.colNUMER_KLIENTA.FieldName = "NUMER_KLIENTA";
            this.colNUMER_KLIENTA.Name = "colNUMER_KLIENTA";
            this.colNUMER_KLIENTA.OptionsColumn.FixedWidth = true;
            this.colNUMER_KLIENTA.Visible = true;
            this.colNUMER_KLIENTA.VisibleIndex = 1;
            this.colNUMER_KLIENTA.Width = 200;
            // 
            // colNAZWA
            // 
            this.colNAZWA.FieldName = "NAZWA";
            this.colNAZWA.Name = "colNAZWA";
            this.colNAZWA.Visible = true;
            this.colNAZWA.VisibleIndex = 2;
            this.colNAZWA.Width = 518;
            // 
            // colNETTO
            // 
            this.colNETTO.DisplayFormat.FormatString = "#,##0.00";
            this.colNETTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNETTO.FieldName = "NETTO";
            this.colNETTO.Name = "colNETTO";
            this.colNETTO.OptionsColumn.FixedWidth = true;
            this.colNETTO.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.colNETTO.Visible = true;
            this.colNETTO.VisibleIndex = 3;
            // 
            // colBRUTTO
            // 
            this.colBRUTTO.DisplayFormat.FormatString = "#,##0.00";
            this.colBRUTTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBRUTTO.FieldName = "BRUTTO";
            this.colBRUTTO.Name = "colBRUTTO";
            this.colBRUTTO.OptionsColumn.FixedWidth = true;
            this.colBRUTTO.Visible = true;
            this.colBRUTTO.VisibleIndex = 4;
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.AllowMoveTabs = false;
            this.tabFormControl1.AllowMoveTabsToOuterForm = false;
            this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.gitHubBarList});
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.MaxTabWidth = 400;
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.Pages.Add(this.tabFormPage2);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.Size = new System.Drawing.Size(1013, 71);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.TitleItemLinks.Add(this.gitHubBarList);
            this.tabFormControl1.SelectedPageChanging += new DevExpress.XtraBars.TabFormSelectedPageChangingEventHandler(this.tabFormControl1_SelectedPageChanging);
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
            this.tabFormContentContainer1.Controls.Add(this.gridDOKMAG);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 71);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1013, 559);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // tabFormPage2
            // 
            this.tabFormPage2.ContentContainer = this.tabFormContentContainer2;
            this.tabFormPage2.Name = "tabFormPage2";
            this.tabFormPage2.Text = "Raport";
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Controls.Add(this.ReportViewer);
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 71);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(800, 385);
            this.tabFormContentContainer2.TabIndex = 2;
            // 
            // ReportViewer
            // 
            this.ReportViewer.ActiveViewIndex = -1;
            this.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.Size = new System.Drawing.Size(800, 385);
            this.ReportViewer.TabIndex = 0;
            // 
            // fKDOKMAGASORTDOKMAGBindingSource
            // 
            this.fKDOKMAGASORTDOKMAGBindingSource.DataMember = "FK_DOKMAG_ASORT_DOKMAG";
            this.fKDOKMAGASORTDOKMAGBindingSource.DataSource = this.dOKMAGBindingSource;
            // 
            // dOKMAGTableAdapter
            // 
            this.dOKMAGTableAdapter.ClearBeforeFill = true;
            // 
            // dOKMAG_ASORTTableAdapter
            // 
            this.dOKMAG_ASORTTableAdapter.ClearBeforeFill = true;
            // 
            // DOKMAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 630);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "DOKMAG";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Test rekrutacyjny   ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DOKMAG_FormClosing);
            this.Load += new System.EventHandler(this.DOKMAG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDOKMAG_ASORT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDOKMAG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOKMAGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._4DOK_MAGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDOKMAG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            this.tabFormContentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKDOKMAGASORTDOKMAGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.BarListItem gitHubBarList;
        private _4DOK_MAGDataSet _4DOK_MAGDataSet;
        private System.Windows.Forms.BindingSource dOKMAGBindingSource;
        private _4DOK_MAGDataSetTableAdapters.DOKMAGTableAdapter dOKMAGTableAdapter;
        private System.Windows.Forms.BindingSource fKDOKMAGASORTDOKMAGBindingSource;
        private _4DOK_MAGDataSetTableAdapters.DOKMAG_ASORTTableAdapter dOKMAG_ASORTTableAdapter;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraGrid.GridControl gridDOKMAG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDOKMAG_ASORT;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DOKMAG1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DOKMAG_ASORT;
        private DevExpress.XtraGrid.Columns.GridColumn colNAZWA1;
        private DevExpress.XtraGrid.Columns.GridColumn colILOSC;
        private DevExpress.XtraGrid.Columns.GridColumn colNETTO1;
        private DevExpress.XtraGrid.Columns.GridColumn colBRUTTO1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDOKMAG;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DOKMAG;
        private DevExpress.XtraGrid.Columns.GridColumn colDATA;
        private DevExpress.XtraGrid.Columns.GridColumn colNUMER_KLIENTA;
        private DevExpress.XtraGrid.Columns.GridColumn colNAZWA;
        private DevExpress.XtraGrid.Columns.GridColumn colNETTO;
        private DevExpress.XtraGrid.Columns.GridColumn colBRUTTO;
        private DevExpress.XtraBars.TabFormPage tabFormPage2;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewer;
    }
}

