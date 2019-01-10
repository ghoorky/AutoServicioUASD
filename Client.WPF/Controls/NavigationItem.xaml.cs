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

namespace Client.WPF.Controls
{
    /// <summary>
    /// Interaction logic for NavigationItem.xaml
    /// </summary>
    public partial class NavigationItem : UserControl
    {
        public ImageSource Icon   { get; set; }
        public string      Header { get; set; } = "[Navigation Item]";

        public NavigationItem()
        {
            InitializeComponent();
        }
    }
}