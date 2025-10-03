using Microsoft.EntityFrameworkCore;
using WebApiCripto2.Models;

namespace WebApiCripto2.Repository
{
    public class CriptoRepository : ICriptoRepository
    {
        private readonly CriptoContext _context;

        public CriptoRepository(CriptoContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var entity = await _context.Criptomonedas.FindAsync(id, cancellationToken);
            if (entity == null)
                return false;
            if (entity.Estado == "H")
            {
                entity.Estado = "NH";
                return await _context.SaveChangesAsync(cancellationToken) > 0;
            }
            else
            { 
                return false; 
            }
                
        }

        public async Task<IEnumerable<Criptomoneda>> GetByCategoria(string categoria, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var list = await _context.Criptomonedas.Include(p => p.CategoriaNavigation)
                        .Where(p => p.CategoriaNavigation.Nombre == categoria).ToListAsync();
            return list;
        }

        public async Task<Criptomoneda> Update(string simbolo, double valor, DateTime fecha, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var entity = await _context.Criptomonedas.FirstOrDefaultAsync(p =>p.Simbolo == simbolo, cancellationToken);
            if (entity == null)
                throw new KeyNotFoundException("No existe la criptomoneda.");
            entity.ValorActual = valor;
            entity.UltimaActualizacion = fecha;
            await _context.SaveChangesAsync(cancellationToken);
            return entity;
        }
    }
}
