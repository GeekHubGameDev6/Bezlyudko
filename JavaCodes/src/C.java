class C
  extends Thread
{
  private final Townsmen3 a;
  
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
