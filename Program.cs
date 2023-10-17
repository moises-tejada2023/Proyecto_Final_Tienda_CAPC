//Uso de vectores para almacenar los productos
string[] productos = new string[14];
string[] productosParaMenu = new string[14];
decimal[] precio = new decimal[14];
decimal[] cantidad = new decimal[14];
string[] tipoCanPro = new string[6];
string[] tipoCanProMenu = new string[14];
string[] carrito = new string[10];
decimal TotalCompra = 0, compraCan = 0;
int opCompra, ComprasxCliente = 0;
bool repetir = true, validarCompra = true;
char? repetirCompra;

//Asignación de valores

tipoCanPro[0] = "lb";
tipoCanPro[1] = "caja";
tipoCanPro[2] = "paquete";
tipoCanPro[3] = "galón";
tipoCanPro[4] = "bolsa";
tipoCanPro[5] = "unidad";

tipoCanProMenu[0] = "lb         ";
tipoCanProMenu[1] = "lb         ";
tipoCanProMenu[2] = "lb         ";
tipoCanProMenu[3] = "lb         ";
tipoCanProMenu[4] = "caja       ";
tipoCanProMenu[5] = "paquete    ";
tipoCanProMenu[6] = "galón      ";
tipoCanProMenu[7] = "bolsa      ";
tipoCanProMenu[8] = "bolsa      ";
tipoCanProMenu[9] = "paquete    ";
tipoCanProMenu[10] = "paquete    ";
tipoCanProMenu[11] = "unidad     ";
tipoCanProMenu[12] = "unidad     ";
tipoCanProMenu[13] = "paquete    ";

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

do
{
    do
    {
        //Menú de compras
        Console.WriteLine(
            "\n               **********            MENÚ DE COMPPRAS            **********\n"
        );
        Console.Write("#     PRODUCTO      ");
        Console.Write("                          UNIDAD VENTA      ");
        Console.Write("   PRECIO      ");
        Console.WriteLine("    CANTIDAD   ");
        for (int i = 0; i < 14; i++)
        {
            Console.WriteLine(
                (i + 1)
                    + "    "
                    + productosParaMenu[i]
                    + "       "
                    + tipoCanProMenu[i]
                    + "          $"
                    + precio[i]
                    + "           "
                    + cantidad[i]
            );
        }
        Console.WriteLine("");
        Console.Write("¿Qué producto desea comprar? (ingrese el número): ");
        opCompra = Convert.ToInt32(Console.ReadLine());
    } while (opCompra <= 0 && opCompra >= 14);
    if (ComprasxCliente <= 10)
    {
        if (opCompra == 0)
        {
            Console.WriteLine("\nESPERAMOS QUE REGRESE PRONTO.");
            Console.WriteLine("... Pulse una tecla para salir ...");
            Console.ReadKey();
            repetir = false;
        }
        else if (opCompra == 1)
        {
            if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 2)
        {
            if (cantidad[1] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[1] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[1] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[1] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[1] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[1] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 3)
        {
             if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 4)
        {
           if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 5)
        {
           if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 6)
        {
          if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 7)
        {
           if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 8)
        {
          if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 9)
        {
           if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 10)
        {
           if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 11)
        {
          if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 12)
        {
            if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 13)
        {
           if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
        else if (opCompra == 14)
        {
           if (cantidad[0] <= 0)
            {
                Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do
                {
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if (compraCan == 0 || compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productos[0] + "                           " + compraCan + " " + tipoCanPro[0] + "            $" + precio[0];
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                } while (validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if (repetirCompra == 's')
                {
                    Console.Clear();
                }
                else if (repetirCompra == 'n')
                {
                    repetir = false;
                }
            }
        }
    }
    /*
    if(opCompra >= 1 && opCompra <=14){
        if (ComprasxCliente <=10)
        {
           switch(opCompra){
            case 1:
                if(cantidad[0] <= 0){
                    Console.WriteLine("Lo sentimos, no podemos venderle este producto.");
                    repetir=false;
                }else if(cantidad[0] > 0){
                    Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                    Console.WriteLine("Este producto se vende por libra.\n");
                    Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                do{
                    Console.Write("¿Cuántas libras desea comprar?");
                    compraCan = Convert.ToDecimal(Console.ReadLine());
                    if(compraCan == 0 || compraCan < 0){
                        Console.WriteLine("Opción inválida.");
                    }else if(compraCan > 0){
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente=ComprasxCliente+1;
                        Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + ".\n");
                    }
                }while(validarCompra == true);
                Console.Write("¿Desea realizar otra compra? (s/n)");
                repetirCompra = Convert.ToChar(Console.ReadLine());
                if(repetirCompra == 's'){
                    Console.Clear();
                    //Menú de compras
                    Console.WriteLine("\n               **********            MENÚ DE COMPPRAS            **********\n");
                    Console.Write("#     PRODUCTO      ");
                    Console.Write("                          UNIDAD VENTA      ");
                    Console.Write("   PRECIO      ");
                    Console.WriteLine("    CANTIDAD   ");
                    for (int i = 0; i < 14; i++) {
                        Console.WriteLine((i + 1) + "    " + productosParaMenu[i] + "       " + tipoCanProMenu[i] + "          $" + precio[i] + "           " + cantidad[i]);
                    }
                    Console.Write("¿Qué producto desea comprar? (ingrese el número): ");
                    opCompra = Convert.ToInt32(Console.ReadLine());
                }else if(repetirCompra == 'n'){
                    repetir = false;
                }
               // repetir = false;
                }
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
            Console.WriteLine("Alcanzo la cantidad maxima de productos que puede llevar");
        }
    }else{
        Console.WriteLine("\nOpción incorrecta.\n");
        Console.Write("Ingrese nuevamente una opción válida: ");
        opCompra = Convert.ToInt32(Console.ReadLine());
    }*/
} while (repetir == true);

//Recibo digital
Console.Clear();
Console.WriteLine("\n                         *****      RECIBO FINAL       *****");
Console.WriteLine("                         *****        SUPER PRECIOS      *****");
Console.WriteLine("                             ");
Console.Write("     PRODUCTO      ");
Console.Write("                          CANTIDAD      ");
Console.Write("   PRECIO      ");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(carrito[i]);
}
Console.WriteLine("TOTAL                                                        $ " + TotalCompra);

Console.WriteLine("productos del cliente " + ComprasxCliente);
