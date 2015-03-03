using System;
using System.Web.Mvc;
using AgileEst.lib;
using AgileEst.web.Models;

namespace AgileEst.web.Controllers
{
	public class ProjectController : Controller
	{
		// GET: Project
		public ActionResult Index()
		{
			return View("Index");
		}

		public ActionResult New()
		{
			var model = new NewProjectViewModel()
			{
				Name = "New Project",
				IncludeIterationZero = true,
				NumberOfIterations = 10,
				NumberOfWeeksInIteration = 2,
				StartDate = FirstWednesdayAfterToday()
			};
			
			return View("New", model);
		}

		public ActionResult Create(NewProjectViewModel input)
		{
			var factory = new ProjectFactory()
			{
				Name = input.Name,
				IncludeIterationZero = input.IncludeIterationZero,
				NumberOfIterations = input.NumberOfIterations,
				NumberOfWeeksInIteration = input.NumberOfWeeksInIteration,
				StartDate = input.StartDate
			};

			var project = factory.Execute();
			var model = new ProjectViewModel(project) { RoleCollection = new ProjectRoleCollection() };

			return View("Edit", model);
		}

		private static DateTime FirstWednesdayAfterToday()
		{
			var rightNow = DateTime.Now.Date.AddDays(1);

			if (rightNow.DayOfWeek == DayOfWeek.Sunday) return rightNow.AddDays(3);
			if (rightNow.DayOfWeek == DayOfWeek.Monday) return rightNow.AddDays(2);
			if (rightNow.DayOfWeek == DayOfWeek.Tuesday) return rightNow.AddDays(1);

			if (rightNow.DayOfWeek == DayOfWeek.Thursday) return rightNow.AddDays(6);
			if (rightNow.DayOfWeek == DayOfWeek.Friday) return rightNow.AddDays(5);
			if (rightNow.DayOfWeek == DayOfWeek.Saturday) return rightNow.AddDays(4);

			return rightNow;
		}
	}
}