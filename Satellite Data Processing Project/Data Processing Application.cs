using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galileo;
using System.Diagnostics;
// Kyle Watson - SMTAFE (30048165)
// Project start: 24/08/2022
// Development of an application that will sort and search complex data sets recorded during satellite operation
namespace Satellite_Data_Processing_Project
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        #region Global variables
        private static LinkedList<double> dataSensorA = new LinkedList<double>();
        private static LinkedList<double> dataSensorB = new LinkedList<double>();
        Stopwatch stopwatch = new Stopwatch();

        #endregion
        #region Load data
        // Utilizes the Galileo class library to return the readings from two sensors and populate the two linked lists.
        // 400 data values created for each linked list within Box-Muller transform rounded to 4 decimal points as per user entered standard deviation and mean.
        // Method then calls display methods to populate the listview and 2 listboxes.
        private void LoadData()
        {
            int max = 400;
            Galileo.ReadData var = new Galileo.ReadData();
            dataSensorA.Clear();
            dataSensorB.Clear();
            for (int i = 0; i < max; i++)
            {
                dataSensorA.AddLast(var.SensorA((double)numericUpDownMu.Value, (double)numericUpDownSigma.Value));
                dataSensorB.AddLast(var.SensorB((double)numericUpDownMu.Value, (double)numericUpDownSigma.Value));
            }
            ShowAllSensorData();
            DisplayListBoxData(dataSensorA, listBoxA);
            DisplayListBoxData(dataSensorB, listBoxB);
        }
        #endregion
        #region Method list view display 
        // Method for displaying the linked list data in the list view - does not fill list boxes.
        private void ShowAllSensorData()
        {
            listView1.Items.Clear();
            for (int i = 0; i < dataSensorA.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(dataSensorA.ElementAt(i).ToString());
                lvi.SubItems.Add(dataSensorB.ElementAt(i).ToString());
                listView1.Items.Add(lvi);
            }
        }
        #endregion
        #region Method Count nodes
        // Calls the LinkedList.Count method and returns the value as an integer
        private int NumberOfNodes(LinkedList<double> LinkedList)
        {
            return LinkedList.Count;
        }
        #endregion
        #region Button load
        // Loads/generates sensor data into the list boxes and list view when pressed
        private void ButtonLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
        #region Populate list box
        // Method populates the specified listbox with data from the specified linked list using a foreach loop.
        private void DisplayListBoxData(LinkedList<double> linkedListName, ListBox listBoxName)
        {
            listBoxName.Items.Clear();
            foreach (var i in linkedListName)
            {
                listBoxName.Items.Add(i);
            }
        }
        #endregion
        #region Method handle user textBox input
        // If the key press is not a control character and not a digit and not a decimal point returns true otherwise returns false.
        private Boolean ValidateTextBox(KeyPressEventArgs keyPress)
        {
                return (!char.IsControl(keyPress.KeyChar) && !char.IsDigit(keyPress.KeyChar) && (keyPress.KeyChar != '.'));
        }

        //Utilizes the ValidateTextBox method to check whether a valid keypress has been entered into the related text box.
        private void TextBoxSearchTargetA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateTextBox(e);
        }
        private void textBoxSearchTargetB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateTextBox(e);
        }
        #endregion
        #region Method form load
        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }
        #endregion
        private void SelectionSort(LinkedList<double> linkedListName)
        {
            int min = 0;
            int max = NumberOfNodes(linkedListName);
            for (int i = 0; i < max; i++)
            {
                min = i;
                for(int j = i+1; j < max; j++)
                {
                    if (linkedListName.ElementAt(j).CompareTo(linkedListName.ElementAt(min)) < 0)
                    {
                        min = j;
                    }
                }
                LinkedListNode<double> currentMin = linkedListName.Find(linkedListName.ElementAt(min));
                LinkedListNode<double> currentI = linkedListName.Find(linkedListName.ElementAt(i));
                var temp = currentMin.Value;
                currentMin.Value = currentI.Value;
                currentI.Value = temp;
            }
        }
        // Start time, execute method, stop time, display data, fill time box
        private void buttonSelectionSortA_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            SelectionSort(dataSensorA);
            stopwatch.Stop();
            ShowAllSensorData();
            DisplayListBoxData(dataSensorA, listBoxA);
            textBoxTimeSelectionA.Text = String.Format("{0} ms", stopwatch.ElapsedMilliseconds.ToString());
        }

        private void buttonSelectionSortB_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            SelectionSort(dataSensorB);
            stopwatch.Stop();
            ShowAllSensorData();
            DisplayListBoxData(dataSensorB, listBoxB);
            textBoxTimeSelectionA.Text = String.Format("{0} ms", stopwatch.ElapsedMilliseconds.ToString());
        }   
    }
}
        