using EjercitoPractica1.Models;
using System.Collections.Generic;
using System.Data.Entity;


namespace EjercitoPractica1.DAL
{
    public class EjercitoDBInitializer : DropCreateDatabaseAlways<EjercitoContext>
    {


        protected override void Seed(EjercitoContext context){
            IList<InfanteriaBasica> defaultStandards = new List<InfanteriaBasica>();

            defaultStandards.Add(new InfanteriaBasica { ID1="IB1", PotenciaFuego1 = 2, Precio1 = 3 , Velocidad1 = 7});
          

            context.infanteriaBasica.AddRange(defaultStandards);

            base.Seed(context);
        }
    }

}