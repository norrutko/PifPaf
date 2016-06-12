using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;


namespace Strzelnica
{
    /// <summary>
    /// Interaction logic for AddScore.xaml
    /// </summary>
    public partial class AddScore : Window
    {


        public AddScore(ref bool op)
        {
            op = true;
            InitializeComponent();  
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AddScoreButton_Click(object sender, RoutedEventArgs e)
        {
            bool existed = false;
            
            foreach (Player person in MainWindow.listOfPeople)
            {
                if (NickTextBox.Text == person.Nick)
                {
                    existed = true;
                    person.Month[Month.SelectedIndex] = PointsPerGame();
                    break;
                }    
            }

            if(!existed)
            {
                MessageBox.Show("Najpierw zarejstruj osobę, a później przyznawaj jej punkty.");
            }
        }


        private int PointsPerGame()
        {
            int points;
            points = ChickenPointsBox.SelectedIndex + BoarPointsBox.SelectedIndex + TurkeyPointsBox.SelectedIndex + MouflonPointsBox.SelectedIndex;
            return points;
        }
        

        private void BoarPointsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TurkeyPointsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MuflonPointsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ChickenPointsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
