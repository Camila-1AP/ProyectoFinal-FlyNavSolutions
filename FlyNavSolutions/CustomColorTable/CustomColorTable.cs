using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyNavSolutions.CustomColorTable
{
    internal class CustomColorTable : ProfessionalColorTable
    {
       
        public override Color MenuStripGradientBegin => Color.MidnightBlue;    // Color base
        public override Color MenuStripGradientEnd => Color.MidnightBlue;      // Color base
    }
    public class MyRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(Brushes.BlueViolet, new Rectangle(Point.Empty, e.Item.Size));
                e.Item.ForeColor = Color.White;
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
        
    }
}

