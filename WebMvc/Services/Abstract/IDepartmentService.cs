using WebMvc.Entities;

namespace WebMvc.Services.Abstract
{
    public interface IDepartmentService
    {
        Task<List<Department>> ListAllDepartments();
    }
}
