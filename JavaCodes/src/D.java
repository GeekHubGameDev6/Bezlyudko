import javax.microedition.lcdui.Graphics;

public class D
{
  private static final byte[][] a = { { 18, -9, 17, -9, 16, -8, 15, -8, 14, -7, 13, -7, 12, -6, 11, -6, 10, -5, 9, -5, 8, -4, 7, -4, 6, -3, 5, -3, 4, -2, 3, -2, 2, -1, 1, -1, 0, 0 }, { -18, -9, -17, -9, -16, -8, -15, -8, -14, -7, -13, -7, -12, -6, -11, -6, -10, -5, -9, -5, -8, -4, -7, -4, -6, -3, -5, -3, -4, -2, -3, -2, -2, -1, -1, -1, 0, 0 }, { 0, 0, 1, -1, 2, -1, 3, -2, 4, -2, 5, -3, 6, -3, 7, -4, 8, -4, 9, -5, 10, -5, 11, -6, 12, -6, 13, -7, 14, -7, 15, -8, 16, -8, 17, -9, 18, -9 }, { 0, 0, -1, -1, -2, -1, -3, -2, -4, -2, -5, -3, -6, -3, -7, -4, -8, -4, -9, -5, -10, -5, -11, -6, -12, -6, -13, -7, -14, -7, -15, -8, -16, -8, -17, -9, -18, -9 } };
  private Townsmen3 b;
  public byte c;
  public byte d;
  public A e;
  public A f;
  public int[] g;
  public byte h;
  public byte i;
  public byte j;
  public byte k;
  public byte l;
  public byte m;
  public byte n;
  public byte o;
  public byte p;
  public byte q;
  public short r;
  public short s;
  public byte t;
  public byte u;
  public byte v = -1;
  public byte w;
  public short x;
  public int y;
  public byte z = -1;
  public boolean aa = true;
  public boolean ba = false;
  public short ca;
  
  public D(Townsmen3 paramTownsmen3, byte paramByte)
  {
    this.b = paramTownsmen3;
    this.c = paramByte;
  }
  
  public D(Townsmen3 paramTownsmen3, int paramInt, A paramA1, A paramA2)
  {
    this.b = paramTownsmen3;
    this.c = ((byte)paramInt);
    this.e = paramA1;
    this.f = paramA2;
    this.g = new int[14];
    if (paramInt == 17) {
      this.t = 38;
    } else if (paramInt == 18) {
      this.t = 39;
    } else if (paramInt == 19) {
      this.t = 47;
    } else {
      this.t = 26;
    }
    switch (paramInt)
    {
    case 19: 
      paramA1.h[9] -= 1;
      this.v = ((byte)paramTownsmen3.D(paramA1));
      A(paramA1.t, paramA1.u);
      A(1);
      break;
    case 0: 
    case 17: 
    case 18: 
      A(paramA1.t, paramA1.u);
      A(1);
      break;
    case 1: 
      A(paramA2.t, paramA2.u);
      A(3);
      break;
    case 8: 
    case 9: 
    case 10: 
    case 11: 
    case 12: 
    case 13: 
    case 14: 
    case 15: 
    case 16: 
      this.h = 0;
      this.i = 0;
      A(paramA1.t, paramA1.u);
      A(1);
    }
  }
  
  private void A()
  {
    int i1;
    switch (this.d)
    {
    case 3: 
      switch (this.c)
      {
      case 0: 
        if (Townsmen3.sa[(this.f.a * 3 + this.e.e)] != this.w)
        {
          H();
        }
        else
        {
          this.y = (Townsmen3.ga[(this.e.a - 6)][this.e.e] * 100);
          if (this.f.a == 3) {
            this.t = 29;
          } else {
            this.t = 27;
          }
        }
        break;
      case 1: 
        if ((this.e.a != 10) && (this.w != -1))
        {
          this.f.h[this.w] += this.g[this.w];
          i1 = Townsmen3.ba[(this.f.a - 6)][this.w][this.f.c];
          if (this.f.h[this.w] >= i1)
          {
            this.b.J(this.w, i1);
            this.f.h[this.w] = i1;
          }
          this.g[this.w] = 0;
          this.v = -1;
        }
        break;
      case 17: 
      case 18: 
        this.f.w = true;
        if (this.c == 17) {
          this.f.x = false;
        } else {
          this.f.x = true;
        }
        this.ca = 700;
        this.b.D(this.f.t, this.f.u);
        this.b.H(0, 142);
        this.b.yc = true;
        break;
      case 19: 
        if ((this.f.w == true) || (this.f.a == 11) || (this.f.a == 12) || (this.f.a == 10))
        {
          this.b.N(22);
          this.b.mc = true;
          this.b.ec = true;
          this.b.yc = true;
          this.b.D(this.f.t, this.f.u);
          this.b.HB();
          this.aa = false;
          this.b.K(209);
        }
        else
        {
          this.ba = true;
          H();
        }
        break;
      case 16: 
        this.y = 32767;
        this.x = 1;
        H();
        break;
      case 11: 
      case 12: 
      case 13: 
      case 14: 
      case 15: 
        this.y = 5;
        this.x = 1;
        H();
      }
      break;
    case 1: 
      switch (this.c)
      {
      case 0: 
        this.v = -1;
        this.e.h[this.w] += this.g[this.w] + this.b.KA(this.w);
        i1 = Townsmen3.ba[(this.e.a - 6)][this.w][this.e.c];
        if (this.e.h[this.w] >= i1)
        {
          if (this.e.a == 13) {
            this.b.J(this.w, i1);
          }
          this.e.h[this.w] = i1;
        }
        this.g[this.w] = 0;
        break;
      case 1: 
        K();
        G();
        break;
      case 19: 
        if (this.ba)
        {
          this.e.h[9] += 1;
          if (this.e.h[9] > Townsmen3.ba[(this.e.a - 6)][9][this.e.c]) {
            this.e.h[9] = Townsmen3.ba[(this.e.a - 6)][9][this.e.c];
          }
          this.b.rd.removeElement(this);
          A(false);
        }
        break;
      case 16: 
        if (this.x == -1)
        {
          this.d = 5;
          return;
        }
        if (this.x == 0) {
          G();
        }
        break;
      case 11: 
      case 12: 
      case 13: 
      case 14: 
      case 15: 
        if (this.x == 0)
        {
          G();
        }
        else
        {
          i1 = this.b.B(this.b.ke, this.e);
          this.b.ge = ((D[])this.b.ke.elementAt(i1))[0].g;
          this.b.C(this.b.ke, this.e);
          this.b.turnAllBooleanArrayElementsToTrue();
          this.b.U();
          this.b.PA();
          this.b.K(203);
          this.b.D(this.e.t, this.e.u);
          this.b.GB();
          this.b.GA(141);
          this.b.S();
        }
        break;
      }
      break;
    }
  }
  
  private void B()
  {
    if ((this.d == 1) && (this.c == 1)) {
      if (this.e.e != -1)
      {
        this.w = Townsmen3.x[(this.e.a - 6)][this.e.c][(this.e.e * 2)];
        int i1 = Townsmen3.x[(this.e.a - 6)][this.e.c][(this.e.e * 2 + 1)] * 5 * 20 / 100;
        this.g[this.w] = (i1 < this.e.h[this.w] ? i1 : this.e.h[this.w]);
        this.e.h[this.w] += -this.g[this.w];
        if (this.g[this.w] > 0) {
          this.v = ((byte)this.b.D(this.e));
        } else {
          this.v = -1;
        }
      }
      else
      {
        this.w = -1;
        this.v = -1;
      }
    }
  }
  
  public void C()
  {
    int i1;
    switch (this.d)
    {
    case 1: 
      switch (this.c)
      {
      case 0: 
        if (((this.e.a == 6) && (this.e.e == 1)) || (this.e.i > 0)) {
          this.aa = false;
        } else {
          this.aa = true;
        }
        break;
      }
      break;
    case 3: 
      switch (this.c)
      {
      case 0: 
        if ((this.e.e == -1) || (this.f.w))
        {
          this.v = -1;
          H();
        }
        else if (--this.y <= 0)
        {
          if (this.e.a == 13) {
            this.v = ((byte)this.b.nd[Townsmen3.sa[(this.f.a * 3 + this.f.e)]]);
          } else {
            this.v = ((byte)this.b.D(this.e));
          }
          I();
          H();
        }
        else
        {
          this.u = ((byte)((this.y & 0x2) > 0 ? 1 : 0));
        }
        break;
      case 1: 
        if ((this.e.i == 0) && (this.e.e != -1) && (!this.e.w) && ((this.e.a != 10) || (this.e.h[Townsmen3.sa[(this.e.a * 3 + this.e.e)]] < Townsmen3.ba[(this.e.a - 6)][Townsmen3.ha[(this.e.a - 6)][(this.e.c * 3 + this.e.e)][14]][this.e.c])))
        {
          int i2 = 0;
          if (!this.b.M(this.e)) {
            i2 = J();
          }
          i1 = 0;
          if (this.e.a != 10) {
            i1 = this.e.h[Townsmen3.x[(this.e.a - 6)][this.e.c][(this.e.e * 2)]];
          }
          if ((i1 > 0) || (i2 > 0)) {
            H();
          }
          if (i2 > 0) {
            this.v = 9;
          } else {
            this.v = -1;
          }
        }
        break;
      case 17: 
      case 18: 
        if (this.f.w)
        {
          if (this.ca > 0)
          {
            this.ca = ((short)(this.ca - 1));
          }
          else if (this.f.a >= 6)
          {
            this.b.A(this.f, false);
            this.f.i = 1;
            this.b.A(10, 8, this.f.t, this.f.u, 0, -24, 48, 36, 0, 6, 0, 2);
            this.ca = 700;
          }
          else
          {
            this.b.od.removeElement(this);
            A(false);
          }
        }
        else
        {
          this.b.od.removeElement(this);
          A(false);
        }
        break;
      }
      break;
    case 5: 
      A(false);
      break;
    case 100: 
      switch (this.c)
      {
      case 11: 
      case 12: 
      case 13: 
      case 14: 
      case 15: 
      case 16: 
        if (this.y > 0)
        {
          this.aa = false;
          this.y -= 1;
          return;
        }
        if (((this.c >= 11) && (this.c <= 15)) || ((this.c >= 3) && (this.c <= 7) && (this.x == 1)))
        {
          if ((this.c >= 11) && (this.c <= 15))
          {
            i1 = this.b.B(this.b.ke, this.e);
            ((D[])this.b.ke.elementAt(i1))[0].g = this.b.MA(this.c);
          }
          else if ((this.c >= 3) && (this.c <= 7))
          {
            i1 = this.b.B(this.b.ke, this.e);
            ((D[])this.b.ke.elementAt(i1))[0].g = this.b.ge;
          }
          this.b.A(this.b.ke, this.e, -1, 2);
          return;
        }
        if ((this.x == 4) || (this.x == 5)) {
          this.aa = false;
        } else {
          this.aa = true;
        }
        break;
      }
      if ((this.c == 0) && (this.e.a == 6) && (this.e.e != 1)) {
        this.aa = true;
      }
      if (D()) {
        A(this.z);
      }
      break;
    }
  }
  
  public void A(Graphics paramGraphics)
  {
    if (((this.aa) && (Townsmen3.p[3] != 0)) || ((this.b.n == 205) && (this.aa)))
    {
      F();
      this.r = ((short)(this.r + this.p * 2));
      if (this.b.ed[this.i][this.h].a == 13) {
        this.s = ((short)(this.s + (this.q * 2 + -8)));
      } else {
        this.s = ((short)(this.s + this.q * 2));
      }
      byte b1 = this.t;
      if ((this.t != 29) && ((this.b.ed[this.i][this.h].a == 3) || (this.b.ed[this.i][this.h].a == 2))) {
        this.t = 43;
      }
      this.b.ub[this.t] = this.u;
      this.b.vb[this.t] = this.r;
      this.b.wb[this.t] = this.s;
      this.b.B(paramGraphics, this.t);
      if (this.v != -1)
      {
        this.b.ub[20] = this.v;
        this.b.vb[20] = ((short)(this.r - 3));
        this.b.wb[20] = ((short)(this.s + -28));
        this.b.B(paramGraphics, 20);
      }
      this.t = b1;
    }
  }
  
  public void A(int paramInt)
  {
    B();
    this.d = ((byte)paramInt);
    A();
  }
  
  public void A(int paramInt1, int paramInt2, int paramInt3)
  {
    if (this.c == 17) {
      this.t = 38;
    } else if (this.c == 18) {
      this.t = 39;
    } else if (this.c == 19) {
      this.t = 47;
    } else {
      this.t = 26;
    }
    this.l = ((byte)paramInt1);
    this.m = ((byte)paramInt2);
    this.j = this.h;
    this.k = this.i;
    if (E()) {
      return;
    }
    this.z = ((byte)paramInt3);
    A(100);
  }
  
  private boolean D()
  {
    if ((this.n == 3) || (this.n == 2))
    {
      if (this.o < 18)
      {
        this.p = a[this.n][(this.o * 2)];
        this.q = a[this.n][(this.o * 2 + 1)];
        this.u = ((byte)(this.n * 2 + ((this.o & 0x1) > 0 ? 1 : 0)));
        this.o = ((byte)(this.o + 1));
      }
      else
      {
        this.b.ed[this.i][this.h].o.removeElement(this);
        this.b.ed[this.k][this.j].o.addElement(this);
        this.h = this.j;
        this.i = this.k;
        this.o = 0;
        if (E())
        {
          this.p = 0;
          this.q = 0;
          this.u = 0;
          return true;
        }
      }
    }
    else if (this.o < 18)
    {
      if (this.o == 0)
      {
        this.b.ed[this.i][this.h].o.removeElement(this);
        this.b.ed[this.k][this.j].o.addElement(this);
        this.h = this.j;
        this.i = this.k;
      }
      this.p = a[this.n][(this.o * 2)];
      this.q = a[this.n][(this.o * 2 + 1)];
      this.u = ((byte)(this.n * 2 + ((this.o & 0x1) > 0 ? 1 : 0)));
      this.o = ((byte)(this.o + 1));
    }
    else
    {
      this.o = 0;
      if (E())
      {
        this.p = 0;
        this.q = 0;
        this.u = 0;
        return true;
      }
    }
    return false;
  }
  
  private boolean E()
  {
    int i3 = this.l - this.j;
    int i2 = this.m - this.k;
    if ((i3 == 0) && (i2 == 0)) {
      return true;
    }
    int i1;
    if (i3 >= 0) {
      i1 = 3;
    } else {
      i1 = 2;
    }
    if ((i3 == 0) && ((this.k & 0x1) > 0)) {
      i1 = 2;
    }
    if (i2 < 0) {
      i2 = 0;
    } else if (i2 == 0)
    {
      if (this.k == 0) {
        i2 = 1;
      } else {
        i2 = 0;
      }
    }
    else {
      i2 = 1;
    }
    if (i2 == 0) {
      if (i1 == 2)
      {
        if ((this.k & 0x1) == 0) {
          this.j = ((byte)(this.j - 1));
        }
        this.k = ((byte)(this.k - 1));
        this.n = 3;
      }
      else
      {
        if ((this.k & 0x1) > 0) {
          this.j = ((byte)(this.j + 1));
        }
        this.k = ((byte)(this.k - 1));
        this.n = 2;
      }
    }
    if (i2 == 1) {
      if (i1 == 2)
      {
        if ((this.k & 0x1) == 0) {
          this.j = ((byte)(this.j - 1));
        }
        this.k = ((byte)(this.k + 1));
        this.n = 0;
      }
      else
      {
        if ((this.k & 0x1) > 0) {
          this.j = ((byte)(this.j + 1));
        }
        this.k = ((byte)(this.k + 1));
        this.n = 1;
      }
    }
    return false;
  }
  
  private void F()
  {
    this.r = ((short)(this.b.E(this.h, this.i) + 36));
    this.s = ((short)(this.b.BA(this.i) + 36));
  }
  
  public void A(int paramInt1, int paramInt2)
  {
    this.b.ed[this.i][this.h].o.removeElement(this);
    this.b.ed[paramInt2][paramInt1].o.addElement(this);
    this.h = ((byte)paramInt1);
    this.i = ((byte)paramInt2);
    F();
  }
  
  public boolean G()
  {
    boolean bool = false;
    switch (this.c)
    {
    case 0: 
      int i1 = Townsmen3.ra[this.e.a];
      this.w = Townsmen3.sa[(this.e.a * 3 + this.e.e)];
      this.f = this.b.A(this.h, this.i, i1, this.e.e, true);
      if ((this.f != null) && (this.f.f[this.e.e] != 0))
      {
        A(this.f.t, this.f.u, 3);
        this.x = ((short)(Townsmen3.ha[(this.e.a - 6)][(this.e.c * 3 + this.e.e)][15] * 5 * this.e.j / 100));
        bool = true;
      }
      break;
    case 1: 
      A(this.f.t, this.f.u, 3);
      bool = true;
      break;
    case 8: 
    case 9: 
    case 10: 
    case 11: 
    case 12: 
    case 13: 
    case 14: 
    case 15: 
    case 16: 
    case 17: 
    case 18: 
    case 19: 
      A(this.f.t, this.f.u, 3);
      bool = true;
    }
    return bool;
  }
  
  public void H()
  {
    A(this.e.t, this.e.u, 1);
  }
  
  public void I()
  {
    int i1 = this.x;
    if ((this.e.e != -1) && (this.f.f[this.e.e] >= 0))
    {
      i1 = this.f.f[this.e.e] < this.x ? this.f.f[this.e.e] : this.x;
      byte tmp93_90 = this.e.e;
      short[] tmp93_83 = this.f.f;
      tmp93_83[tmp93_90] = ((short)(tmp93_83[tmp93_90] - i1));
    }
    else if (this.e.e == -1)
    {
      i1 = 0;
    }
    if (i1 == 0) {
      this.v = -1;
    }
    this.g[this.w] += i1;
    if ((this.f.f[0] + this.f.f[1] + this.f.f[2] == 0) && (this.f.a != 3) && (this.f.a != 5)) {
      this.b.B(this.f);
    }
  }
  
  public int J()
  {
    int i6 = 0;
    for (int i5 = 0; i5 < 14; i5++)
    {
      int i4 = Townsmen3.ha[(this.e.a - 6)][(this.e.c * 3 + this.e.e)][i5] * 5 * this.e.j / 100;
      int i3 = this.f.h[i5];
      int i2 = this.e.h[i5];
      if (i4 > 0)
      {
        i2 = i4 - i2;
        if (i2 > 0)
        {
          int i1 = Townsmen3.ha[(this.e.a - 6)][(this.e.c * 3 + this.e.e)][i5] * 5 * 20 / 100;
          i1 = i2 < i1 ? i2 : i3 < (i2 < i1 ? i2 : i1) ? i3 : i1;
          this.f.h[i5] += -i1;
          this.g[i5] += i1;
          i6 += i1;
        }
      }
    }
    return i6;
  }
  
  public void K()
  {
    for (int i2 = 0; i2 < 14; i2++)
    {
      this.e.h[i2] += this.g[i2];
      int i1 = Townsmen3.ba[(this.e.a - 6)][i2][this.e.c];
      if (this.e.h[i2] > i1) {
        this.e.h[i2] = i1;
      }
      this.g[i2] = 0;
    }
  }
  
  public void A(boolean paramBoolean)
  {
    if (paramBoolean) {
      this.b.A(0, 1, this.h, this.i, 36 + this.p - 12, 36 + this.q - 24, 0, 0, 1, 1, 0, 0);
    }
    this.aa = false;
    this.b.ed[this.i][this.h].o.removeElement(this);
    if ((this.c == 17) || (this.c == 18) || (this.c == 19)) {
      return;
    }
    this.d = 0;
    if ((this.e != null) && (this == this.e.p)) {
      this.e.p = null;
    }
    if ((this.f != null) && (this == this.f.q)) {
      this.f.q = null;
    }
  }
}
