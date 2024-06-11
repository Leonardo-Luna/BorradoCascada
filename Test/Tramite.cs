using System.ComponentModel.DataAnnotations;

namespace SGE.Aplicacion;

public class Tramite
{


    public Expediente? expediente {get; set;}
    public int ID {get; private set;}

    public Tramite(Expediente e)
    {
        this.expediente = e;
    }

    public Tramite() {}

}