using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Watercalc.Main_interface;

namespace Watercalc
{
    public partial class cost : Form
    {
        public cost()
        {
            InitializeComponent();
            if (SetNightMode.nightmode)
            {
                this.BackColor = Color.Black;
                btnExit.BackColor = Color.Black;
                ForeColor = Color.White;
            }
            if (!SetNightMode.nightmode)
            {
                this.BackColor = SystemColors.Control;
                btnExit.BackColor = SystemColors.Control;
                ForeColor = Color.Black;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
