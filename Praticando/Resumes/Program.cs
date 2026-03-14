using System;
using Microsoft.VisualBasic;

public class Program
{
static void Main(string[] args)
{
   Game game1 = new Game();
   game1._title = "Crash";
   game1._platform = "Playstation";
   game1._price = 10.0;

   Game game2 = new Game();
   game2._title = "Mortal Kombat";
   game2._platform = "Nintendo";
   game2._price = 25.0;

   Collection mycollection = new Collection();
   mycollection._owner = "Renata";
   mycollection._gameList.Add(game1);
   mycollection._gameList.Add(game2);
   //A classe Collection não tem um método chamado Add. Quem tem o método Add é a lista que está dentro dela, nesse caso a _gameList

   mycollection.ShowCollection();

  

}
}

//No C#, para usar uma classe, você precisa primeiro declarar ela (no arquivo Job.cs) e depois instanciar 
//(criar um objeto dela no Program.cs).