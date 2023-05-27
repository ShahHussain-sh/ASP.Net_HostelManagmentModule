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

namespace HostelManagmentModule
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        //db connect karo
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\HostelManagment.mdf;Integrated Security=True;Connect Timeout=30");

        // registered stds ki id nikalo
        public void FillStdIdCb()
        {
            connect.Open();

            string query = "select Std_id from Student_tbl";
            SqlCommand cmd2 = new SqlCommand(query, connect);
            SqlDataReader rdr1;
            rdr1 = cmd2.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Std_id", typeof(string));
            dt.Load(rdr1);
            stdidcb.ValueMember = "Std_id";
            stdidcb.DataSource = dt;

            connect.Close();
        }

        // fetch karo data stdid sy 

        string sname, rnum;
        public void FetchData()
        {
            connect.Open();

            string query = "select * from Student_tbl where Std_id = '" + stdidcb.SelectedItem.ToString() + "'" ;
            SqlCommand cmd3 = new SqlCommand(query, connect);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows) 
            {
                sname = dr["Std_Name"].ToString();
                rnum = dr["Std_room"].ToString();

                StdName.Text = sname;
                RoomNum.Text = rnum;
            }
            
            connect.Close();
        }

        // to fill room list 
        void FillFeeList()
        {
            connect.Open();
            string Myquery = "Select * from Fees_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, connect);
            SqlCommandBuilder sbl = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            FeeList.DataSource = ds.Tables[0];

            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            FillStdIdCb();
            FetchData();
            FillFeeList();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string RoomBooked; // status save krmy ky leye
            
            if (FeeId.Text == "" || stdidcb.SelectedItem.ToString() == "" || StdName.Text == "" || RoomNum.Text == "" || FeeAmount.Text == "" )
            {
                MessageBox.Show("No Empty Field Allowed");
            }

            else
            {
                string payemnetperiod;

                payemnetperiod = DatePicker.Value.Month.ToString() + DatePicker.Value.Year.ToString();  

                connect.Open();

                string query = "insert into Fees_tbl values(" + FeeId.Text + ",'" + stdidcb.SelectedItem.ToString() + "','" + StdName.Text + "','" + RoomNum.Text + "','" + DatePicker.Text + "','" + FeeAmount.Text + "','" + "')";
                SqlCommand cmd1 = new SqlCommand(query, connect);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Fees Detail Successfully Added");
                connect.Close();
                FillFeeList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchData();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
