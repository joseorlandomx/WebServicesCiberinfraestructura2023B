using WebService.Models;

namespace WebService.DataAccess
{
    public interface IDataAccessProvider
    {
        IEnumerable<catalumno> Alumnos { get; set; }

        //internal IEnumerable<catalumno> Alumnos => throw new NotImplementedException();

        //Interface de acceso a metodos de persistencia
        List<catalumno> GetAlumnos();

    }
}
