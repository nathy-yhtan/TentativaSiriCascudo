using Microsoft.EntityFrameworkCore;
using TentativaSiriCascudo.Data;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Repositories
{

    //boa pratica separar pois aqui é a infraestrutura de dados "como o sistema vai salvar"
    //a interface é a regra de negocios
    public class InfonutriRepository : IInfonutriRepository
    {

        //conexão com o B.D., variável banco de dados
        private readonly AppDbContext _context;


        //construtor
        public InfonutriRepository(AppDbContext context)
        {
            _context = context;
        }


        //retornar todas as Infonutri
        public async Task<IEnumerable<Infonutri>> ListarTudo()
        {
            return await _context.Infonutris
                .ToListAsync();
        }


        //salvar no B.D.
        public async Task Adicionar(Infonutri infonutri)
        {
            await _context.Infonutris.AddAsync(infonutri);
            await _context.SaveChangesAsync();
        }

    }

}