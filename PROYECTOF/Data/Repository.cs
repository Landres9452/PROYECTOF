using Microsoft.EntityFrameworkCore;
using PROYECTOF.Models;

namespace PROYECTOF.Data
{
    public class Repository : IRepository
    {
        private readonly PROYECTOFDBContext context;

        public Repository(PROYECTOFDBContext context)
        {
            this.context = context;
        }

        public async Task Commit()
        {
           await context.SaveChangesAsync();
        }

        public void Delete<T>(T obj) where T : Entidad
        {
            context.Set<T>().Remove(obj);
        }

        public async Task<List<T>> GetAll<T>() where T : Entidad
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task Save<T>(T obj) where T : Entidad
        {
            await context.Set<T>().AddAsync(obj);
        }

        public void Update<T>(T obj) where T : Entidad
        {
            context.Set<T>().Update(obj);
        }

       
    }
}
