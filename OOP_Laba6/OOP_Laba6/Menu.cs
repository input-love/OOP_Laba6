using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Laba6
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private Point lastPoint;
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Start_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Sorting sort = new Sorting();
            sort.Show();
        }
    }
}
