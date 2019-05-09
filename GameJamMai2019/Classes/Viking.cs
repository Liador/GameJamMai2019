using System;
using System.Collections.Generic;
using System.Text;

namespace GameJamMai2019.Classes
{
	class Viking
	{
		public double Power;
		public Slot[] Slots;

		public Viking()
		{
			Slots = new Slot[3];
			Power = 25;
		}
	}
}
