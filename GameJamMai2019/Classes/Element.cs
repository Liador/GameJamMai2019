using GameJamMai2019.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameJamMai2019.Classes
{
	class Element : IComparable
	{
		public Elements ElementAttribute { get; set; }

		public Element(Elements elem)
		{
			ElementAttribute = elem;
		}

		public int CompareTo(Object obj)
		{
			Element comparedElement = obj as Element;
			int retVal;
			switch (comparedElement.ElementAttribute)
			{
				case Elements.Ice:
					if (comparedElement.ElementAttribute == Elements.Ice)
					{
						retVal = 0;
					}
					else
					{
						retVal = comparedElement.ElementAttribute == Elements.Lava ? 1 : -1;
					}
					break;
				case Elements.Lava:
					if (comparedElement.ElementAttribute == Elements.Lava)
					{
						retVal = 0;
					}
					else
					{
						retVal = comparedElement.ElementAttribute == Elements.Lightning ? 1 : -1;
					}
					break;
				case Elements.Lightning:
					if (comparedElement.ElementAttribute == Elements.Lightning)
					{
						retVal = 0;
					}
					else
					{
						retVal = comparedElement.ElementAttribute == Elements.Ice ? 1 : -1;
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
