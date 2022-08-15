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
/* 4.2	Copy the Galileo.DLL file into the root directory of your solution folder and add the appropriate 
 * reference in the solution explorer. Create a method called “LoadData” which will populate both
 * LinkedLists. Declare an instance of the Galileo library in the method and create the appropriate loop 
 * construct to populate the two LinkedList; the data from Sensor A will populate the first LinkedList, 
 * while the data from Sensor B will populate the second LinkedList. The LinkedList size will be 
 * hardcoded inside the method and must be equal to 400. The input parameters are empty, and the 
 * return type is void.
 */
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
        /* 4.1	Create two data structures using the LinkedList<T> class from the C# Systems.Collections.Generic
         * namespace. The data must be of type “double”; you are not permitted to use any additional classes, 
         * nodes, pointers or data structures (array, list, etc) in the implementation of this application. The two 
         * LinkedLists of type double are to be declared as global within the “public partial class”.
         */
        #region Global variables
        private static LinkedList<double> dataSensorA = new LinkedList<double>();
        private static LinkedList<double> dataSensorB = new LinkedList<double>();
        #endregion

        #region Method: load data
        // First function operation is to the existing data from the double linked lists and set the sorted boolean values to false.
        // Utilizes the Galileo class library to return the readings from two sensors and populate the two linked lists.
        // 400 data values created for each linked list within Box-Muller transform rounded to 4 decimal points as per user entered standard deviation and mean.
        // Method then calls display methods to populate the listview and 2 listboxes.
        private void LoadData()
        {
            int max = 400;
            Galileo.ReadData var = new Galileo.ReadData();
            for (int i = 0; i < max; i++)
            {
                dataSensorA.AddLast(var.SensorA((double)numericUpDownMu.Value, (double)numericUpDownSigma.Value));
                dataSensorB.AddLast(var.SensorB((double)numericUpDownMu.Value, (double)numericUpDownSigma.Value));
            }
        }
        #endregion
        /* 4.4	Create a button and associated click method that will call the LoadData and ShowAllSensorData 
         * methods. The input parameters are empty, and the return type is void.
         */
        #region Button: load data
        // Loads/generates sensor data into the list boxes and list view when pressed
        private void ButtonLoadData_Click(object sender, EventArgs e)
        {
            dataSensorA.Clear();
            dataSensorB.Clear();
            LoadData();
            ShowAllSensorData();
            DisplayListBoxData(dataSensorA, listBoxA);
            DisplayListBoxData(dataSensorB, listBoxB);
            ClearTextBoxes();
            toolStripStatusLabel1.Text = "Sensors' data cleared, new data generated.";
        }
        #endregion
        /* 4.3	Create a custom method called “ShowAllSensorData” which will display both LinkedLists in a 
         * ListView. Add column titles “Sensor A” and “Sensor B” to the ListView. The input parameters are
         * empty, and the return type is void.
         */
        #region Display: list view display 
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
        /* 4.6	Create a method called “DisplayListboxData” that will display the content of a LinkedList inside the 
         * appropriate ListBox. The method signature will have two input parameters; a LinkedList, and the 
         * ListBox name.  The calling code argument is the linkedlist name and the listbox name.
         */
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
        #region Display: call all display methods
        // Method which when called will fill both the listview and 2 list boxes with data from the double linked lists.
        public void DisplayAll()
        {
            ShowAllSensorData();
            DisplayListBoxData(dataSensorA, listBoxA);
            DisplayListBoxData(dataSensorB, listBoxB);
        }
        #endregion
        /* 4.5	Create a method called “NumberOfNodes” that will return an integer which is the number of 
         * nodes(elements) in a LinkedList. The method signature will have an input parameter of type 
         * LinkedList, and the calling code argument is the linkedlist name.
         */
        #region Method: count nodes
        // Calls the LinkedList.Count method and returns the value as an integer - counts the number of nodes in the target linked list parameter
        private int NumberOfNodes(LinkedList<double> linkedList)
        {
            return linkedList.Count;
        }
        #endregion
        /* 4.14	Add two textboxes for the search value; one for each sensor, ensure only numeric values can be entered
         */
        #region Method: handle user textBox input
        // If the key press is not a control character and not a digit and not a decimal point returns true otherwise returns false.
        private Boolean ValidateTextBox(KeyPressEventArgs keyPress)
        {
            return (!char.IsControl(keyPress.KeyChar) && !char.IsDigit(keyPress.KeyChar) && (keyPress.KeyChar != '.') && (keyPress.KeyChar != '-'));
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

        }
        #endregion
        #region Method: search highlight
        // Highlights the index returned by the binary search as well as 2 values on either side or as allowed by proximity to the min and max indexes.
        private void HighlightSearchIndex(int index, LinkedList<double> linkedListName, ListBox listBoxName)
        {
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
                    listBoxName.SelectedIndices.Add(i);
                }
            }
        }
        #endregion
        #region Method: clear all text boxes
        public void ClearTextBoxes()
        {
            textBoxSearchTargetA.Clear();
            textBoxSearchTargetB.Clear();
            textBoxTimeSelectionA.Clear();
            textBoxTimeSelectionB.Clear();
            textBoxTimeInsertionA.Clear();
            textBoxTimeInsertionB.Clear();
            textBoxTimeIterativeA.Clear();
            textBoxTimeIterativeB.Clear();
            textBoxTimeInsertionA.Clear();
            textBoxTimeInsertionB.Clear();
        }
        #endregion
        /* 4.7	Create a method called “SelectionSort” which has a single input parameter of type LinkedList, while 
         * the calling code argument is the linkedlist name. The method code must follow the pseudo code 
         * supplied below in the Appendix. The return type is Boolean.
         */
        #region Method: selection sort
        // Implements a selection method for sorting the target double linked list. Returns true if the sort was executed.
        // Coded as per client requirements.
        private bool SelectionSort(LinkedList<double> linkedListName)
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
        #endregion

        /* 4.8	Create a method called “InsertionSort” which has a single parameter of type LinkedList, while the
         * calling code argument is the linkedlist name. The method code must follow the pseudo code supplied 
         * below in the Appendix. The return type is Boolean.
         */
        #region Method: insertion sort
        // Implements an insertion method for sorting the target double linked list. Returns true if the sort was executed.
        // Coded as per client requirements.
        private bool InsertionSort(LinkedList<double> linkedListName)
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
        #endregion

        /* 4.9	Create a method called “BinarySearchIterative” which has the following four parameters: LinkedList, 
         * SearchValue, Minimum and Maximum. This method will return an integer of the linkedlist element 
         * from a successful search or the nearest neighbour value. The calling code argument is the linkedlist 
         * name, search value, minimum list size and the number of nodes in the list. The method code must 
         * follow the pseudo code supplied below in the Appendix.
         */
        #region Method: binary search iterative
        // Method coded as per client requirements. The parameters accept a double value from text box inputs.
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

        /* 4.10	Create a method called “BinarySearchRecursive” which has the following four parameters: LinkedList, 
         * SearchValue, Minimum and Maximum. This method will return an integer of the linkedlist element 
         * from a successful search or the nearest neighbour value. The calling code argument is the linkedlist 
         * name, search value, minimum list size and the number of nodes in the list. The method code must 
         * follow the pseudo code supplied below in the Appendix.
         */
        #region Method: binary search recursive
        // Method coded as per client requirements. The parameters accept a double value from text box inputs.
        private int BinarySearchRecursive(LinkedList<double> linkedListName, double searchValue, int min, int max)
        {
            if (min <= max - 1)
            {
                int mid = (min + max) / 2;
                if (searchValue == linkedListName.ElementAt(mid))
                {
                    return mid;
                }
                else if (searchValue < linkedListName.ElementAt(mid))
                {
                    return BinarySearchRecursive(linkedListName, searchValue, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(linkedListName, searchValue, mid + 1, max);

                }
            }
            return min;
        }
        #endregion

        /* 4.11	Create four button click methods that will search the LinkedList for a value entered into a textbox on 
         * the form. The four methods are:
         *      1.	Method for Sensor A and Binary Search Iterative
         *      2.	Method for Sensor A and Binary Search Recursive
         *      3.	Method for Sensor B and Binary Search Iterative
         *      4.	Method for Sensor B and Binary Search Recursive
         * The search code must check to ensure the data is sorted, then start a stopwatch before calling the 
         * search method. Once the search is complete the stopwatch will stop and the number of ticks will be 
         * displayed in a read only textbox. Finally, the code will call the “DisplayListboxData” method and 
         * highlight the appropriate number (or the next closest number). 
         */

        /* 4.12	Create four button click methods that will sort the LinkedList using the Selection and Insertion 
         * methods. The four methods are:
         *      1.	Method for Sensor A and Selection Sort
         *      2.	Method for Sensor A and Insertion Sort
         *      3.	Method for Sensor B and Selection Sort
         *      4.	Method for Sensor B and Insertion Sort
         * The button method must start a stopwatch before calling the sort method. Once the sort is complete
         * the stopwatch will stop and the number of milliseconds will be displayed in a read only textbox. 
         * Finally, the code will call the “ShowAllSensorData” method and “DisplayListboxData” for the 
         * appropriate sensor.
         */
        #region Button: iterative search A & B

        private void ButtonIterativeSearchA_Click(object sender, EventArgs e)
        {
            // The stop watch starts, the search method is called, the stopwatch is stopped, the displays are updated and the text box is filled.
            // Try catches first check there is data in the linked list, then sorts the linked list and checks there is data in the search target text box.
            try
            {
                if (NumberOfNodes(dataSensorA) > 0)
                {
                    if (!string.IsNullOrEmpty(textBoxSearchTargetA.Text))
                    {
                        if (SelectionSort(dataSensorA))
                        {
                            DisplayAll();
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            int index = BinarySearchIterative(dataSensorA, double.Parse(textBoxSearchTargetA.Text), 0, NumberOfNodes(dataSensorA));
                            stopwatch.Stop();
                            HighlightSearchIndex(index, dataSensorA, listBoxA);
                            textBoxTimeIterativeA.Text = String.Format("{0} ticks", stopwatch.Elapsed.Ticks);
                            toolStripStatusLabel1.Text = String.Format("Iterative search returned index {0} as the value closest to the search target", index);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: please enter a valid value before searching.");
                    }
                }
                else
                {
                    MessageBox.Show("Error: there is no data to search.");
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    MessageBox.Show("Error: please enter a valid value before searching.");
                }
            }
        }
        private void ButtonIterativeSearchB_Click(object sender, EventArgs e)
        {
            // The stop watch starts, the search method is called, the stopwatch is stopped, the displays are updated and the text box is filled.
            // Try catches first check there is data in the linked list, then sorts the linked list and checks there is data in the search target text box.
            try
            {
                if (NumberOfNodes(dataSensorA) > 0)
                {
                    if (!string.IsNullOrEmpty(textBoxSearchTargetB.Text))
                    {
                        if (SelectionSort(dataSensorB))
                        {
                            DisplayAll();
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            int index = BinarySearchIterative(dataSensorB, double.Parse(textBoxSearchTargetB.Text), 0, NumberOfNodes(dataSensorB));
                            stopwatch.Stop();
                            HighlightSearchIndex(index, dataSensorB, listBoxB);
                            textBoxTimeIterativeB.Text = String.Format("{0} ticks", stopwatch.Elapsed.Ticks);
                            toolStripStatusLabel1.Text = String.Format("Iterative search returned index {0} as the value closest to the search target", index);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: please enter the value you wish to search.");
                    }
                }
                else
                {
                    MessageBox.Show("Error: there is no data to search.");
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    MessageBox.Show("Error: please enter a valid value before searching.");
                }
            }
        }
        #endregion
        #region Button: binary search recursive A & B
        // The stop watch starts, the search method is called, the stopwatch is stopped, the displays are updated and the text box is filled.
        // Try catches first check there is data in the linked list, then sorts the linked list and checks there is data in the search target text box.
        private void ButtonRecursiveSearchA_Click(object sender, EventArgs e)
        {
            try
            {
                if (NumberOfNodes(dataSensorA) > 0)
                {
                    if (InsertionSort(dataSensorA))
                    {
                        if (!string.IsNullOrEmpty(textBoxSearchTargetA.Text))
                        {
                            DisplayAll();
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            int index = BinarySearchRecursive(dataSensorA, double.Parse(textBoxSearchTargetA.Text), 0, NumberOfNodes(dataSensorA));
                            stopwatch.Stop();
                            HighlightSearchIndex(index, dataSensorA, listBoxA);
                            textBoxTimeRecursiveA.Text = String.Format("{0:0.00} ms", stopwatch.Elapsed.TotalMilliseconds);
                            toolStripStatusLabel1.Text = String.Format("Recursive search returned index {0} as the value closest to the search target", index);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: please enter the value you wish to search.");
                    }
                }
                else
                {
                    MessageBox.Show("Error: there is no data to search.");
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    MessageBox.Show("Error: please enter a valid value before searching.");
                }
            }
        }
        private void ButtonRecursiveSearchB_Click(object sender, EventArgs e)
        {
            // The stop watch starts, the search method is called, the stopwatch is stopped, the displays are updated and the text box is filled.
            // Try catches first check there is data in the linked list, then sorts the linked list and checks there is data in the search target text box.
            try
            {
                if (NumberOfNodes(dataSensorA) > 0)
                {
                    if (InsertionSort(dataSensorB))
                    {
                        if (!string.IsNullOrEmpty(textBoxSearchTargetB.Text))
                        {
                            DisplayAll();
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            int index = BinarySearchRecursive(dataSensorB, double.Parse(textBoxSearchTargetB.Text), 0, NumberOfNodes(dataSensorB));
                            stopwatch.Stop();
                            HighlightSearchIndex(index, dataSensorB, listBoxB);
                            textBoxTimeRecursiveB.Text = String.Format("{0:0.00} ms", stopwatch.Elapsed.TotalMilliseconds);
                            toolStripStatusLabel1.Text = String.Format("Recursive search returned index {0} as the value closest to the search target", index);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: please enter the value you wish to search.");
                    }
                }
                else
                {
                    MessageBox.Show("Error: there is no data to search.");
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    MessageBox.Show("Error: please enter a valid value before searching.");
                }
            }
        }
        #endregion
        #region Button: selection sort A & B
        // The stop watch starts, the sort method is called, the stopwatch is stopped, the displays are updated and the text box is filled.
        private void ButtonSelectionSortA_Click(object sender, EventArgs e)
        {
            if (NumberOfNodes(dataSensorA) > 0)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start(); ;
                SelectionSort(dataSensorA);
                stopwatch.Stop();
                //ShowAllSensorData();
                DisplayListBoxData(dataSensorA, listBoxA);
                textBoxTimeSelectionA.Text = String.Format("{0:0.##} ms", stopwatch.Elapsed.TotalMilliseconds);
                toolStripStatusLabel1.Text = "Data was successfully sorted using a selection sort";
            }
            else
            {
                MessageBox.Show("Error: there is no data to sort.");
            }
        }

        private void buttonSelectionSortB_Click(object sender, EventArgs e)
        {
            // The stop watch starts, the sort method is called, the stopwatch is stopped, the displays are updated and the text box is filled.
            if (NumberOfNodes(dataSensorA) > 0)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                SelectionSort(dataSensorB);
                stopwatch.Stop();
                //ShowAllSensorData();
                DisplayListBoxData(dataSensorB, listBoxB);
                textBoxTimeSelectionB.Text = String.Format("{0:0.##} ms", stopwatch.Elapsed.TotalMilliseconds);
                toolStripStatusLabel1.Text = "Data was successfully sorted using a selection sort";
            }
            else
            {
                MessageBox.Show("Error: there is no data to sort.");
            }
        }
        #endregion
        #region Button: insertion sort A & B
        // The stop watch starts, the sort method is called, the stopwatch is stopped, the displays are updated and the text box is filled.
        private void buttonInsertionSortA_Click(object sender, EventArgs e)
        {
            if (NumberOfNodes(dataSensorA) > 0)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                InsertionSort(dataSensorA);
                stopwatch.Stop();
                //ShowAllSensorData();
                DisplayListBoxData(dataSensorA, listBoxA);
                textBoxTimeInsertionA.Text = String.Format("{0:0.00} ms", stopwatch.Elapsed.TotalMilliseconds);
                toolStripStatusLabel1.Text = "Data was successfully sorted using an insertion sort";
            }
            else
            {
                MessageBox.Show("Error: there is no data to sort.");
            }
        }

        private void buttonInsertionSortB_Click(object sender, EventArgs e)
        {
            // The stop watch starts, the sort method is called, the stopwatch is stopped, the displays are updated and the text box is filled.
            if (NumberOfNodes(dataSensorA) > 0)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                InsertionSort(dataSensorB);
                stopwatch.Stop();
                //ShowAllSensorData();
                DisplayListBoxData(dataSensorB, listBoxB);
                textBoxTimeInsertionB.Text = String.Format("{0:0.00} ms", stopwatch.Elapsed.TotalMilliseconds);
                toolStripStatusLabel1.Text = "Data was successfully sorted using an insertion sort";
            }
            else
            {
                MessageBox.Show("Error: there is no data to sort.");
            }
        }
        #endregion

        /* 4.13	Add two NumericUpDown controls for Sigma and Mu. The value for Sigma must be limited with a 
         * minimum of 10 and a maximum of 20. Set the default value to 10. The value for Mu must be limited 
         * with a minimum of 35 and a maximum of 75. Set the default value to 50.
         */

        /* 4.14	Add two textboxes for the search value; one for each sensor, ensure only numeric values can be 
         * entered.
         */

        /* 4.15	All code is required to be adequately commented. Map the programming criteria and features to 
         * your code/methods by adding comments above the method signatures. Ensure your code is 
         * compliant with the CITEMS coding standards (refer http://www.citems.com.au/).
         */
    }
}
