using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_DangKiMonHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2020; i <= 2025; i++)
            {
                cbxNienkhoa.Items.Add(i.ToString());
            }
            cbxNienkhoa.SelectedIndex = 5; 
            cbxLop.Items.Add("Ứng dụng phần mềm 2");
            cbxLop.Items.Add("Ứng dụng phần mềm 3" +
                "");
            cbxLop.Items.Add("Thiết kế đồ họa");
            cbxLop.Items.Add("Quản lý mạng");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxNienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
                   
               
            

        }

        private void btnDangki_Click(object sender, EventArgs e)
        {

        }
    }
}
