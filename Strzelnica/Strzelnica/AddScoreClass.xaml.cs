using System;
using System.ComponentModel;
using System.Windows;


namespace Strzelnica
{

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
                    person.TotalScore = TotalScore(person);

                    if (person.TotalScore == MainWindow.BestScore &&
                        person.Month[Month.SelectedIndex] > PointsPerGame())
                    {
                        FindNewLeader();
                    }
                    else
                    {
                        CheckLeader(person);
                    }
                    Dethronement();
                    HuntedAnimals();
                    ResetFields();
                    break;
                }
            }
            if (!existed)
            {
                MessageBox.Show("Najpierw zarejstruj osobę, a później przyznawaj jej punkty.");
            }
        }

        private void ResetFields()
        {
            NickTextBox.Text = "";
            ChickenPointsBox.SelectedIndex = 0;
            BoarPointsBox.SelectedIndex = 0;
            TurkeyPointsBox.SelectedIndex = 0;
            MouflonPointsBox.SelectedIndex = 0;
        }

        private void HuntedAnimals()
        {
            MainWindow.statistics[0].Hunt(this.ChickenPointsBox.SelectedIndex);
            MainWindow.statistics[1].Hunt(this.BoarPointsBox.SelectedIndex);
            MainWindow.statistics[2].Hunt(this.TurkeyPointsBox.SelectedIndex);
            MainWindow.statistics[3].Hunt(this.MouflonPointsBox.SelectedIndex);
        }

        private int PointsPerGame()
        {
            int points;
            points = ChickenPointsBox.SelectedIndex + BoarPointsBox.SelectedIndex +
                    TurkeyPointsBox.SelectedIndex + MouflonPointsBox.SelectedIndex;
            return points;
        }

        private int TotalScore(Player person)
        {
            int tmp = 0;
            foreach (int month in person.Month)
            {
                tmp = tmp + month;
            }
            return tmp;
        }

        private void Dethronement()
        {
            foreach (Player person in MainWindow.listOfPeople)
            {
                try
                {
                    person.TotalScorePercentage = person.TotalScore * 100 / MainWindow.BestScore;
                }
                catch (DivideByZeroException)
                {
                    person.TotalScorePercentage = person.TotalScore * 100 / 1;
                }
            }
        }

        private void CheckLeader(Player leader)
        {
            if (TotalScore(leader) > MainWindow.BestScore)
            {
                MainWindow.BestScore = TotalScore(leader);
                Dethronement();
            }
        }

        private void FindNewLeader()
        {
            MainWindow.BestScore = 0;
            foreach (var score in MainWindow.listOfPeople)
            {
                if (score.TotalScore > MainWindow.BestScore)
                {
                    MainWindow.BestScore = score.TotalScore;
                }
            }
        }
    }
}
