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
        int[,] xo = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Mouse(object sender, MouseEventArgs e)
        {
            int i,j;
            i =int.Parse(((Label)sender).Name[3].ToString());
            j =int.Parse(((Label)sender).Name[4].ToString());

            if (e.Button == MouseButtons.Left)
            {
                ((Label)sender).Text = "1";
                xo[i, j] = 1;
                check(i,
                    j,
                    1);
            }

            else
            {
                ((Label)sender).Text = "2";
                xo[i, j] = 2;
                check(i ,j ,2);
            }     
        }


        public void check(int i, int j, int person)
        {
            rowcheck(i, j, person);
            colcheck(i, j, person);
            gotraslicheck(person);
            gotrafarecheck(person);
        }

        public void rowcheck(int i, int j, int person)
        {

            if (xo[i,0] == person && xo[i,1] == person && xo[i,2]== person) 
            {
                MessageBox.Show("بازیکن شماره "+person.ToString()+" برنده شد");
            }
        }


        public void colcheck(int i, int j, int person)
        {

            if (xo[0,j] == person && xo[1,j] == person && xo[2,j] == person)
            {
                MessageBox.Show("بازیکن شماره " + person.ToString() + " برنده شد");
            }
        }
        public void gotraslicheck(int person)
        {

            if (xo[0,0] == person && xo[1,1] == person && xo[2,2] == person)
            {
                MessageBox.Show("بازیکن شماره " + person.ToString() + " برنده شد");
            }
        }

        public void gotrafarecheck(int person)
        {

            if (xo[2,0] == person && xo[1,1] == person && xo[0,2] == person)
            {
                MessageBox.Show("بازیکن شماره " + person.ToString() + " برنده شد");
            }
        }

    }
}
