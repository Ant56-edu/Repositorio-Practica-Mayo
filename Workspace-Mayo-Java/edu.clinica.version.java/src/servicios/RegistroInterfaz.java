package servicios;

import dtos.CitaDto;

public interface RegistroInterfaz
{
	void leerArchivo();

	void escribirRegistro(CitaDto cita);

}
