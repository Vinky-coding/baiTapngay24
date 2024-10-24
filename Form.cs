using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDangKy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label mylab = new Label();
            mylab.Text = "ĐĂNG KÝ";
            mylab.Size = new Size(120, 25);

            this.Controls.Add(mylab);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       
        /*private bool IsValidPass(string pass) 
        { 
            string PwPattern = @"^(?=.*[!?/@&]).{8,}$";
            return Regex.IsMatch(pass, PwPattern);
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "1234";

            if(textBox1.Text == username && textBox2.Text == password)
            {
                MessageBox.Show("Dang nhap thanh cong !");
                return;
            }
            else
            {
                MessageBox.Show("Dang nhap that bai!");
            }
           /* if(!IsValidPass(password))
            {
                MessageBox.Show("Mat khau phai co it nhat 8 ki tu va co 1 ky tu dac biet(!,*,%,..)!");
                return;
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
