﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;
using IxMilia.Step;
using IxMilia.Step.Items;

namespace WpfAppStepReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, RoutedEventArgs e)
        {
            String knownPath = FilePathField.Text;
            if (File.Exists(knownPath))
            {
                StepFile stepFile = StepFile.Load(knownPath);

                foreach (StepRepresentationItem item in stepFile.Items)
                {
                    switch (item.ItemType)
                    {
                        case StepItemType.Line:
                            StepLine line = (StepLine)item;
                            // ...
                        break;
                            // ...
                    }
                }

            }
        }
    }
}
