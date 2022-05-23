using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMvc.Models;
using WebMvc.Services.Abstract;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDepartmentService departmentService;
        private readonly IWorkerService workerService;

        public HomeController(IDepartmentService departmentService, IWorkerService workerService)
        {
            this.departmentService = departmentService;
            this.workerService = workerService;
        }

        public async Task<IActionResult> Index()
        {
            var departments = await departmentService.ListAllDepartments();
            return View(departments);
        }
        public async Task<IActionResult> WorkersInDepartment(int id)
        {
            var workers = await workerService.GetWorkersInDepartmentAsync(id);
            return View(workers);
        }
        public async Task<IActionResult> WorkersInSection(int id)
        {
            var workers = await workerService.GetWorkersInSectionAsync(id);
            return View(workers);
        }
        public async Task<IActionResult> WorkersInJob(int id)
        {
            var workers = await workerService.GetWorkersInSectionAsync(id);
            return View(workers);
        }
    }
}