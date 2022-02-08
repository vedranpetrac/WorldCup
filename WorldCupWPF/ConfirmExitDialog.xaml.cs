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
using System.Windows.Shapes;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for ConfirmExitDialog.xaml
    /// </summary>
    public partial class ConfirmExitDialog : Window
    {
        public ConfirmExitDialog()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                btnNo_Click(sender, e);
            }
            else if (e.Key == Key.Enter)
            {
                btnYes_Click(sender, e);
            }
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Application.Current.Shutdown();
        }
    }
}
