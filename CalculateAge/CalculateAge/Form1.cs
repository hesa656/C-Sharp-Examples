using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateAge
{
    public partial class Form1 : Form
    {
        int birthYear;

        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            birthYear = e.Start.Year; //Get selected Year in calendar
        }

        private void calculate_bttn_Click(object sender, EventArgs e)
        {
            var age = DateTime.Now.Year - birthYear; //Calculate Age (Actual year minus Your birthday year)

            Console.WriteLine("DateTime.Now.Year: " + DateTime.Now.Year + "\nbirthYear: " + birthYear + "\nResult: " + age);

            MessageBox.Show("You are " + age + " years old!", "That's it!", MessageBoxButtons.OK, MessageBoxIcon.Information); //Show MessageBox with result
        }
    }
}
