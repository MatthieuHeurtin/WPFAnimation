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
using System.Windows.Shapes;

namespace heurtin.WpfAnimation.Animation
{
    /// <summary>
    /// Interaction logic for FirstAnimationTest.xaml
    /// </summary>
    public partial class FirstAnimationTest : Window, IAnimation
    {

        public static string GetComment()
        {
            return "The First Animation that I used as Test";
        }

        public FirstAnimationTest()
        {
            InitializeComponent();
        }
    }
}