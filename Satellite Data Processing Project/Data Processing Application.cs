﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galileo;
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

        private static LinkedList<double> dataSensorA = new LinkedList<double>();
        private static LinkedList<double> dataSensorB = new LinkedList<double>();

        private void LoadData()
        {
            int max = 400;
            Galileo.ReadData var = new Galileo.ReadData();
            dataSensorA.Clear();
            dataSensorB.Clear();
            for(int i = 0; i < max; i++)
            {
                dataSensorA.AddLast(var.SensorA((double)numericUpDownMu.Value, (double)numericUpDownSigma.Value));
                dataSensorB.AddLast(var.SensorB((double)numericUpDownMu.Value, (double)numericUpDownSigma.Value));
            }
            ShowAllSensorData();
        }
        public void ShowAllSensorData()
        {
            listView1.Items.Clear();
            for(int i = 0; i < dataSensorA.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(dataSensorA.ElementAt(i).ToString());
                lvi.SubItems.Add(dataSensorB.ElementAt(i).ToString());
                listView1.Items.Add(lvi);
            }
        }

        public int NumberOfNodes(LinkedList<double>, )
        {

        }
        private void ButtonLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }
    }
}