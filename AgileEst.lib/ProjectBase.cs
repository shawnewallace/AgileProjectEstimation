using System;

namespace AgileEst.lib
{
	public class ProjectBase
	{
		public string Name { get; set; }
		public DateTime StartDate { get; set; }
		public int NumberOfIterations { get; set; }
		public bool IncludeIterationZero { get; set; }
		public int NumberOfWeeksInIteration { get; set; }
	}
}