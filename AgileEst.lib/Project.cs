using System.Collections.Generic;

namespace AgileEst.lib
{
	public class Project : ProjectBase
	{
		public decimal TargetBlendedRate { get; set; }
		public virtual List<Iteration> Iterations { get; set; }
		public virtual List<ProjectRole> ProjectRoles { get; set; }
	}
}