using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_Click(object sender, EventArgs e)
        {
            long val =await GetValue();
            long val2 = await GetValue2();
            btn.Text = (val+val2).ToString();
        }

        private async Task<long> GetValue()
        {
            long res = 0;
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 1000000000; i++)
                {
                    res += i;
                }
            });

            await task;

            return res;
        }

        private async Task<long> GetValue2()
        {
            long res = 0;
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 1000000000; i++)
                {
                    res += i;
                }
            });

            await task;

            return res;
        }
    }
}
