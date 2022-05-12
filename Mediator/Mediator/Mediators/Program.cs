using Mediator.Mediators;
using Mediator.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            ChatMediator chat = new ChatMediator();

            SimpleUser user1 = new SimpleUser(chat, "Oleg");
            SimpleUser user2 = new SimpleUser(chat, "Olejca");
            SimpleUser user3 = new SimpleUser(chat, "Olesea");


            chat.AddSimpleUserToChat(user1);
            chat.AddSimpleUserToChat(user2);
            chat.AddSimpleUserToChat(user3);


            user1.SendMessageAll("Buna ziua");
            user2.SendMessageTo("Ce faci, Oleg?", "Oleg");
            user3.SendMessageTo("Da tu ce faci, Olejca", "Olejca");
            user3.SendMessageTo("Tu ce faci, Olesea", "Olesea");
        }
    }
}
