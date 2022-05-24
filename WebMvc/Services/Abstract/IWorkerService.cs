using WebMvc.Entities;

namespace WebMvc.Services.Abstract
{
    public interface IWorkerService
    {
        Task<List<string>> GetWorkersInDepartmentAsync(int departmentId);
        Task<List<string>> GetWorkersInSectionAsync(int sectionId);
        Task<List<string>> GetWorkersInJobAsync(int jobId);
    }
    
}
