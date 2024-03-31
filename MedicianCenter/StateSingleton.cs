using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicianCenter
{
    internal class StateSingleton
    {
        private static StateSingleton instance;

        public AuthState authState { get; set; }
        public string connectionString { get; set; }
        public AuthForm authForm { get; set; }

        private StateSingleton()
        { 
            authState =  AuthState.NonAuth;
        }

        public static StateSingleton getInstance()
        {
            if (instance == null)
                instance = new StateSingleton();
            return instance;
        }
    }
}
