

class Program
{
    static void Main(string[] args)
    {
        

        bool rodando = true;

        List<Livro> livrosApp = new List<Livro>();

        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("Seja bem vindo ao WayBooks!");

            Console.WriteLine("Selecione o que você deseja:");
            Console.WriteLine("1 - Cadastrar livro");
            Console.WriteLine("2 - Listar livros");
            Console.WriteLine("3 - Sair");


            Console.Write("Digite a opção desejada: ");
        }

        static void CadastrarLivro(List<Livro> livro)
        {
            Console.Clear();
            Livro novoLivro = new Livro();

            Console.WriteLine("Digite o título do livro que deseja cadastrar:");
            novoLivro.Titulo = Console.ReadLine();


            Console.WriteLine("Agora, digite o nome do autor:");
            novoLivro.Autor = Console.ReadLine();


            Console.WriteLine("Pra finalizar, digite o ano do livro:");
            novoLivro.Ano = int.Parse(Console.ReadLine());

            livro.Add(novoLivro);

            Console.Clear();

            Console.WriteLine("Livro cadastrado! \n");
            Console.WriteLine($"Título: {novoLivro.Titulo}");
            Console.WriteLine($"Autor: {novoLivro.Autor}");
            Console.WriteLine($"Ano: {novoLivro.Ano}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void ListarLivros(List<Livro> livros)
        {
            Console.Clear();
            foreach (var livro in livros)
            {
                Console.WriteLine($"{livro.Titulo} - {livro.Autor} ({livro.Ano})");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
        }


        while (rodando)
        {

            Menu();

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CadastrarLivro(livrosApp);
                    break;

                case 2:
                    ListarLivros(livrosApp);
                    break;

                case 3:
                    rodando = false;
                    break;
            }
        }
        
    }
}