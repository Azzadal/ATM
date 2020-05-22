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
            many.Add(50, 0);
            many.Add(100, 0);
            many.Add(200, 0);
            many.Add(500, 0);
            many.Add(1000, 0);
            many.Add(2000, 0);
            many.Add(5000, 0);
        }

        private Dictionary<int, int> many = new Dictionary<int, int>(7);
        

        public void SetMoney(int value, int amount)
        {
            int amountBanknoteATM = many[value];
            many.Add(value, amountBanknoteATM + amount);
        }

        public int GetMoney(int sum)
        {
            return 100;
        }
    }
}
