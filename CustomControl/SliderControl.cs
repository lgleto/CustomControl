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
    public partial class SliderControl : Control
    {

        int Ypos = 0;
        public event EventHandler MouseValueClick;
        public SliderControl()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            
            base.OnPaint(pe);
            pe.Graphics.DrawRectangle(new Pen(Color.Red, 1), 0, 0, Width, Height);
            pe.Graphics.FillRectangle(new SolidBrush(Color.Aqua), 0, Ypos, Width, Height);

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {

            // Make the cursor the Hand cursor when the mouse moves 
            // over the button.
            Cursor = Cursors.Hand;

            // Call MyBase.OnMouseMove to activate the delegate.
            base.OnMouseMove(e);

            Ypos = e.Y;
            Invalidate();
        }
        
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            float value = ((float)Ypos / (float)Height) * 100f;
            SliderEventArgs sliderEventArgs = new SliderEventArgs();
            sliderEventArgs.Value = (int)(100-value);
            MouseValueClick?.Invoke(this, sliderEventArgs);

            
        }


    }


    public class SliderEventArgs : EventArgs
    {
        public int Value { get; set; }
       
    }
}
