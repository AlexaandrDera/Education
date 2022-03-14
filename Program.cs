using System;


namespace Metanit
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message("some message text");
            EmailMessage email = new EmailMessage("text from email");

            SendMessage(email);
            SendMessage(message);

            void SendMessage<T>(T message) where T: Message
            {
                Console.WriteLine($"сообщение от сенд месседж {message.Text}");
            }

            Messenger<Message> telegram = new Messenger<Message>();
            telegram.SendMessage(new Message("hello telegram"));

            Messenger<EmailMessage> outlook = new Messenger<EmailMessage>();
            outlook.SendMessage(new EmailMessage("hello outlook"));
        }
    }
}


