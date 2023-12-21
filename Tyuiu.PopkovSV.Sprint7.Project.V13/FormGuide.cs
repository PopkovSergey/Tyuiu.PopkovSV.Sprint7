using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PopkovSV.Sprint7.Project.V13
{
    public partial class FormGuide : Form
    {
        public FormGuide()
        {
            InitializeComponent();
        }

        private void buttonOkGuide_PSV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxGuide_PSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
