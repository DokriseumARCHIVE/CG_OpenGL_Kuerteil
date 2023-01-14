using CG_OpenGL_Kuerteil_CSharp.Universum.UniversumskoerperImpl;

namespace CG_OpenGL_Kuerteil_CSharp.Universum;

public class Sonnensystem : ISonnensystem
{
    private List<Planetenkoerper> ListPlaneten;
    private Sternenkoerper Stern;
    private int intRotationUmSonne;

    public Sonnensystem(int intRotationUmSonne)
    {
        this.intRotationUmSonne = intRotationUmSonne;
    }

    public void RotationUmSonne()
    {
        throw new NotImplementedException();
    }

    public List<Planetenkoerper> getPlaneten()
    {
        return this.ListPlaneten;
    }

    public Planetenkoerper getPlanet(int index)
    {
        return this.ListPlaneten.ToArray()[index];
    }

    public void setPlaneten(List<Planetenkoerper> ListPlaneten)
    {
        this.ListPlaneten = ListPlaneten;
    }

    public Sternenkoerper getStern()
    {
        return this.Stern;
    }

    public void setStern(Sternenkoerper Stern)
    {
        this.Stern = Stern;
    }
}