using WebMvc.Entities;

namespace WebMvc.Services.Abstract
{
    public interface IWorkerService
    {
        Task<List<Worker>> GetWorkersInDepartmentAsync(int departmentId);
        Task<List<Worker>> GetWorkersInSectionAsync(int sectionId);
        Task<List<Worker>> GetWorkersInJobAsync(int jobId);
    }
    
}
