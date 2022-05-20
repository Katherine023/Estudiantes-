using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Domain.Interface
{
    public interface IEstudiantesRepository: IRepository<Estudiantes>
    {
        Estudiantes FindById(int id);
        Estudiantes FindByCode(string code);
        List<Estudiantes> FindByName(string name);

    }
}
