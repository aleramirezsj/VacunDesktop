using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.Inferfaces;
using VacunDesktop.Models;
using VacunDesktop.Presentation;

namespace VacunDesktop.AdminData
{
    public class DbAdminCalendarios : IDbAdmin
    {
        public IEnumerable<object> ObtenerTodos()
        {
            using VacunWebContext db = new VacunWebContext();
            return db.Calendarios.ToList();
        }
        public void Eliminar(int idSeleccionado)
        {
            using VacunWebContext db = new VacunWebContext();
            var calendario = db.Calendarios.Find(idSeleccionado);
            calendario.Eliminado = true;
            calendario.FechaHoraEliminacion = DateTime.Now;
            calendario.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(calendario).State = EntityState.Modified;
            //db.Calendarios.Remove(Calendario);
            db.SaveChanges();
        }
        public void Restaurar(int idSeleccionado)
        {
            using VacunWebContext db = new VacunWebContext();
            var calendario = db.Calendarios.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            calendario.Eliminado = false;
            db.Entry(calendario).State = EntityState.Modified;
            //db.Calendarios.Remove(Calendario);
            db.SaveChanges();
        }
        public object Obtener(int? idObtener)
        {
            using VacunWebContext db = new VacunWebContext();
            return db.Calendarios.Find(idObtener);
        }
        public void Agregar(object calendario)
        {
            using VacunWebContext db = new VacunWebContext();
            db.Calendarios.Add((Calendario)calendario);
            db.SaveChanges();
        }
        public void Actualizar(object calendario)
        {
            using VacunWebContext db = new VacunWebContext();
            db.Entry(calendario).State = EntityState.Modified;
            db.SaveChanges();
        }
        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            using VacunWebContext db = new VacunWebContext();

            //var listaCalendarios = from calendario in db.Calendarios
            //                       select new { id = calendario.Id, Nombre = calendario.Nombre.Trim(), sexo = calendario.SexoPaciente };
            //return listaCalendarios.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();
            return db.Calendarios.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();


        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using VacunWebContext db = new VacunWebContext();
            return db.Calendarios.Include(c => c.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }
    }
}
