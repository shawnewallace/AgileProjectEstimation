using System.Collections.Generic;

namespace AgileEst.lib
{
	public class ProjectRoleCollection : List<ProjectRole>
	{
		public ProjectRoleCollection()
		{
			Add(new ProjectRole { Name = "Iteration Manager", Description = "", MinRate = 75, MaxRate = 150, Rate = 135});
			Add(new ProjectRole { Name = "Solution Architect", Description = "", MinRate = 75, MaxRate = 150, Rate = 125 });
			Add(new ProjectRole { Name = "Developer", Description = "", MinRate = 75, MaxRate = 150, Rate = 115 });
			Add(new ProjectRole { Name = "Business Analyst", Description = "", MinRate = 75, MaxRate = 150, Rate = 120 });
			Add(new ProjectRole { Name = "Manual Tester", Description = "", MinRate = 75, MaxRate = 150, Rate = 115 });
			Add(new ProjectRole { Name = "Test Automation Developer", Description = "", MinRate = 75, MaxRate = 150, Rate = 115 });
		}
	}
}
