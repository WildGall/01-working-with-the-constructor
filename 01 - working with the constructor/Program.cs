using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___working_with_the_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = { new Player("PlayerOne", 100, 50, 10, 5), new Player("PlayerTwo", 70, 60, 15, 7) };

            for (int i = 0; i < players.Length; i++)
            {
                players[i].ShowInformation();
            }
        }
    }

    class Player
    {
        private string _gamerName;
        private int _gamerHealth;
        private int _gamerStamina;
        private int _gamerDamage;
        private int _gamerArmore;

        public Player(string gamerName, int gamerHealth, int gamerStamina, int gamerDamage, int gamerArmore)
        {
            _gamerName = gamerName;
            _gamerHealth = gamerHealth;
            _gamerStamina = gamerStamina;
            _gamerDamage = gamerDamage;
            _gamerArmore = gamerArmore;
        } 
        
        public void ShowInformation()
        {
            Console.WriteLine($"Игрок:{_gamerName}, Здровье:{_gamerHealth}, Выносливость: {_gamerStamina}, Урон: {_gamerDamage}, Броня: {_gamerArmore}");
        }
    }
}
