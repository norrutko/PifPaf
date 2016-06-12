namespace Strzelnica
{
    public class Player
    {

        public static int NumberOfPerson { get; set; }
        public string Nick { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int[] Month { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public Player()
        {
            NumberOfPerson = 1 + NumberOfPerson;
        }

    }
}
