using System;
using System.Collections.Generic;

namespace AgileEst.lib
{
	public class Project : ProjectBase
	{
		public virtual List<Iteration> Iterations { get; set; }
		public virtual List<ProjectRole> ProjectRoles { get; set; }
	}

	public class Iteration
	{
		public int Number { get; set; }
		public DateTime FirstDay { get; set; }
		public DateTime LastDay { get; set; }
		public int TargetedVelocity { get; set; }

		public virtual List<ProjectRole> ParticipatingRoles { get; set; }
	}

	public class ProjectRole : Role
	{
		public decimal MinRate { get; set; }
		public decimal MaxRate { get; set; }
		public decimal Rate { get; set; }
	}

	public class Role
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}

	public class EntityBase
	{
		public Guid Id { get; set; }
		public DateTime WhenCreated { get; set; }
		public DateTime WhenModified { get; set; }
	}

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
