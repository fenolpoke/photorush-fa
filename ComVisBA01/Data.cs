using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComVisBA01
{
    class User
    {
        public String Name = "";
        public String Username = "";
        public String Password = "";
        public String Email = "";
    }

    class Data
    {

        public static User[] Users = new User[10];
        public static Int32 UserCount = 1;

    }
}
