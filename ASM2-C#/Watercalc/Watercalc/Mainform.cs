using System.Security.Cryptography.X509Certificates;

namespace Watercalc
{
    public partial class Main_interface : Form
    {
        public class Type_customer
        {
            public static string type = "";
        }
        public class Set_nightmode
        {
            public static bool nightmode = false;
        }

        public Main_interface()
        {
            InitializeComponent();
        }
        private void btn_night_Click(object sender, EventArgs e)
        {
            Set_nightmode.nightmode = !Set_nightmode.nightmode;
            if (Set_nightmode.nightmode)
            {
                this.BackColor = Color.Black;
                ForeColor = Color.White;
                btn_a.BackColor = Color.Black;
                btn_h.BackColor = Color.Black;
                btn_p.BackColor = Color.Black;
                btn_b.BackColor = Color.Black;
                btn_cost.BackColor = Color.Black;
                btn_history.BackColor = Color.Black;
                btn_night.BackColor = Color.Black;
                btn_exit.BackColor = Color.Black;

            }
            if (!Set_nightmode.nightmode)
            {
                this.BackColor = SystemColors.Control;
                ForeColor = Color.Black;
                btn_a.BackColor = Color.White;
                btn_h.BackColor = Color.White;
                btn_p.BackColor = Color.White;
                btn_b.BackColor = Color.White;
                btn_cost.BackColor = Color.White;
                btn_history.BackColor = Color.White;
                btn_night.BackColor = Color.White;
                btn_exit.BackColor = Color.White;
            }
        }


        private void btn_h_Click(object sender, EventArgs e)
        {
            Type_customer.type = "House Hold";
            calc window_calc = new calc();
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            Type_customer.type = "Administrative agency or public services";
            calc window_calc = new calc();
            window_calc.txt_numMem.Enabled = false;
            window_calc.txt_numMem.BackColor = Color.Black;
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            Type_customer.type = "Production units";
            calc window_calc = new calc();
            window_calc.txt_numMem.Enabled = false;
            window_calc.txt_numMem.BackColor = Color.Black;
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            Type_customer.type = "Business services";
            calc window_calc = new calc();
            window_calc.txt_numMem.Enabled = false;
            window_calc.txt_numMem.BackColor = Color.Black;
            this.Hide();
            window_calc.ShowDialog();
            window_calc.Close();
            this.Show();
        }

        private void btn_cost_Click(object sender, EventArgs e)
        {
            cost cost = new cost();
            this.Hide();
            cost.ShowDialog();
            cost.Close();
            this.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
