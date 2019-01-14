using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    class Program
    {
        static void Main(string[] args)
        {                   
            int i;
            try
            {
                do
                {
                    Console.Write
                        (
                        "Меню:\n" +
                        "1 - регистрация \n" +
                        "2 - Добавить новость \n" +
                        "3 - Посмотреть новость \n" +                       
                        "Enter - Выйти\n"
                       );

                    i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            using (var db = new Context())
                            {
                                Console.Clear();
                                Console.WriteLine("Введите полное имя: ");
                                string fullName = Console.ReadLine();

                                Console.WriteLine("Введите почту: ");
                                string email = Console.ReadLine();

                                Console.WriteLine("Введите пароль: ");
                                string password = Console.ReadLine();

                                Author author = new Author { Email = email, Password = password, FullName = fullName };

                                db.Author.Add(author);
                                db.SaveChanges();
                                Console.WriteLine("Вы успешно зарегистрировались");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            break;

                        case 2:
                           
                                Console.WriteLine("Введите заголовок новости: ");
                                string title = Console.ReadLine();

                                Console.WriteLine("Введите содержимое: ");
                                string context = Console.ReadLine();

                                News news = new News { Title = title, Context = context };

                                Console.ReadLine();
                                Console.Clear();
                            
                            break;

                        case 3:
                            var Authors = db.Author;
                            Console.WriteLine("Список объектов:");
                            foreach (Author u in Authors)
                            {
                                Console.WriteLine("{0}.{1} - {2}", u.Id, u.FullName, u.Email, u.Password);
                            }                   
                             Console.ReadLine();
                    break;
                        case 4:
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                while (i != 4);
            }
            catch (Exception esc)
            {
                Console.WriteLine("");
            }
        }
    }
}


 
               