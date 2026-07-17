class Program
{
    static void Main(string[] args)
    {
        
        static void Menu()
        {
            Console.WriteLine("Seja bem-vindo ao meu primeiro programa solo!");
            Console.WriteLine("Qual é seu nome?");
            string nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Muito prazer, {nome}!");
            Console.WriteLine("Vamos começar?");
            Console.WriteLine("Primeiro, selecione uma das opções abaixo: ");
            Console.WriteLine("1 - Adicionar um livro");
            Console.WriteLine("2 - Pesquisar por um livro");
            Console.WriteLine("3 - Excluir um livro");
            Console.WriteLine("4 - Sair ");
            int resposta = Convert.ToInt32(Console.ReadLine());

            if(resposta == 1)
            {
                addBook();
            }
        }

        static void addBook()
        {
            Console.Clear();
            Console.WriteLine("Se você deseja adicionar um livro, você está no lugar certo!");
            Console.Write("Primeiro, digite o nome do livro: ");
            string livroNome = Console.ReadLine();
            Console.Write("Perfeito! Agora me passa o nome do autor: ");
            string autor = Console.ReadLine();
            Console.Write("Agora para finalizar, diga a data de lançamento do livro: ");
            string data = Console.ReadLine();
            Console.WriteLine($"\nEstamos registrando o livro:\n");
            Console.WriteLine($"Nome: {livroNome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Data: {data}");
            Console.Write($"\nDeseja confirmar? (S/N)");
            string confirmation = Console.ReadLine();

        }

        Menu();

        
        

    }
}