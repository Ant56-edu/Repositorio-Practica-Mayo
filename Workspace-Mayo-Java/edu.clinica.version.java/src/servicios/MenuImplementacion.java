package servicios;

import controladores.Inicio;

public class MenuImplementacion implements MenuInterfaz {
	OperativaInterfaz operativaInterfaz = new OperativaImplementacion();
    byte optUser = 0;

    public void mostrarMenu()
    {
        boolean esCerrado = false;
        do
        {
            System.out.println("----------------------------");
            System.out.println("1. Registrar llegada");
            System.out.println("2. Listado de consultas");
            System.out.println("----------------------------");
            optUser = Inicio.entrada.nextByte();
            switch (optUser)
            {
                case 1:
                    {
                        operativaInterfaz.registroLlegada();
                        break;
                    }
                case 2:
                    {
                        mostrarSubmenu();
                        break;
                    }
                default:
                    {
                        System.out.print("Esta opción no existe. Elija una de las mostradas en el menú.");
                        break;
                    }
            }
        } while (!esCerrado);
    }

    public void mostrarSubmenu()
    {
        boolean esCerrado = false;
        do
        {
        	System.out.println("----------------------------");
        	System.out.println("0. Volver");
        	System.out.println("1. Mostrar consultas");
        	System.out.println("2. Imprimir consultas");
        	System.out.println("----------------------------");
            optUser = Inicio.entrada.nextByte();
            switch (optUser)
            {
                case 0:
                    {
                        esCerrado = true;
                        break;
                    }
                case 1:
                    {
                        operativaInterfaz.mostrarConsultas();
                        esCerrado = true;
                        break;
                    }
                case 2:
                    {
                        operativaInterfaz.imprimirConsultas();
                        esCerrado = true;
                        break;
                    }
                default:
                    {
                        System.out.println("Esta opción no existe. Elija una de las mostradas en el menú.");
                        break;
                    }
            }
        } while (!esCerrado);
    }
}
