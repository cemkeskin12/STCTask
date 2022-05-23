using Microsoft.EntityFrameworkCore;
using WebMvc.Context;
using WebMvc.Entities;
using WebMvc.Services.Abstract;

namespace WebMvc.Services.Concrete
{
    public class DepartmentService : IDepartmentService
    {
        private readonly AppDbContext dbContext;

        public DepartmentService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<List<Department>> ListAllDepartments()
        {
            return dbContext.Departments.Include(x=>x.Sections).ThenInclude(x=>x.Jobs).Include(x=>x.Worker).ToListAsync();
        }
    }
}
