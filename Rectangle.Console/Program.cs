using System;
using System.Linq;
using Rectangle.Impl;

namespace Rectangle.Console
{
	class Program
	{
		/// <summary>
		/// Use this method for local debugging only. The implementation should remain in Rectangle.Impl project.
		/// See TODO.txt file for task details.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{


			var rectangle = Service.FindRectangle(new[] { new Point(2, 3), new Point(3,4), new Point(-2,2) }.ToList());
            System.Console.WriteLine($"Width: {rectangle.Width} " +
				                     $" Height: {rectangle.Height} "+
				                     $" X: {rectangle.X}" +
									 $" Y: {rectangle.Y}" );
			System.Console.ReadKey();
		}
	}
}
//TODO: Logic in implementation IComparible must be better.
//      Tests.