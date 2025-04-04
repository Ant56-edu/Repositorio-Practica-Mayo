using System;
using Registros;
using Servicios;

namespace Controladores {

class Inicio {
        static IMenuInterfaz menuInterfaz = new MenuImplementacion();
        static IRegistroInterfaz registroInterfaz = new RegistroImplementacion();
        public static List<CitaDto> lista = [];
        static void Main(String[] args)
        {
            registroInterfaz.LeerArchivo();
            menuInterfaz.MostrarMenu();
        }
}

}