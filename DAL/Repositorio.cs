namespace TiposGenerios2.DAL
{
    public class Repositorio<T> where T : class
    {
        private List<T> _itens;

        public Repositorio()
        {
            _itens = new List<T>();
        }

        // Criar (Adicionar)
        public void Adicionar(T item)
        {
            _itens.Add(item);
        }

        // Ler (Listar)
        public List<T> Listar()
        {
            return _itens;
        }

        // Atualizar
        public void Atualizar(int codigo, T item)
        {
            dynamic contato = item; // Para acessar o Codigo
            foreach (var i in _itens)
            {
                dynamic c = i;
                if (c.Codigo == codigo)
                {
                    _itens[_itens.IndexOf(i)] = item;  // Atualiza o item
                    return;
                }
            }
            Console.WriteLine("Contato não encontrado!");
        }

        // Excluir
        public void Excluir(int codigo)
        {
            foreach (var i in _itens)
            {
                dynamic c = i;
                if (c.Codigo == codigo)
                {
                    _itens.Remove(i);  // Exclui o item
                    return;
                }
            }
            Console.WriteLine("Contato não encontrado!");
        }
    }
}
