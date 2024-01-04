using Student.Class;
using Student.src.Class;

class Programa
{
    static void Main()
    {
        string input;
        List<User> users = new List<User>();

        do
        {
            Console.WriteLine("*---------------------------------------*");
            Console.WriteLine();
            Console.WriteLine("Informe qual opção desejas: ");
            Console.WriteLine("1 - Cadastro de usuário");
            Console.WriteLine("2 - Cadastrar um estudante");
            Console.WriteLine("3 - Listagem de usuários");
            Console.WriteLine("4 - Listagem de usuários com senhas");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();
            Console.WriteLine("*---------------------------------------*");

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    string name;
                    string email;

                    Console.WriteLine("Informe o nome: ");
                    name = Console.ReadLine();

                    Console.WriteLine("Informe o E-mail: ");
                    email = Console.ReadLine();

                    string randomPass = User.GenerateRandomPassword();

                    User user = new(name, randomPass, email);

                    users.Add(user);
                    break;
                 case "2":
                    Students student = new(5234, "John Doe", "123", "jd@mail.com");
                    student.Greet();
                    break;

                case "3":
                    foreach(User user1 in users)
                    {
                        user1.Greet();
                    }
                    break;

                case "4":
                    foreach (User user1 in users)
                    {
                        user1.Greet(true);
                    }
                    break;

                default: 
                    Console.WriteLine("Encerrando...");
                    break;

            }

        } while (input != "0");
    }
}