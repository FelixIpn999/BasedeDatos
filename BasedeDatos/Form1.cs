using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BasedeDatos
{
    public partial class Form1 : Form
    {
       
        SqlConnection con = new SqlConnection("Data Source=FELIX-PC;Initial Catalog=AdventureWorks2014;Integrated Security=True");
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        public string query = "SELECT * FROM Person.Person";
        public DataTable dtable;
        public DataView MyDataView;
        private int ID = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayData();

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(query,con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
