using System;
namespace Demo {
	public class Program {
		public static void Main(String[] args) {
			Console.WriteLine("hai world :3");
			foreach (String arg in args) {
				Console.WriteLine(arg);
			}
		}
	}
}