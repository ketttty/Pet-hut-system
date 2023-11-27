using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

public abstract class Pet
{
    private string name;
    private string type;
    private string color;
    private string weight;
    private string food;

    public string Name { get => name; set => name = value; }
    public string Type { get => type; set => type = value; }
    public string Color { get => color; set => color = value; }
    public string Weight { get => weight; set => weight = value; }
    public string Food { get => food; set => food = value; }
    public abstract void Showme();



}





