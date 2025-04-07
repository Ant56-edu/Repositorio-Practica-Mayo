package controladores;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import dtos.CitaDto;
import servicios.MenuImplementacion;
import servicios.MenuInterfaz;
import servicios.RegistroInterfaz;
import servicios.RegistroImplementacion;

public class Inicio {

	
    public static List<CitaDto> lista = new ArrayList<>();
    public static Scanner entrada = new Scanner(System.in);
	
	public static void main(String[] args) {
		
		MenuInterfaz menuInterfaz = new MenuImplementacion();
	    RegistroInterfaz registroInterfaz = new RegistroImplementacion();
	    
	    registroInterfaz.LeerArchivo();
        menuInterfaz.MostrarMenu();
	    
	}

}
