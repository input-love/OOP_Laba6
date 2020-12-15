using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Laba6
{
    public partial class Sorting : Form
    {
        public Sorting()
        {
            InitializeComponent();
        }

        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private Point lastPoint;
        private void Sorting_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Sorting_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Go_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                check_correct_input();

                string name = File_name.Text;
                int size = Parser.parse(Count.Text);

                int[] arr = ScanFile.scan_file(ref name, size);

                shape_facty(ref arr);
                print_file(ref arr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void file_name_Enter(object sender, EventArgs e)
        {
            if (File_name.Text == "File name")
            {
                File_name.Text = "";
                File_name.ForeColor = Color.Black;
            }
        }

        private void file_name_Leave(object sender, EventArgs e)
        {
            if (File_name.Text == "")
            {
                File_name.Text = "File name";
                File_name.ForeColor = Color.Gray;
            }
        }
        private void count_Enter(object sender, EventArgs e)
        {
            if (Count.Text == "Count")
            {
                Count.Text = "";
                Count.ForeColor = Color.Black;
            }
        }
        private void count_Leave(object sender, EventArgs e)
        {
            if (Count.Text == "")
            {
                Count.Text = "Count";
                Count.ForeColor = Color.Gray;
            }
        }

        private void check_correct_input()
        {
            if (!(File_name.Text != "File name" && Count.Text != "Count"))
            {
                throw new Exception("Ошибка ввода данных!");
            }
        }

        private void shape_facty(ref int[] arr)
        {
            if (Quick.Checked)
            {
                Shape shape = new Quick();
                shape.sort(ref arr);
            }
            else
            {
                Shape shape = new Choice();
                shape.sort(ref arr);
            }
        }

        private void print_file(ref int[] arr)
        {
            PrintFile.print_file(ref arr);
            MessageBox.Show(String.Format("Успешно, файл будет выгружен в корневую папку проекта!"));
        }
    }
}
