using System;
using Weapons;

namespace Characters.Warriors
{

    public class Warrior
    {
        //fields - internal use
        private int height;
        private int weight;
        private string name;
        private int age;
        private Sword swordWeapon;

        //Properties - external use
        public int Height
        {
            get
            {
                return height;
            }
            private set
            {
                height = value; //gives the value of the property Height and assigns it to height field
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        } //accessors that control the way the field is being accessed

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value >= 18 && value <= 45)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The selected age for {name} is not a proper age for a warrior. It must be between 18 and 45");
                    //string interpolation
                }
            }
        }

        public Sword SwordWeapon 
        { 
            get
            {
                return this.swordWeapon;
            }
            set
            {
                this.swordWeapon = value;
            }
        }

        public Warrior()
        {
            this.Height = height;
            this.Weight = weight;
            this.Age = 18;
            this.Name = name;
            this.SwordWeapon = new Sword();

        }
        public Warrior(int height, int weight)//arguments
        {
            this.Height = height;
            this.Weight = weight;
            this.Age = 18;
            this.Name = name;
            this.SwordWeapon = new Sword();
        }

        public Warrior(int height, int weight, string name)
        {
            this.Height = height; //this gets the Height of this class and assign the argument to it
            this.Weight = weight;
            this.Name = name;
            this.SwordWeapon = new Sword(); //create new instance for that class
            //this gives access to all members of the classes 
            //Weight property <-> weight argument
        }

        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($@"Greetings, {warrior.Name}!");
            //allows variable to be used directly inside strings
        }

    }
}