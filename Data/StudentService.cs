using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp.Data
{
    public class StudentService
    {
        private readonly StudentContext _dbContext;

        public StudentService(StudentContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Student>> GetStudentData()
        {
            List<Student> students = await _dbContext.Students.ToListAsync();
            return students ?? new List<Student>();
        }

    }
}
