//Ejemplo 1 de calcular el area total en manzanas de un terreno rectangular una finca nicaraguense.

double ancho = 5.0;
double VarasPorManzana = 1428.8;

Console.WriteLine("Ingrese el largo del terreno en varas:");
double largo = Convert.ToDouble(Console.ReadLine());

double areaEnVaras = ancho * largo;
double areaEnManzanas = areaEnVaras / VarasPorManzana;

Console.WriteLine("El area total del terreno es: " + areaEnManzanas + " manzanas");
