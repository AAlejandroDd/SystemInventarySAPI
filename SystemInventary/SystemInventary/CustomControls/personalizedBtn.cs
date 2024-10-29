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
    internal class personalizedBtn : Button
    {
        public int BorderRadius { get; set; } = 20; // Valor predeterminado

        public personalizedBtn()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0; // Quita el borde de clic predeterminado
            FlatAppearance.MouseDownBackColor = BackColor; // Evita el cambio de color al hacer clic
            FlatAppearance.MouseOverBackColor = BackColor; // Evita el cambio de color al pasar el mouse
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            graphicsPath.AddArc(Width - BorderRadius - 1, 0, BorderRadius, BorderRadius, 270, 90);
            graphicsPath.AddArc(Width - BorderRadius - 1, Height - BorderRadius - 1, BorderRadius, BorderRadius, 0, 90);
            graphicsPath.AddArc(0, Height - BorderRadius - 1, BorderRadius, BorderRadius, 90, 90);
            graphicsPath.CloseAllFigures();

            Region = new Region(graphicsPath);
        }

        // Sobrescribe el método OnMouseDown para evitar el cambio de estilo al hacer clic
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            // No llama a la base para evitar el cambio de borde
        }

        // Sobrescribe el método OnMouseUp para evitar el cambio de estilo al soltar el clic
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            // No llama a la base para evitar el cambio de borde
        }
    }
}
