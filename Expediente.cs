using System;
using System.ComponentModel.DataAnnotations;
namespace SGE.Aplicacion;

public class Expediente
{

    public int ID {get; private set;}
    public List<Tramite> Tramites {get; set;}

    // ------------------------------------------------------------------

    public Expediente() {}

}