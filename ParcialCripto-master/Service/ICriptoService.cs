using WebApiCripto2.Dto;

namespace WebApiCripto2.Service
{
    public interface ICriptoService
    {
        Task<IEnumerable<CriptoGetDto>> GetByCategoria(string categoria, CancellationToken cancellationToken);
        Task<CriptoGetDto> Update(string simbolo, CriptoPutDto dto, CancellationToken cancellationToken);
        Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
