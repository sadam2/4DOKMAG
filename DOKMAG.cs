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
        public DOKMAG()
        {
            SetConnection();
            InitializeComponent();
            FillGitHubInfo();
        }

        private void DOKMAG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_4DOK_MAGDataSet.DOKMAG_ASORT' table. You can move, or remove it, as needed.
            this.dOKMAG_ASORTTableAdapter.Fill(this._4DOK_MAGDataSet.DOKMAG_ASORT);
            // TODO: This line of code loads data into the '_4DOK_MAGDataSet.DOKMAG' table. You can move, or remove it, as needed.
            this.dOKMAGTableAdapter.Fill(this._4DOK_MAGDataSet.DOKMAG);

        }
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
        #endregion
    }
}
