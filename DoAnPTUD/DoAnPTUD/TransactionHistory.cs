using System;
﻿using BLL;
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
        public TransactionHistory()
        {
            InitializeComponent();
        public DTO_TaiKhoan use;
        BLL_ChiTietGiaoDich giaoDich =new BLL_ChiTietGiaoDich();
        public TransactionHistory(DTO_TaiKhoan use)
        {
            InitializeComponent();
            this.use = use;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = !textBox1.Visible;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagementCard management = new ManagementCard(use);
            management.Show();
            this.Hide();
        }
        public void loadata()
        {
            dataGridView1.DataSource = giaoDich.laydanhsach(use.IdTaiKhoan.ToString());
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            loadata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void radTienVao_CheckedChanged(object sender, EventArgs e)
        {
            if (radTienVao.Checked)
            {
                dataGridView1.DataSource = giaoDich.laydanhsachNhan(use.IdTaiKhoan.ToString());
                loadata();
            }
        }

        private void radTienRa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTienRa.Checked)
            {
                dataGridView1.DataSource = giaoDich.laydanhsachchuyen(use.IdTaiKhoan.ToString());
                loadata();
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                dataGridView1.DataSource = giaoDich.laydanhsach(use.IdTaiKhoan.ToString());
                loadata();
            }
        }
           
    }
}
