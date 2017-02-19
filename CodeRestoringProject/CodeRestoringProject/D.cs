using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRestoringProject
{
    class D
    {
        private Townsmen3 b;
        public sbyte c;
        public sbyte d;
        public A e;
        public A f;
        public int[] g;
        public sbyte h;
        public sbyte i;
        public sbyte j;
        public sbyte k;
        public sbyte l;
        public sbyte m;
        public sbyte n;
        public sbyte o;
        public sbyte p;
        public sbyte q;
        public short r;
        public short s;
        public sbyte t;
        public sbyte u;
        public sbyte v = -1;
        public sbyte w;
        public short x;
        public int y;
        public sbyte z = -1;
        public bool aa = true;
        public bool ba = false;
        public short ca;
  
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
                    this.b.R();
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
}
