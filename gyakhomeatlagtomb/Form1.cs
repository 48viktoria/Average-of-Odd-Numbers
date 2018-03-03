using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyakhomeatlagtomb
{
    public partial class Form1 : Form
    {

        int [] numbers  =new int [20];

        Random rnd = new Random();



        void average()

        {
            int db = 0;
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                

                if (numbers[i]%2==1)

                {
                    db++;
                    sum = sum + numbers[i];
                }



                label1.Text = sum.ToString();
                label2.Text = db.ToString();
                this.Text = (sum / Convert.ToDouble(db)).ToString();
            }
        }




        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 20);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            average();
        }
    }
}
