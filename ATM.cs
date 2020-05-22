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
            money.Add(50, 0);
            money.Add(100, 0);
            money.Add(200, 0);
            money.Add(500, 0);
            money.Add(1000, 0);
            money.Add(2000, 0);
            money.Add(5000, 0);
        }

        private Dictionary<int, int> money = new Dictionary<int, int>(7);
        

        public void SetMoney(int value, int amount)
        {
            int amountBanknoteATM = money[value];
            money.Add(value, amountBanknoteATM + amount);
        }

        public int GetMoney(int sum)
        {
            return 100;
        }
    }
}
