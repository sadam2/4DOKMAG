using DevExpress.XtraGrid.Views.Grid;
using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4DOKMAG
{
    public partial class DOKMAG : DevExpress.XtraBars.TabForm
    {
        #region Inicjalizacja i zamykanie
        public DOKMAG()
        {
            SetConnection();
            InitializeComponent();
            FillGitHubInfo();
        }

        private void DOKMAG_Load(object sender, EventArgs e)
        {
            dOKMAG_ASORTTableAdapter.Fill(this._4DOK_MAGDataSet.DOKMAG_ASORT);
            dOKMAGTableAdapter.Fill(this._4DOK_MAGDataSet.DOKMAG);
        }

        private void DOKMAG_FormClosing(object sender, FormClosingEventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.BaseView view = gridDOKMAG.FocusedView;
            if (!(view.PostEditor() && view.UpdateCurrentRow()))
            {
                e.Cancel = true;
                return;
            }
            dOKMAG_ASORTTableAdapter.Update(_4DOK_MAGDataSet.DOKMAG_ASORT);
            dOKMAGTableAdapter.Update(_4DOK_MAGDataSet.DOKMAG);
        }
        #endregion
        #region GitHub Info
        private string repositoryName = "4DOKMAG";
        private string CredentialsToken = "0ed370b66e8ab2aa9cd85cbff0e3466b8a0b0458";
        public static readonly string GitHubIdentity = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyProductAttribute>().Product;

        private void FillGitHubInfo()
        {
            Credentials Credentials = new Credentials(CredentialsToken);
            GitHubClient client = new GitHubClient(new ProductHeaderValue(GitHubIdentity));
            client.Credentials = Credentials;
            IReadOnlyList<Repository> repository = client.Repository.GetAllForCurrent().GetAwaiter().GetResult();
            if (repository.Count > 0)
            {
                foreach (Repository ourRepository in repository)
                {
                    if (ourRepository.Name == repositoryName)
                    {
                        gitHubBarList.Strings.AddRange(FromGitHub(ourRepository));
                    }
                }
            }
        }

        private string[] FromGitHub(Repository ourRepository)
        {
            string[] info = {
                "Repozytorium utworzył: " + ourRepository.Owner.Login,
                "Data utworzenia: " + ourRepository.CreatedAt.ToString(),
                "Liczba gwiazdek: " + ourRepository.StargazersCount.ToString(),
                "Url: " + (ourRepository.Url ?? "").ToString()
            };
            return info;
        }
        #endregion
        #region USTAWIENIA dla bazy danych
        private readonly string DBServer = "SLAWEK";
        private readonly string DBDatabase = "4DOK_MAG";
        private readonly string DBLogin = "superuser";
        private readonly string DBPassword = "123";
        private string ConnectionString
        {
            get => @"Data Source=" + DBServer + ";database=" + DBDatabase + ";user id=" + DBLogin + ";password=" + DBPassword + ";connection timeout=60;Persist Security Info=True";
        }

        private void SetConnection()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["_4DOKMAG.Properties.Settings.ConnectionString"].ConnectionString = ConnectionString;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        private void gridViewDOKMAG_MasterRowExpanding(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs e)
        {
            dOKMAGTableAdapter.Update(_4DOK_MAGDataSet.DOKMAG);
        }

        private void gridViewDOKMAG_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            DataRow master = gridViewDOKMAG.GetDataRow(gridViewDOKMAG.FocusedRowHandle);
            DataRow[] childs = master.GetChildRows("FK_DOKMAG_ASORT_DOKMAG");
            foreach (DataRow child in childs)
            {
                child.Delete();
            }
            dOKMAG_ASORTTableAdapter.Update(_4DOK_MAGDataSet.DOKMAG_ASORT);
        }

        private void gridViewDOKMAG_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                if (view.FocusedColumn.FieldName == "NETTO" || view.FocusedColumn.FieldName == "BRUTTO")
                {
                    decimal val = 0;
                    if (!Decimal.TryParse(e.Value as String, out val) || val <= 0)
                    {
                        e.Valid = false;
                        e.ErrorText = "To musi być liczba dodatnia.";
                    }
                }
            }
        }

        private void gridViewDOKMAG_ASORT_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                if (view.FocusedColumn.FieldName == "ILOSC" || view.FocusedColumn.FieldName == "NETTO" || view.FocusedColumn.FieldName == "BRUTTO")
                {
                    decimal val = 0;
                    if (!Decimal.TryParse(e.Value as String, out val) || val <= 0)
                    {
                        e.Valid = false;
                        e.ErrorText = "To musi być liczba dodatnia.";
                    }
                }
            }
        }
        #endregion
        #region Raport
        private ReportTables tables = new ReportTables();
        private void tabFormControl1_SelectedPageChanging(object sender, DevExpress.XtraBars.TabFormSelectedPageChangingEventArgs e)
        {
            if (e.Page != null && e.Page.Text == "Raport")
            {
                tables.DokInfo.Rows.Clear();
                tables.AsortInfo.Rows.Clear();
                DataRow master = gridViewDOKMAG.GetDataRow(gridViewDOKMAG.FocusedRowHandle);
                DataRow[] childs = master.GetChildRows("FK_DOKMAG_ASORT_DOKMAG");
                tables.DokInfo.ImportRow(master);
                foreach (DataRow child in childs)
                {
                    tables.AsortInfo.ImportRow(child);
                }
                AsortReport subrap = new AsortReport();
                subrap.SetDataSource(tables);
                DokMagReport rap = new DokMagReport();
                ReportViewer.ReportSource = rap;
                rap.SetDataSource(tables);
            }
        }
        #endregion
    }
}
