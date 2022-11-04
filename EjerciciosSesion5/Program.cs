string nobre_cliente = "";
string email = "";
string descuento = "";
string nome = "";
int cantidad = 0;
double precio = 0;
double perc_descuento = 0;
double total_descuento = 0;
double total_bruto = 0;

Console.WriteLine("\nIntroduce tu nombre ");
nobre_cliente = Console.ReadLine();

Console.WriteLine("\nemail: ");
email = Console.ReadLine();

Console.WriteLine("\n¿Tienes un cupón de descuento? s/n: ");
descuento = Console.ReadLine();

Console.Write("\n¿Qué producto deseas?: ");
nome = Console.ReadLine();

Console.WriteLine("\n¿Qué cantidad quieres?");
cantidad = int.Parse(Console.ReadLine());

Console.WriteLine("\nInserta el precio: ");
precio = int.Parse(Console.ReadLine());

Console.WriteLine("\n¿cuál es el porcentaje de descuento?");
perc_descuento = double.Parse(Console.ReadLine());


// Percentage Calculation
total_bruto = cantidad * precio;
total_descuento = total_bruto - ((perc_descuento / 100) * total_bruto);
Console.WriteLine("\nEl total con descuento es " + total_descuento);

