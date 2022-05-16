using System;

class Minesweeper {
	public static void Main(string[] args) {
		
		Grid grid = new Grid();
		Player player = new Player(grid);
		while(true) {
			Cell picked = grid.GetCell(player.GetInput());
			if(picked.IsBomb) {
				Console.Write("\n\n");
				grid.RevealBombs();
				grid.Print();
				Console.Write("You picked a bomb, game over\n");
				return;
			}
		}

	}
}


/* class CheckerBoard {
public static void Main (string[] args) {
  string[,] board = {
    {" ", "B", " ", "B", " ", "B", " ", "B"},
    {"B", " ", "B", " ", "B", " ", "B", " "},
    {" ", "B", " ", "B", " ", "B", " ", "B"},
    {" ", " ", " ", " ", " ", " ", " ", " "},
    {" ", " ", " ", " ", " ", " ", " ", " "},
    {"R", " ", "R", " ", "R", " ", "R", " "},
    {" ", "R", " ", "R", " ", "R", " ", "R"},
    {"R", " ", "R", " ", "R", " ", "R", " "}
  }; */

  