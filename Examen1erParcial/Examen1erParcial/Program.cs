using System;

namespace Examen1erParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("¡Información de los docentes!");
            Console.WriteLine("*****************************");
            Console.WriteLine("");
            Profesor Profesor = new Profesor("Cornejo", "Luis", 1313839555, "Calle 5 AV 34B");
            Console.WriteLine("**Datos del profesor**");
            Profesor.ImprimirDatosProfesor();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            
            ProfesorHora ProfesorHora = new ProfesorHora("Mero", "Alfredo", 1306589874, "Calle 108 AV 210", 40, 20);
            Console.WriteLine("**Datos del profesor por hora**");
            ProfesorHora.ImprimirDatosProfesor();
            Paga[] R = { ProfesorHora };
            foreach (Paga item in R)
            {
                Console.WriteLine(item.Pago());

            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");


            
            ProfesorContrato ProfesorContrato = new ProfesorContrato("Cedeño", "Mayerly", 1315252487, "Calle 10 AV 2", 10);
            Console.WriteLine("**Datos del profesor por contrato**");
            ProfesorContrato.ImprimirDatosProfesor();
            Paga[] R1 = { ProfesorContrato };
            foreach (Paga item in R1)
            {
                Console.WriteLine(item.Pago());

            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");



            
            ProfesorNombramiento ProfesorNombramiento = new ProfesorNombramiento("Mero", "Alfredo", 1306589874, "Calle J10 y J14");
            Console.WriteLine("**Datos del profesor por nombramiento**");
            ProfesorNombramiento.ImprimirDatosProfesor();
            Paga[] R2 = { ProfesorNombramiento };
            foreach (Paga item in R2)
            {
                Console.WriteLine(item.Pago());

            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
           
        }
    }
}

