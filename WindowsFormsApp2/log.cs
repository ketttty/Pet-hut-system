using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void log_Load(object sender, EventArgs e)
        {
           
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {               
                chongwu1.type = "狗";
                chongwu1.name ="旺旺";
                chongwu1.weight ="20Kg";
                chongwu1.color ="黄";
                chongwu1.food ="骨头";
                chongwu2.type = "猫";
                chongwu2.name = "妙妙";
                chongwu2.weight = "10Kg";
                chongwu2.color = "黑";
                chongwu2.food = "小鱼";
                chongwu3.type = "鸟";
                chongwu3.name = "咕咕";
                chongwu3.weight = "5Kg";
                chongwu3.color = "蓝";
                chongwu3.food = "虫子";
            if (textBox1.Text == "1" && textBox2.Text == "1" && radioButton1.Checked)
            {
                petHous f = new petHous();
                f.Show();
            }
            else if (textBox1.Text == user.name  && textBox2.Text == user.password && radioButton2.Checked)
            {
                choice  f1 = new choice();
                f1.Show();
            }
            else  if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("账号或密码不能为空！");
            }
            else {
                MessageBox.Show("账号或密码输入错误或未选择正确用户信息！");

            }
            }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sign f1 = new sign();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
