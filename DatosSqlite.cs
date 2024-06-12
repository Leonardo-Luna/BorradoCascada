namespace SGE.Repositorios;
using SGE.Aplicacion;

public class DatosSqlite
{

    public static void Inicializar()
    {
        using var context = new DatosContext();
        if(context.Database.EnsureCreated())
        {

            Console.WriteLine("Se creó la base de datos"); //Borrar junto con el if 8)

        }
    }

}