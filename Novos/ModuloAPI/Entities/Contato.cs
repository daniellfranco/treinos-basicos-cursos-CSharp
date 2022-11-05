namespace ModuloAPI.Entities
{
    /* 
     * Entidades são como referencias as tabelas que tem no banco de dados
     * Todos os campos que vai ter no banco de dados, tem que ter aqui
     * ai com ela o Entity Framework saberá trabalhar certinho com a tabela no banco de dados
     */
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }

    }
}
