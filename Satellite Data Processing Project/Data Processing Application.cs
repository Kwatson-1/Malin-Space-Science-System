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
        // Stopwatch variable made global so instantiation only has to be conducted once.
        Stopwatch stopwatch = new Stopwatch();
        // Global boolean variables to track whether sort function has been called.
        private static bool dataASorted = false;
        private static bool dataBSorted = false;

        #endregion
        #region Load data
        // First function operation is to the existing data from the double linked lists and set the sorted boolean values to false.
        // Utilizes the Galileo class library to return the readings from two sensors and populate the two linked lists.
        // 400 data values created for each linked list within Box-Muller transform rounded to 4 decimal points as per user entered standard deviation and mean.
        // Method then calls display methods to populate the listview and 2 listboxes.
        private void LoadData()
        {
            dataSensorA.Clear();
            dataSensorB.Clear();
            dataASorted = false;
            dataBSorted = false;
            int max = 400;
            Galileo.ReadData var = new Galileo.ReadData();
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
        #region Method: list view display 
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
        #region Method: count nodes
        // Calls the LinkedList.Count method and returns the value as an integer
        private int NumberOfNodes(LinkedList<double> LinkedList)
        {
            return LinkedList.Count;
        }
        #endregion
        #region Button: load
        // Loads/generates sensor data into the list boxes and list view when pressed
        private void ButtonLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
        #region Display: populate list box
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
        #region Method: handle user textBox input
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
        #region Method: form load
        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            // Remove below methods
            LoadData();
        }
        #endregion
        #region Method: selection sort
        // Implements a selection method for sorting the target double linked list. Returns true if the sort was executed.
        private bool SelectionSort(LinkedList<double> linkedListName)
        {
            if (NumberOfNodes(linkedListName) > 0)
            {
                int min = 0;
                int max = NumberOfNodes(linkedListName);
                for (int i = 0; i < max; i++)
                {
                    min = i;
                    for (int j = i + 1; j < max; j++)
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
                return true;
            }
            else return false;
        }
        #endregion
        #region Method: insertion sort
        private bool InsertionSort(LinkedList<double> linkedListName)
        {
            if (NumberOfNodes(linkedListName) > 0)
            {
                int max = NumberOfNodes(linkedListName);
                for (int i = 0; i < max - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (linkedListName.ElementAt(j - 1) > linkedListName.ElementAt(j))
                        {
                            LinkedListNode<double> current = linkedListName.Find(linkedListName.ElementAt(j));
                            var temp = current.Previous.Value;
                            current.Previous.Value = current.Value;
                            current.Value = temp;
                        }
                    }
                }
                return true;
            }
            else return false;
        }
        #endregion
        #region Method: binary search iterative
        private int BinarySearchIterative(LinkedList<double> linkedListName, double searchValue, int min, int max)
        {
            while (min <= max - 1)
            {
                int mid = (min + max) / 2;
                if (searchValue == linkedListName.ElementAt(mid))
                {
                    return ++mid;
                }
                else if (searchValue < linkedListName.ElementAt(mid))
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return min;
        }
        #endregion
        #region Button: selection sort A & B
        // Start time, execute method, stop time, display data, fill time box
        private void ButtonSelectionSortA_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            SelectionSort(dataSensorA);
            stopwatch.Stop();
            dataASorted = true;
            ShowAllSensorData();
            DisplayListBoxData(dataSensorA, listBoxA);
            textBoxTimeSelectionA.Text = String.Format("{0} ms", stopwatch.ElapsedMilliseconds);
        }

        private void buttonSelectionSortB_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            SelectionSort(dataSensorB);
            stopwatch.Stop();
            dataBSorted = true;
            ShowAllSensorData();
            DisplayListBoxData(dataSensorB, listBoxB);
            textBoxTimeSelectionB.Text = String.Format("{0} ms", stopwatch.ElapsedMilliseconds);
        }
        #endregion
        #region Button: insertion sort A & B
        private void buttonInsertionSortA_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            InsertionSort(dataSensorA);
            stopwatch.Stop();
            dataBSorted = true;
            ShowAllSensorData();
            DisplayListBoxData(dataSensorA, listBoxA);
            textBoxTimeInsertionA.Text = String.Format("{0} ms", stopwatch.ElapsedMilliseconds.ToString());
        }

        private void buttonInsertionSortB_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            InsertionSort(dataSensorB);
            stopwatch.Stop();
            dataBSorted = true;
            ShowAllSensorData();
            DisplayListBoxData(dataSensorB, listBoxB);
            textBoxTimeInsertionB.Text = String.Format("{0} ms", stopwatch.ElapsedMilliseconds.ToString());
        }
        #endregion
        #region Button: iterative search A & B

        private void ButtonIterativeSearchA_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            int index = BinarySearchIterative(dataSensorA, int.Parse(textBoxSearchTargetA.Text), 0, NumberOfNodes(dataSensorA));
            stopwatch.Stop();
            HighlightSearchIndex(index, dataSensorA, listBoxA);
            textBoxTimeIterativeA.Text = String.Format("{0} ms", stopwatch.ElapsedMilliseconds);
        }
        private void ButtonIterativeSearchB_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            int index = BinarySearchIterative(dataSensorB, int.Parse(textBoxSearchTargetB.Text), 0, NumberOfNodes(dataSensorB));
            stopwatch.Stop();
            HighlightSearchIndex(index, dataSensorB, listBoxB);
            textBoxTimeIterativeB.Text = String.Format("{0} ms", stopwatch.ElapsedMilliseconds);

        }
        #endregion
        #region Method: list item selection
        // Highlights the index returned by the binary search as well as 2 values on either side or as allowed by proximity to the min and max indexes.
        private void HighlightSearchIndex(int index, LinkedList<double> linkedListName, ListBox listBoxName)
        {
            listView1.SelectedItems.Clear();
            listView1.Select();
            listBoxA.ClearSelected();
            listBoxB.ClearSelected();
            // If the binary search returns an index of 400 decrement by 1 so that the upper highlight selection consistently has 3 values. Without decrement only 2 values are highlighted.
            if (index == 400)
            {
                index -= 1;
            }
            // Only highlights index inside a valid selection range.
            for (int i = index - 2; i <= index + 2; i++)
            {
                if (i < 0 || i > NumberOfNodes(linkedListName) - 1)
                {
                     
                }
                else
                {
                    listView1.Items[i].Selected = true;
                    listBoxName.SelectedIndices.Add(i);
                }
            }
        }
        #endregion
        #region Method: binary search recursive
        private void 

        #endregion
    }
}
