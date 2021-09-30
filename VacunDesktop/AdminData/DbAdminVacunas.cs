using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VacunDesktop.Inferfaces;
using VacunDesktop.Models;
using VacunDesktop.Presentation;

namespace VacunDesktop.AdminData
{
    public class DbAdminVacunas: IDbAdmin
    {
        public IEnumerable<object> ObtenerTodos()
        {
            using VacunWebContext db = new VacunWebContext();
            return db.Vacunas.ToList();
        }

        public void Eliminar(int idSeleccionado)
        {
            using VacunWebContext db = new VacunWebContext();
            var vacuna = db.Vacunas.Find(idSeleccionado);
            vacuna.Eliminado = true;
            vacuna.FechaHoraEliminacion = DateTime.Now;
            vacuna.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(vacuna).State = EntityState.Modified;
            //db.Vacunas.Remove(Vacuna);
            db.SaveChanges();
        }

        public object Obtener(int? idObtener)
        {
            using VacunWebContext db = new VacunWebContext();
            return db.Vacunas.Find(idObtener);
        }
        public void Agregar(object vacuna)
        {
            using VacunWebContext db = new VacunWebContext();
            db.Vacunas.Add((Vacuna)vacuna);
            db.SaveChanges();
        }
        public void Actualizar(object vacuna)
        {
            using VacunWebContext db = new VacunWebContext();
            db.Entry(vacuna).State = EntityState.Modified;
            db.SaveChanges();
        }



        public  IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            using VacunWebContext db = new VacunWebContext();

            //var listaVacunas = from vacuna in db.Vacunas
            //                       select new { id = vacuna.Id, Nombre = vacuna.Nombre.Trim(), sexo = vacuna.SexoPaciente };
            //return listaVacunas.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();
            return db.Vacunas.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();


        }

        IEnumerable<object> IDbAdmin.ObtenerEliminados()
        {
            throw new NotImplementedException();
        }

        void IDbAdmin.Restaurar(int idSeleccionado)
        {
            throw new NotImplementedException();
        }
    }
}
