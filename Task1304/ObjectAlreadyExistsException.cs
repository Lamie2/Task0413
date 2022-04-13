using System;
using System.Collections.Generic;
using System.Text;

namespace Task1304
{
    class ObjectAlreadyExistsException:Exception
    {
        public ObjectAlreadyExistsException(string message) : base(message)
        {
            
        }
    }
}
