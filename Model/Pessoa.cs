namespace ApiMySql.Model
{
    ///<summary>
    /// Classe pessoa que representa um registro de pessoa no banco de dados
    ///</summary>
    public class Pessoa
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }

        public string Endereco { get; set; }
    }
}