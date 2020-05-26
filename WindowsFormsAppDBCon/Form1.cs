using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDBCon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection con;

            connectionString = @"Data Source=AZ20002010; 
                                 Initial Catalog = Demodb;
                                User ID= sa;
                                Password= onirban123@";
            con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output="";
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = "Insert into demotb(TutorialID,TutorialName) values(4,'" + "VB.NET" + "')";


            //sql = "Select TutorialID,TutorialName from demotb";

            command = new SqlCommand(sql,con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();

            //dataReader = command.ExecuteReader();

            //while(dataReader.Read())
            //{
            //    Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "\n";
            //}

            //MessageBox.Show(Output);
            //dataReader.Close();
            command.Dispose();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demodbDataSet.demotb' table. You can move, or remove it, as needed.
            this.demotbTableAdapter.Fill(this.demodbDataSet.demotb);

        }
    }
}
