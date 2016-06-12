using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;


namespace Strzelnica
{
    /// <summary>
    /// Interaction logic for ScoresTable.xaml
    /// </summary>
    public partial class ScoresTableClass : Window
    {
        public bool opened;
        public ScoresTableClass(ref bool op)
        {
            op = true;
            InitializeComponent();
            this.ListView1.ItemsSource = MainWindow.listOfPeople;
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            this.opened = true;
            this.Hide();

            e.Cancel = true;
        }


        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView1.Items.Refresh();
        }

        public void Refresh()
        {
            ListView1.Items.Refresh();
        }
    }
}
