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
            Player[] players = { new Player("PlayerOne", 100, 50, 10, 5), 
                new Player("PlayerTwo", 70, 60, 15, 7) };

            for (int i = 0; i < players.Length; i++)
            {
                players[i].ShowInformation();
            }
        }
    }

    class Player
    {
        private string _name;
        private int _health;
        private int _stamina;
        private int _damage;
        private int _armore;

        public Player(string name, int health, int stamina, int damage, int armore)
        {
            _name = name;
            _health = health;
            _stamina = stamina;
            _damage = damage;
            _armore = armore;
        } 
        
        public void ShowInformation()
        {
            Console.WriteLine($"Игрок:{_name}, Здровье:{_health}, Выносливость: {_stamina}, Урон: {_damage}, Броня: {_armore}");
        }
    }
}
