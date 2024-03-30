using System.Security.Cryptography.X509Certificates;

namespace Watercalc
{
    public partial class Main_interface : Form
    {
        public class TypeCustomer
        {
            public static string type = string.Empty;
        }
        public class SetNightMode
        {
           public  static bool nightmode = false;
        }

        public Main_interface()
        {
            InitializeComponent();
        }
        private void btnNight_Click(object sender, EventArgs e)
        {
            SetNightMode.nightmode = !SetNightMode.nightmode;
            if (SetNightMode.nightmode)
            {
                this.BackColor = Color.Black;
                ForeColor = Color.White;
                btnA.BackColor = Color.Black;
                btnH.BackColor = Color.Black;
                btnP.BackColor = Color.Black;
                btnB.BackColor = Color.Black;
                btnCost.BackColor = Color.Black;
                btnHistory.BackColor = Color.Black;
                btnNight.BackColor = Color.Black;
                btnExit.BackColor = Color.Black;

            }
            if (!SetNightMode.nightmode)
            {
                this.BackColor = SystemColors.Control;
                ForeColor = Color.Black;
                btnA.BackColor = Color.White;
                btnH.BackColor = Color.White;
                btnP.BackColor = Color.White;
                btnB.BackColor = Color.White;
                btnCost.BackColor = Color.White;
                btnHistory.BackColor = Color.White;
                btnNight.BackColor = Color.White;
                btnExit.BackColor = Color.White;
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            TypeCustomer.type = "House Hold";
            calc window_calc = new calc();
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            TypeCustomer.type = "Administrative agency or public services";
            calc window_calc = new calc();
            window_calc.txtNumMem.Enabled = false; // set lại về false
            window_calc.txtNumMem.BackColor = Color.DarkGray;
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            TypeCustomer.type = "Production units";
            calc window_calc = new calc();
            window_calc.txtNumMem.Enabled = false; // set lại về false
            window_calc.txtNumMem.BackColor = Color.DarkGray;
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            TypeCustomer.type = "Business services";
            calc window_calc = new calc();
            window_calc.txtNumMem.Enabled = false; // set lại về false
            window_calc.txtNumMem.BackColor = Color.DarkGray;
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            cost cost = new cost();
            this.Hide();
            cost.ShowDialog();
            cost.Close();
            this.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            this.Hide();
            //Lỗi lần đầu chạy chưa có file text
            try
            {
                history.readData();
            }
            catch 
            {
                
            }
            history.ShowDialog();
            history.Close();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
