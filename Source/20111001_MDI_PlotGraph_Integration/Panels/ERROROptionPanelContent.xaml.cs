﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using AvalonDock;
using MDI_PlotGraph_Integration.Kinect;

namespace MDI_PlotGraph_Integration.Panels
{
    /// <summary>
    /// Interaction logic for ControlPanel.xaml
    /// </summary>
    public partial class ERROROptionPanelContent : DockableContent
    {
        MainWindow m;

        public ERROROptionPanelContent()
        {
            m = (MainWindow)Application.Current.MainWindow;

            InitializeComponent();

            this.AllowDrop = false;
        }

    }
}
