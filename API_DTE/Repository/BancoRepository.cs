using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_DTE.Entity;

namespace API_DTE.Repository
{
    public class BancoRepository : Interface.IBancoRepository
    {

        private readonly List<Banco> repo = new List<Banco>();
        public BancoRepository()
        {
            repo.Add(new Banco() { Id = 1, Nombre = "Rodrigo", Codigo = "Ciudad de Mexico" });
            repo.Add(new Banco() { Id = 2, Nombre = "Juan", Codigo = "Santiago" });
            repo.Add(new Banco() { Id = 3, Nombre = "Jorge", Codigo = "Lima" });

        }

        public Task<Banco> GetAsync(int Id)
        {

            //Banco data = repo.Where(c => c.Id == Id).FirstOrDefault();
            Banco data = repo.FirstOrDefault(c => c.Id == Id);
                return Task.FromResult(data);
           
            
        }
    }
}
