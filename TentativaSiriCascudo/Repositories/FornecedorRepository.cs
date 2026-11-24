using Microsoft.EntityFrameworkCore;
using TentativaSiriCascudo.Data;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Repositories
{
    //camada de acesso aos dados, so ele se comunica com o B.D. e o E.F.
    public class FornecedorRepository : IFornecedorRepository
    {

        //conexão com o B.D., variável banco de dados
        private readonly AppDbContext _context;


        //construtor
        public FornecedorRepository(AppDbContext context)
        {
            _context = context;
        }


        //retornar todo os Fornecedor
        public async Task<IEnumerable<Fornecedor>> ListarTudo()
        {
            return await _context.Fornecedores
                .ToListAsync();
        }


        //salvar no B.D.
        public async Task Adicionar(Fornecedor fornecedor)
        {
            await _context.Fornecedores.AddAsync(fornecedor);

            await _context.SaveChangesAsync();
        }

    }
}