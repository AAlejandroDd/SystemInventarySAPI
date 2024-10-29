using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemInventary.CustomControls
{
    internal class personalizedTxt : TextBox
    {
        public int BorderRadius { get; set; } = 40; // Valor predeterminado

        public personalizedTxt()
        {
            // Para quitar el borde del TextBox predeterminado
            BorderStyle = BorderStyle.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crear un nuevo GraphicsPath para redondear el TextBox
            using (GraphicsPath graphicsPath = new GraphicsPath())
            {
                graphicsPath.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
                graphicsPath.AddArc(Width - BorderRadius - 1, 0, BorderRadius, BorderRadius, 270, 90);
                graphicsPath.AddArc(Width - BorderRadius - 1, Height - BorderRadius - 1, BorderRadius, BorderRadius, 0, 90);
                graphicsPath.AddArc(0, Height - BorderRadius - 1, BorderRadius, BorderRadius, 90, 90);
                graphicsPath.CloseAllFigures();

                Region = new Region(graphicsPath);
            }

            // Para redibujar el TextBox
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Forzar un redibujo cuando el tamaño cambia
            Invalidate();
        }

    }
}
