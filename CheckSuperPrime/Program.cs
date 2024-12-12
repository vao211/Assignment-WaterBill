//dotnet new console
using System;
using System.Globalization;
using System.Text;
namespace SuperPrime{
    class Program{
        static bool checkPrime(long num){
            if (num < 2){
                return false;
            }
            else if (num == 2){
                return true;
            }
            else{
                for(int i = 2; i <= Math.Sqrt(num); i++){
                    Console.WriteLine(num + " : " + i + " = " + num/i + " dư " + num%i);
                    if (num % i == 0){
                        return false;
                    }
                }
            }
            return true;
        }
        static bool checkSPrime(long num){
            bool result = checkPrime(num); 
            if (result == false){
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++){
                num /= 10; // loại bỏ chữ số cuối.
                if(num > 0){
                Console.WriteLine(num + " : " + i + " = " + num/i + " dư " + num%i);
                if(!checkPrime(num)){
                    return false;
                } //không sử dụng:
                /*else{
                    return true;
                }*/ 
                // vì sau khi checkPrime xong lần đầu mà không false, sẽ trả về true và kết thúc ct. 
                }
            }
            return true;
        }
        static void Main(string[] args){
            do
            {
                Console.OutputEncoding=UTF8Encoding.UTF8;
                Console.Write("Nhập 1 số bất kỳ: ");
                long num = Convert.ToInt64(Console.ReadLine());
                bool lastResult = checkSPrime(num);
                string mess = string.Empty;
                if(lastResult == true)
                {
                    mess = String.Format("{0} is a Super Prime number !.",num);
                }
                else
                {
                    mess = String.Format("{0} is not a Super Prime number !.", num);
                }
                Console.WriteLine(mess);
            }
            while (true);
        }
    }
}