using System;

namespace Metodo_Empleado
{
   class Empleado
{
        private string[] emp;
        private int[,] sueldos;
        private int[] sueldostot;

        public void Cargar() 
        {
            emp=new String[5];
            sueldos=new int[5,1];
            for(int f = 0; f < emp.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado: ");
                emp[f]=Console.ReadLine();
                for(int c = 0; c < sueldos.GetLength(1); c++) 
                {
                    Console.Write("Ingrese sueldo: ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[f,c]=int.Parse(linea);
                }
            }
        }

        public void CalcularSumaSueldos()
        {
            sueldostot = new int[5];
            for (int f = 0; f < sueldos.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    suma = suma + sueldos[f,c];
                }
                sueldostot[f] = suma;
            }
        }

        public void ImprimirTotalPagado() 
        {
    	    Console.WriteLine("Total de sueldos pagados por empleado.");
            for(int f = 0; f < sueldostot.Length; f++) 
            {
                Console.WriteLine(emp[f]+" - "+sueldostot[f]);
            }
        }

        public void EmpleadoMayorSueldo() 
        {
            int may=sueldostot[0];
            string nom=emp[0];
            for(int f = 0; f < sueldostot.Length; f++) 
            {
                if (sueldostot[f] > may) 
                {
                    may=sueldostot[f];
                    nom=emp[f];
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es "+ nom + " que tiene un sueldo de "+may);
        }
          static void Main(string[] args)
        {
            Empleado emp = new Empleado();
            emp.Cargar();
            emp.CalcularSumaSueldos();
            emp.ImprimirTotalPagado();
            emp.EmpleadoMayorSueldo(); 
            Console.ReadKey();
        }
    }
}
