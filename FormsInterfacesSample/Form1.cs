using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsInterfacesSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            APEntities context = new APEntities();
            try
            {
                List<Vendor> allVendors = context.Vendors.ToList();
                //do something with results
            }

            finally
            {
                //clean up resources
                context.Dispose();
            }

            //same as above: following dispose pattern
            using(var context2 = new APEntities())
            {
                var allVendors = context2.Vendors.ToList();
                //do something with results
            }
            //Dispose is called here . . .
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayHelloWorld("Hello World", new FileLogger());
        }

        private void DisplayHelloWorld(string msg, ILogger logger)
        {
            MessageBox.Show(msg);
            logger.Log(msg + " was printed out...");
        }
    }
}
