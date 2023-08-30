using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLearning.CustomDelegtes
{
        
    //Declaration of Delegate
    public delegate void MessageDelegate(string message);
    public class CustomDelegate
    {
        public void CustomDelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class GreetDelegate
    {
        public void GreetDelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
