using System;
using System.ComponentModel.Design;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Collections;
using System.Reflection.Emit;
using System.Runtime.Serialization;
//Hỏi xem có muốn bắt đầu không và có muốn chạy ct lần nữa sau khi có kq ko
do
{
    Console.Write("Start the program? (y/n) ");
    string start = Convert.ToString(Console.ReadLine());
    if (start == "n")
    {
        Console.WriteLine("Good bye!");
        break;
    }
    else if (start != "n" && start != "y")
    {
        Console.WriteLine("Please enter yes(y) or no(n)!");
        continue;
    }
    else if (start == "y")
    {
        //lấy tên
        Console.Write("Enter your name: ");
        string name = Convert.ToString(Console.ReadLine());
        do
        {
            //Lấy kiểu người dùng:
            Console.WriteLine("Enter h if you are Household customer.");
            Console.WriteLine("Enter a if you are Administrative agency or public services.");
            Console.WriteLine("Enter p if you are Production units.");
            Console.WriteLine("Enter b if you are Business services.");
            Console.Write("Enter your type of customer: ");
            string type = Convert.ToString(Console.ReadLine());
            //Nhập sai thì nhập lại (While true)
            if (type != "h" && type != "a" && type != "p" && type != "b")
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter your type of customer correctly!");
                Console.WriteLine("");
            }
            //Nhập đúng thì chạy chương trình
            else
            {
                Calc();
                break;
            }
            //Hàm tính
            void Calc()
            {
                double money = 0; //tiền
                //nước tháng trước và tháng này
                Console.Write("Enter last month water index: ");
                int lastWater = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter this month water index: ");
                int thisWater = Convert.ToInt32(Console.ReadLine());
                int usedWater = thisWater - lastWater;
                int numMem = 0;
                //nước tháng này ít hơn nước tháng trước thì ngừng
                if (usedWater < 0 || thisWater < 0 || lastWater < 0)
                {
                    Console.WriteLine("Please Check your water index");
                }
                //nhiều hoặc bằng hơn thì tiếp tục
                else
                {
                    //nếu là hộ gia đình
                    if (type == "h")
                    {
                        //Số người trong gia đình
                        Console.Write("Enter the number of family members: ");
                        numMem = Convert.ToInt16(Console.ReadLine());
                        //<0 thì dừng
                        if (numMem <= 0)
                        {
                            goto theEnd;
                        }
                        else
                        {
                            double memberUsedWater = usedWater / numMem;
                            if (memberUsedWater <= 10)
                            {
                                //tiền = 110%
                                money = usedWater * 5973 * 1.1;
                            }
                            else if (memberUsedWater > 10 && memberUsedWater <= 20)
                            {
                                money = usedWater * 7052 * 1.1;
                            }
                            else if (memberUsedWater > 20 && memberUsedWater <= 30)
                            {
                                money = usedWater * 8699 * 1.1;
                            }
                            else if (memberUsedWater <= 0)
                            {
                                
                            }
                            else
                            {
                                money = usedWater * 15929 * 1.1;
                            }
                        }
                    }
                    //Nếu là cơ quan hành chính
                    else if (type == "a")
                    {
                        money = usedWater * 9955 * 1.1;
                    }
                    //nếu là đv sản xuất
                    else if (type == "p")
                    {
                        money = (usedWater * 11615 * 1.1);
                    }
                    //nếu là bussiness
                    else if (type == "b")
                    {
                        money = usedWater * 22068 * 1.1;
                    }
                    //in ra kết quả
                    string typeCustomer = "";
                    if (type == "h")
                    {
                        typeCustomer = "Household customer";
                    }
                    else if (type == "a")
                    {
                        typeCustomer = "Administrative agency (public services)";
                    }
                    else if (type == "p")
                    {
                        typeCustomer = "Production units";
                    }
                    else if (type == "b")
                    {
                        typeCustomer = "Business services";
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Name of customer: {0}", name);
                    Console.WriteLine("Last month water index is: {0}", lastWater);
                    Console.WriteLine("This month water index is: {0}", thisWater);
                    Console.WriteLine("This month water consumption amount is: {0}", usedWater);
                    Console.WriteLine("This month's your {0} water bill is: {1} VND", typeCustomer, money);
                    Console.WriteLine("---------------------------------------------------------------");
                }
            theEnd:
                if (type == "h" && numMem <= 0)
                {
                    Console.WriteLine("Please enter the number of family members correctly!");
                }
            }
        }
        while (true);
    }
}
while (true);

