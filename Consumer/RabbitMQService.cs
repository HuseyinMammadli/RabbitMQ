using RabbitMQ.Client;

namespace RabbitMQSample
{
    public class RabbitMQService
    {

        private readonly string _hostName = "192.168.13.129";

        public IConnection GetRabbitMQConnection()
        {
            var connectionFactory = new ConnectionFactory()
            {
                
                HostName = _hostName,
                Port = 5672,
                UserName = "huseyn",
                Password = "123456"
            };

            return connectionFactory.CreateConnection();
        }
    }
}