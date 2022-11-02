using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    //Classes context fazem uma ligação do programa com o banco de dados, seja de conexão quanto de referenciamento de entidades
    public class AgendaContext : DbContext
    {
        //construtor que passa a conexão que vamos receber do banco de dados e vamos passar para a classe herdada DbContext.
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            //aqui fica vazio mesmo
        }

        //Referencia a entidade Contatos
        public DbSet<Contato> Contatos { get; set; }

    }
}
