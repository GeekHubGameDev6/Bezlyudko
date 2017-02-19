using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeRestoringProject
{
    class B //extends GameCanvas implements Runnable
    {
        private Townsmen3 townsmen3Object;
        private int b;
        private int c;
        public bool d;
        public bool e;
        private long f;
  
        public B(Townsmen3 paramTownsmen3, int paramInt1, int paramInt2) //: base(false)
        {
            //paramTownsmen3.xc = getGraphics(); 
            //xc field has the Graphics type from javax.microedition.lcdui.Graphics
            //getGraphics is the method from GameCanvas class
            this.townsmen3Object = paramTownsmen3;
            this.b = paramInt1;
            this.c = paramInt2;
            //setFullScreenMode(true);  
            //setFullScreenMode is the method from GameCanvas class
        }
 
        // If we ignore the Thread start then this method might as well be a continuation of the constructor
        public void A(bool paramBoolean1, bool paramBoolean2)
        {
            this.d = paramBoolean1;
            this.e = paramBoolean2;
            //?? new Thread(this).start();
            //?? What method is run in a thread anyway?
        }
  
        // GameCanvas paint method override with a Graphics paramgraphics argument
        public void paint(Graphics paramGraphics)
        {
            super.paint(paramGraphics);
        }

        // For now I can't understand how does this binary & works, 
        // but this method's work is surely dependant on the c variable of the a object of the Townsmen3 class
        protected void keyPressed(int paramInt)
        {
            // 0x0000 is 4096 in Hex
            if ((this.c & 0x1000) != 0)     
            {
                this.townsmen3Object.bc = false;
                this.townsmen3Object.V(paramInt);
            }
        }
  
        // Same stuff as in the method above with only the bool output changed
        protected void keyRepeated(int paramInt)
        {
            if ((this.c & 0x1000) != 0)
            {
                this.townsmen3Object.bc = true;
                this.townsmen3Object.V(paramInt);
            }
        }


        protected void keyReleased(int arg1)
        {
            if ((this.c & 0x1000) != 0)
            {
                this.townsmen3Object.W(???);
            }
            else
            {
                this.c = 4;
                synchronized (this)
                {
                    notifyAll();
                }
            }
        }
  
        public void run()
        {
            if ((this.c & 0x1000) != 0)
            {
                do
                {
                    System.gc();
                    if (this.e)
                    {
                        this.townsmen3Object.BA();
                        this.townsmen3Object.WA();
                        flushGraphics();
                    }
                    long l = System.currentTimeMillis() - this.f;
                    if (l < 150L) {
                        try
                        {
                        Thread.sleep(150L - l);
                        }
                        catch (Exception localException1) {}
                    }
                    this.f = System.currentTimeMillis();
                } while (this.d);
            }
            else
            {
                synchronized (this)
                {
                this.townsmen3Object.WA();
                flushGraphics();
                try
                {
                    wait(this.b);
                }
                catch (Exception localException2) {}
                }
                this.townsmen3Object.C(this.c | 0x400, false);
            }
        }
  
        public void hideNotify()
        {
            this.townsmen3Object.pauseApp();
        }
  
        public void showNotify()
        {
            if ((this.townsmen3Object.n != 204) && ((this.townsmen3Object.n != 203) || (this.townsmen3Object.eD != 145)) && (Townsmen3.b == 11)) {
                this.townsmen3Object.N(Townsmen3.G(1, 4));
            }
        }
    }
}
