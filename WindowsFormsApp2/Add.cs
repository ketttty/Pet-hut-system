using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Program;

namespace WindowsFormsApp2
{
    public partial class Add1 : Form
    {
        public Add1()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {


        }

        private void speciesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {         
            chongwu4.type = type.Text;
            chongwu4.weight = weight.Text;
            chongwu4.food = food.Text;
            chongwu4.color = color.Text;
            chongwu4.name = name.Text;
            if (type.Text == "" || weight.Text == "" || food.Text == ""|| color.Text == ""|| name.Text == "")
            {
                MessageBox.Show("宠物信息不完善"); 
            }
            else 
            {  
                MessageBox.Show("成功添加!");
                this.Hide();
            }      
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

