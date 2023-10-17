using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;

namespace ProductWinApp
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        private string getConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                              .AddJsonFile("appsettings.json", true, true).Build();
            var strConnection = config["ConnectionStrings:MyStoreDB"];
            return strConnection;
        }
        DataSet dsMyStore = new DataSet();
        private void frmProduct_Load(object sender, EventArgs e)
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            using DbConnection connection = factory.CreateConnection();
            if (connection == null)
            {
                Console.WriteLine($"Unable to create the connection object.");
                return;
            }
            connection.ConnectionString = getConnectionString();
            connection.Open();
            string sql = "Select ProductID, ProductName From Products; Select * from Categories";
            try
            {
                DataAdapter dataAdapter = new SqlDataAdapter(sql, getConnectionString());
                dataAdapter.Fill(dsMyStore);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Get Data From Database"); }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsMyStore.Tables[0];
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsMyStore.Tables[1];
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}