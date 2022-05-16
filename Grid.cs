 using System;

class Grid {
	private const int Rows = 8;
	private const int Cols = 8;

	private Cell[,] grid = new Cell[Rows, Cols];

	public Grid() {

		for(int i = 0; i < Rows; ++i) {
			for(int j = 0; j < Cols; ++j) {
				grid[i, j] = new Cell();
			}
		}

		Random rand = new Random();
		int randNums = (Rows + Cols) / 2;
		while(randNums > 0) {
			int randInt = rand.Next(Rows * Cols);
			int i = randInt / Rows;
			int j = randInt % Cols;
			if(!grid[i, j].IsBomb) {
				grid[i, j].IsBomb = true;
				--randNums;
			}
		}

	}

	public Cell GetCell(string s) {
		return grid[s[0] - 's', s[1] - 'a'];
	}

	public void RevealBombs() {
		for(int i = 0; i < Rows; ++i) {
			for(int j = 0; j < Cols; ++j) {
				if(grid[i, j].IsBomb) {
					grid[i, j].State = '*';
				}
			}
		}
	}

	public void Print() {

		Console.Write("  ");
		for(char c = 'a'; c < 'a' + Rows; ++c) {
			Console.Write(c + " ");
		}
		Console.Write('\n');

		for(int i = 0; i < Rows; ++i) {

			char c = 's';
			c += (char) i; 
			Console.Write(c + " ");

			for(int j = 0; j < Cols; ++j) {
				// grid[i][j] will be the ith row, jth column
				Console.Write(grid[i, j].State);
				Console.Write(' ');
			}
			Console.Write('\n');
		}
	}
}
/*

Cell[,] grid = new Cell[4, 4];

  0 1 2 3
0 . . . .
1 . . . .
2 . . . X
3 . . . .

grid[2][3] == X

*/