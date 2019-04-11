/* C1891
 * CIS 199-75
 * 4/25/17
 * Program 4
 * Program 4 asks us to make a new class, which has properties of our package
 * and we are to calculate a price depending on zip codes and the package's specifications
 * We are also required to have it added to a listbox, with details options, along with 
 * options to send to and from U of L, which will change the price and details of the package.
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class Form1 : Form
    {
        private List<GroundPackage> packageList = new List<GroundPackage>();

        public Form1()
        {
            InitializeComponent();
        }
        // This button adds packages to the listbox, from the user's input in the textboxes
        private void addPackageButton_Click(object sender, EventArgs e)
        {
            GroundPackage myPackage;// holds new package 
            int origin; // origin zip
            int destination; // destination zip
            double length; // holds the length of package
            double width; //holds the width of package
            double height; //holds the height of package
            double weight; //holds the weight of package
            if (int.TryParse(originTextbox.Text, out origin))
                if (int.TryParse(destinationTextBox.Text, out destination))
                    if (double.TryParse(lengthTextBox.Text, out length))
                        if (double.TryParse(widthTextBox.Text, out width))
                            if (double.TryParse(heightTextBox.Text, out height))
                                if (double.TryParse(weightTextBox.Text, out weight))
                                {
                                    myPackage = new GroundPackage(origin, destination, length, width, height, weight);
                                    packageList.Add(myPackage);
                                    packageListBox.Items.Add(myPackage.CalcCost());
                                    originTextbox.Clear();
                                    destinationTextBox.Clear();
                                    lengthTextBox.Clear();
                                    widthTextBox.Clear();
                                    heightTextBox.Clear();
                                    weightTextBox.Clear();
                                }
                                else
                                    MessageBox.Show("Enter valid weight");
                            else
                                MessageBox.Show("Enter valid height");
                        else
                            MessageBox.Show("Enter valid width");
                    else
                        MessageBox.Show("Enter valid length");
                else
                    MessageBox.Show("Enter valid destination zip code");
            else
                MessageBox.Show("Enter valid original zip code");
        }//destination zip, on the package, in the package list, at position selected index
        // set equal to new string, where string come from? cost of the package in the package list at position index

        // this button is to show a messagebox of the details of the package
        private void detailsButton_Click(object sender, EventArgs e)
        { int index; // will hold the selected index value
            index = packageListBox.SelectedIndex;
            if (index >= 0)
            {
                MessageBox.Show(packageList[index].ToString());
            }
            else
                MessageBox.Show("Add valid package or click on added package");
        }
        // this button is to change the destination zip to 40292, also changing the details and price of package
        private void sendUOfLButton_Click(object sender, EventArgs e)
        {   
            int index; // will hold the selected index value
            index = packageListBox.SelectedIndex;
            if (index >= 0)
            {   
                packageListBox.Items[index] = //packageList[index].ToString();
                MessageBox.Show("Destination zip code has been updated");
            }
            else
                MessageBox.Show("Select cost of package");
            
        }
        // this button is to change the origin zip to 40292, also changing the details and price of package
        private void sendFromUOfL_Click(object sender, EventArgs e)
        {   
            int index; // will hold the selected index value
            index = packageListBox.SelectedIndex;
            if (index >= 0)
            {   
                packageListBox.Items[index] = //packageList[index].ToString();
                MessageBox.Show("Origin zip code has been updated");
            }
            else
                MessageBox.Show("Select cost of package");
        }
    }
}
