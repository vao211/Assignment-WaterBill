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


        //Truyền dữ liệu từ calc vào history
        public void dataTransm(
            string theName, 
            double theConsump, 
            double theMoney, 
            string theUsertype
            )
        {
            string folderPath = @"C:/Userdata";
            string filePath = @"C:/Userdata/WaterBill.userdata.txt";

            // Tạo thư mục nếu thư mục chưa tồn tại
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Tạo tệp tin và ghi nội dung vào tệp 
            string content = string.Format("|Name: {0} |" +
                " Type: {3} | Consumption: {1} m3 |" +
                " Pay: {2} VND|.\r\n"
                , theName, theConsump, Math.Round(theMoney, 3), theUsertype);
            File.AppendAllText(filePath, content);
        }
        public string readData()
        {
            // Đọc nội dung file
            string fileContent = File.ReadAllText(
                @"C:/Userdata/WaterBill.userdata.txt");
            // Hiển thị nội dung file trong TextBox
            txtHistory.Text = fileContent;
            return fileContent;
        }

        public History()
        {
            InitializeComponent();
            if (SetNightMode.nightmode)
            {
                ForeColor = Color.White;
                this.BackColor = Color.Black;
                btnExit.BackColor = Color.Black;
                btnClear.BackColor = Color.Black;
                txtHistory.BackColor = Color.Black;

            }
            if (!SetNightMode.nightmode)
            {
                this.BackColor = SystemColors.Control;
                btnExit.BackColor = Color.White;
                btnClear.BackColor = Color.White;
                ForeColor = Color.Black;
                txtHistory.BackColor = Color.White;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Lỗi lần đầu chạy chưa có file text
            try
            {
                string filePath = @"C:/Userdata/WaterBill.userdata.txt";

                // Xóa toàn bộ dữ liệu trong file
                File.WriteAllText(filePath, string.Empty);
                txtHistory.Text = readData();
            }
            catch { }
        }
    }
}
