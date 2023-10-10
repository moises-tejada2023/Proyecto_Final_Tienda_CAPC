//Uso de vectores para almacenar los productos
string[] productos = new string[14];
string[] productosParaMenu = new string[14];
decimal[] precio = new decimal[14];
decimal[] cantidad = new decimal[14];
string[] tipoCanPro = new string[14];
int opCompra;
bool repetir = true;

//Asignación de valores

tipoCanPro[0] = "lb         ";
tipoCanPro[1] = "lb         ";
tipoCanPro[2] = "lb         ";
tipoCanPro[3] = "lb         ";
tipoCanPro[4] = "caja       ";
tipoCanPro[5] = "paquete    ";
tipoCanPro[6] = "galón      ";
tipoCanPro[7] = "bolsa      ";
tipoCanPro[8] = "bolsa      ";
tipoCanPro[9] = "paquete    ";
tipoCanPro[10] = "paquete    ";
tipoCanPro[11] = "unidad     ";
tipoCanPro[12] = "unidad     ";
tipoCanPro[13] = "paquete    ";

productos[0] = "Jamón de Pavo.";
productos[1] = "Carne Pollo.";
productos[2] = "Carne Res.";
productos[3] = "Carne Cerdo.";
productos[4] = "Cereal Integral.";
productos[5] = "Galletas Oreo.";
productos[6] = "Leche Salud.";
productos[7] = "Detergente Xedex.";
productos[8] = "Limpia pisos Fabuloso.";
productos[9] = "Pasta de Dientes Colgate.";
productos[10] = "Rasuradoras Lady Speed Stick.";
productos[11] = "Almohada para sala.";
productos[12] = "Muñeca Barbie Mattel.";
productos[13] = "Lapiceros Bic.";

productosParaMenu[0] = " Jamón de Pavo.                   ";
productosParaMenu[1] = " Carne Pollo.                     ";
productosParaMenu[2] = " Carne Res.                       ";
productosParaMenu[3] = " Carne Cerdo.                     ";
productosParaMenu[4] = " Cereal Integral.                 ";
productosParaMenu[5] = " Galletas Oreo.                   ";
productosParaMenu[6] = " Leche Salud.                     ";
productosParaMenu[7] = " Detergente Xedex.                ";
productosParaMenu[8] = " Limpia pisos Fabuloso.           ";
productosParaMenu[9] = "Pasta de Dientes Colgate.        ";
productosParaMenu[10] = "Rasuradoras Lady Speed Stick.    ";
productosParaMenu[11] = "Almohada para sala.              ";
productosParaMenu[12] = "Muñeca Barbie Mattel.            ";
productosParaMenu[13] = "Lapiceros Bic.                   ";

precio[0] = 2.15m;
precio[1] = 2.50m;
precio[2] = 3.50m;
precio[3] = 3.25m;
precio[4] = 3.00m;
precio[5] = 4.25m;
precio[6] = 6.70m;
precio[7] = 5.00m;
precio[8] = 3.30m;
precio[9] = 1.75m;
precio[10] = 3.99m;
precio[11] = 6.00m;
precio[12] = 15.25m;
precio[13] = 2.20m;

cantidad[0] = 220m;
cantidad[1] = 500m;
cantidad[2] = 440m;
cantidad[3] = 360m;
cantidad[4] = 77m;
cantidad[5] = 125m;
cantidad[6] = 57m;
cantidad[7] = 187m;
cantidad[8] = 110m;
cantidad[9] = 74m;
cantidad[10] = 80m;
cantidad[11] = 150m;
cantidad[12] = 43m;
cantidad[13] = 230m;


//Creación de la pantalla de Bienvenida
Console.Clear();
Console.WriteLine("\n                         *****      BIENVENIDO A LA TIENDA       *****");
Console.WriteLine("                         *****          SUPER PRECIOS            *****\n");
Console.WriteLine("                             ... Pulse una tecla para continuar ...");
Console.ReadKey();

//Menú de compras
Console.WriteLine("\n               **********            MENÚ DE COMPPRAS            **********\n");
Console.Write("#     PRODUCTO      ");
Console.Write("                          UNIDAD VENTA      ");
Console.Write("   PRECIO      ");
Console.WriteLine("    CANTIDAD   ");

for (int i = 0; i < 14; i++) {
    Console.WriteLine((i + 1) + "    " + productosParaMenu[i] + "       " + tipoCanPro[i] + "          $" + precio[i] + "           " + cantidad[i]);
}

Console.WriteLine("");

Console.Write("¿Qué producto desea comprar? (ingrese el número): ");
opCompra = Convert.ToInt32(Console.ReadLine());

do{
    if(opCompra >= 1 && opCompra <=14){
        switch(opCompra){
            case 1:
                Console.WriteLine("\nSeleccionó " + productos[0]);
                repetir = false;
                break;
            case 2: 
                Console.WriteLine("\nSeleccionó " + productos[1]);
                repetir = false;
                break;
            case 3: 
                Console.WriteLine("\nSeleccionó " + productos[2]);
                repetir = false;
                break;
            case 4: 
                Console.WriteLine("\nSeleccionó " + productos[3]);
                repetir = false;
                break;
            case 5: 
                Console.WriteLine("\nSeleccionó " + productos[4]);
                repetir = false;
                break;
            case 6: 
                Console.WriteLine("\nSeleccionó " + productos[5]);
                repetir = false;
                break;
            case 7: 
                Console.WriteLine("\nSeleccionó " + productos[6]);
                repetir = false;
                break;
            case 8: 
                Console.WriteLine("\nSeleccionó " + productos[7]);
                repetir = false;
                break;
            case 9: 
                Console.WriteLine("\nSeleccionó " + productos[8]);
                repetir = false;
                break;
            case 10: 
                Console.WriteLine("\nSeleccionó " + productos[9]);
                repetir = false;
                break;
            case 11: 
                Console.WriteLine("\nSeleccionó " + productos[10]);
                repetir = false;
                break;
            case 12: 
                Console.WriteLine("\nSeleccionó " + productos[11]);
                repetir = false;
                break;
            case 13: 
                Console.WriteLine("\nSeleccionó " + productos[12]);
                repetir = false;
                break;
            case 14: 
                Console.WriteLine("\nSeleccionó " + productos[13]);
                repetir = false;
                break;
            default:
                Console.WriteLine("\nOpción incorrecta.\n");
                Console.Write("Ingrese nuevamente una opción válida: ");
                opCompra = Convert.ToInt32(Console.ReadLine());
                break;
        }   
    }else{
        Console.WriteLine("\nOpción incorrecta.\n");
        Console.Write("Ingrese nuevamente una opción válida: ");
        opCompra = Convert.ToInt32(Console.ReadLine());
    }
}while(repetir == true);