Console.Write("Gradusni kiriting: ");
double degree = Convert.ToDouble(Console.ReadLine());
double formulaFahrenheit = (degree * 9/5) + 32;
double formulaKelvin =  degree + 273.15;
Console.WriteLine($"Selsiyus: {degree}, Fahrenheit: {formulaFahrenheit}, Kelvin : {formulaKelvin}");