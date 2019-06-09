using System;

namespace StarsVisual
{
	class Program
	{
		
		// 变量
		static int starsLimit = 5;
		
		// 主程式
		public static void Main(string[] args)
		{
			for (int i = 1; i < starsLimit + 1; i++) 
			{
				DrawStars(i);
				Console.WriteLine();
			}
			
			// 将 /* */ 给去除可使用里面的代码.
			/*for (int i = starsLimit; i > 0; i--) 
			{
				DrawStars(i);
				Console.WriteLine();
			}*/
			
			
			Console.ReadKey();
		}
		
		
		public static void DrawStars(int count)
		{
			for (int i = 0; i < count; i++) 
			{
				Console.Write("*");
			}
		}
		
	}
}
