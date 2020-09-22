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
    enum DriverCommand
    {
        Start,
        Stop
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Driver(DriverCommand.Start);
        }

        private void Driver(DriverCommand command)
        {
            switch(command)
            {
                case DriverCommand.Start:
                    Console.WriteLine("Start!!!");
                    break;
                case DriverCommand.Stop:
                    Console.WriteLine("Stop!!!");
                    break;
                default:
                    break;
            }
        }
    }
}
