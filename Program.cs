using System;
using System.Collections.Generic;
using System.Linq;
//-------------------------------
//-----------Delegados-----------
//-------------------------------
namespace Dia7Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Proyecto pro = new Proyecto();
            
            //Console.ReadKey();
            //pro.AgregarProyecto();
            //pro.AgregarProyecto2();
            //pro.Imprimir();

            //Delegados (1.1)

            //Func<double, double, double> raiz = CalcularRaiz;
            //double pr=raiz(8, 2);
            //Console.WriteLine($"Raiz de {pr}");
            //Func<double, double, double> potencia = (x, y) => { return Math.Pow(x, y); };
            //Console.WriteLine($"Raiz con landa {potencia(8,2)}");
            //Func<int, int> doble = x => { return x *= 2; };
            //Console.WriteLine($"Multiplicación con landa {doble(8)}");

            var proyect = pro.AgregarProyecto2();
            //foreach (var item in ejm1)
            //{
            //    Console.WriteLine($"lista{item.Nombre}");
            //}
            var proys = proyect.Where(x => x.Codigo>0).ToList();
            //Console.WriteLine($"lista{proys}");
            Console.WriteLine($"-----------------------------------" + "\n" + "-------------Ejercio 1-------------");
            var ejem1 = proys.Where(x => x.Duracion > 6 && x.Duracion < 12).ToList();
            //Console.WriteLine($"lista");
            //foreach (var item in ejem1)
            //{
            //    Console.WriteLine($"Nombre: {item.Nombre}");
            //    Console.WriteLine($"Codigo: {item.Codigo}");
            //    Console.WriteLine($"Area: {item.Area}");
            //    Console.WriteLine($"Duracion: {item.Duracion}");
            //}
            pro.Imprimir2(ejem1);


            Console.ReadKey();
            Console.WriteLine($"-----------------------------------"+"\n"+"-------------Ejercio 2-------------");
            var ejem2 = from p in proys
                        where (p.Nombre.StartsWith("B"))
                        select p;
            
            pro.Imprimir2(ejem2.ToList());
            Console.ReadKey();
            Console.WriteLine($"-----------------------------------"+"\n"+"-------------Ejercio 3-------------");
            var ejem3 = proys.Where(x => x.Codigo %7==0).ToList();
            pro.Imprimir2(ejem3);
            Console.ReadKey();
            Console.WriteLine($"-----------------------------------" + "\n" + "-------------Ejercio 4-------------");
            var ejem4 =proys.GroupBy(x =>
              {
                  if (x.Duracion <=6)
                  {
                      return "Duracion inferior a 6";
                  }
                  else if (x.Duracion > 6 && x.Duracion < 10)
                  {
                      return "Duracion inferior a 10 y mayor a 6";
                  }
                  
                  else
                  {
                      return "Duracion mayor a 10";
                      
                  }
              });
            foreach (var groupProys in ejem4)
            {
                Console.ReadLine();
                Console.WriteLine("Grupo de proyectos"+groupProys.Key+"\n");
                
                foreach (var item in groupProys)
                {
                    Console.WriteLine($"Nombre: {item.Nombre}");
                    Console.WriteLine($"Codigo: {item.Codigo}");
                    Console.WriteLine($"Area: {item.Area}");
                    Console.WriteLine($"Duracion: {item.Duracion}");
                }
            }
            Console.ReadKey();
            Console.WriteLine($"-----------------------------------" + "\n" + "-------------Ejercio 5-------------");
            var ejem5 = proys.Average(x => x.Duracion);
            Console.WriteLine($"El promedio de duracion de todos los proyectos es:{ejem5}");
            Console.ReadKey();
            Console.WriteLine($"-----------------------------------" + "\n" + "-------------Ejercio 6-------------");
            //var ejem6 = proys.Where(x => x.Codigo>0).Select(x=> x.Nombre && x.Duracion);
            var ejem61 = proys.Max(x => x.Duracion);
            var ejem6 = from p in proys
                        where p.Duracion==ejem61
                        select p.Nombre;
            foreach (var item in ejem6)
            {
                Console.WriteLine($"El nombre de la maxima duracion es {item}");

            }
            Console.ReadKey();
            Console.WriteLine($"-----------------------------------" + "\n" + "-------------Ejercio 7-------------");
            var ejem7 = proys.Where(x => x.Duracion > 6 ).ToList();
            foreach (var item in ejem7)
            {
                Console.WriteLine($"Nombre:  {item.Nombre}\nArea: {item.Area}");
            }
            Console.ReadKey();
            Console.WriteLine($"-----------------------------------" + "\n" + "-------------Ejercio 8-------------");
        }

        public static double CalcularRaiz(double bas,double exp)
        {
            return Math.Pow(bas, exp);
        }
        
    }
}
