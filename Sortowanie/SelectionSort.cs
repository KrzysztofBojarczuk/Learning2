using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectionSort(int[] iArray)
        {
            int minIndex;
            int minValue;

            for (int startScan = 0; startScan < iArray.Length - 1; startScan++)
            {
                minIndex = startScan;
                minValue = iArray[startScan];

                for (int index = startScan + 1; index < iArray.Length; index++)
                {
                    if (iArray[index] < minValue)
                    {
                        minValue = iArray[index];
                        minIndex = index;
                    }
                }
                Swap(ref iArray[minIndex], ref iArray[startScan]);
            }
        }
        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int[] numbers = { 4, 6, 1, 3, 5, 2 };

            foreach (int value in numbers)
            {
                originalListBox.Items.Add(value);
            }
            SelectionSort(numbers);

            foreach (int value in numbers)
            {
                sortedListBox.Items.Add(value);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
