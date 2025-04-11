using Characters.Warriors;
using System;

public class EntryPoint
{
    static void Main()
    {
        //creating the instance of the class
        Warrior theGoodGuy = new Warrior(19,80,"Good Guy"); 
        Warrior theBadGuy = new Warrior(170, 80,"The Bad Guy");

        Warrior youngWarrior = new Warrior(150, 50);

        Warrior youngWarrior = new Warrior();

        Console.WriteLine(youngWarrior.Age);

        Console.WriteLine(theBadGuy.Height);
        Console.WriteLine(theGoodGuy.Height);

        try
        {
            theGoodGuy.Age = 25;
            theBadGuy.Age = 15;
        }
        catch (ArgumentOutOfRangeException ex) //ex -variable name
        {
            Console.WriteLine(ex.Message);
        }
        //they greet each other
        theGoodGuy.Greetings(theBadGuy);
        theBadGuy.Greetings(theGoodGuy);

        Console.WriteLine(theGoodGuy.SwordWeapon.Damage);
        // going from one class to the 2nd class and then to the property
    }
}