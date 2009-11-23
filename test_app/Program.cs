using System;
using System.Linq;
using System.Collections.Generic;

namespace test_app
{
	class Program
	{
		static void Main(string[] args)
		{
			var c = '►';

			for( var i = 9650; i < 9670; i++ )
				Console.WriteLine("{0}: {1}", i, (char)i);
		}

		private static void TestGrid()
		{
			var home_coord_x = 0;
			var home_coord_y = 0;

			var skip_x = 15 - (home_coord_x % 15);
			var skip_y = 5 - (home_coord_y % 5);
			//var skip = 0;

			var row = skip_y;

			for( var i = 0; i < 5 * 5; i++ )
			{
				if( row++ % 5 == 0 )
				{
					foreach( var c in GenerateGridRow().Skip(skip_x).Take(76) )
						Console.Write(c);
					Console.WriteLine();
				}
				else
				{
					foreach( var c in GenerateNormalRow().Skip(skip_x).Take(76) )
						Console.Write(c);
					Console.WriteLine();
				}
			}

			Console.CursorTop = home_coord_y;
			Console.CursorLeft = home_coord_x;
			Console.Write('X');

			Console.CursorTop = 30;
			Console.CursorLeft = 0;
		}

		private static IEnumerable<char> GenerateGridRow()
		{
			while( true )
			{
				yield return '┼';
				yield return '─';
				yield return ' ';
				yield return '·';
				yield return ' ';
				yield return ' ';
				yield return '·';
				yield return ' ';
				yield return ' ';
				yield return '·';
				yield return ' ';
				yield return ' ';
				yield return '·';
				yield return ' ';
				yield return '─';
			}
		}

		private static IEnumerable<char> GenerateNormalRow()
		{
			while( true )
			{
				yield return '·';
				yield return ' ';
				yield return ' ';
				yield return ' ';
				yield return ' ';
				yield return ' ';
				yield return ' ';
				yield return ' ';
				yield return ' ';
				yield return ' ';
				yield return ' ';
				yield return ' ';
				yield return ' ';
				yield return ' ';
				yield return ' ';
			}
		}

	}
}
