using PepitoSchool.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Applications.Interfaces
{
    public interface IEstudiantesService : IService<Estudiantes>
    {
        Estudiantes FindById(int id);
        Estudiantes FindByCode(string code);
        List<Estudiantes> FindByName(string name);
    }
}
