using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static frmProject.Form1;

namespace frmProject
{
    public partial class Form1 : Form
    {
        private List<Sinhvien> sinhvien;
        public class Sinhvien
        {
            public string MaSV { get; set; }
            public string TenSV { get; set; }
            public string Lop { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            sinhvien = new List<Sinhvien>();

            dataGridView1.DataSource = sinhvien;
            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                if (index >= 0 && index < sinhvien.Count)
                {
                    
                    textBox1.Text = sinhvien[index].MaSV;
                    textBox2.Text = sinhvien[index].TenSV;
                    textBox3.Text = sinhvien[index].Lop;
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sv = new Sinhvien
            {
                MaSV = textBox1.Text,
                TenSV = textBox2.Text,
                Lop = textBox3.Text
            };

            sinhvien.Add(sv);
            RefreshDataGridView();
            ClearTextBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                sinhvien[index].MaSV = textBox1.Text;
                sinhvien[index].TenSV = textBox2.Text;
                sinhvien[index].Lop = textBox3.Text;
                RefreshDataGridView();
                ClearTextBoxes();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                sinhvien.RemoveAt(index);
                RefreshDataGridView();
                ClearTextBoxes();
            }
        }
        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sinhvien;
            dataGridView1.Refresh();
        }

        // Xóa dữ liệu trong các TextBox.
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
