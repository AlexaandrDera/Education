using System;


namespace Metanit
{
    class Messenger<T> where T : Message
    {
        public void SendMessage(T message)
        {
            Console.WriteLine($"сообщение {message.Text}");
        }
    }
}


