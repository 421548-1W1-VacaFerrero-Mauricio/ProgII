using WebApiCripto2.Dto;
using WebApiCripto2.Repository;

namespace WebApiCripto2.Service
{
    public class CriptoService : ICriptoService
    {
        private ICriptoRepository _repository;

        public CriptoService(ICriptoRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return _repository.Delete(id, cancellationToken);
        }

        public async Task<IEnumerable<CriptoGetDto>> GetByCategoria(string categoria, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var min = DateTime.Now.AddDays(-1);

            var entity = await _repository.GetByCategoria(categoria, cancellationToken);
            if (entity == null)
                return Enumerable.Empty<CriptoGetDto>();
            return entity.Where(p => p.UltimaActualizacion >= min).Select(p => new CriptoGetDto
            {
                Nombre = p.Nombre,
                Simbolo = p.Simbolo,
                ValorActual = p.ValorActual,
                UltimaActualizacion = p.UltimaActualizacion,
                Categoria = p.CategoriaNavigation.Nombre,
                Estado = p.Estado,
            });            
                
        }

        public async Task<CriptoGetDto> Update(string simbolo, CriptoPutDto dto, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var min = DateTime.Now.AddDays(-1);
            var max = DateTime.Now;
            if (dto.UltimaActualizacion < min || dto.UltimaActualizacion > max)
                throw new ArgumentException($"La fecha debe encontrarse entre {min} y {max}, entre las ultimas 24hs", nameof(dto.UltimaActualizacion));
            var entity = await _repository.Update(simbolo, dto.ValorActual, dto.UltimaActualizacion, cancellationToken);
            if (entity == null)
                throw new KeyNotFoundException("No existe la criptomoneda.");

            return new CriptoGetDto
            {
                ValorActual = entity.ValorActual,
                UltimaActualizacion = entity.UltimaActualizacion,
            };           
        }
    }
}
