using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;


namespace Strzelnica
{
    public partial class ScoresTableClass : Window
    {
        public ScoresTableClass(ref bool op)
        {
            op = true;
            InitializeComponent();
            this.ListView1.ItemsSource = MainWindow.listOfPeople;
            ListView1.Items.Refresh();
        }
        
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        
        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView1.Items.Refresh();
        }

        public void Refresh()
        {
            this.ListView1.Items.Refresh();
        }
    }
}
