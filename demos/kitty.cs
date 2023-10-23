using System;
using System.Threading;
namespace Kitty {
	public class Program {
		private static String safeSubstring(String str, int start, int end) {
			try {
				return str.Substring(start, end);
			} catch {
				return "";
			}
		}
		
		private static int marqueeSpaces = 0;
		private static int marqueeJump = 2;
		private static String marqueeStr = "meow!";
		private static int marqueeOver = 0;		
		private static void drawMarquee() {
			marqueeOver = marqueeSpaces - Console.WindowWidth + marqueeStr.Length;				
				
			if (marqueeOver > 0) {
				Console.Write(safeSubstring(marqueeStr, marqueeStr.Length - marqueeOver, marqueeOver));
			}				

			for (int i=0; i < marqueeSpaces - (marqueeOver > 0 ? marqueeOver : 0); i++) {
				Console.Write(" ");
			}
				
			if (marqueeOver > 0) {
				Console.Write(safeSubstring(marqueeStr, 0, marqueeStr.Length - marqueeOver));
			} else {
				Console.Write(marqueeStr);
			}

			if (marqueeSpaces > Console.WindowWidth - 1) {
				marqueeSpaces = 0;
			} else {
				marqueeSpaces += marqueeJump;
			}
			Console.WriteLine();
		}

		private static String kitty = "u =-w-= ^";
		private static String kitty2 = "^ =-w-= u";
		private static void drawKitty() {
			if (marqueeSpaces / (marqueeJump * 3) % 2 > 0) {
				Console.WriteLine(kitty);
			} else {
				Console.WriteLine(kitty2);
			}
		}
		public static void Main(String[] args=null) {
			while (true) {
				Console.Clear();
				drawMarquee();
				drawKitty();
				
				/* listens for break key */
				if (Console.KeyAvailable) {
					if (Console.ReadKey(false).Key == ConsoleKey.Escape) {
						break;
					}
				} else {
					Thread.Sleep(100);
				}
			}
		}
	}
}