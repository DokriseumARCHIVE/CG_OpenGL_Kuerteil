namespace CG_OpenGL_Kuerteil_CSharp.Universum;

public abstract class Universumskoerper
{
    public double Durchmesser { get; set; }
    public double Masse { get; set; }
    public double Rotationsgeschwindigkeit { get; set; }
    public string Name { get; set; }

    public Universumskoerper(double Durchmesser, double Masse, double Rotationsgeschwindigkeit, string Name)
    {
        this.Durchmesser = Durchmesser;
        this.Masse = Masse;
        this.Rotationsgeschwindigkeit = Rotationsgeschwindigkeit;
        this.Name = Name;
    }
    
    
}