﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetricsProject
{
   

    public partial class Form1 : MetroForm
    {

        public Dictionary<string, Ratings> EAFValues = new Dictionary<string, Ratings>();

        public Form1()
        {
            InitializeComponent();
            FillComboBox();
            
        }

        private void FillComboBox()
        {
            //Product Attributes
            EAFValues.Add("Required Software Reliability", new Ratings(0.75, 0.88, 1, 1.15, 1.40, 1));
            EAFValues.Add("Size of Application Database", new Ratings(1, 0.94, 1, 1.08, 1.16, 1));
            EAFValues.Add("Complexity of The Product", new Ratings(0.70, 0.85, 1, 1.15, 1.30, 1.65));
            //Hardware Atrributes
            EAFValues.Add("Run-Time Performance Constraints", new Ratings(1, 1, 1, 1.11, 1.30, 1.66));
            EAFValues.Add("Memory Constraints", new Ratings(1, 1, 1, 1.06, 1.21, 1.56));
            EAFValues.Add("Volatility of the Virtual Machine Enviroment", new Ratings(1, 0.87, 1, 1.15, 1.30, 1));
            EAFValues.Add("Required Turnabout Time", new Ratings(1, 0.87, 1, 1.07, 1.15, 1));
            //Personal Attributes
            EAFValues.Add("Analyst Capability", new Ratings(1.46, 1.19, 1, 0.86, 0.71, 1));
            EAFValues.Add("Applications Experience", new Ratings(1.29, 1.13, 1, 0.91, 0.82, 1));
            EAFValues.Add("Software Engineer Capability", new Ratings(1.42, 1.17, 1, 0.86, 0.70, 1));
            EAFValues.Add("Virtual Machine Experience", new Ratings(1.21, 1.10, 1, 0.90, 1, 1));
            EAFValues.Add("Programming Language Experience", new Ratings(1.14, 1.07, 1, 0.95, 1, 1));
            //Project Attributes
            EAFValues.Add("Application of Software Engineering", new Ratings(1.24, 1.10, 1, 0.91, 0.82, 1));
            EAFValues.Add("User of Software Tools", new Ratings(1.24, 1.10, 1, 0.91, 0.83, 1));
            EAFValues.Add("Required Development Schedule", new Ratings(1.23, 1.08, 1, 1.04, 1.10, 1));

            BindingSource bindingSource = new BindingSource(EAFValues, null);
            metroComboBox1.DataSource = bindingSource;
            metroComboBox1.DisplayMember = "Key";
            metroComboBox1.ValueMember = "Value";

            //everythingReady = true;
        }
        public double Effort(int Size_of_project)
        {
            double a, b, Effort;

            if (Size_of_project <= 50 && Size_of_project >= 2)//Organic
            {
                if (comboBox1.SelectedIndex == 0)//Basic Organic
                {
                    a = 2.4;
                    b = 1.05;
                    return Effort = a * Math.Pow(Size_of_project, b);
                }
                else //Intermediate/Detailed Organic
                {
                    a = 3.2;
                    b = 1.05;
                    return Effort = a * Math.Pow(Size_of_project, b);
                }
            }

            else if (Size_of_project <= 300 && Size_of_project > 50)//Semi-detached
            {
                if (comboBox1.SelectedIndex == 0)//Basic Semi-detached
                {
                    a = 3.0;
                    b = 1.12;
                    return Effort = a * Math.Pow(Size_of_project, b);
                }
                else //Intermediate/Detailed Semi-detached
                {
                    a = 3.0;
                    b = 1.12;
                    return Effort = a * Math.Pow(Size_of_project, b);
                }
            }

            else if (Size_of_project > 300)//Embedded
            {
                if (comboBox1.SelectedIndex == 0)//Basic Embedded
                {
                    a = 3.6;
                    b = 1.20;
                    return Effort = a * Math.Pow(Size_of_project, b);
                }
                else //Intermediate/Detailed Embedded
                {
                    a = 3.6;
                    b = 1.20;
                    return Effort = a * Math.Pow(Size_of_project, b);
                }
            }

            return 0;
        }

        public double TDEV(int Size_of_project, double Ei)
        {
            double c, d, TDEV;

            if (Size_of_project <= 50 && Size_of_project >= 2)
            {
                if (comboBox1.SelectedIndex == 0)
                {

                    c = 2.4;
                    d = 1.05;
                    return TDEV = c * Math.Pow(Ei, d);
                }
                else
                {
                    c = 3.2;
                    d = 1.05;
                    return TDEV = c * Math.Pow(Ei, d);
                }
            }

            else if (Size_of_project <= 300 && Size_of_project > 50)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    c = 3.0;
                    d = 1.12;
                    return TDEV = c * Math.Pow(Ei, c);
                }
                else
                {
                    c = 3.0;
                    d = 1.12;
                    return TDEV = c * Math.Pow(Ei, d);
                }
            }

            else if (Size_of_project < 300)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    c = 3.6;
                    d = 1.20;
                    return TDEV = c * Math.Pow(Ei, d);
                }
                else
                {
                    c = 3.6;
                    d = 1.20;
                    return TDEV = c * Math.Pow(Ei, d);
                }
            }

            return 0;
        }

        public double ActualEffort(double EAF, double Effort)
        {
            return 0;
        }

        public void CalculateEffort_Click(object sender, EventArgs e)
        {
            ResultEffort.Text = Effort(int.Parse(Size.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void CalculateTDEV_Click(object sender, EventArgs e)
        {
            //double actualEffort = ActualEffort();
            // TDEV(int.Parse(Size.Text), actualEffort);

        }

        private void CalculateActualEffort_Click(object sender, EventArgs e)
        {
            double effort = Effort(int.Parse(Size.Text));
            //ActualEffort(effort, double Effort);
        }
    }

    public class Ratings
    {
        public Ratings(double vl, double l, double n, double h, double vh, double eh)
        {
            this.VeryLow = vl;
            this.Low = l;
            this.Nominal = n;
            this.High = h;
            this.VeryHigh = vh;
            this.ExtraHigh = eh;
        }

        public double VeryLow;
        public double Low;
        public double Nominal;
        public double High;
        public double VeryHigh;
        public double ExtraHigh;
    }
}