using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1erParcial
{
    class ProfesorNombramiento:Profesor,Paga
    {
        int PagaN;

        public string Pago()
        {
            return "El pago ha sido un éxito";
        }

        public ProfesorNombramiento(string Apellido, string Nombre, int Cedula, string Direccion) : base(Apellido, Nombre, Cedula, Direccion)
        {
            PagaN = 1500; // Aquí se le da el valor del pago al profesor por nombramiento y donde pasa por el if para ver si muestra el valor o muestra un mesaje diferente
            if(PagaN >= 1000)
            {
                Console.WriteLine("El pago mensual que recibe el profesor es de: " + PagaN);
            }
            else
            {
               
                Console.WriteLine("El pago no pudo ser registrado por falta de fondos por favot ingresar un monto mayor a $1000");
                
            }
        }

        public override void ImprimirDatosProfesor()
        {
            base.ImprimirDatosProfesor();            
            
        }
    }
}
