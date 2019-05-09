using GameJamMai2019.Interface;
using System;
using System.Collections.Generic;

namespace GameJamMai2019
{
	class Program
	{
		public static double TimeStep = 0.015;
		public static List<IUnit> Units;
		

		static void Main(string[] args)
		{
			
			foreach (var unit in Units)
			{
				unit.Regulate(TimeStep);
			}

		}
		static void Init ()
		{
			Units = new List<IUnit>();
		}
	}
}
