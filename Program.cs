// Criando o repositório de contatos
using TiposGenerios2.DAL;
using TiposGenerios2.Model;

Repositorio<Contato> repositorio = new Repositorio<Contato>();

// Menu de interação com o usuário
while (true)
{
    Console.Clear();
    Console.WriteLine("Agenda de Contatos:");
    Console.WriteLine("1. Adicionar Contato");
    Console.WriteLine("2. Listar Contatos");
    Console.WriteLine("3. Atualizar Contato");
    Console.WriteLine("4. Excluir Contato");
    Console.WriteLine("5. Sair");
    Console.Write("Escolha uma opção: ");
    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            // Adicionar Contato
            Console.Write("Digite o código do contato (número único): ");
            var codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do contato: ");
            var nome = Console.ReadLine();
            Console.Write("Digite o telefone do contato: ");
            var telefone = Console.ReadLine();
            repositorio.Adicionar(new Contato(codigo, nome, telefone));
            Console.WriteLine("Contato adicionado com sucesso!");
            Console.ReadKey();
            break;

        case "2":
            // Listar Contatos
            var contatos = repositorio.Listar();
            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato encontrado.");
            }
            else
            {
                Console.WriteLine("Contatos cadastrados:");
                foreach (var contato in contatos)
                {
                    Console.WriteLine(contato);
                }
            }
            Console.ReadKey();
            break;

        case "3":
            // Atualizar Contato
            Console.Write("Digite o código do contato que deseja atualizar: ");
            var codigoAtualizacao = int.Parse(Console.ReadLine());
            Console.Write("Digite o novo nome do contato: ");
            var novoNome = Console.ReadLine();
            Console.Write("Digite o novo telefone do contato: ");
            var novoTelefone = Console.ReadLine();
            repositorio.Atualizar(codigoAtualizacao, new Contato(codigoAtualizacao, novoNome, novoTelefone));
            Console.WriteLine("Contato atualizado com sucesso!");
            Console.ReadKey();
            break;

        case "4":
            // Excluir Contato
            Console.Write("Digite o código do contato que deseja excluir: ");
            var codigoExclusao = int.Parse(Console.ReadLine());
            repositorio.Excluir(codigoExclusao);
            Console.WriteLine("Contato excluído com sucesso!");
            Console.ReadKey();
            break;

        case "5":
            // Sair
            Console.WriteLine("Saindo do programa...");
            return;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ReadKey();
            break;
    }
}