﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

namespace Handwriting_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FontCreator fontCreator = new FontCreator();
            fontCreator.Add(@"C:\Users\egor0\source\repos\Handwriting Generator\Handwriting Generator\Resources\testing\0.jpg");
            fontCreator.Add(@"C:\Users\egor0\source\repos\Handwriting Generator\Handwriting Generator\Resources\testing\1.jpg");
            Font font = fontCreator.GetFont();
            //Font font = new Font("debugOut/savedFont.zip");
            font.Save("DebugOut/savedFont2.zip");
        }
    }
}
