using System;
using System.Collections.Generic;
using AgileEst.lib;

namespace AgileEst.web.Models
{
	public class ProjectViewModel : ProjectBase
	{
		public ProjectViewModel(NewProjectViewModel model)
		{
			Name = model.Name;
			StartDate = model.StartDate;
			NumberOfIterations = model.NumberOfIterations;
			IncludeIterationZero = model.IncludeIterationZero;
			NumberOfWeeksInIteration = model.NumberOfWeeksInIteration;
		}

		public ProjectViewModel(Project model)
		{
			Name = model.Name;
			StartDate = model.StartDate;
			NumberOfIterations = model.NumberOfIterations;
			IncludeIterationZero = model.IncludeIterationZero;
			NumberOfWeeksInIteration = model.NumberOfWeeksInIteration;

			Iterations = new IterationViewModelList(model.Iterations);
			Roles = new ProjectRoleViewModelList(model.ProjectRoles);
		}

		public List<IterationViewModel> Iterations { get; set; }
		public List<ProjectRoleViewModel> Roles { get; set; }
		public ProjectRoleCollection RoleCollection { get; set; }
	}

	public class ProjectRoleViewModelList : List<ProjectRoleViewModel>
	{
		public ProjectRoleViewModelList(IEnumerable<ProjectRole> roles)
		{
			foreach (var projectRole in roles)
			{
				Add(new ProjectRoleViewModel
				{
					Name = projectRole.Name,
					Description = projectRole.Description,
					MaxRate = projectRole.MaxRate,
					MinRate = projectRole.MinRate,
					Rate = projectRole.Rate
				});
			}
		}
	}

	public class IterationViewModelList : List<IterationViewModel>
	{
		public IterationViewModelList(IEnumerable<Iteration> iterations)
		{
			foreach (var iteration in iterations)
			{
				Add(new IterationViewModel
				{
					FirstDay = iteration.FirstDay,
					LastDay = iteration.LastDay,
					Number = iteration.Number
				});
			}
		}
	}

	public class ProjectRoleViewModel : ProjectRole
	{
	}

	public class IterationViewModel : Iteration
	{
	}

	public class NewProjectViewModel : ProjectBase
	{
	}

}