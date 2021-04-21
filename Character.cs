
namespace ConsoleAppTask
{
    class Character
    {
        //Character attributes
        private string name;
        private int hp;
        private int strength;
        private int luck;

        //Get and set for each variable
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Luck
        {
            get { return luck; }
            set { luck = value; }
        }

        //Custom ToString to print out in the format I want
        override public string ToString()
        {
            string output = "";
            output += "Name: ";
            output += name;

            output += ", Health: ";
            output += hp;

            output += ", Strength: ";
            output += strength;

            output += ", Luck: ";
            output += luck;

            return output;
        }
    }
}
