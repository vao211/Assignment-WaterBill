using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static Watercalc.Main_interface;
using System.Data.SqlClient;

namespace Watercalc
{
    public partial class History : Form
    {
        string connectionString = "Data Source=myServerAddress;Initial Catalog=myDatabase;Integrated Security=True;";

        //Truyền dữ liệu từ calc vào history
        public void data_transm(string theName, double theConsump, double theMoney, string theUsertype)
        {
            string folderPath = @"C:/Userdata";
            string filePath = Path.Combine(folderPath, "Userdata.txt");

            // Tạo thư mục nếu thư mục chưa tồn tại
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Tạo tệp tin và ghi nội dung vào tệp (\r tạo dòng mới)
            string content = string.Format("|Name: {0} | Type: {3} | Consumption: {1} m3 | Pay: {2} Vnđ|.\r\n", theName, theConsump, Math.Round(theMoney, 3), theUsertype);
            File.AppendAllText(filePath, content);
        }
        public string readData()
        {
            // Đọc nội dung file
            string fileContent = File.ReadAllText(@"C:/Userdata/Userdata.txt");

            // Hiển thị nội dung file trong TextBox
            txt_history.Text = fileContent;
            return fileContent;
        }

        public History()
        {
            InitializeComponent();
            if (Set_nightmode.nightmode)
            {
                ForeColor = Color.White;
                this.BackColor = Color.Black;
                btn_exit.BackColor = Color.Black;
                btn_clear.BackColor= Color.Black;
                txt_history.BackColor = Color.Black;

            }
            if (!Set_nightmode.nightmode)
            {
                this.BackColor = SystemColors.Control;
                btn_exit.BackColor = Color.White;
                btn_clear.BackColor = Color.White;
                ForeColor = Color.Black;
                txt_history.BackColor = Color.White;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            string filePath = @"C:/Userdata/Userdata.txt";

            // Xóa toàn bộ dữ liệu trong file
            File.WriteAllText(filePath, string.Empty);
            txt_history.Text = readData();
        }
    }
}
