using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Exeptions
{
    internal class NotFoundompileTime : Exception
    {
        public string Output { get; }
        public NotFoundompileTime(string message)    
        {
            Output = message;
        }
    }
}
