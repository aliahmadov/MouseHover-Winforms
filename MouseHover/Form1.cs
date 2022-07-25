using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseHover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();

            int random_x = random.Next(this.Size.Width - 100);
            int random_y = random.Next(this.Size.Height - 100);

            button1.Location=new Point(random_x, random_y);
            Color[] colors=new Color[15] {Color.Aqua,Color.Red,Color.Green,Color.Blue,Color.Brown,Color.Orange,
            Color.PaleGreen,Color.Pink,Color.Purple,Color.Aquamarine,Color.AntiqueWhite,Color.Beige,
            Color.Azure,Color.BurlyWood,Color.Chocolate};
            Random random_Num = new Random();
            int random_Color = random.Next(14);
            this.BackColor = colors[random_Color];
        }
    }
}
