using CG_OpenGL_Kuerteil_CSharp.Universum.UniversumskoerperImpl;

namespace CG_OpenGL_Kuerteil_CSharp.Universum;

public interface ISonnensystem
{
    void RotationUmSonne();
    List<Planetenkoerper> getPlaneten();
    Planetenkoerper getPlanet(int index);
    void setPlaneten(List<Planetenkoerper> ListPlaneten);
    Sternenkoerper getStern();
    void setStern(Sternenkoerper Stern);
}