//Calcule el tiempo de recorrido de un autobus de managua a granada con una distancia de 40km

const double Distancia = 40.0;

Console.WriteLine("Introduce la velocidad en km/h la que va el bus: ");
double velocidad = Convert.ToDouble(Console.ReadLine());

if (velocidad <= 0)
{
Console.WriteLine("La velocidad debe ser mayor que 0");
}
else
{ 
double tiempo = Distancia / velocidad;
Console.WriteLine($"El tiempo total que tomara el viaje es de {tiempo:F2} horas");
}