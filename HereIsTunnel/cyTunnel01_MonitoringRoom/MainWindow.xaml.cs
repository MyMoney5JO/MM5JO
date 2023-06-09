﻿using MahApps.Metro.Controls;
using System;
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
using System.Xml;

namespace cyTunnel01_MonitoringRoom
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btnsolution_Click(object sender, RoutedEventArgs e)
        {
            var subWin = new Emergency();
            subWin.ShowDialog();
        }

        private void BtnLCD_Click(object sender, RoutedEventArgs e)
        {
            var subWin = new LcdControl();
            subWin.ShowDialog();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            var subWin = new dontknow();
            subWin.ShowDialog();
        }

        private void BtnMngDBControl_Click(object sender, RoutedEventArgs e)
        {
            var subWin = new DBmanagement();
                        subWin.ShowDialog();
        }

    }
}
