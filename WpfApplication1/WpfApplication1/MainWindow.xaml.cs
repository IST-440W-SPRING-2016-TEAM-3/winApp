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

namespace WpfApplication1
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

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (patientInfo != null && patientInfo.IsSelected)
            {
                headLabel.Content = "Patient Info";
            }
            if (currentIssues != null && currentIssues.IsSelected)
            {
                headLabel.Content = "Current Health Issues";
            }
            if (medications != null && medications.IsSelected)
            {
                headLabel.Content = "Medications";
            }
            if (allergies != null && allergies.IsSelected)
            {
                headLabel.Content = "Allergies";
            }
            if (immunizations != null && immunizations.IsSelected)
            {
                headLabel.Content = "Immunizations";
            }
            if (historySummary != null && historySummary.IsSelected)
            {
                headLabel.Content = "History Summary";
            }
            if (testResults != null && testResults.IsSelected)
            {
                headLabel.Content = "Test Results";
            }
        }



    }
}
