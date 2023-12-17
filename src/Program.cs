using Student.Class;

class Programa
{
    static void Main()
    {
        string input;
        List<User> users = new List<User>();

        do
        {
            Console.WriteLine("*---------------------------------------*");
            Console.WriteLine("Informe qual opção desejas: ");
            Console.WriteLine("1 - Cadastro de usuário");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("*---------------------------------------*");

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    string name;
                    string password;
                    string email;

                    Console.WriteLine("Informe o nome: ");
                    name = Console.ReadLine();

                    Console.WriteLine("Informe a senha: ");
                    password = Console.ReadLine();

                    Console.WriteLine("Informe o E-mail: ");
                    email = Console.ReadLine();

                    User user = new(name, password, email);
                    
                    users.Add(user);

                    //  foreach (User user1 in users)
                    //  {
                    //     Console.WriteLine(user1.Name);
                    //  }

                    break;

                    default: 
                    Console.WriteLine("Encerrando...");
                    break;

            }

        } while (input != "0");
    }
}