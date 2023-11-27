using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Isfood:eat
    {
        public bool IsFavoriteFood(string Petname,string Foodname)
        {
            if ((Petname == "旺旺" && Foodname == "骨头") || (Petname == "妙妙" && Foodname == "小鱼") || (Petname == "咕咕" && Foodname == "虫子"))
            {
                return true;
            }
            else
                return false;
        }
    }
}
