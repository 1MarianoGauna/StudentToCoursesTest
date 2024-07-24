using System.Data;

namespace CoursesAndStudents.Interfaces
{
    public interface IConnectionDB
    {
        IDbConnection DbConnection();
    }
}
