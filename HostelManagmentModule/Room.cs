using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//db import krny ky leye
using System.Data.SqlClient;

namespace HostelManagmentModule
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }
         //db connect karo
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\HostelManagment.mdf;Integrated Security=True;Connect Timeout=30");

        // to fill room list 
        void FillRoomList()
        {
            connect.Open();
            string Myquery = "Select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery,connect);
            SqlCommandBuilder sbl = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomList.DataSource = ds.Tables[0];

            connect.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        string RoomBooked; // status save krmy ky leye
        private void button1_Click(object sender, EventArgs e)
        {
            //string RoomBooked; // status save krmy ky leye

            if (RoomNumBtn.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }

            else
            {
                // agar yes radio check ha tu 
                if(RoomYesRadBtn.Checked == true) { RoomBooked = "Busy"; }
                else { RoomBooked = "Free"; }

                connect.Open();

                string query = "insert into Room_tbl values("+RoomNumBtn.Text+",'"+RoomStatusBtn.SelectedItem.ToString()+"','"+RoomBooked+"')";
                SqlCommand cmd1 = new SqlCommand(query, connect);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Room Successfully Added");
                connect.Close();
                FillRoomList();
            }
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (RoomNumBtn.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }

            else
            {
             
                connect.Open();

                string query = "delete from Room_tbl where RoomNum="+RoomNumBtn.Text+"";
                SqlCommand cmd1 = new SqlCommand(query, connect);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Room Successfully Deleted");
                connect.Close();
                FillRoomList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomNumBtn.Text = RoomList.SelectedRows[0].Cells[0].Value.ToString();
            
        }

        private void Room_Load(object sender, EventArgs e)
        {
            FillRoomList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RoomNumBtn.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }

            else
            {
                if (RoomYesRadBtn.Checked == true) { RoomBooked = "Busy"; }
                else { RoomBooked = "Free"; }

                connect.Open();

                string query = "update Room_tbl set RoomStatus='"+RoomStatusBtn.SelectedItem.ToString()+"',Booked='"+RoomBooked+"' where RoomNum="+RoomNumBtn.Text+" ";
                SqlCommand cmd1 = new SqlCommand(query, connect);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Room Successfully Updated");
                connect.Close();
                FillRoomList();
            }
        }
    }
}
