using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static Watercalc.Main_interface;

namespace Watercalc
{

    public partial class calc : Form
    {
        public calc()
        {

            InitializeComponent();

            if (Set_nightmode.nightmode)
            {
                this.BackColor = Color.Black;
                btn_calc.BackColor = Color.Black;
                btn_clear.BackColor = Color.Black;
                btn_save.BackColor = Color.Black;
                btn_exit.BackColor = Color.Black;
                ForeColor = Color.White;
            }
            if (!Set_nightmode.nightmode)
            {
                this.BackColor = SystemColors.Control;
                btn_calc.BackColor = Color.White;
                btn_clear.BackColor = Color.White;
                btn_save.BackColor = Color.White;
                btn_exit.BackColor = Color.White;
                ForeColor = Color.Black;
            }
        }
        public double calc_money()
        {
            double money = 0;
            bool txt_numMem_enable = txt_numMem.Enabled;//(true)
            //H
            if (txt_numMem_enable == true)
            {
                string numMem = txt_numMem.Text.Trim();
                string lastIndex = txt_lastIndex.Text.Trim();
                string thisIndex = txt_thisIndex.Text.Trim();
                if (!int.TryParse(lastIndex, out _))
                {
                    MessageBox.Show("Please Enter a number!, Error !");
                    return money;
                }
                else if (!int.TryParse(thisIndex, out _))
                {
                    MessageBox.Show("Please Enter a number!, Error !");
                    return money;
                }
                else if (!int.TryParse(numMem, out _))
                {
                    MessageBox.Show("Please Enter a number!, Error !");
                    return money;
                }
                else if (int.Parse(numMem) < 1)
                {
                    MessageBox.Show("Number of members must be >= 1");
                    return money;
                }
                else if (int.Parse(thisIndex) - int.Parse(lastIndex) < 0 || int.Parse(lastIndex) < 0 || int.Parse(thisIndex) < 0)
                {
                    MessageBox.Show("Please Check your water index");
                    return money;
                }
                else
                {
                    double usedWater = int.Parse(thisIndex) - int.Parse(lastIndex);
                    double memberUsedWater = usedWater / int.Parse(numMem);
                    if (memberUsedWater <= 10)
                    {
                        //tiền = 110%
                        money = usedWater * 5973 * 1.1;
                        txt_result.Text = Convert.ToString(money);
                        txt_consum.Text = Convert.ToString(usedWater);
                        return money;
                    }
                    else if (memberUsedWater > 10 && memberUsedWater <= 20)
                    {
                        money = usedWater * 7052 * 1.1;
                        txt_result.Text = Convert.ToString(money);
                        txt_consum.Text = Convert.ToString(usedWater);
                        return money;
                    }
                    else if (memberUsedWater > 20 && memberUsedWater <= 30)
                    {
                        money = usedWater * 8699 * 1.1;
                        txt_result.Text = Convert.ToString(money);
                        txt_consum.Text = Convert.ToString(usedWater);
                        return money;
                    }
                    else
                    {
                        money = usedWater * 15929 * 1.1;
                        txt_result.Text = Convert.ToString(money);
                        txt_consum.Text = Convert.ToString(usedWater);
                        return money;
                    }
                }

            }
            //A P B
            else if (txt_numMem_enable == false)
            {
                string lastIndex = txt_lastIndex.Text.Trim();
                string thisIndex = txt_thisIndex.Text.Trim();
                if (!int.TryParse(lastIndex, out _))
                {
                    MessageBox.Show("Please Enter a number!, Error !");
                    return money;
                }
                if (!int.TryParse(thisIndex, out _))
                {
                    MessageBox.Show("Please Enter a number!, Error !");
                    return money;
                }
                else if (int.Parse(thisIndex) - int.Parse(lastIndex) < 0 || int.Parse(lastIndex) < 0 || int.Parse(thisIndex) < 0)
                {
                    MessageBox.Show("Please Check your water index");
                    return money;
                }
                else
                {
                    double usedWater = int.Parse(thisIndex) - int.Parse(lastIndex);
                    if (Type_customer.type == "Administrative agency or public services")
                    {
                        money = usedWater * 9955 * 1.1;
                        txt_result.Text = Convert.ToString(money);
                        txt_consum.Text = Convert.ToString(usedWater);
                        return money;
                    }
                    //nếu là đv sản xuất
                    else if (Type_customer.type == "Production units")
                    {
                        money = (usedWater * 11615 * 1.1);
                        txt_result.Text = Convert.ToString(money);
                        txt_consum.Text = Convert.ToString(usedWater);
                        return money;
                    }
                    //nếu là bussiness
                    else if (Type_customer.type == "Business services")
                    {
                        money = usedWater * 22068 * 1.1;
                        txt_result.Text = Convert.ToString(money);
                        txt_consum.Text = Convert.ToString(usedWater);
                        return money;
                    }
                }
            }
            return money;
        }
        public void btn_calc_Click(object sender, EventArgs e)
        {
            calc_money();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string strLastIndex = txt_lastIndex.Text.Trim();
            string strThisIndex = txt_thisIndex.Text.Trim();
            if (!int.TryParse(strLastIndex, out _))
            {
                MessageBox.Show("Please Enter a number!, Error !");
                return;
            }
            if (!int.TryParse(strThisIndex, out _))
            {
                MessageBox.Show("Please Enter a number!, Error !");
                return;
            }
            double consumption = double.Parse(strThisIndex) - double.Parse(strLastIndex);
            if (int.Parse(strThisIndex) - int.Parse(strLastIndex) < 0 || int.Parse(strLastIndex) < 0 || int.Parse(strThisIndex) < 0)
            {
                MessageBox.Show("Please check your water index!");
                return;
            }
            string name = txt_name.Text.Trim();
            History history = new History();
            this.Hide();
            history.data_transm(name, consumption, Math.Round(calc_money(), 3), Convert.ToString(Type_customer.type));
            history.readData();
            history.ShowDialog();
            history.Close();
            this.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_consum.Clear();
            txt_lastIndex.Clear();
            txt_numMem.Clear();
            txt_result.Clear();
            txt_thisIndex.Clear();
        }

        private void calc_Load(object sender, EventArgs e)
        {
            lbl_type.Text = Type_customer.type.ToString() + " customer";
        }
    }
}
