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

        public async Task<List<Worker>> GetWorkersInDepartmentAsync(int departmentId)
        {
            return await dbContext.Workers.Where(x => x.DepartmentId == departmentId).ToListAsync();
        }

        public async Task<List<Worker>> GetWorkersInSectionAsync(int sectionId)
        {
            return await dbContext.Workers.Where(x => x.SectionId == sectionId).ToListAsync();
        }
        public async Task<List<Worker>> GetWorkersInJobAsync(int jobId)
        {
            return await dbContext.Workers.Where(x => x.JobId == jobId).ToListAsync();
        }
    }
}
