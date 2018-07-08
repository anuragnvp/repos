using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String TypeName = textTypeName.Text;
            Type T = Type.GetType(TypeName);
            MethodInfo[] methodInfo = T.GetMethods();
            foreach (MethodInfo methods in methodInfo)
            {
                listmethods.Items.Add(methods.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textTypeName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
