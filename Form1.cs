using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1[] A= new Class1[2];
            int[] M=new int[3];
            
            A[0] = new Class1();
            A[0].a = 8;
            
            Console.WriteLine("{0}, {0}", "d");
        }
    }
}
