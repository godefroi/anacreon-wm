using System;

namespace Anacreon.Mobile
{
	static class Program
	{
		[MTAThread]
		static void Main()
		{
			//DrawTextMap();

			System.Windows.Forms.Application.Run(new MainForm());

			//System.Windows.Forms.Application.Run(new WorldForm(world));
		}

		public static Anacreon.Engine.Universe CreateUniverse()
		{
			var universe = new Anacreon.Engine.Universe(45, 30)
			{
				HomeSector = new Anacreon.Engine.Coordinate(2, 2),
			};

			// this block is so I can see how close stuff is
			/*universe.Sectors[00, 00].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.MetalMine };
			universe.Sectors[00, 01].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.MetalMine };
			universe.Sectors[00, 02].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.MetalMine };
			universe.Sectors[01, 00].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.MetalMine };
			universe.Sectors[01, 01].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.MetalMine };
			universe.Sectors[01, 02].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.MetalMine };
			universe.Sectors[02, 00].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.MetalMine };
			universe.Sectors[02, 01].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.MetalMine };
			universe.Sectors[02, 02].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.MetalMine };*/

			universe.Sectors[05, 01].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[09, 01].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[13, 01].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[22, 01].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[23, 01].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[27, 01].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[32, 01].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[40, 01].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			//universe.Sectors[02, 02].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Capitol      };
			universe.Sectors[10, 02].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[13, 02].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[24, 02].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[25, 02].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[29, 02].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[08, 03].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[10, 03].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[16, 03].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[30, 03].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[38, 03].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[02, 04].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[09, 04].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[16, 04].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[18, 04].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[21, 04].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[27, 04].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[37, 04].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[43, 04].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[00, 05].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[03, 05].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[07, 05].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[16, 05].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[22, 05].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[29, 05].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[35, 05].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[04, 06].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[17, 06].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[23, 06].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[01, 07].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[15, 07].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[22, 07].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[42, 07].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[10, 08].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[17, 08].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[24, 08].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[38, 08].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[39, 08].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[08, 09].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[18, 09].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[31, 09].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[43, 09].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[04, 10].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[06, 10].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[08, 10].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[20, 10].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[28, 10].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[01, 11].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[03, 11].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[05, 11].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[10, 11].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[16, 11].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[20, 11].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[27, 11].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[31, 11].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[36, 11].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[28, 12].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[42, 12].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[44, 12].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[04, 13].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[21, 13].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[25, 13].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[19, 14].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[26, 14].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[36, 14].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[03, 15].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[07, 15].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[13, 15].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[14, 15].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[39, 15].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[01, 16].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[17, 16].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[36, 16].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[38, 16].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			// this is the j Anacreon.Engine.World
			universe.Sectors[17, 17].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[03, 18].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[33, 18].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[01, 19].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[34, 19].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[38, 19].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[23, 20].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };
			universe.Sectors[39, 20].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[18, 22].Object = new Anacreon.Engine.World() { WorldType = Anacreon.Engine.WorldType.Agricultural };

			universe.Sectors[29, 13].Nebula = true;
			universe.Sectors[30, 13].Nebula = true;
			universe.Sectors[31, 13].Nebula = true;

			universe.Sectors[28, 14].Nebula = true;
			universe.Sectors[29, 14].Nebula = true;
			universe.Sectors[30, 14].Nebula = true;
			universe.Sectors[31, 14].Nebula = true;
			universe.Sectors[32, 14].Nebula = true;
			universe.Sectors[33, 14].Nebula = true;

			universe.Sectors[26, 15].Nebula = true;
			universe.Sectors[27, 15].Nebula = true;
			universe.Sectors[28, 15].Nebula = true;
			universe.Sectors[29, 15].Nebula = true;
			universe.Sectors[30, 15].Nebula = true;
			universe.Sectors[31, 15].Nebula = true;

			universe.Sectors[29, 16].Nebula = true;
			universe.Sectors[30, 16].Nebula = true;
			universe.Sectors[31, 16].Nebula = true;
			universe.Sectors[32, 16].Nebula = true;
			universe.Sectors[33, 16].Nebula = true;

			universe.Sectors[29, 17].Nebula = true;
			universe.Sectors[30, 17].Nebula = true;
			universe.Sectors[31, 17].Nebula = true;
			universe.Sectors[32, 17].Nebula = true;

			universe.Sectors[02, 02].Object = new Anacreon.Engine.World()
			{
				Class      = "Class j",
				Technology = "bio-tech",
				Population = "36.26 billion",
				Efficiency = 75,
				Ambrosia   = false,
				Revolution = 0,
				WorldType  = Anacreon.Engine.WorldType.Capitol,
				Supplies   = new Anacreon.Engine.Supplies()
				{
					Ambrosia  = 0,
					Chemicals = 3483,
					Metals    = 6384,
					Food      = 2176,
					Trillium  = 2323,
				},
				Ships      = new Anacreon.Engine.Ships()
				{
					Fighters       = 3730,
					HunterKillers  = 0,
					Jumpships      = 2728,
					JumpTransports = 1111,
					Penetrators    = 463,
					Starships      = 0,
					Transports     = 1715,
				},
				Troops     = new Anacreon.Engine.Troops()
				{
					Men    = 5115,
					Ninjas = 0,
				},
				Defenses   = new Anacreon.Engine.Defenses()
				{
					LAM               = 0,
					DefenseSatellites = 0,
					GDM               = 3073,
					IonCannons        = 939
				},
				FlavorText = "Only by defeating Arronax will you be able to expand your empire.",
			};

			return universe;
		}

		private static void DrawTextMap()
		{
			var u = CreateUniverse();
			var w = new System.Diagnostics.Stopwatch();
			var c = 0;

			using( var sw = new System.IO.StreamWriter("\\storage card\\map_chars.txt", false) )
			{
				for( var y = 0; y <= u.Sectors.GetUpperBound(1); y++ )
				{
					for( var x = 0; x <= u.Sectors.GetUpperBound(0); x++ )
					{
						w.Start();
						var chars = MapControl.GetSectorChars(u, x, y);
						w.Stop();
						c++;

						if( chars[0].Character == '\0' )
							sw.Write(' ');
						else
							sw.Write(chars[0].Character);

						if( chars[1].Character == '\0' )
							sw.Write(' ');
						else
							sw.Write(chars[1].Character);

						if( chars[2].Character == '\0' )
							sw.Write(' ');
						else
							sw.Write(chars[2].Character);
					}

					sw.WriteLine();
				}

				sw.WriteLine("{0} sectors in {1}ms", c, w.ElapsedMilliseconds);
			}
		}
	}
}