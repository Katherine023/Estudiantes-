using PepitoSchool.Applications.Interfaces;
using PepitoSchool.Domain;
using PepitoSchool.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Applications.Services
{
    public class EstudiantesService : IEstudiantesService
    {
        private IEstudiantesRepository estudiantesRepository;


        public EstudiantesService(IEstudiantesRepository estudiantesRepository)
        {
            this. estudiantesRepository = estudiantesRepository;
        }
        
        public void Create(Estudiantes t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("El Estudiantes no puede ser null.");
            }

            estudiantesRepository.Create(t);
        }

        public bool Delete(Estudiantes t)
        {
            throw new NotImplementedException();
        }

        public Estudiantes FindByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Estudiantes FindById(int id)
        {
            return estudiantesRepository.FindById(id);
        }

        public List<Estudiantes> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Estudiantes> GetAll()
        {
            return estudiantesRepository.GetAll();
        }

        public int Update(Estudiantes t)
        {
            throw new NotImplementedException();
        }
    }
}
