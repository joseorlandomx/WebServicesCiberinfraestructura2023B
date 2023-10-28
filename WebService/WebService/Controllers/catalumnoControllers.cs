using Microsoft.AspNetCore.Mvc;
using WebService.DataAccess;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/[Controllers]")]
    public class catalumnoControllers : ControllerBase

    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public catalumnoControllers(IDataAccessProvider dataAccessProvider) 
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet]
        public IEnumerable<catalumno> Get()
        {
            return _dataAccessProvider.Alumnos;

        }
    }
}
