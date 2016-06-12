using System.ComponentModel;
using System.Windows;


namespace Strzelnica
{
    /// <summary>
    /// Interaction logic for AddPersonView.xaml
    /// </summary>
    public partial class AddPersonClass : Window
    {
        public bool opened;
        public AddPersonClass(ref bool op)
        {
            op = true;
            InitializeComponent();
        }

        public void AddPersonButton_Click(object sender, RoutedEventArgs e)
        {
            bool existed = false;
            foreach (Player person in MainWindow.listOfPeople)
            {
                if (NickTextBox.Text == person.Nick || NickTextBox.Text == "")
                {
                    existed = true;
                    break;
                }
            }
            if(!existed)
            {
                CreatePerson();
            }
            else
            {
                MessageBox.Show("Osoba o podanym nicku już istnieje. BĄDŹ KREATYWNY!!!");
            }
        }

        private void  CreatePerson()
        {
            Player newPerson = new Player();

            newPerson.Nick = this.NickTextBox.Text;
            newPerson.Name = this.NameTextBox.Text;
            newPerson.Surname = this.SurnameTextBox.Text;

            MainWindow.listOfPeople.Add(newPerson);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            this.opened = true;
            this.Hide();
            e.Cancel = true;
        }
    }
}
