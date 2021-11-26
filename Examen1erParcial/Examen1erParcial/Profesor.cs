using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1erParcial
{
    class Profesor
    {
        private string Apellido;
        private string Nombre;
        private int Cedula;
        private string Direccion;
        
        public string Recomendacion()
        {
            return "Las recomendacion han sido adjuntadas con éxito";
        }

        public Profesor(string Apellido, string Nombre, int Cedula, string Direccion)
        {
            this.Apellido = Apellido;
            this.Nombre = Nombre;
            this.Cedula = Cedula;
            this.Direccion = Direccion;
        }

        public string getApellido()
        {
            return Apellido;
        }
        public void setApellido(string Apellido)
        {
            this.Apellido = Apellido;
        }


        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }


        public int getCedula()
        {
            return Cedula;
        }
        public void setCedula(int Cedula)
        {
            this.Cedula = Cedula;
        }



        public string getDireccion()
        {
            return Direccion;
        }
        public void setDireccion(string Direccion)
        {
            this.Direccion = Direccion;
        }

        public virtual void ImprimirDatosProfesor()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Cédula: " + Cedula);
            Console.WriteLine("Direccion: " + Direccion);           
        }

    }
}

