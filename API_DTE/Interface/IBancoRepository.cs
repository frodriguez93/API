using System.Threading.Tasks;

namespace API_DTE.Interface
{
    public interface IBancoRepository
    {
        Task<Entity.Banco> GetAsync(int Id);
    }
}
