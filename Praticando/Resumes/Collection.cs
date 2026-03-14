using System;
using System.Collections.Generic;

    public class Collection
    {
        public string _owner;
        public List<Game> _gameList = new List<Game>();

        public void ShowCollection()
        {
            Console.WriteLine($"Nome Game: {_owner}");
            Console.WriteLine("Games:");
            foreach (Games game in _gameList)
            {
                game.Display();
            }
        }


    }