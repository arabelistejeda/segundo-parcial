using System;

namespace segundo_parcial
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] candidato =
           {
                "Partido: PRM (Partido Revolucionario Moderno fundado el 9/9/2020), Candidato: Carlos Sanchez, Aspira: presidencia " ,
                "Partido: PLD (Partido de la Liberacion Dominicana fundado el 15/12/1983), Candidato: Manuel Lopez, Aspira: presidencia ",
                "Partido: FDP (Fuerza del Pueblo fundado el 17/12/2017), Candidato: Juan Encarnacion, Aspira: presidencia  " ,
                "Partido: PRD (Partido Revolucionario Dominicano fundado el 21/1939), Candidato: Andres Matos, Aspira: presidencia  "

            };
            Console.WriteLine(candidato[0]);
            Console.WriteLine(candidato[1]);
            Console.WriteLine(candidato[2]);
            Console.WriteLine(candidato[3] + "\n");

            int[] canv = { 0, 0, 0, 0 };
            double can1, can2, can3, can4, total;

            Random alea = new Random();

            for (int a = 1; a < 1001; a++)
            {
                int be = alea.Next(1, 5);

                if (be == 1)
                {
                    canv[0] += 1;
                }

                if (be == 2)
                {
                    canv[1] += 1;
                }
                if (be == 3)
                {
                    canv[2] += 1;
                }
                if (be == 4)
                {
                    canv[3] += 1;
                }
            }
            total = canv[0] + canv[1] + canv[2] + canv[3];

            can1 = (canv[0] / total) * 100;
            can2 = (canv[1] / total) * 100;
            can3 = (canv[2] / total) * 100;
            can4 = (canv[3] / total) * 100;

            if (canv[0] > canv[1] && canv[0] > canv[2] && canv[0] > canv[3])
            {
                Console.WriteLine("El ganador es  Carlos Sanchez \n");
            }
            if (canv[1] > canv[0] && canv[1] > canv[2] && canv[1] > canv[3])
            {
                Console.WriteLine("El ganador es  Manuel Lopez \n");
            }
            if (canv[2] > canv[1] && canv[2] > canv[0] && canv[2] > canv[3])
            {
                Console.WriteLine("El ganador es  Juan Encarnacion \n");
            }
            if (canv[3] > canv[1] && canv[3] > canv[2] && canv[3] > canv[0])
            {
                Console.WriteLine("El ganador es Andres Matos \n");
            }

            Console.WriteLine("Carlos tuvo un " + can1 + "% de votos" + "\n" + "Manuel tuvo un " + can2 + "% de votos" + "\n" + "Juan tuvo un " + can3 + "% de votos" + "\n" + "Andres tuvo un " + can4 + "% de votos \n");

            Console.WriteLine("Orden de mayor a menor de los votos\n");
            for (int i = 0; i < canv.Length; i++)
            {
                for (int j = i + 1; j < canv.Length; j++)
                {
                    int ayu;
                    if (canv[i] > canv[j])
                    {
                        ayu = canv[i];
                        canv[i] = canv[j];
                        canv[j] = ayu;
                    }
                }

            }
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(canv[i]);
            }
            Console.ReadKey();


        }
    }
}
