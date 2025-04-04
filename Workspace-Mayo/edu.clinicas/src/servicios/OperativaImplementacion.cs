using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Globalization;
using Controladores;
using Servicios;
using Registros;

class OperativaImplementacion : IOperativaInterfaz
{

    IRegistroInterfaz registroInterfaz = new RegistroImplementacion();

    public void ImprimirConsultas()
    {
        byte optUser = 0;
        bool esCerrado = false;
        bool encontrado = false;
        string especialidad;
        do
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("0. Psicología");
            Console.WriteLine("1. Traumatología");
            Console.WriteLine("2. Fisioterapia");
            Console.WriteLine("-------------------");

            optUser = Convert.ToByte(Console.ReadLine());
            switch (optUser)
            {
                case 0:
                    {
                        Console.WriteLine("Elija una fecha (dd/MM/yyyy):");
                        string fecha = Console.ReadLine();
                        especialidad = "Psicología";
                        foreach (CitaDto cita in Inicio.lista)
                        {
                            if (cita.FechaConsulta.Date == DateTime.ParseExact(fecha, "dd/MM/yyyy", null).Date &&
                                cita.Consulta.Equals(especialidad))
                            {
                                registroInterfaz.EscribirRegistro(cita);
                                encontrado = true;
                                break;
                            }
                            else
                            {
                                encontrado = false;
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");
                        }
                        esCerrado = true;
                        break;
                    }

                case 1:
                    {
                        Console.WriteLine("Elija una fecha (dd/MM/yyyy):");
                        string fecha = Console.ReadLine();
                        especialidad = "Traumatología";
                        foreach (CitaDto cita in Inicio.lista)
                        {
                            if (cita.FechaConsulta.Date == DateTime.ParseExact(fecha, "dd/MM/yyyy", null).Date &&
                                cita.Consulta.Equals(especialidad))
                            {
                                registroInterfaz.EscribirRegistro(cita);
                                encontrado = true;
                                break;
                            }
                            else
                            {
                                encontrado = false;
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");
                        }
                        esCerrado = true;
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Elija una fecha (dd/MM/yyyy):");
                        string fecha = Console.ReadLine();
                        especialidad = "Fisioterapia";
                        foreach (CitaDto cita in Inicio.lista)
                        {
                            if (cita.FechaConsulta.Date == DateTime.ParseExact(fecha, "dd/MM/yyyy", null).Date &&
                                cita.Consulta.Equals(especialidad))
                            {
                                registroInterfaz.EscribirRegistro(cita);
                                encontrado = true;
                                break;
                            }
                            else
                            {
                                encontrado = false;
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");
                        }
                        esCerrado = true;
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Esta opción no existe. Elija una de las mostradas en el menú.");
                        break;
                    }
            }

        } while (!esCerrado);
    }

    public void MostrarConsultas()
    {
        byte optUser = 0;
        bool esCerrado = false;
        bool encontrado = false;
        string especialidad;
        do
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("0. Psicología");
            Console.WriteLine("1. Traumatología");
            Console.WriteLine("2. Fisioterapia");
            Console.WriteLine("-------------------");
            optUser = Convert.ToByte(Console.ReadLine());
            switch (optUser)
            {
                case 0:
                    {
                        Console.WriteLine("Elija una fecha (dd/MM/yyyy):");
                        string fecha = Console.ReadLine();
                        especialidad = "Psicología";
                        foreach (CitaDto cita in Inicio.lista)
                        {
                            if (cita.FechaConsulta.Date == DateTime.ParseExact(fecha, "dd/MM/yyyy", null).Date &&
                                cita.Consulta.Equals(especialidad))
                            {
                                Console.WriteLine(cita.ToString());
                                encontrado = true;
                                break;
                            }
                            else
                            {
                                encontrado = false;
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");
                        }
                        esCerrado = true;
                        break;
                    }

                case 1:
                    {
                        Console.WriteLine("Elija una fecha (dd/MM/yyyy):");
                        string fecha = Console.ReadLine();
                        especialidad = "Traumatología";
                        foreach (CitaDto cita in Inicio.lista)
                        {
                            if (cita.FechaConsulta.Date == DateTime.ParseExact(fecha, "dd/MM/yyyy", null).Date &&
                                cita.Consulta.Equals(especialidad))
                            {
                                Console.WriteLine(cita.ToString());
                                encontrado = true;
                                break;
                            }
                            else
                            {
                                encontrado = false;
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");
                        }
                        esCerrado = true;
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Elija una fecha (dd/MM/yyyy):");
                        string fecha = Console.ReadLine();
                        especialidad = "Fisioterapia";
                        foreach (CitaDto cita in Inicio.lista)
                        {
                            if (cita.FechaConsulta.Date == DateTime.ParseExact(fecha, "dd/MM/yyyy", null).Date &&
                                cita.Consulta.Equals(especialidad))
                            {
                                Console.WriteLine(cita.ToString());
                                encontrado = true;
                                break;
                            }
                            else
                            {
                                encontrado = false;
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");
                        }
                        esCerrado = true;
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Esta opción no existe. Elija una de las mostradas en el menú.");
                        break;
                    }

            }
        } while (!esCerrado);
    }

    public void RegistroLlegada()
    {
        Boolean encontrado = false;
        Boolean cerrado = false;
        do
        {
            Console.WriteLine("Introduzca su DNI: ");
            string dni = Console.ReadLine();
            if (VerificarDni(dni) == true)
            {
                foreach (CitaDto cita in Inicio.lista)
                {
                    if (cita.Dni == dni)
                    {
                        Console.WriteLine("Espere su turno para la consulta de " + cita.Consulta + " en la sala de espera. Su especialista le avisará.");
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("No dispone de cita previa para hoy.");
                }

                cerrado = true;
            }
            else
            {
                Console.WriteLine("Este DNI no es válido.");
            }
        } while (!cerrado);
    }

    public Boolean VerificarDni(String dniAComprobar)
    {
        Boolean valido;

        char[] letraDni = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V',
                'H', 'L', 'C', 'K', 'E' };

        String num = "";


        if (dniAComprobar.Length == 8)
        {
            dniAComprobar = "0" + dniAComprobar;
        }

        if (!char.IsLetter(dniAComprobar[8]))
        {
            valido = false;
        }

        if (dniAComprobar.Length != 9)
        {
            valido = false;
        }

        for (int i = 0; i < 8; i++)
        {

            if (!char.IsDigit(dniAComprobar[i]))
            {
                valido = false;
            }

            num += dniAComprobar[i];
        }

        int ind = Int32.Parse(num);
        ind %= 23;

        if (char.ToUpper(dniAComprobar[8]) != letraDni[ind])
        {
            valido = false;
        }
        valido = true;

        return valido;
    }
}