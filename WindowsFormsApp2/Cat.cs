using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Cat:Pet
    {
        public override void Showme()
        {
            MessageBox.Show("喵喵喵,并躺了下来");
        }
    }
    public class Dog : Pet
    {
        public override void Showme()
        {
            MessageBox.Show("汪汪汪,并摇了摇尾巴");
        }
    }
    public class Bird : Pet
    {
        public override void Showme()
        {
            MessageBox.Show("飞了一圈,又落在你的肩膀");
        }
    }
}
