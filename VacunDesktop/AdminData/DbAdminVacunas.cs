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
            using VacunasContext db = new VacunasContext();
            return db.Vacunas.ToList();
        }

        public void Eliminar(int idSeleccionado)
        {
            using VacunasContext db = new VacunasContext();
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
            using VacunasContext db = new VacunasContext();
            return db.Vacunas.Find(idObtener);
        }
        public void Agregar(object vacuna)
        {
            using VacunasContext db = new VacunasContext();
            db.Vacunas.Add((Vacuna)vacuna);
            db.SaveChanges();
        }
        public void Actualizar(object vacuna)
        {
            using VacunasContext db = new VacunasContext();
            db.Entry(vacuna).State = EntityState.Modified;
            db.SaveChanges();
        }



        public  IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            using VacunasContext db = new VacunasContext();

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
