using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ai_Assistant
{
    public partial class Form1 : Form
    {
        public int xCoor, Ycoor;
        public static void runMouse()
        {
            while (true)
            {
                Thread.Sleep(300);
                Console.WriteLine(Cursor.Position.X + ":" + Cursor.Position.Y);
            }

        }

        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
