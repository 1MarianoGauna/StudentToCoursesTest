using System.Data;
using System.Data.SqlClient;
using CoursesAndStudents.Const;
using CoursesAndStudents.Interfaces;

namespace CoursesAndStudents.Datos.ConnectionDB
{
    public class ConnectionDB : IConnectionDB
    {
        private ILogger<ConnectionDB> _logger;
        public ConnectionDB(ILogger<ConnectionDB> logger)
        {
            _logger = logger;
        }

        public IDbConnection DbConnection()
        {
            try
            {
                IDbConnection db = new SqlConnection($"{Constantes.BDD}");
                return db;
            }
            catch (Exception ex)
            {
                _logger.LogError($"ConexionBaseDeDatos(), ex:{ex.ToString()}");
                return null;
            }
        }
    }
}
