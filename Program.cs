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
bool repetir = true, validarCompra = true, validarRepetirCompra = true;
char repetirCompra;

//Asignación de valores

tipoCanPro[0] = "lb.";
tipoCanPro[1] = "caj.";
tipoCanPro[2] = "paq.";
tipoCanPro[3] = "gal.";
tipoCanPro[4] = "bolsa";
tipoCanPro[5] = "ud.";

tipoCanProMenu[0] = "libras     ";
tipoCanProMenu[1] = "libras     ";
tipoCanProMenu[2] = "libras     ";
tipoCanProMenu[3] = "libras     ";
tipoCanProMenu[4] = "cajas      ";
tipoCanProMenu[5] = "paquetes   ";
tipoCanProMenu[6] = "galones    ";
tipoCanProMenu[7] = "bolsas     ";
tipoCanProMenu[8] = "bolsas     ";
tipoCanProMenu[9] = "paquetes   ";
tipoCanProMenu[10] = "paquetes   ";
tipoCanProMenu[11] = "unidades   ";
tipoCanProMenu[12] = "unidades   ";
tipoCanProMenu[13] = "paquetes   ";

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
        Console.WriteLine("\n               **********            MENÚ DE COMPPRAS            **********\n");
        Console.Write("#     PRODUCTO      ");
        Console.Write("                          UNIDAD VENTA      ");
        Console.Write("   PRECIO      ");
        Console.WriteLine("    CANTIDAD   ");

        for (int i = 0; i < 14; i++)
        {
            Console.WriteLine((i + 1) + "    " + productosParaMenu[i] + "       " + tipoCanProMenu[i] + "          $" + precio[i] + "           " + cantidad[i]);
        }

        Console.Write("\n¿Qué producto desea comprar? (Ingrese un número y si desea salir ingrese '0'): ");
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
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);

            }
            else if (cantidad[0] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[0] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[0] + " " + tipoCanPro[0] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántas libras desea comprar? (Ingrese '0' para salir):");
                    compraCan = Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[0])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[0] + " " + tipoCanPro[0] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[0] = cantidad[0] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[0] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[0] + compraCan + " " + tipoCanProMenu[0] + "            $" + precio[0] + "            $" + (precio[0] * compraCan);
                        Console.WriteLine("\nDisponemos de " + cantidad[0] + " " + tipoCanPro[0] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 2)
        {
            if (cantidad[1] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[1] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[1] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[1] + " " + tipoCanPro[0] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántas libras desea comprar? (Ingrese '0' para salir):");
                    compraCan = Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[1])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[1] + " " + tipoCanPro[0] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[1] = cantidad[1] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[1] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[1] + compraCan + " " + tipoCanProMenu[1] + "            $" + precio[1];
                        Console.WriteLine("\nDisponemos de " + cantidad[1] + " " + tipoCanPro[0] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 3)
        {
            if (cantidad[2] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[2] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[2] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[2] + " " + tipoCanPro[0] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántas libras desea comprar? (Ingrese '0' para salir):");
                    compraCan = Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[2])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[2] + " " + tipoCanPro[0] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[2] = cantidad[2] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[2] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[2] + compraCan + " " + tipoCanProMenu[2] + "            $" + precio[2];
                        Console.WriteLine("\nDisponemos de " + cantidad[2] + " " + tipoCanPro[0] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 4)
        {
            if (cantidad[3] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[3] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[3] + "\n");
                Console.WriteLine("Este producto se vende por libra.\n");
                Console.WriteLine("Disponemos de " + cantidad[3] + " " + tipoCanPro[0] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántas libras desea comprar? (Ingrese '0' para salir):");
                    compraCan = Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[3])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[3] + " " + tipoCanPro[0] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[3] = cantidad[3] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[3] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[3] + compraCan + " " + tipoCanProMenu[3] + "            $" + precio[3];
                        Console.WriteLine("\nDisponemos de " + cantidad[3] + " " + tipoCanPro[0] + "\n");
                    }
                } while (validarCompra == true);

                Console.Write("¿Desea realizar otra compra? (s/n): ");
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
            if (cantidad[4] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");
                
                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[4] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[4] + "\n");
                Console.WriteLine("Este producto se vende por caja.\n");
                Console.WriteLine("Disponemos de " + cantidad[4] + " " + tipoCanPro[1] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántas cajas desea comprar? (Ingrese '0' para salir):");
                    compraCan = (int) Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[4])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[4] + " " + tipoCanPro[1] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[4] = cantidad[4] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[4] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[4] + compraCan + " " + tipoCanProMenu[4] + "            $" + precio[4];
                        Console.WriteLine("\nDisponemos de " + cantidad[4] + " " + tipoCanPro[1] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 6)
        {
            if (cantidad[5] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");
                
                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[5] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[5] + "\n");
                Console.WriteLine("Este producto se vende por paquete.\n");
                Console.WriteLine("Disponemos de " + cantidad[5] + " " + tipoCanPro[2] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántos paquetes desea comprar? (Ingrese '0' para salir):");
                    compraCan = (int) Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[5])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[5] + " " + tipoCanPro[2] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[5] = cantidad[5] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[5] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[5] + compraCan + " " + tipoCanProMenu[5] + "            $" + precio[5];
                        Console.WriteLine("\nDisponemos de " + cantidad[5] + " " + tipoCanPro[2] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 7)
        {
            if (cantidad[6] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");
                
                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[6] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[6] + "\n");
                Console.WriteLine("Este producto se vende por galón.\n");
                Console.WriteLine("Disponemos de " + cantidad[6] + " " + tipoCanPro[3] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántos galones desea comprar?");
                    compraCan = (int) Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[6])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[6] + " " + tipoCanPro[3] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[6] = cantidad[6] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[6] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[6] + compraCan + " " + tipoCanProMenu[6] + "            $" + precio[6];
                        Console.WriteLine("\nDisponemos de " + cantidad[6] + " " + tipoCanPro[3] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 8)
        {
            if (cantidad[7] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");
                
                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[7] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[7] + "\n");
                Console.WriteLine("Este producto se vende por bolsa.\n");
                Console.WriteLine("Disponemos de " + cantidad[7] + " " + tipoCanPro[4] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántas bolsas desea comprar?");
                    compraCan = (int) Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[7])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[7] + " " + tipoCanPro[4] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[7] = cantidad[7] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[7] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[7] + compraCan + " " + tipoCanProMenu[7] + "            $" + precio[7];
                        Console.WriteLine("\nDisponemos de " + cantidad[7] + " " + tipoCanPro[4] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 9)
        {
            if (cantidad[8] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");
                
                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[8] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[8] + "\n");
                Console.WriteLine("Este producto se vende por bolsa.\n");
                Console.WriteLine("Disponemos de " + cantidad[8] + " " + tipoCanPro[4] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántas bolsas desea comprar?");
                    compraCan = (int) Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[8])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[8] + " " + tipoCanPro[4] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[8] = cantidad[8] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[8] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[8] + compraCan + " " + tipoCanProMenu[8] + "            $" + precio[8];
                        Console.WriteLine("\nDisponemos de " + cantidad[8] + " " + tipoCanPro[4] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 10)
        {
            if (cantidad[9] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");
                
                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[9] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[9] + "\n");
                Console.WriteLine("Este producto se vende por paquete.\n");
                Console.WriteLine("Disponemos de " + cantidad[9] + " " + tipoCanPro[2] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántos paquetes desea comprar? (Ingrese '0' para salir):");
                    compraCan = (int) Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[9])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[9] + " " + tipoCanPro[2] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[9] = cantidad[9] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[9] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[9] + compraCan + " " + tipoCanProMenu[9] + "            $" + precio[9];
                        Console.WriteLine("\nDisponemos de " + cantidad[9] + " " + tipoCanPro[2] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 11)
        {
            if (cantidad[10] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");
                
                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[10] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[10] + "\n");
                Console.WriteLine("Este producto se vende por paquete.\n");
                Console.WriteLine("Disponemos de " + cantidad[10] + " " + tipoCanPro[2] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántos paquetes desea comprar? (Ingrese '0' para salir):");
                    compraCan = (int) Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[10])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[10] + " " + tipoCanPro[2] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[10] = cantidad[10] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[10] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[10] + compraCan + " " + tipoCanProMenu[10] + "            $" + precio[10];
                        Console.WriteLine("\nDisponemos de " + cantidad[10] + " " + tipoCanPro[2] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 12)
        {
            if (cantidad[11] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");
                
                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[11] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[11] + "\n");
                Console.WriteLine("Este producto se vende por unidad.\n");
                Console.WriteLine("Disponemos de " + cantidad[11] + " " + tipoCanPro[5] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántas unidades desea comprar? (Ingrese '0' para salir):");
                    compraCan = (int) Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[11])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[11] + " " + tipoCanPro[5] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[11] = cantidad[11] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[11] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[11] + compraCan + " " + tipoCanProMenu[11] + "            $" + precio[11];
                        Console.WriteLine("\nDisponemos de " + cantidad[11] + " " + tipoCanPro[5] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 13)
        {
            if (cantidad[12] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");
                
                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[12] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[12] + "\n");
                Console.WriteLine("Este producto se vende por unidad.\n");
                Console.WriteLine("Disponemos de " + cantidad[12] + " " + tipoCanPro[5] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántas unidades desea comprar? (Ingrese '0' para salir):");
                    compraCan = (int) Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[12])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[12] + " " + tipoCanPro[5] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[12] = cantidad[12] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[12] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[12] + compraCan + " " + tipoCanProMenu[12] + "            $" + precio[12];
                        Console.WriteLine("\nDisponemos de " + cantidad[12] + " " + tipoCanPro[5] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
        else if (opCompra == 14)
        {
            if (cantidad[13] <= 0)
            {
                Console.WriteLine("\nLo sentimos, no podemos venderle este producto.\n");
                
                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
            else if (cantidad[13] > 0)
            {
                Console.WriteLine("\nSeleccionó " + productos[13] + "\n");
                Console.WriteLine("Este producto se vende por paquete.\n");
                Console.WriteLine("Disponemos de " + cantidad[13] + " " + tipoCanPro[2] + "\n");

                do
                {
                    Console.WriteLine("¿Cuántos paquetes desea comprar? (Ingrese '0' para salir):");
                    compraCan = (int) Convert.ToDecimal(Console.ReadLine());

                    if (compraCan == 0)
                    {
                        validarCompra = false;
                    }
                    if (compraCan < 0 || compraCan > cantidad[13])
                    {
                        Console.WriteLine("\nOpción inválida.\n");
                        Console.WriteLine("La cantidad de producto disponible es: " + cantidad[13] + " " + tipoCanPro[2] + "\n");
                        validarCompra = true;
                    }
                    else if (compraCan > 0)
                    {
                        cantidad[13] = cantidad[13] - compraCan;
                        validarCompra = false;
                        ComprasxCliente = ComprasxCliente + 1;
                        TotalCompra = TotalCompra + (precio[13] * compraCan);
                        carrito[ComprasxCliente] = "    " + productosParaMenu[13] + compraCan + " " + tipoCanProMenu[13] + "            $" + precio[13];
                        Console.WriteLine("\nDisponemos de " + cantidad[13] + " " + tipoCanPro[2] + "\n");
                    }
                } while (validarCompra == true);

                do
                {
                    Console.Write("¿Desea realizar otra compra? (s/n): ");
                    repetirCompra = Convert.ToChar(Console.ReadLine());

                    if (repetirCompra == 's')
                    {
                        Console.Clear();
                        validarRepetirCompra = true;
                    }
                    else if (repetirCompra == 'n')
                    {
                        repetir = false;
                        validarRepetirCompra = true;
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no válida. Debe ingresar solo 's' o 'n'.\n");
                        validarRepetirCompra = false;
                    }
                } while (validarRepetirCompra == false);
            }
        }
    }
} while (repetir == true);

//Recibo digital
Console.Clear();
Console.WriteLine("\n                         *****      RECIBO FINAL       *****");
Console.WriteLine("                         *****        SUPER PRECIOS      *****");
Console.WriteLine("                             ");
Console.Write("     PRODUCTO      ");
Console.Write("                   CANTIDAD");
Console.Write("                 PRECIO");
Console.Write("                 PRECIO TOTAL");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(carrito[i]);
}

Console.WriteLine("TOTAL                                                        $ " + TotalCompra);

Console.WriteLine("productos del cliente " + ComprasxCliente);