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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        //db connect karo
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\HostelManagment.mdf;Integrated Security=True;Connect Timeout=30");

        void FillEmployeeList()
        {
            connect.Open();
            string Myquery = "Select * from Employee_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, connect);
            SqlCommandBuilder sbl = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EmpList.DataSource = ds.Tables[0];

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

        private void Employee_Load(object sender, EventArgs e)
        {
            FillEmployeeList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpID.Text == "" || EmpName.Text == "" || EmpAdd.Text == "" || EmpPhone.Text == "" || EmpSal.Text == "")
            {
                MessageBox.Show("No Empty Field Allowed");
            }

            else
            {

                connect.Open();

                string query = "insert into Employee_tbl values(" + EmpID.Text + ",'" + EmpName.Text + "','" + EmpPhone.Text + "','" + EmpAdd.Text + "','" + EmpSal.Text + "','" + EmpPosCb.SelectedItem.ToString() + "','" + EmpStatCb.SelectedItem.ToString() + "')";
                SqlCommand cmd1 = new SqlCommand(query, connect);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Added");
                connect.Close();
                FillEmployeeList();
            }
        }

        private void EmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpID.Text = EmpList.SelectedRows[0].Cells[0].Value.ToString();
            EmpName.Text = EmpList.SelectedRows[0].Cells[1].Value.ToString();
            EmpAdd.Text = EmpList.SelectedRows[0].Cells[2].Value.ToString();
            EmpPhone.Text = EmpList.SelectedRows[0].Cells[3].Value.ToString();
            EmpSal.Text = EmpList.SelectedRows[0].Cells[4].Value.ToString();
            EmpPosCb.SelectedItem = EmpList.SelectedRows[0].Cells[5].Value.ToString();
            EmpStatCb.SelectedItem = EmpList.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EmpID.Text == "")
            {
                MessageBox.Show("Enter The Employee ID");
            }

            else
            {

                connect.Open();

                string query = "delete from Employee_tbl where Emp_id='" + EmpID.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query, connect);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Student Record Successfully Deleted");
                connect.Close();
                FillEmployeeList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpID.Text == "")
            {
                MessageBox.Show("Enter The Employee ID");
            }

            else
            {

                connect.Open();

                string query = "update Employee_tbl set Emp_Name='" + EmpName.Text + "',Emp_Phone='" + EmpPhone.Text + "',Emp_Address='" + EmpAdd.Text + "',Emp_Salary='" + EmpSal.Text + "',Emp_Position=" + EmpPosCb.SelectedItem.ToString() + "',Emp_status='" + EmpStatCb.SelectedItem.ToString() + "',  where Emp_id=" + EmpID.Text + " ";
                SqlCommand cmd1 = new SqlCommand(query, connect);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Employee Record Successfully Updated");
                connect.Close();
                FillEmployeeList();
            }
        }
    }
}
