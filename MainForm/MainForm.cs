using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace UI_Example
{
    public partial class QueueForm : Form
    {
        //TODO: fix this path
        private const string orderExePath = @"C:\Users\isysoi\Documents\GitHub\Doners\AddOrder\bin\Debug\AddOrder.exe";

        public QueueForm()
        {
            InitializeComponent();
        }

        private void AddNewOrderButtonClick(object sender, EventArgs e)
        {
            Process.Start(orderExePath);
        }
    }
}
