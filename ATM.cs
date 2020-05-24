using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
            money.Add(5000, 100);
            money.Add(2000, 25);
            money.Add(1000, 60);
            money.Add(500, 342);
            money.Add(200, 41);
            money.Add(100, 100);
            money.Add(50, 39);
            GetMoney(5450);
        }

        private Dictionary<int, int> money = new Dictionary<int, int>(7);
        

        public void SetMoney(int value, int amount)
        {
            int amountBanknoteATM = money[value];
            money.Add(value, amountBanknoteATM + amount);
        }

        public void GetMoney(float sum)
        {
            float amBan;
            int amBan1;
            Dictionary<int, int> banknotesForIssue = new Dictionary<int, int>();
            int t = money.Keys.Last();
           // int t1 = money.Keys.
           // Console.WriteLine(t1);
            foreach (var el in money.Keys)
            {
                
                amBan = sum / el / 100 * 80;
                amBan1 = (int)amBan;

                sum = sum - amBan1 * el;

                if (el == t && sum > 0)
                {
                    amBan = sum / el * 2;
                    Console.WriteLine("1 " + el + " 2 " + t + " 3 " + amBan1);
                    sum = sum - amBan1 * el;
                }
                

                if (amBan > 0) banknotesForIssue.Add(el, amBan1);
                


                Console.WriteLine("номинал " + el);
                Console.WriteLine("Кол-во банкнот " + (int)amBan);
                Console.WriteLine("остаток " + sum);
                
            }
            foreach(var le in banknotesForIssue)
            {
                Console.WriteLine("ключ " + le.Key + " значение " + le.Value);
            }
            




        }
    }
}
