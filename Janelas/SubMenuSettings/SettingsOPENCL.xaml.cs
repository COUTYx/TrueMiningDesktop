﻿using System.Windows;
using System.Windows.Controls;

namespace TrueMiningDesktop.Janelas.SubMenuSettings
{
    /// <summary>
    /// Interação lógica para SettingsOPENCL.xam
    /// </summary>
    public partial class SettingsOPENCL : UserControl
    {
        public SettingsOPENCL()
        {
            InitializeComponent();
            DataContext = User.Settings.Device.opencl;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            WrapPanel_ManualConfig.IsEnabled = false;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            WrapPanel_ManualConfig.IsEnabled = true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (User.Settings.Device.opencl.AlgorithmsList.Contains(AlgorithmComboBox.Text)) { User.Settings.Device.opencl.Algorithm = AlgorithmComboBox.Text; }
        }
    }
}