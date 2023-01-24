namespace RabbitMQSample
{
    class Program
    {
        private static readonly string _queueName = "Huseyn-1";
        private static Publisher _publisher;

        static void Main(string[] args)
        {
            _publisher = new Publisher(_queueName, "Salam");

            Console.ReadKey();
        }
    }
}