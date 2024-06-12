using Microsoft.EntityFrameworkCore;
using SGE.Aplicacion;
using SGE.Repositorios;

Expediente e1 = new Expediente();
Expediente e2 = new Expediente();
Expediente e3 = new Expediente();

Tramite t1 = new Tramite(e1);
Tramite t2 = new Tramite(e1);
Tramite t3 = new Tramite(e2);

DatosSqlite.Inicializar();

using(var context = new DatosContext())
{

    context.Add(e1); //Expedientes
    context.Add(e2);

    context.Add(t1); //Tramites
    context.Add(t2);
    context.Add(t3);

    context.Add(e3); //Expediente pq why not

    context.SaveChanges();

    Console.WriteLine("Datos guardados.");

}

using (var context = new DatosContext())
{

    int IDEliminar;

    do
    {

        IDEliminar = int.Parse(Console.ReadLine() ?? "0");

        var query = context.Expedientes.Include(e => e.Tramites).Where(e => e.ID == IDEliminar);

        if(query == null)
        {
            Console.WriteLine("No se encontró el expediente");
        }
        else
        {
            foreach(var obj in query)
            {
                context.Remove(obj);
            }
            context.SaveChanges();
        }

    } while(IDEliminar != 0);

}

