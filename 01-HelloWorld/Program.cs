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
        Console.WriteLine("Seja bem vindo ao App! Para começar, cadastre um livro.");

        Livro novoLivro = new Livro();

        Console.WriteLine("Digite o título do livro que deseja cadastrar:");
        novoLivro.Titulo = Console.ReadLine();


        Console.WriteLine("Agora, digite o nome do autor:");
        novoLivro.Autor = Console.ReadLine();


        Console.WriteLine("Pra finalizar, digite o ano do livro:");
        novoLivro.Ano = int.Parse(Console.ReadLine()); 
        

        Console.WriteLine("Livro cadastrado!");
        Console.WriteLine($"Título: {novoLivro.Titulo}");
        Console.WriteLine($"Autor: {novoLivro.Autor}");
        Console.WriteLine($"Ano: {novoLivro.Ano}");
    }
}