using System;

public class Propriedades
{


    private int _a;
    private int _b;

    public void setA(int A)
    {
        this._a = A; 
    }

    public int getA()
    {
        return this._a;
    }
    public int B
    {
        get { return _b; }
        set { _b = value;  }
    }

    public Propriedades()
	{ }
}
