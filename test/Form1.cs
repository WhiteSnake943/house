using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            SolidBrush b = new SolidBrush(Color.Blue);
            SolidBrush c = new SolidBrush(Color.Yellow);
            g.DrawRectangle(new Pen(Brushes.Indigo, 4), 400, 300, 150, 150);
            g.FillRectangle(b, 400, 300, 150, 150);
            g.DrawLine(new Pen(Brushes.Red, 4), 400, 300, 475, 200);
            g.DrawLine(new Pen(Brushes.Red, 4), 475, 200, 550, 300);
            g.DrawLine(new Pen(Brushes.Red, 4), 400, 300, 550, 300);
            g.FillRectangle(c, 435, 350, 80, 50);
            g.DrawRectangle(new Pen(Brushes.Orange, 3), 435, 350, 80, 50);
            g.DrawLine(new Pen(Brushes.Orange, 3), 475, 350, 475, 400);
            int a = 0;
            Pen p = new Pen(Brushes.Green, 3);
            for (int i = 0; i < 100; i++)
            {
                g.DrawLine(p, a, 450, a + 5, 450);
                a = a + 10;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
