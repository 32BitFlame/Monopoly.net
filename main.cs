using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		/*--------------------
		Define Player Variables
		---------------------*/
    int turns = 0;
		List<string> playerName = new List<string>();
		List<int> playerMoney = new List<int>();
		List<int> playerLocation = new List<int>();
    List<int> playersOut = new List<int>();
		int playerCount = 0;
    for(int i = 5; i >= -1; i--)
    {
    //Clear Terminal
    clearConsole();
    //Title 1
    Console.WriteLine("   _____  _  _     __  __                               _        ");
    for(int a = 0; a <= i; a++) {
      Console.WriteLine();
    }
    Console.WriteLine(@"  / ____|| || |_  |  \/  |                             | |      ");
    for(int a = 0; a <= i; a++) {
      Console.WriteLine();
    }
    Console.WriteLine(@" | |   |_  __  _| | \  / | ___  _ __   ___  _ __   ___ | |_   _ ");
    for(int a = 0; a <= i; a++) {
      Console.WriteLine();
    }
    Console.WriteLine(@" | |    _| || |_  | |\/| |/ _ \| '_ \ / _ \| '_ \ / _ \| | | | |");
    for(int a = 0; a <= i; a++) {
      Console.WriteLine();
    }
    Console.WriteLine(@" | |___|_  __  _| | |  | | (_) | | | | (_) | |_) | (_) | | |_| |");
    for(int a = 0; a <= i; a++) {
      Console.WriteLine();
    }
    Console.WriteLine(@"  \_____||_||_|   |_|  |_|\___/|_| |_|\___/| .__/ \___/|_|\__, |");
    for(int a = 0; a <= i; a++) {
      Console.WriteLine();
    }
    Console.WriteLine(@"                                           | |             __/ |");
    for(int a = 0; a <= i; a++) {
      Console.WriteLine();
    }
    Console.WriteLine(@"                                           |_|            |___/ ");
    //Clear Terminal
    if(i != -1)
    {
      System.Threading.Thread.Sleep(500);
      clearConsole();
    } 
    else
    {
      System.Threading.Thread.Sleep(1500);
    }
    
  }
		Console.WriteLine("How many players?");
		while (true)
		{
			try
			{
				playerCount = Convert.ToInt32(Console.ReadLine());
				break;
			}
			catch
			{
				Console.WriteLine("Please enter a number");
			}
		}

		for (int i = 0; i < playerCount; i++)
		{
      int players = i + 1;
      Console.WriteLine("Name: " + players);
			playerName.Add(Console.ReadLine());
		}

		foreach (string name in playerName)
		{
			playerMoney.Add(1000);
			playerLocation.Add(0);
		}

		/*--------------------
    Define World Varialbles
    ---------------------*/
    Console.WriteLine("What do you want the board size to be? (1 - 12)");
    int boardSize = 0;
    while(true)
    {
      try
      {
        boardSize = Convert.ToInt32(Console.ReadLine());
        if((boardSize < 1) || (boardSize > 12))
        {
          Console.WriteLine("1 - 12 please.");
          continue;
        }
      } 
      catch
      {
        Console.WriteLine("Please enter a number (1-12)");
        continue;
      }
      break;
    }
    Console.WriteLine("Board Size is " + boardSize);
    Console.WriteLine("Press enter to continue.");
    Console.ReadLine();
		List<string> spaces = new List<string>()
		{"Go", "Testvile", "Rickrolled", "Creative Naming Convention", "Mcdonalds", "Diabetes", "Ebola", "Pepe the Frog", "Ninja", "Skeleton Trumpet", "Donald Turnip", "Great Clips"};
    Console.WriteLine(spaces.Count);
		List<int> spacesCost = new List<int>()
		{};
		int startCost = 200;
		foreach (string s in spaces)
		{
			spacesCost.Add(startCost);
			startCost += 50;
		}

		List<int> spacesOwners = new List<int>();
		foreach (string s in spaces)
		{
			spacesOwners.Add(-1);
		}
    bool gameIsOn = true;
		while (gameIsOn)
		{
			//int playerCount, List<int> playerLocation, List<string> playerName, List<string> spaces, List<int> playerMoney, List<int> spaceCosts, List<int> spaceOwners
      turns++;
      Console.WriteLine(turns);
			turn(playerCount, playerLocation, playerName, spaces, playerMoney, spacesCost, spacesOwners, playersOut, boardSize);
      int i = 0;
      //Check for losers
      foreach(int m in playerMoney)
      {
        if(m < 0)
        {
          Console.WriteLine("player " + (i+1) + " is out of the game");
          playersOut.Add(i);
        }
        i++;
      }
      //Check for winner
      if((playerName.Count - playersOut.Count == 1) ||(playerName.Count == 1))
      {
        for(int currentIndex = playerName.Count -1; currentIndex >= 0; currentIndex--) {
          if(playerMoney[currentIndex] <= 0) {
            playerName.RemoveAt(currentIndex);
          }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
  Console.WriteLine("░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄");
Console.WriteLine("░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄");
Console.WriteLine("░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█");
Console.WriteLine("░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█");
Console.WriteLine("░▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░█");
Console.WriteLine("█▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█");
Console.WriteLine("█▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█");
Console.WriteLine("░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█");
Console.WriteLine("░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█");
Console.WriteLine("░░░█░░██░░▀█▄▄▄█▄▄█▄████░█");
Console.WriteLine("░░░░█░░░▀▀▄░█░░░█░███████░█");
Console.WriteLine("░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█");
Console.WriteLine("░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█");
Console.WriteLine("░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█");
Console.WriteLine("░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█");
        Console.WriteLine(playerName[0] + " is your winner!!!");
        gameIsOn = false;
      }
		}
	}
  public static void clearConsole()
  {
    for(int i = 0; i <100; i++)
    {
      Console.WriteLine();
    }
  }
  /*--------------------
  DEBUG RELATED FUNCTIONS
  --------------------*/
	public static void writeListContentInt(List<int> list) //For Testing Sake
	{
		foreach (int content in list)
		{
			Console.WriteLine(content);
		}
	}
  	public static void writeListContentString(List<string> list) //For Testing Sake... Again  (>'_')>
	{
		string toWrite = "";
		foreach (string content in list)
		{
			toWrite += content + ", ";
		}

		Console.WriteLine(toWrite);
	}

  //No need for large catagory
  public static bool isInIntList(List<int> list, int toCheck)
  {
    foreach(int i in list)
    {
      if(i == toCheck)
      {
        return true;
      }
    }
    return false;
  }
  public static bool tryConvertToInt32(int number)
  {
    try
    {
      int sample = Convert.ToInt32(number);
    }
    catch
    {
      return false;
    }
    return true;
  }

  /*--------------------
  TURN RELATED FUNCTIONS
  --------------------*/
  //Checks for special areas and if not treats as a property
	public static void area(List<int> money, List<int> owners, List<int> spaceCosts, int player, int location)
	{
		if (owners[location] < 0)
		{
			Console.WriteLine("No one owns this.");
			string x = "sample text";
			while (true)
			{
        Console.WriteLine("Buy?(yes, no)");
        x = Console.ReadLine();
				try
				{
					if ((x.ToLower() == "yes") && (money[player] - spaceCosts[location] > 0))
					{
						owners[location] = player;
						money[player] -= spaceCosts[location];
						Console.WriteLine("You have $" + money[player]);
						break;
					}
					else if (!(money[player] - spaceCosts[location] > 0) &&(x.ToLower() != "no"))
					{
						Console.WriteLine("Ya out o money, p");
						Console.WriteLine("You have $" + money[player]);
						break;
            
					}
					else if (x.ToLower() == "no")
					{
						Console.WriteLine("Ok then...");
						break;
					}
          else
          {
            continue;
          }
				}
				catch
				{
					Console.WriteLine("BEE like Jerry Seinfeld and BEE carefull formating xD lol sample text");
				}
			}
		}
		else
		{
			if(owners[location] != player)
			{
				Console.WriteLine("You owe $" + spaceCosts[location]);
				//Subtract from player who landed then add to owner
				money[player] -= spaceCosts[location];
				money[owners[location]] += spaceCosts[location];
				
			}
			else 
			{
				Console.WriteLine("You own this place :)");	
			}
		}
		Console.WriteLine("Press Enter to Continue");
		Console.ReadLine();
	}

	public static void place(int space, int player, int location, List<int> money, List<int> spaceOwners, List<int> spaceCosts)
	{
		if (space == 0)
		{
			Console.WriteLine("Press Enter to Continue");
			Console.ReadLine();
			return;
		}
		else if (space == 2)
		{
			Console.WriteLine("You've been RICKROLLED!");
			Console.WriteLine();
			Console.WriteLine("that means you lose 200 m9");
			money[player] -= 200;
			Console.WriteLine("Press Enter to Continue");
			Console.ReadLine();
			return;
		}
		else
		{
			//List<int> money, List<int> owners, List<int> spaceCosts, int player, int location
			area(money, spaceOwners, spaceCosts, player, location);
			return;
		}
	}

	public static void turn(int playerCount, List<int> playerLocation, List<string> playerName, List<string> spaces, List<int> playerMoney, List<int> spaceCosts, List<int> spaceOwners, List<int> playersOut, int size)
	{
		Random rng = new Random();
		for (int i = 0; i < playerCount; i++)
		{
      if(isInIntList(playersOut, i))
      {
        continue;
      }
			Console.WriteLine(playerName[i] + "s turn:");
			Console.WriteLine("Currently at " + playerLocation[i]);
			int space = rng.Next(1, 4);
			Console.WriteLine(playerName[i] + " rolled a " + space);
			int priorSpace = playerLocation[i];
			playerLocation[i] += space;
			
			if (playerLocation[i] >= size)
			{
				Console.WriteLine(playerName[i] + " passed go!");
				Console.WriteLine(playerName[i] + " got $200");
				playerMoney[i] += 200;
				playerLocation[i] -= size;
			}
      Console.WriteLine("Now at " + playerLocation[i]);
			//int space, int player, int location, List<int> money, List<int> spaceOwners, List<int> spaceCosts
			Console.WriteLine("You landed at " + spaces[playerLocation[i]]);
			place(playerLocation[i], i, playerLocation[i], playerMoney, spaceOwners, spaceCosts);
		}
	}
}