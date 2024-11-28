using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Pampazon.Diseño
{
    public static class UIHelper
    {
        public static void ConfigurarListViewYAnchoColumnas(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is ListView listView)
                {
                    
                    listView.BackColor = ColorTranslator.FromHtml("#f7f7f7"); // Gris claro
                    listView.OwnerDraw = true;
                    listView.GridLines = true;

                    listView.DrawColumnHeader += (sender, e) =>
                    {
                        e.DrawBackground();
                        using (var brush = new SolidBrush(ColorTranslator.FromHtml("#004c6d"))) // Azul petróleo
                        {
                            e.Graphics.FillRectangle(brush, e.Bounds);
                        }
                        if (e.Header != null)
                        {
                            TextRenderer.DrawText(e.Graphics, e.Header.Text, new Font("Arial", 10, FontStyle.Bold), e.Bounds, Color.White);
                        }
                    };

                    listView.DrawItem += (sender, e) => e.DrawDefault = true;
                    listView.DrawSubItem += (sender, e) => e.DrawDefault = true;

                    
                    foreach (ColumnHeader column in listView.Columns)
                    {
                        column.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                        if (column.Width <= 250)
                        {
                            column.Width = listView.Width / listView.Columns.Count;
                        }
                    }
                }
                else if (ctrl.HasChildren)
                {
                    ConfigurarListViewYAnchoColumnas(ctrl); 
                }
            }
        }

        public static void ConfigurarBotones(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = ColorTranslator.FromHtml("#004c6d"); // Azul petróleo
                    btn.ForeColor = Color.White; 
                    btn.FlatAppearance.BorderSize = 0; 
                    btn.MouseEnter += (s, e) => btn.BackColor = ColorTranslator.FromHtml("#005f8a"); // Hover
                    btn.MouseLeave += (s, e) => btn.BackColor = ColorTranslator.FromHtml("#004c6d"); // Color original
                }
                else if (ctrl.HasChildren)
                {
                    ConfigurarBotones(ctrl); 
                }
            }
        }
    }
}
