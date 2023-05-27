using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace HostelManagmentModule
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        //db connect karo
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\HostelManagment.mdf;Integrated Security=True;Connect Timeout=30");

        // to fill room list 
        void FillStudentList()
        {
            connect.Open();
            string Myquery = "Select * from Student_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, connect);
            SqlCommandBuilder sbl = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StdList.DataSource = ds.Tables[0];

            connect.Close();
        }

        void FillRoomCombox()
        {
            connect.Open();
            string query = "Select * from Room_tbl where RoomStatus ='"+"Active"+"' and Booked='"+"Free"+"'";
            SqlCommand cmd1 = new SqlCommand(query, connect);
            SqlDataReader rdr;
            rdr = cmd1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomNum",typeof(int));
            dt.Load(rdr);
            StdRoomCb.ValueMember = "RoomNum";
            StdRoomCb.DataSource = dt;
            connect.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdId.Text = StdList.SelectedRows[0].Cells[0].Value.ToString();
            StdName.Text = StdList.SelectedRows[0].Cells[1].Value.ToString();
            StdFatherName.Text = StdList.SelectedRows[0].Cells[2].Value.ToString();
            StdPhone.Text = StdList.SelectedRows[0].Cells[3].Value.ToString();
            StdAddress.Text = StdList.SelectedRows[0].Cells[4].Value.ToString();
            StdUni.Text = StdList.SelectedRows[0].Cells[5].Value.ToString();
            StdDept.Text = StdList.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string RoomBooked; // status save krmy ky leye

            if (StdId.Text == "" || StdName.Text == "" || StdFatherName.Text == "" || StdDept.Text == "" || StdAddress.Text == "" || StdPhone.Text == "" || StdUni.Text == "")
            {
                MessageBox.Show("No Empty Field Allowed");
            }

            else
            {
               
                connect.Open();

                string query = "insert into Student_tbl values(" + StdId.Text + ",'" + StdName.Text + "','" + StdFatherName.Text + "','" + StdPhone.Text + "','" + StdAddress.Text + "','" + StdUni.Text + "','" + StdDept.Text + "','" + StdRoomCb.SelectedItem.ToString() + "','" + StdStatCb.SelectedItem.ToString() + "')";
                SqlCommand cmd1 = new SqlCommand(query, connect);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Added");
                connect.Close();
                FillStudentList();
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {
            FillRoomCombox();
            FillStudentList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StdId.Text == "")
            {
                MessageBox.Show("Enter The Student Roll Number");
            }

            else
            {

                connect.Open();

                string query = "delete from Student_tbl where Std_id='" + StdId.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query, connect);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Student Record Successfully Deleted");
                connect.Close();
                FillStudentList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StdId.Text == "")
            {
                MessageBox.Show("Enter The Student ID");
            }

            else
            {
                
                connect.Open();

                string query = "update Student_tbl set Std_Name='" + StdName.Text + "',Father_Name='" + StdFatherName.Text + "',Std_Cellphone='" + StdPhone.Text + "',Std_Address='" + StdAddress.Text + "',Std_University='" + StdUni.Text + "',Std_Depart='" + StdDept + "',Std_room=" + StdRoomCb.SelectedItem.ToString() + "',Std_status='" + StdStatCb.SelectedItem.ToString() + "',  where Std_id=" + StdId.Text + " ";
                SqlCommand cmd1 = new SqlCommand(query, connect);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Student Record Successfully Updated");
                connect.Close();
                FillStudentList();
            }
        }
    }
}
