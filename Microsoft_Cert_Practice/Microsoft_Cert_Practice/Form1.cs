using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsoft_Cert_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Func<int, int> square = x => x * x; // so Func<int,int> is an Action delegate - takes an int gives an int
            Console.WriteLine(square(5));
            Console.ReadKey();
        }
    }
}
