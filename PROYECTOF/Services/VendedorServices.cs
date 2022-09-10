using PROYECTOF.Data;
using PROYECTOF.Models;

namespace PROYECTOF.Services
{
    public class VendedorServices
    {
        private readonly IRepository repository;

        public VendedorServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Vendedor vendedor)
        {
            await this.repository.Save(vendedor);
            await this.repository.Commit();
        }
    }
    
}
