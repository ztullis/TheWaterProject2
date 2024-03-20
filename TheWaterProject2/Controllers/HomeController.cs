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

        public IActionResult Index(int pageNum)
        {
            int pageSize = 5;

            var Blah = new ProjectsListViewModel
            {
                Projects = _repo.Projects
                    .OrderBy(x => x.projectName)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Projects.Count()
                }
            };

            return View(Blah);
        }
    }
}
