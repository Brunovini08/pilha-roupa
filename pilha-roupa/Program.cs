
using pilha_roupa;

Pilha pilha = new Pilha();


void Menu()
{
    Console.WriteLine("1 - Empilhar roupa");
    Console.WriteLine("2 - Desempilhar roupa");
    Console.WriteLine("3 - Exibir roupa do topo");
    Console.WriteLine("4 - Verificar se a pilha está vazia");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    int opcao = int.Parse(Console.ReadLine());

    while (opcao != 0)
    {

        switch (opcao)
        {
            case 1:
                Console.Write("Digite a descrição da roupa: ");
                string descricao = Console.ReadLine();
                Console.Write("Digite a cor da roupa: ");
                string cor = Console.ReadLine();
                Roupa roupa = new Roupa(descricao, cor);
                pilha.Empilha(roupa);
                Console.WriteLine("");
                Console.WriteLine("1 - Empilhar roupa");
                Console.WriteLine("2 - Desempilhar roupa");
                Console.WriteLine("3 - Exibir roupa do topo");

                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());
                break;
            case 2:
                Roupa roupaDesempilhada = pilha.Desempilha();
                if (roupaDesempilhada == null)
                {
                    Console.WriteLine("A pilha está vazia!");
                    Console.WriteLine("");
                    Console.WriteLine("1 - Empilhar roupa");
                    Console.WriteLine("2 - Desempilhar roupa");
                    Console.WriteLine("3 - Exibir roupa do topo");

                    Console.WriteLine("0 - Sair");
                    Console.Write("Escolha uma opção: ");

                    opcao = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Roupa desempilhada: {roupaDesempilhada.Descricao}, Cor: {roupaDesempilhada.Cor}");
                    Console.WriteLine("");
                    Console.WriteLine("1 - Empilhar roupa");
                    Console.WriteLine("2 - Desempilhar roupa");
                    Console.WriteLine("3 - Exibir roupa do topo");

                    Console.WriteLine("0 - Sair");
                    Console.Write("Escolha uma opção: ");

                    opcao = int.Parse(Console.ReadLine());
                }
                break;
            case 3:
                pilha.Exibir();
                Console.WriteLine("");
                Console.WriteLine("1 - Empilhar roupa");
                Console.WriteLine("2 - Desempilhar roupa");
                Console.WriteLine("3 - Exibir roupa do topo");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("");
                Console.WriteLine("1 - Empilhar roupa");
                Console.WriteLine("2 - Desempilhar roupa");
                Console.WriteLine("3 - Exibir roupa do topo");

                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());
                break;
        }
    }
}

Menu();