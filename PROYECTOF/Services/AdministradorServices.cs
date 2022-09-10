using PROYECTOF.Data;
using PROYECTOF.Models;

namespace PROYECTOF.Services
{
    public class AdministradorServices
    {
        private readonly IRepository repository;

        public AdministradorServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Administrador administrador)
        {
            await this.repository.Save(administrador);
            await this.repository.Commit();
        }

        public async Task<List<Administrador>> GetAllAdministrador()
        {
            return await this.repository.GetAll<Administrador>();
        }

        public void Update(Administrador administrador)
        {
            

            this.repository.Update(administrador);
            this.repository.Commit();
        }

        public void Delete(Administrador administrador)
        {
           

            this.repository.Delete(administrador);
            this.repository.Commit();
        }
    }
}
