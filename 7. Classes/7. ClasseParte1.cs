using System;

public partial class ClassePartial
{
	public string propriedadeString { get; set; }
    public int propriedadeInt { get; set; }
    public double propriedadeDouble { get; set; }

    public ClassePartial(string p1, int p2, double p3){
		this.propriedadeString = p1;
		this.propriedadeInt = p2;
		this.propriedadeDouble = p3;
	}
	
}
