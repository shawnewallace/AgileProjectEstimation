using System.Collections.Generic;

namespace AgileEst.lib
{
	public class ProjectFactory : ProjectBase, IExecute<Project>
	{
		public int InitialVelocity { get; set; }

		public Project Execute()
		{
			var project = new Project
			{
				Name = Name,
				IncludeIterationZero = IncludeIterationZero,
				NumberOfIterations = NumberOfIterations,
				StartDate = StartDate,
				Iterations = CreateIterations(),
				ProjectRoles = SPIKECreateProjectRoles()
			};

			return project;
		}

		private List<ProjectRole> SPIKECreateProjectRoles()
		{
			var roles = new List<ProjectRole>();

		  var roleCollection = new ProjectRoleCollection();

		  foreach (var role in roleCollection)
		  {
        roles.Add(new ProjectRole
        {
          Description = role.Description,
          MaxRate = role.MaxRate,
          MinRate = role.MinRate,
          Name = role.Name,
          Rate = role.Rate
        });
		  }

			return roles;
		}

		private List<Iteration> CreateIterations()
		{
			var iterations = new List<Iteration>();
			var startNumber = IncludeIterationZero ? 0 : 1;
			for (var i = startNumber; i <= NumberOfIterations; i++)
			{
				var iterationStartDate = StartDate.AddDays(7*NumberOfWeeksInIteration*i);
				var iterationEndDate = iterationStartDate.AddDays((7*NumberOfWeeksInIteration) - 1);
				var newIteration = new Iteration()
				{
					Number = i,
					FirstDay = iterationStartDate.Date,
					LastDay = iterationEndDate.Date,
					TargetedVelocity = InitialVelocity
				};

				iterations.Add(newIteration);
			}
			return iterations;
		}
	}
}