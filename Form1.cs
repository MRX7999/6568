using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // подключили 

namespace BASE_DATA
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        public string CmdText = "SELECT * FROM [Category]";
        
        public string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ruban\\source\\repos\\WindowsFormsApp2\\ProjectOrganization.mdb";

        

        public Form1()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            // создаем объект DataSet
            DataSet ds = new DataSet();
            // заполняем таблицу Order  
            // данными из базы данных
            dataAdapter.Fill(ds, "[Category]");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "project_organization_1DataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.project_organization_1DataSet.Category);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}