using Microsoft.AspNetCore.Mvc;
using TheWaterProject2.Models;

namespace TheWaterProject2.Components
{
    public class ProjectTypesViewComponent: ViewComponent
    {
        private IWaterRepository _waterRepo;
        public ProjectTypesViewComponent(IWaterRepository temp) 
        {
            _waterRepo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedProjectType = RouteData?.Values["projectType"];

            var projectTypes = _waterRepo.Projects
                .Select(x => x.projectType)
                .Distinct()
                .OrderBy(x => x);

            return View(projectTypes);
        }
    }
}
