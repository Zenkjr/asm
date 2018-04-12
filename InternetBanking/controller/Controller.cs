using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking
{
    class Controller
    {
        public bool HandleLogin(string username, string password)
        {
            // gọi hàm SelectByUsername(username).
            // nếu hàm trả về 1 user: 
            //  - so sánh password nhập vào và pass lưu trong database: == thì return true còn != return false (có muối);
            // nếu hàm trả về null thì return false(đăng nhập không thành công); 

            return true;
        }

        // viết các câu lệnh xử lí phần đăng kí
        public void HandleSignup()
        {

        }

        // viết các câu lệnh xử lí phần thông tin người dùng
        public void HandleInforUser()
        {

        }

        // viết các câu lệnh xử lí phần truy vấn số dư
        public void HandleQueryBalance()
        {

        }

        // viết các câu lệnh xử lí phần rút tiền
        public void HandleWithdrawal()
        {
            ValidateBlane validateBlane = new ValidateBlane();
            Model model = new Model();

            // hiển thị cho người dùng lựa chọn
            Console.WriteLine("---------------------------------- Withdrawal -----------------------------");
            Console.WriteLine("1. 100 000");
            Console.WriteLine("2. 200 000");
            Console.WriteLine("3. 500 000");
            Console.WriteLine("4. 1 000 000");
            Console.WriteLine("5. 2 000 000");
            Console.WriteLine("6. 5 000 000");
            Console.WriteLine("7. another choice");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" please enter you choise ");

            //tạo biến cho người dùng nhập vào
            int choise;
            Double WithdrawalAmount = 0;

            // cho người dùng nhập vào lựa chọn
            choise = int.Parse(Console.ReadLine());

            User user = model.SelectByUsernameFromTableUser("loc");

            Boolean checkBlance = false;

            switch (choise)
            {
                case 1:
                    WithdrawalAmount = 100000;
                    checkBlance = validateBlane.CheckBlance(WithdrawalAmount);
                    if (checkBlance)
                    {
                        user.Balance -= WithdrawalAmount;
                    }
                    break;
                case 2:
                    WithdrawalAmount = 200000;
                    checkBlance = validateBlane.CheckBlance(WithdrawalAmount);
                    if (checkBlance)
                    {
                        user.Balance -= WithdrawalAmount;
                    }
                    break;
                case 3:
                    WithdrawalAmount = 500000;
                    checkBlance = validateBlane.CheckBlance(WithdrawalAmount);
                    if (checkBlance)
                    {
                        user.Balance -= WithdrawalAmount;
                    }
                    break;
                case 4:
                    WithdrawalAmount = 1000000;
                    checkBlance = validateBlane.CheckBlance(WithdrawalAmount);
                    if (checkBlance)
                    {
                        user.Balance -= WithdrawalAmount;
                    }
                    break;
                case 5:
                    WithdrawalAmount = 2000000;
                    checkBlance = validateBlane.CheckBlance(WithdrawalAmount);
                    if (checkBlance)
                    {
                        user.Balance -= WithdrawalAmount;
                    }
                    break;
                case 6:
                    WithdrawalAmount = 5000000;
                    checkBlance = validateBlane.CheckBlance(WithdrawalAmount);
                    if (checkBlance)
                    {
                        user.Balance -= WithdrawalAmount;
                    }
                    break;
                case 7:
                    // cho người dùng nhập số tiền muốn rút ra 
                    WithdrawalAmount = double.Parse(Console.ReadLine());
                    checkBlance = validateBlane.CheckBlance(WithdrawalAmount);
                    if (checkBlance)
                    {
                        user.Balance -= WithdrawalAmount;
                    }
                    break;
                default:
                    Console.WriteLine("Ban chon chua dung");
                    break;
            }
            if (checkBlance)
            {
                //trừ đi số tiền trong tài khoản trên dâtbase
                model.Update(user.Balance, user.Username);
                //lưu lịch sử rút tiền
                model.InsertToTableHistory(user.Username, WithdrawalAmount);
                Console.WriteLine("withdraw money successfully");
            }
        }

        // viết các câu lệnh xử lí phần chuyển khoản
        public void HandleTransfers()
        {

        }

        // viết các câu lệnh xử lí phần xem lịch sử giao dịch
        public void HandleTransactionHistory()
        {

        }
    }
}
