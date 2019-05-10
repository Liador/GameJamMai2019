using System;
using System.Collections.Generic;
using System.Text;

namespace GameJamMai2019.Enums
{
	public enum Elements
	{
		Ice,
		Lightning,
		Lava
	}
	
	public class Tools
	{
		public static int CompareElements(Elements element, Elements comparedElement)
		{
			int retVal;
			switch (element)
			{
				case Elements.Ice:
					if (comparedElement == Elements.Ice)
					{
						retVal = 0;
					}
					else
					{
						retVal = comparedElement == Elements.Lava ? 1 : -1;
					}
					break;
				case Elements.Lava:
					if (comparedElement == Elements.Lava)
					{
						retVal = 0;
					}
					else
					{
						retVal = comparedElement == Elements.Lightning ? 1 : -1;
					}
					break;
				case Elements.Lightning:
					if (comparedElement == Elements.Lightning)
					{
						retVal = 0;
					}
					else
					{
						retVal = comparedElement == Elements.Ice ? 1 : -1;
					}
					break;
				default:
					retVal = 0;
					break;

			}
			return retVal;
		}
	}
}
