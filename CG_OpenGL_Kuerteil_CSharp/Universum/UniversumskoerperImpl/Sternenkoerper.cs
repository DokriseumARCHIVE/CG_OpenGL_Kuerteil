namespace CG_OpenGL_Kuerteil_CSharp.Universum.UniversumskoerperImpl;

public class Sternenkoerper : Universumskoerper
{
    public double Lichtintensitaet { get; set; }

    public Sternenkoerper(double Durchmesser, double Masse, double Rotationsgeschwindigkeit, string Name, double Lichtintensitaet) : base(Durchmesser, Masse, Rotationsgeschwindigkeit, Name)
    {
        base.Masse = Masse;
        base.Rotationsgeschwindigkeit = Rotationsgeschwindigkeit;
        base.Durchmesser = Durchmesser;
        base.Name = Name;
        this.Lichtintensitaet = Lichtintensitaet;
    }
}