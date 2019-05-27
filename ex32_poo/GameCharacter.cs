using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ex32_poo
{
    public abstract class GameCharacter : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
