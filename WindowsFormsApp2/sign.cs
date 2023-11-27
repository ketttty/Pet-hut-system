using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp2
{
    public partial class sign : Form
    {
        public sign()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("账号或密码不能为空！");
            }
            user.name=textBox1.Text ;
            user.password=textBox2.Text  ;
            MessageBox.Show("注册成功");
            this.Hide();
        }

        private void sign_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
