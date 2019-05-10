using GameJamMai2019.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameJamMai2019.Classes
{
	class ArenaMob
	{
		public Coord Position;
		public Coord TargetPosition;
		private bool randomTarget = false;
		public Element MobElement { get; protected set; }

		public void Move()
		{
			if (randomTarget)
			{
				//check if new target
			}

			if (TargetPosition != null)
			{
				//move toward targetPosition
			}
			else
			{
					randomTarget = true;
				//random new target
			}
		}

		public virtual void CheckForNewTarget()
		{

		}
	}

}
