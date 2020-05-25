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
            
            
        }
        
        private Dictionary<int, int> money = new Dictionary<int, int>(7);
        private int inputCash;
        private List<int> temp = new List<int>();

        public void SetMoney(int value, int amount)
        {
            
            int amountBanknoteATM = money[value];
            money.Add(value, amountBanknoteATM + amount);
        }

        public void GetMoney(float sum)
        {
            temp.Sort(delegate (int x, int y)
            {
                return y.CompareTo(x);
            });

            float amBan;
            int amBan1;
            Dictionary<int, int> banknotesForIssue = new Dictionary<int, int>();
            int t = money.Keys.Last();
            int lastElemList = temp.Last();
            int i = 0;
            int perc = 80;

            try
            {
                foreach (var el in money.Keys)
                {
                    


                        if (el == temp[i])
                        {

                        amBan = sum / el / 100 * perc;

                            amBan1 = (int)amBan;

                        if (el == lastElemList && sum > 0)
                        {
                            perc -= 10;

                            amBan = sum / el;

                            amBan1 = (int)amBan;
                        }

                        sum = sum - amBan1 * el;

                            if (amBan > 0) banknotesForIssue.Add(el, amBan1);
                            //if (sum > 0)
                            //{
                            //    MessageBox.Show("Выберите более мелкие купюры");
                            //    return;
                            //}

                            Console.WriteLine();
                            Console.Write("номинал " + el);
                            Console.Write(" Кол-во банкнот " + (int)amBan);
                            Console.WriteLine(" остаток " + sum);
                        }
                        else
                        {
                            continue;
                        }

                        i++;
                    
                }
            }
            catch
            {

            }
                
                foreach (var le in banknotesForIssue)
            {
                Console.WriteLine("ключ " + le.Key + " значение " + le.Value);
            }
        }

        private void getCash_Click(object sender, EventArgs e)
        {
            inputCash = int.Parse(input.Text);
            GetMoney(inputCash);
        }

        private void check5000_CheckedChanged(object sender, EventArgs e)
        {
            if(check5000.Checked == true)
            {
                temp.Add(5000);
            }
            else
            {
                temp.Remove(5000);
            }
        }

        private void check2000_CheckedChanged(object sender, EventArgs e)
        {
            if (check2000.Checked == true)
            {
                temp.Add(2000);
            }
            else
            {
                temp.Remove(2000);
            }
        }

        private void check1000_CheckedChanged(object sender, EventArgs e)
        {
            if (check1000.Checked == true)
            {
                temp.Add(1000);
            }
            else
            {
                temp.Remove(1000);
            }
        }

        private void check500_CheckedChanged(object sender, EventArgs e)
        {
            if (check500.Checked == true)
            {
                temp.Add(500);
            }
            else
            {
                temp.Remove(500);
            }
        }

        private void check200_CheckedChanged(object sender, EventArgs e)
        {
            if (check200.Checked == true)
            {
                temp.Add(200);
            }
            else
            {
                temp.Remove(200);
            }
        }

        private void check100_CheckedChanged(object sender, EventArgs e)
        {
            if (check100.Checked == true)
            {
                temp.Add(100);
            }
            else
            {
                temp.Remove(100);
            }
        }

        private void check50_CheckedChanged(object sender, EventArgs e)
        {
            if (check50.Checked == true)
            {
                temp.Add(50);
            }
            else
            {
                temp.Remove(50);
            }
        }
    }
}
