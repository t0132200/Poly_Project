using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Driver(new StartCommander());
            this.Driver(new StopCommander());
        }

        private void Driver(Commander command)
        {
            command.Execute();
        }

    }

    abstract class Commander
    {
        public abstract void Execute();
    }

    class StartCommander:Commander
    {
       override public void Execute()
        {
            Console.WriteLine("Start!!!");
            MessageBox.Show("Start!!!");
        }
    }

    class StopCommander : Commander
    {
        override public void Execute()
        {
            Console.WriteLine("Stop!!!");
            MessageBox.Show("Stop!!!");
        }
    }
}
