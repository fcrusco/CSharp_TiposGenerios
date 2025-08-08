namespace TiposGenerios2.Model
{
    public class Contato
    {
        public int Codigo { get; set; }  // Código único para identificar o contato
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato(int codigo, string nome, string telefone)
        {
            Codigo = codigo;
            Nome = nome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"Código: {Codigo} - {Nome} - {Telefone}";
        }
    }
}
