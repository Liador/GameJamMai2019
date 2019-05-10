using System;
using System.Collections.Generic;
using System.Text;
using GameJamMai2019.Enums;
using GameJamMai2019.Interface;

namespace GameJamMai2019.Classes
{
	class Viking : ArenaMob , IUnit
	{
		public const double VIKING_ADVANTAGE_WIN = 10;
		public const double VIKING_NEUTRAL_WIN = 0;
		public const double VIKING_LOSS = -10;
		public const double VIKING_ARENA_POWER_CHANGE = 0.3;

		public double Power;
		public Slot[] Slots;
		private Arena arena;

		public Viking()
		{
			Slots = new Slot[3];
			Power = 25;

		}

		public void Fight(Monster monster)
		{
			var comparison = MobElement.CompareTo(monster.MobElement);
			var powerDiff = comparison * VIKING_ADVANTAGE_WIN;

			//if (comparison > 0)
			//{
			//	powerDiff = VIKING_ADVANTAGE_WIN;
			//}
			//else
			//{
			//	powerDiff = comparison == 0 ? VIKING_NEUTRAL_WIN : VIKING_LOSS;
			//}
			Power += powerDiff;
		}

		public void Regulate(double timeStep)
		{
			var comparison = MobElement.CompareTo(arena.Element);
			var powerDiff = comparison * VIKING_ARENA_POWER_CHANGE;
		}
	}
}
