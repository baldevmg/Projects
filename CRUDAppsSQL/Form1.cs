using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace CRUDAppsSQL
{
    public partial class Form1 : Form
    {
        //Connecting String
        MySqlConnection con = new MySqlConnection
        ("SERVER=LOCALHOST ;DATABASE=StudentInformation ;UID=root ;PASSWORD=Sonata@123 ;");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ViewGird_bt_Click(object sender, EventArgs e)
        {
            viewGridData();
        }
        void viewGridData()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Student", con);

                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }
        void ClearTextBox()
        {
            RegNo_tx.Text = "";
            Name_tx.Text = "";
            Address_tx.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("insert into student(RegNo, student, address) values ("+RegNo_tx .Text+",'"+Name_tx .Text+"','"+Address_tx .Text+"')",con);

                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Insertion Successfull!!!");
                viewGridData();
                ClearTextBox();
                RegNo_tx.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }

        private void Update_tx_Click(object sender, EventArgs e)
        {
            string update = "update student set RegNo = " + RegNo_tx.Text + ", student='" + Name_tx.Text + "',address ='" + Address_tx.Text + "' where id = " + dataGridView1.SelectedRows[0].Cells[0].Value + "";
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(update, con);

                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Updated Successfull!!!");
                viewGridData();
                ClearTextBox();
                RegNo_tx.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            string delete = "delete from student where id = " + dataGridView1.SelectedRows[0].Cells[0].Value + "";
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(delete, con);

                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Deletion Successfull!!!");
                viewGridData();
                ClearTextBox();
                RegNo_tx.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }

        private void exit_tx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
