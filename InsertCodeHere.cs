using System;

namespace RolePlayV11
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior warriorA = new Warrior("Ragnar", 1000);
            Warrior warriorB = new Warrior("Lagertha", 1500);

            warriorA.LevelUp();        
            warriorA.DamageTaken(1000);
            
            warriorB.DamageTaken(300);

            Console.WriteLine($"Warrior A is called {warriorA.Name} is level {warriorA.Level}");
            Console.WriteLine($"Warrior B is called {warriorB.Name} is level {warriorB.Level}");

            Console.WriteLine($"{warriorA.Name} hitpoints is {warriorA.Hitpoints}");
            Console.WriteLine($"{warriorB.Name} hitpoints is {warriorB.Hitpoints}");
            Console.WriteLine($"Is {warriorA.Name} dead? {warriorA.Dead}");
            Console.WriteLine($"Is {warriorB.Name} dead? {warriorB.Dead}");
            // The LAST line of code should be ABOVE this line
        }
    }
}