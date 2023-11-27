using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class petHous : Form
    {
        public petHous()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamReader st = new StreamReader(@"pet.txt", Encoding.Default))
            {
                while (!st.EndOfStream)//判断是否读到文件结尾
                {
                    textBox1.Text = st.ReadToEnd();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = @"pet.txt";

            // 以Truncate的方式打开文件，实现清空文件
            using (FileStream fs = new FileStream(filePath, FileMode.Truncate))
            {
                // 清空文件
            }
            using (FileStream fsWrite = new FileStream(@"pet.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str =textBox1.Text;
              // byte[] buffer = Encoding.UTF8.GetBytes(str);
                 byte[] buffer = Encoding.Default.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
          
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label29.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label23.Visible = true;
            label22.Visible = true;
            label21.Visible = true;
            label20.Visible = true;
            label19.Visible = true;
            label19.Text = chongwu3.type;
            label20.Text = chongwu3.name;
            label21.Text = chongwu3.weight;
            label22.Text = chongwu3.color;
            label23.Text = chongwu3.food;
            label18.Visible = true;
            label17.Visible = true;
            label16.Visible = true;
            label15.Visible = true;
            label14.Visible = true;
            label14.Text = chongwu2.type;
            label15.Text = chongwu2.name;
            label16.Text = chongwu2.weight;
            label17.Text = chongwu2.color;
            label18.Text = chongwu2.food;
            label13.Visible = true;
            label12.Visible = true;
            label11.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
            label9.Text = chongwu1.type;
            label10.Text = chongwu1.name;
            label11.Text = chongwu1.weight;
            label12.Text = chongwu1.color;
            label13.Text = chongwu1.food;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add1 form = new Add1();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label29 .Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label24.Text = chongwu4.type;
            label25.Text = chongwu4.name;
            label26.Text = chongwu4.weight;
            label27.Text = chongwu4.color;
            label28.Text = chongwu4.food;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = false;
            button7.Visible = false;
            button6.Visible = false;
            label1.Visible = false ;
            label29.Visible = false ;
            label2.Visible = false ;
            label3.Visible = false ;
            label23.Visible = false ;
            label22.Visible = false ;
            label21.Visible = false ;
            label20.Visible = false ;
            label19.Visible = false ;
            label18.Visible = false ;
            label17.Visible = false ;
            label16.Visible = false ;
            label15.Visible = false  ;
            label14.Visible = false ;

            label13.Visible = false ;
            label12.Visible = false ;
            label11.Visible = false ;
            label10.Visible = false ;
            label9.Visible = false ;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false ;
            button3.Visible = false ;
            button4.Visible = false ;
            button5.Visible = true;
            button7.Visible = true;
            button6.Visible = true ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Isfood isfood = new Isfood();
            if (radioButton1.Checked)
            {
                if (isfood.IsFavoriteFood("旺旺", comboBox1.Text))
                {
                    MessageBox.Show("我喜欢这个o(*￣▽￣*)ブ");
                }
                else
                {
                    MessageBox.Show("我对你投来的食物不屑一顾 (╯▔皿▔)╯");
                }
            }
            if (radioButton2.Checked)
            {
                if (isfood.IsFavoriteFood("妙妙", comboBox1.Text))
                {
                    MessageBox.Show("我喜欢这个o(*￣▽￣*)ブ");
                }
                else
                {
                    MessageBox.Show("我对你投来的食物不屑一顾 (╯▔皿▔)╯");
                }
            }
            if (radioButton3.Checked)
            {
                if (isfood.IsFavoriteFood("咕咕", comboBox1.Text))
                {
                    MessageBox.Show("我喜欢这个o(*￣▽￣*)ブ");
                }
                else
                {
                    MessageBox.Show("我对你投来的食物不屑一顾 (╯▔皿▔)╯");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Dog dog = new Dog();
                dog.Showme();
            }
            if (radioButton2.Checked)
            {
                Cat cat = new Cat();
                cat.Showme();
            }
            if (radioButton3.Checked)
            {
                Bird bird = new Bird();
                bird.Showme();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
