using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1erParcial
{
    class ProfesorContrato:Profesor,Paga
    {
        int HoraExtra;
        int PagaC;
        int C;

        public string Pago()
        {
            return "El pago ha sido un éxito";
        }
        public ProfesorContrato(string Apellido, string Nombre, int Cedula, string Direccion, int HoraExtra) : base(Apellido, Nombre, Cedula, Direccion)
        {
            this.HoraExtra = HoraExtra;

            C = HoraExtra * 20;
            PagaC = 400 + C;
        }

        public override void ImprimirDatosProfesor()
        {
            base.ImprimirDatosProfesor();
            Console.WriteLine("La cantidad de horas extras trabajadas por el docente es de: " + HoraExtra);
            Console.WriteLine("El pago mensual que recibe el profesor es de: " + PagaC);
        }
    }
}
