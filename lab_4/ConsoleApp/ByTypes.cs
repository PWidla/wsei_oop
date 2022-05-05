using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class ByTypes : IEnumerable<string>
    {



        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }


        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
        //    throw new System.NotImplementedException();
            return (IEnumerator<string>)GetEnumerator();

        }
    }
}
