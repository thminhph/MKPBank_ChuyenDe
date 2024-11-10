using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPTUD
{
    public partial class TransactionHistory : Form
    {
        public DTO_TaiKhoan use;
        public DTO_ThongTinKH kh;
        BLL_ChiTietGiaoDich giaoDich = new BLL_ChiTietGiaoDich();
        public TransactionHistory(DTO_TaiKhoan use, DTO_ThongTinKH kh)
        {
            InitializeComponent();
            this.use = use;
            this.kh = kh;
        }
        private void TransactionHistory_Load_1(object sender, EventArgs e)
        {
            loadata();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }
        public void loadata()
        {
            dataGridView1.DataSource = giaoDich.laydanhsach(use.IdTaiKhoan.ToString());

        }
        private void radTienRa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radTienRa.Checked == true)
            {
                dataGridView1.DataSource = giaoDich.laydanhsachchuyen(use.IdTaiKhoan.ToString());

            }
        }

        private void radTienVao_CheckedChanged(object sender, EventArgs e)
        {
            if (radTienVao.Checked == true)
            {
                dataGridView1.DataSource = giaoDich.laydanhsachNhan(use.IdTaiKhoan.ToString());

            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTatCa.Checked == true)
            {
                dataGridView1.DataSource = giaoDich.laydanhsach(use.IdTaiKhoan.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagementCard management = new ManagementCard(use);
            management.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                dataGridView1.DataSource = giaoDich.laydanhsachdungtien(float.Parse(textBox1.Text).ToString());
                textBox1.Clear();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                dataGridView1.DataSource = giaoDich.laydanhsachtheotien(textBox2.Text, textBox3.Text);
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("hãy nhập số tiền bắt đầu");
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            if (dateTimePicker2.Text != null)
            {
                dataGridView1.DataSource = giaoDich.laydanhsachtheongay(dateTimePicker2.Value, dateTimePicker1.Value);

            }
        }
    }
}
