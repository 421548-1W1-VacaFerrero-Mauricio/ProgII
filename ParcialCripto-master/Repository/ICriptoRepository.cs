using WebApiCripto2.Models;

namespace WebApiCripto2.Repository
{
    public interface ICriptoRepository
    {
        Task<IEnumerable<Criptomoneda>> GetByCategoria(string categoria, CancellationToken cancellationToken);
        Task<Criptomoneda> Update(string simbolo, double valor, DateTime fecha, CancellationToken cancellationToken);
        Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
