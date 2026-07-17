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

            if( confirmation == "N")
            {
                Console.WriteLine("O que você deseja?");
                Console.WriteLine("1 - Ajustar uma informação");
                Console.WriteLine("2 - Voltar ao menu principal");
                Console.WriteLine("3 - Sair");
                Console.Write("Digite: ");
                string respostaCN =  Console.ReadLine();

                if (respostaCN == "1")
                {
                   
                }else if (respostaCN == "2") 
                {
                    Menu();
                }else if (respostaCN == "3")
                {
                    Console.WriteLine("Até a próxima!");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Livro adicionado!");
                Console.WriteLine("O que você deseja fazer agora?");
                Console.WriteLine("1 - Adicionar um novo livro");
                Console.WriteLine("2 - Voltar ao menu principal");
                Console.WriteLine("3 - Sair");
                Console.Write("Digite: ");
                string respostaCS = Console.ReadLine();

                if (respostaCS == "1")
                {
                    addBook();
                }
                else if (respostaCS == "2") 
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine("Até a próxima!");
                }

            }

        }

        Menu();

        
        

    }
}