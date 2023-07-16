using ProyectoCrud.DAL.DataContext;
using ProyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.DAL.Repositorio
{
    public class ContactoRepository : IGenericRepository<Contacto>
    {
        private readonly DbcapasContext _dbContext;

        public ContactoRepository(DbcapasContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Contacto modelo)
        {
            _dbContext.Contactos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Contacto modelo = _dbContext.Contactos.First(c => c.IdContacto == id);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Contacto modelo)
        {
            _dbContext.Contactos.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Contacto> Obtener(int id)
        {
            return await _dbContext.Contactos.FindAsync(id);
        }

        public async Task<IQueryable<Contacto>> ObtenerTodos()
        {
            IQueryable<Contacto> queryContactosSQL = _dbContext.Contactos;
            return queryContactosSQL;
        }
    }
}
