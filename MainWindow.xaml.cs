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

namespace Yakira_RTB
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

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            // Button Display message from
            // txtDisplay to rtbDisplay REPLACING the message
            string message = txtSingleMessageDisplay.Text;

            rtbDisplay.Text = message;

        } // btnDisplay_Click

        private void btnAppend_Click(object sender, RoutedEventArgs e)
        {
            // Appends message from text box to the rtbDisplay
            string messageToAppend = txtAppendMessage.Text;

            // Doing \n to newline
            rtbDisplay.Text += "\n" + messageToAppend;
        }

        private void btnAppendNewRtb_Click(object sender, RoutedEventArgs e)
        {
            string fullMessage = rtbNewRtb.Text;

            rtbDisplay.Text += "\n" + fullMessage;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            rtbNewRtb.Text = "";
            rtbDisplay.Text = "";
        }
    }
}
