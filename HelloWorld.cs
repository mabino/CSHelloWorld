using System;
using System.Windows.Forms;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Form1 : Form
    {
        public Form1()
        {
            Text = "HelloWorld";
            Label label = new Label();
            label.Text = "HelloWorld";
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(50, 50);
            Controls.Add(label);
        }
    }
}
