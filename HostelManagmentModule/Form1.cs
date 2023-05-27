using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagmentModule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Employee Myemployee = new Employee();
            Myemployee.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Room Myroom = new Room();
            Myroom.Show();
            this.Hide();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Student Mystudent = new Student();
            Mystudent.Show();
            this.Hide();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            Fees Myfees = new Fees();   
            Myfees.Show();
            this.Hide();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Salary Mysalary = new Salary(); 
            Mysalary.Show();
            this.Hide();
        }
    }
}
