using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1erParcial
{
    class ProfesorHora:Profesor,Paga
    {
        int CantidadHora;
        int PrecioHora;
        int PagaH;

        public string Pago()
        {
            return "El pago ha sido un éxito";
        }

        public ProfesorHora(string Apellido, string Nombre, int Cedula, string Direccion, int CantidadHora, int PrecioHora) : base(Apellido, Nombre, Cedula, Direccion)
        {
            this.CantidadHora = CantidadHora;
            this.PrecioHora = PrecioHora;
            
            PagaH = CantidadHora * PrecioHora;
        }

        
        public override void ImprimirDatosProfesor()
        {
            base.ImprimirDatosProfesor();
            Console.WriteLine("Las el total de horas trabajadas por el profesor es: " + CantidadHora);
            Console.WriteLine("El precio por hora que se le paga al profesor es de: " + PrecioHora);
            Console.WriteLine("El pago mensual que recibe el profesor es de: " + PagaH);
        }
        
    }
}
