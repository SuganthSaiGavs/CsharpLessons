using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>INTERFACE
/// An interface cannot contain fields or provide default implementations for its members.
/// A class can implement two interfaces(multiple implementation is supported but not multiple inheritance)
/// All members of an interface are implicitly public and cannot have access modifiers.
/// BY default all methods are (abstract methods).
/// </summary>
/// 
namespace LessonA.DayThree
{
    internal interface IMessageService
    {
       void SendMessage(string message);

        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceiveMessage();
        void DeleteMessge();
    }

    public interface IPayments
    {
        void Makepayment(float amount);
    }

    internal class WhatsApp : IMessageService,IPayments
    {
        public void DeleteMessage()
        {
            throw new NotImplementedException();
        }

        public void DeleteMessge()
        {
            throw new NotImplementedException();
        }

        public void Makepayment(float amount)
        {
            throw new NotImplementedException();
        }

        public void ReceiveMessage()
        {
            Console.WriteLine("Method not Implemented");
        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("Method not Implemented");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine("Method not Implemented");
        }
        public void SendVideoMessage(string messge)
        {
            Console.WriteLine("Method Not Implemented");
        }

    }

    public class MessageTester
    {
        public static void TestOne()
        {
            IMessageService messageService = new WhatsApp();
            messageService.SendMessage("Hello");
            messageService.ReceiveMessage();
        }
    }
}
