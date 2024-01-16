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

        public async Task<List<StudentViewAllResult>> GetStudentData()
        {
            List<StudentViewAllResult> students = await _dbContext.Procedures.StudentViewAllAsync();
            return students;
        }

    }
}
