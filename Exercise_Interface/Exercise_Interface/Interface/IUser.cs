using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Interface.Interface
{
    public interface IUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        void PrintUser();

    }
}
