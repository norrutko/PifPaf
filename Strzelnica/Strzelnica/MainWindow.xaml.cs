using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;


namespace Strzelnica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Player> listOfPeople;
        private ScoresTableClass scoresTable;
        private AddPersonClass addPerson;
        private AddScore addScore;
        bool[] _opened = { false, false, false, false };   // flagi mówiące o widocznosci okienka okienka
        enum WindowNames{ Scores = 0, AddScore = 1, AddPerson = 2, SearchPerson = 3};

        public MainWindow()
        {
            listOfPeople = new ObservableCollection<Player>();
            InitializeComponent();
        }

        private void Mode_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(Mode.Value == 1)
            {
                StringMode.Text = listOfPeople.ToString();
            }
            else
            {
                StringMode.Text = "Zawody";
            }
        }

        private void Weapon_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Weapon.Value == 1)
            {
                StringWeapon.Text = "Karabin";
            }
            else
            {
                StringWeapon.Text = "Pistolet";
            }
        }

        private void Scores_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(WindowNames.Scores);
            if (!_opened[x])
            {
                scoresTable = new ScoresTableClass(ref _opened[x]);
            }
            scoresTable.Refresh();
            scoresTable.Show();
        }

        private void AddScores_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(WindowNames.AddScore);
            if (!_opened[x])
            {
                addScore = new AddScore(ref _opened[x]);
                addScore.Month.SelectedIndex = 0;
            }
            addScore.ChickenPointsBox.SelectedIndex = 0;
            addScore.BoarPointsBox.SelectedIndex = 0;
            addScore.TurkeyPointsBox.SelectedIndex = 0;
            addScore.MouflonPointsBox.SelectedIndex = 0;
            addScore.Show();
        }

        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(WindowNames.AddPerson);
            if (!_opened[x])
            {
                addPerson = new AddPersonClass(ref _opened[x]);
            }
            addPerson.Show();
        }

        private void FindPerson_Click(object sender, RoutedEventArgs e)
        {

        }


        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
    }
}

    