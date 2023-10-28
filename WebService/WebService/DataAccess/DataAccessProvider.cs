using WebService.Models;

namespace WebService.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        //Implementacion del metodo de la interface
        private readonly PostgreSqlContext _context;
        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }
        public List <catalumno> GetCatalumnos()
        {
            return _context.catalumno.ToList();
        }
    }
}
