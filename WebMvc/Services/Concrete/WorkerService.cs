using Microsoft.EntityFrameworkCore;
using WebMvc.Context;
using WebMvc.Entities;
using WebMvc.Services.Abstract;

namespace WebMvc.Services.Concrete
{
    public class WorkerService : IWorkerService
    {
        private readonly AppDbContext dbContext;

        public WorkerService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<string>> GetWorkersInDepartmentAsync(int departmentId)
        {
            var workers = await dbContext.Workers
                .Where(x => x.DepartmentId == departmentId && x.SectionId == null && x.JobId == null)
                .Select(x=> x.FirstName + " " + x.LastName).ToListAsync();
            return workers;
        }

        public async Task<List<string>> GetWorkersInSectionAsync(int sectionId)
        {
            var workers = await dbContext.Workers
                .Where(x => x.SectionId == sectionId && x.DepartmentId != null && x.JobId == null)
                .Select(x => x.FirstName + " " + x.LastName).ToListAsync();
            return workers;
        }
        public async Task<List<string>> GetWorkersInJobAsync(int jobId)
        {
            var workers = await dbContext.Workers
                .Where(x => x.JobId == jobId && x.SectionId != null && x.DepartmentId != null)
                .Select(x => x.FirstName + " " + x.LastName).ToListAsync();
            return workers;
        }
    }
}
