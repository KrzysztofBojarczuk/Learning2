using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int SequentialSearch(string[] sArray, string value)
        {
            bool found = false;
            int index = 0;
            int position = -1;

            while (!found && index < sArray.Length)
            {
                if(sArray[index] == value)
                {
                    found = true;
                    position = index;
                }
                index++;
            }
            return position;
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            string selection;

            string[] colonies = {"Deleware", "Pensywalnia", "New Jersey",
            "Georgia", "Connecticut", "Massachusetts", "Wirginia", "Nowy Jork", "Karolina Północna",
            "Rhode Islands"};

            if (selectionListBox.SelectedIndex != -1)
            {
                selection = selectionListBox.SelectedItem.ToString();

                if (SequentialSearch(colonies, selection) != -1)
                {
                    MessageBox.Show("Tak, to była jedna z początkowych kolonii.");
                }
                else
                {
                    MessageBox.Show("Nie, to nie była jedna z początkowych kolonii.");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
