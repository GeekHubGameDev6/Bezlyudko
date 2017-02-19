import javax.microedition.lcdui.Canvas;
import javax.microedition.lcdui.Graphics;
import javax.microedition.lcdui.game.GameCanvas;

public class B
  extends GameCanvas
  implements Runnable
{
  private Townsmen3 a;
  private int b;
  private int c;
  public boolean d;
  public boolean e;
  private long f;
  
  public B(Townsmen3 paramTownsmen3, int paramInt1, int paramInt2)
  {
    super(false);
    paramTownsmen3.xc = getGraphics();
    this.a = paramTownsmen3;
    this.b = paramInt1;
    this.c = paramInt2;
    setFullScreenMode(true);
  }
  
  public void A(boolean paramBoolean1, boolean paramBoolean2)
  {
    this.d = paramBoolean1;
    this.e = paramBoolean2;
    new Thread(this).start();
  }
  
  public void paint(Graphics paramGraphics)
  {
    super.paint(paramGraphics);
  }
  
  protected void keyPressed(int paramInt)
  {
    if ((this.c & 0x1000) != 0)
    {
      this.a.bc = false;
      this.a.V(paramInt);
    }
  }
  
  protected void keyRepeated(int paramInt)
  {
    if ((this.c & 0x1000) != 0)
    {
      this.a.bc = true;
      this.a.V(paramInt);
    }
  }
  
  protected void keyReleased(int arg1)
  {
    if ((this.c & 0x1000) != 0)
    {
      this.a.W(???);
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
          this.a.BA();
          this.a.WA();
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
        this.a.WA();
        flushGraphics();
        try
        {
          wait(this.b);
        }
        catch (Exception localException2) {}
      }
      this.a.C(this.c | 0x400, false);
    }
  }
  
  public void hideNotify()
  {
    this.a.pauseApp();
  }
  
  public void showNotify()
  {
    if ((this.a.n != 204) && ((this.a.n != 203) || (this.a.eD != 145)) && (Townsmen3.b == 11)) {
      this.a.N(Townsmen3.G(1, 4));
    }
  }
}
