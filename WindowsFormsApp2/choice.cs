using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp2
{
    public partial class choice : Form
    {
      
        public choice()
        {
            InitializeComponent();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "旺旺":
                    textBox1.Text = "您选择的宠物叫" + chongwu1.name + "，重" + chongwu1.weight + "，爱吃" + chongwu1.food + "的" + chongwu1.color + chongwu1.type;
                    textBox2.Text = null;
                    pictureBox1.Visible=false; 
                    pictureBox2.Visible = true;
                    break;
                case "妙妙":
                    textBox1.Text = "您选择的宠物叫" + chongwu2.name + "，重" + chongwu2.weight + "，爱吃" + chongwu2.food + "的" + chongwu2.color + chongwu2.type ;
                    textBox2.Text = "　　　　　／＞　 　 フ\r\n　　　　　|  　_　 _|\r\n　 　　　／` ミ＿xノ\r\n　　 　 /　　　 　 |\r\n　　　 /　 ヽ　　 ﾉ\r\n　 　 │　　|　|　|       喵~\r\n　／￣|　　 |　|　|\r\n　| (￣ヽ＿_ヽ_)__)      \r\n　＼二つ ";
                    break;
                case "咕咕":
                    textBox1.Text = "您选择的宠物叫" + chongwu3.name + "，重" + chongwu3.weight + "，爱吃" + chongwu3.food + "的" + chongwu3.color + chongwu3.type;
                    textBox2.Text = null; 
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                   
                    break;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "旺旺":
                    Dog dog = new Dog();
                    dog.Showme();
                    break;
                case "妙妙":
                    Cat cat = new Cat();
                    cat.Showme();
                    break;
                case "咕咕":
                    Bird bird = new Bird();
                    bird.Showme();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Isfood isfood = new Isfood();
            if(isfood.IsFavoriteFood(comboBox1.Text,comboBox2.Text))
            {
                MessageBox.Show("我喜欢这个o(*￣▽￣*)ブ");
            }
            else
            {
                MessageBox.Show("对你投来的食物不屑一顾 (╯▔皿▔)╯");
            }
        }

    
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void choice_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
