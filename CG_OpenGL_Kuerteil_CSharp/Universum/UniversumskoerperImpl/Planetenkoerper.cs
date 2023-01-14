namespace CG_OpenGL_Kuerteil_CSharp.Universum.UniversumskoerperImpl;

public class Planetenkoerper : Universumskoerper
{
    public int Trabantenanzahl { get; set; }

    public Planetenkoerper(double Durchmesser, double Masse, double Rotationsgeschwindigkeit, string Name, int Trabantenanzahl) : base(Durchmesser, Masse, Rotationsgeschwindigkeit, Name)
    {
        base.Masse = Masse;
        base.Rotationsgeschwindigkeit = Rotationsgeschwindigkeit;
        base.Durchmesser = Durchmesser;
        base.Name = Name;
        this.Trabantenanzahl = Trabantenanzahl;
    }
}