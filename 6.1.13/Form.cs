using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1._13
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string str = TextInput.Text;
            StringUtility StringUtility = new StringUtility(str);
            LabelOut.Text = StringUtility.SelectPallindroms();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
