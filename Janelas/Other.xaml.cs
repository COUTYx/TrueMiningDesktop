﻿using System.Windows;
using System.Windows.Controls;
using True_Mining_Desktop.Core;

namespace True_Mining_Desktop.Janelas
{
    public partial class Other : UserControl
    {
        public Other()
        {
            InitializeComponent();
        }

        private void Button_website_Click(object sender, RoutedEventArgs e)
        {
            Tools.OpenLinkInBrowser("https://truemining.online/");
        }

        private void Button_github_Click(object sender, RoutedEventArgs e)
        {
            Tools.OpenLinkInBrowser("https://github.com/True-Mining");
        }

        private void Button_YtTutorial_Click(object sender, RoutedEventArgs e)
        {
            Tools.OpenLinkInBrowser("https://www.youtube.com/watch?v=3VbH1y4o7Ak");
        }

        private void Button_telegramGroup_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You will be redirected to an interactive group. Do not send subjects not related to True Mining. You can be banned without notice.");
            Tools.OpenLinkInBrowser("https://t.me/true_mining");
        }

        private void Button_telegramLOGChannel_Click(object sender, RoutedEventArgs e)
        {
            Tools.OpenLinkInBrowser("https://t.me/joinchat/AAAAAFTI4DfIEWk8MM-YLQ");
        }

        private void Button_whatsapp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You will be redirected to an support group. Only True Mining support, request help or help a friend.");
            Tools.OpenLinkInBrowser("https://chat.whatsapp.com/GmZheo5aQmoFbWXP6ZXQh2");
        }

        private void Button_whatsapp_offtopic_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You will be redirected to an offtopic interactive group. Be respectfull and don't scam your friends.");
            Tools.OpenLinkInBrowser("https://chat.whatsapp.com/LEWSKLAMKwj2iwcT64AIXg");
        }
    }
}