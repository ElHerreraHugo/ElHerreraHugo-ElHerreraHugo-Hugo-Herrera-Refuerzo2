List<double> califica = new List<double>();

Console.WriteLine("Ingrese su Clasificacion:");
int cantidad = int.Parse(Console.ReadLine());


for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Ingrese la calificación {i + 1}:");
    double calificacion = double.Parse(Console.ReadLine());
    califica.Add(calificacion);
}


  double calificacionMasAlta = double.MinValue;
 double calificacionMasBaja = double.MaxValue;
            double sumaCalificaciones = 0;

 foreach (var calificacion in califica)
{
                if (calificacion > calificacionMasAlta)
                {
                    calificacionMasAlta = calificacion;
                }

               if (calificacion < calificacionMasBaja)
                {
                    calificacionMasBaja = calificacion;
                }

                sumaCalificaciones += calificacion;
            }

            double promedio = sumaCalificaciones / califica.Count;

            Console.WriteLine("\nEstadísticas de calificaciones: ");
            Console.WriteLine($"- Calificación más alta: {calificacionMasAlta}");
            Console.WriteLine($"- Calificación más baja: {calificacionMasBaja}");
            Console.WriteLine($"- Promedio de las calificaciones: {promedio}");

  