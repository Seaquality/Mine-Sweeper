using System;

class Player {

	private Grid grid;

	public Player(Grid grid) {
		this.grid = grid;
	}

	public string GetInput() {
		while(true) {
			Console.Write("\n\n");
			grid.Print();
			Console.Write("\nInput: ");
			string input = Console.ReadLine();

			if(input.Length != 2) {
				Console.Write("Improper Input");
				continue;
			}

			char x = input[0];
			char y = input[1];

			if(x < 's'
			|| x > 'z'
			|| y < 'a'
			|| y > 'z'
			) {
				Console.Write("Improper Input: Make sure y axis comes first, and then x axis (eg. sf, yh, ta)");
			}

			return input;
		}
	}

}