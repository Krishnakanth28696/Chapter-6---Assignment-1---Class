using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
class Wizard{
        public String name;
        public int age;
        private int health;
        private bool death;

        public Wizard (String _name, int _age){
            name = _name;
            age = _age;
            health = 100;
            death = false;
        }
        public void Fight(){
            if(health > 0 && death == false){
                Console.WriteLine(name+" fights efficiently!!");
                health = health -25;
                if(health == 0){
                    death = true;
                    Console.WriteLine(name+" of age "+age+" was died in the fight");
                }else{
                Console.WriteLine(name+" of age "+age+" fought successfully!! and his health is "+health);}
            }else{
                Console.WriteLine(name+" was died. Can't fight.");
            }

        }
        public void Heal(){
            if(death == true){
                Console.WriteLine(name+" was already died. Can't be healed");
            }else{
                Console.WriteLine(name+" was healing himself with spell");
                health = health +50;
            }

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Wizard w1 = new Wizard("Skywin", 20);
            w1.Fight();
            w1.Fight();
            w1.Heal();
            w1.Fight();
            Wizard w2 = new Wizard("calridge", 50);
            w2.Fight();
            w2.Fight();
            w2.Fight();
            w2.Fight();
            w2.Heal();
            w2.Fight();

            Console.ReadKey();
    }


}
}
