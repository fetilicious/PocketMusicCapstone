using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Storage.DataStorage.Models
{
    public class User
    {
        public String UserName { get; }

        public IPAddress StreamingAddress; 

        public User(string userName)
        {
            UserName = userName;
        }
    }
}
