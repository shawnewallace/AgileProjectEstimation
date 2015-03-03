using System;
using System.Collections.Generic;

namespace AgileEst.lib
{
	public class Iteration
	{
		public int Number { get; set; }
		public DateTime FirstDay { get; set; }
		public DateTime LastDay { get; set; }
		public int TargetedVelocity { get; set; }

		public virtual List<ProjectRole> ParticipatingRoles { get; set; }
	}
}