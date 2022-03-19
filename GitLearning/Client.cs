using System;

namespace GitLearning
{
    public class Client
    {
        public int id;
        private string name;

        public Client()
        {
            Console.Write("Введите id клиента ");
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите имя клиента ");
            this.name = Console.ReadLine();

        }

        public void PrintClientInfo()
        {
            Console.WriteLine("Id клиента "+this.id);
            Console.WriteLine("Имя клиента "+this.name);
            
        }

    }
}