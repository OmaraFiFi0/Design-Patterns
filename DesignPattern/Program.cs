using DesignPattern.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Problem

            // var obj01 = new ConfigurationManager();
            // var obj02 = new ConfigurationManager();
            //
            // Console.WriteLine(obj01 == obj02); 

            #endregion

            #region Egar Singleton

            //ConfigurationManager.ShowMessage();

            //var obj01 = ConfigurationManager.Instance;


            // OutPut
            //Object Created
            //Static Constructor Called
            //Hello from ConfigurationManager

            #endregion

            #region Lazy Singleton

            //   ConfigurationManager.ShowMessage();
            //   Console.WriteLine("TESTing");
            //   var obj01 = ConfigurationManager.Instance;
            //   var obj02 = ConfigurationManager.Instance;
            //   Console.WriteLine(obj01 == obj02);
            // OutPut
            //Hello from Configuration Manager Message
            //TESTing
            //Object Created
            //True

            #endregion


        }
    }
}
