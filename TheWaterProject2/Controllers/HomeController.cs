using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheWaterProject2.Models;
using TheWaterProject2.Models.ViewModels;

namespace TheWaterProject2.Controllers
{
    public class HomeController : Controller
    {
        public IWaterRepository _repo;
        public HomeController(IWaterRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum, string? projectType)
        {
            int pageSize = 2;

            var Blah = new ProjectsListViewModel
            {
                Projects = _repo.Projects
                    .Where(x => x.projectType == projectType || projectType == null)
                    .OrderBy(x => x.projectName)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = projectType == null ? _repo.Projects.Count() : _repo.Projects.Where(x => x.projectType == projectType).Count()
                    //If the project type is null, do the first thing, else do the second thing
                },

                CurrentProjectType = projectType
            };

            return View(Blah);
        }
    }
}
