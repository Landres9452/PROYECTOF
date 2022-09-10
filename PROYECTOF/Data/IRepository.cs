using PROYECTOF.Models;

namespace PROYECTOF.Data
{
    public interface IRepository
    {
        public Task Save<T>(T obj) where T : Entidad;
        public void Delete<T>(T obj) where T : Entidad;
        public void Update<T>(T obj) where T : Entidad;
        public Task<List<T>> GetAll<T>() where T : Entidad;

        public Task Commit();
    }
}
