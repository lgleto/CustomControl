using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void sliderControl2_MouseValueClick(object sender, EventArgs e)
        {
            label1.Text = $"hello{((SliderEventArgs)e).Value}";
        }
    }
}
