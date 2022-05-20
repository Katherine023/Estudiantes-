using PepitoSchool.Domain;
using PepitoSchool.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Infrastructure
{
    public class EFEstudiantesRepository : IEstudiantesRepository
    {
        public IEstudiantesContext estudiantesContext;


        public EFEstudiantesRepository(IEstudiantesContext estudiantesContext)
        {
            this. estudiantesContext = estudiantesContext;
        }

        public void Create(Estudiantes t)
        {
            try
            {
                estudiantesContext.Estudiantes.Add(t);
                estudiantesContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Estudiantes t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto Estudiantes no puede ser null.");
                }

                Estudiantes estudiantes = FindById(t.Id);
                if (estudiantes == null)
                {
                    throw new Exception($"El objeto con id {t.Id} no existe.");
                }

                estudiantesContext.Estudiantes.Remove(estudiantes);
                int result = estudiantesContext.SaveChanges();

                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiantes FindByCode(string code)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(code))
                {
                    throw new Exception($"El parametro carnet {code} no tiene el formato correcto.");
                }

                return estudiantesContext.Estudiantes.FirstOrDefault(x => x.Carnet.Equals(code));
            }
            catch
            {
                throw;
            }
        }

        public Estudiantes FindById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new Exception($"El id {id} no puede ser menor o igual a cero.");
                }

                return estudiantesContext.Estudiantes.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                throw;
            }
        }

        public List<Estudiantes> FindByName(string name)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new Exception($"El parametro nombre '{name}' no tiene el formato correcto.");
                }

                return estudiantesContext.Estudiantes
                                        .Where(x => x.Nombres.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                                        .ToList();
            }
            catch
            {
                throw;
            }

        }

        public List<Estudiantes> GetAll()
        {
           return estudiantesContext.Estudiantes.ToList();
        }

        public int Update(Estudiantes t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto estudiante no puede ser null.");
                }

                Estudiantes estudiantes = FindById(t.Id);
                if (estudiantes == null)
                {
                    throw new Exception($"El objeto estudiantes con id {t.Id} no existe.");
                }

                estudiantes.Nombres = t.Nombres;
                estudiantes.Apellidos = t.Apellidos;
                estudiantes.Carnet = t.Carnet;
                estudiantes.Phone = t.Phone;
                estudiantes.Dirrecion = t.Dirrecion;
                estudiantes.Correo = t.Correo;
                estudiantes.Matematica = t.Matematica;
                estudiantes.Contabilidad = t.Contabilidad;
                estudiantes.Programaciion = t.Programaciion;
                estudiantes.Estadisticas = t.Estadisticas;



                estudiantesContext.Estudiantes.Update(estudiantes);
                return estudiantesContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
