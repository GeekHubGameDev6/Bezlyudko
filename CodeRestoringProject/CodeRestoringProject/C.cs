using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRestoringProject
{
    class C //extends Thread
    {
        // The a object was also declared as final
        // Can't yet understand whether that means that the a object can't be redefined or that the object itself can't be changed
        private Townsmen3 a;
  
        C(Townsmen3 paramTownsmen3)
        {
            this.a = paramTownsmen3;
        }
  
        public void run()
        {
            switch (Townsmen3.A(this.a))
            {
                case 11: 
                    this.a.LA();
            }
            this.a.nc = 1;
            Townsmen3.A(this.a, false);
            this.a.J(Townsmen3.A(this.a));
            Townsmen3.A(this.a);
            Townsmen3.A(this.a, -1);
        }
    }
}
