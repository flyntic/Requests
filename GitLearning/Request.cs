using System;

namespace GitLearning
{
    public class Request
    {
        private static int id = 0;
        public int codeOfRequest;
        public Client client;
        public Dictionary<string, int> listOfgoods;
        private int Summa=0;

        public Request()
        {
            id++;
            this.codeOfRequest = id;
            this.client = new Client();
            this.listOfgoods = new Dictionary<string, int>();
            Console.Write("Введите Y для добавления товара ");
            string stopContinue = Console.ReadLine();

            while (stopContinue == "Y")
            {
                Console.Write("Название товара ");
                string name = Console.ReadLine();
                Console.Write("Стоимость товара ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Стоимость товара ");
                this.listOfgoods.Add(name, price);
                Console.Write("Введите Y для добавления следующего товара ");
                stopContinue = Console.ReadLine();
            }
            Console.WriteLine("---------------------------------");
            this.CalculateSumm();
        }

        public void CalculateSumm()
        {
            foreach (var item in this.listOfgoods)
                this.Summa += item.Value;
        }

        public void PrintInfoRequest()
        { 
            Console.WriteLine("ID заказа "+this.codeOfRequest);
            Console.WriteLine("----Инфо о клиенте-----------");
            this.client.PrintClientInfo();
            Console.WriteLine("-----------------------------");
            foreach(var item in this.listOfgoods)
            {
                Console.WriteLine("Название товара "+ item.Key+ " Стоимость "+item.Value);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Стоимость "+this.Summa);
            
        }
    }
}