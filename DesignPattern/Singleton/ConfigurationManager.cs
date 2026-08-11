using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    internal class ConfigurationManager
    {
        #region Egar Singleton
        //private static readonly ConfigurationManager _instance = new ConfigurationManager();

        //static ConfigurationManager()
        //{
        //    Console.WriteLine("Static Constructor Called");
        //}
        //private ConfigurationManager()
        //{
        //    Console.WriteLine("Object Created ");
        //}
        //public static ConfigurationManager Instance => _instance;


        //public static void ShowMessage()
        //{
        //    Console.WriteLine("Hello from ConfigurationManager");
        //}
        #endregion

        #region Lazy Singleton

        //private static  ConfigurationManager _instance;

        //private ConfigurationManager()
        //{
        //    Console.WriteLine("Object Created ");
        //}
        //public static ConfigurationManager Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //             _instance = new ConfigurationManager();
        //        return _instance;
        //    }
        //}
        //public static void ShowMessage()
        //{
        //    Console.WriteLine("Hello from Configuration Manager Message");
        //}

        #endregion

        #region Lock Thread

        //private static ConfigurationManager _instance;
        //private static readonly object _lock = new object();

        //private ConfigurationManager()
        //{
        //    Console.WriteLine("Object Created");
        //}

        //public static ConfigurationManager Instance
        //{
        //    get
        //    {
        //        lock (_lock)
        //        {
        //            if (_instance == null)
        //                _instance = new ConfigurationManager();

        //            return _instance;
        //        }
        //    }
        //}
        #endregion

        #region Lazy<T>

        private static readonly Lazy<ConfigurationManager> _instance =
        new Lazy<ConfigurationManager>(() => new ConfigurationManager());
        private ConfigurationManager()
        {
            Console.WriteLine("Object Created");
        }

        public static ConfigurationManager Instance => _instance.Value;

        public static void ShowMessage()
        {
            Console.WriteLine("Hello from Configuration Manager Message");
        }

        #endregion

    }
}
