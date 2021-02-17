using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3 };

            outputListBox.Items.Add("Poczatkowa zawartość tablicy:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }
            SetToZero(numbers);

            outputListBox.Items.Add("");
            outputListBox.Items.Add("Po wywołaniu metody SetToZero():");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }

        }

        private void SetToZero(int[] iArray)
        {
            for (int index = 0; index < iArray.Length; index++)
            {
                iArray[index] = 0;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
