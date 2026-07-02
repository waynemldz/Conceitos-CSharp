class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Livro> livros = new List<Livro>();

        bool rodando = true;

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

        while (rodando)
        {

            Menu();

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();

                    Livro novoLivro = new Livro();

                    Console.WriteLine("Digite o título do livro que deseja cadastrar:");
                    novoLivro.Titulo = Console.ReadLine();


                    Console.WriteLine("Agora, digite o nome do autor:");
                    novoLivro.Autor = Console.ReadLine();


                    Console.WriteLine("Pra finalizar, digite o ano do livro:");
                    novoLivro.Ano = int.Parse(Console.ReadLine());

                    livros.Add(novoLivro);

                    Console.Clear();

                    Console.WriteLine("Livro cadastrado! \n");
                    Console.WriteLine($"Título: {novoLivro.Titulo}");
                    Console.WriteLine($"Autor: {novoLivro.Autor}");
                    Console.WriteLine($"Ano: {novoLivro.Ano}");
                    Console.WriteLine("\n Pressione Enter para voltar ao menu principal ou Esc para fechar o app");

                    ConsoleKeyInfo tecla = Console.ReadKey();

                    if (tecla.Key == ConsoleKey.Escape)
                    {
                        rodando = false;
                    }

                    break;

                case 2:
                    Console.Clear();
                    foreach (var livro in livros)
                    {
                        Console.WriteLine($"{livro.Titulo} - {livro.Autor} ({livro.Ano})");
                    }
                    Console.WriteLine("\nPressione qualquer tecla para voltar...");
                    Console.ReadKey();
                    break;

                case 3:
                    rodando = false;
                    break;
            }
        }
        
    }
}