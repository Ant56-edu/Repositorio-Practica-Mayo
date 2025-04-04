package servicios;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;
import java.time.LocalDate;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;

import controladores.Inicio;
import dtos.CitaDto;

public class RegistroImplementacion implements RegistroInterfaz{
	public void LeerArchivo()
    {
        CitaDto cdto = new CitaDto();
        Path ruta = Paths.get("citas.txt");
        try {
			for (String linea : Files.readAllLines(ruta)) {
			    String[] elementos = linea.split(";");
			    cdto.setId(Inicio.lista.size());
			    cdto.setDni(elementos[0]);
			    cdto.setNombre(elementos[1]);
			    String[] apellidosArray = elementos[2].split(" ");
			    cdto.setApellido1(apellidosArray[0]);
			    cdto.setApellido2(apellidosArray[1]);
			    cdto.setConsulta(elementos[3]);
			    String[] fechaHora = elementos[4].split(" ");
			    LocalDate fecha = LocalDate.parse(fechaHora[0], DateTimeFormatter.ofPattern("dd-MM-yyyy"));
			    LocalTime hora = LocalTime.parse(fechaHora[1]);
			    cdto.setFechaConsulta(fecha.atTime(hora));
			    cdto.setAsistencia(Boolean.parseBoolean(elementos[5]));
			    Inicio.lista.add(cdto);
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
    }

    public void EscribirRegistro(CitaDto cita) {
        Path ruta = Paths.get("citasConAsistencia-" + Integer.toString(cita.getFechaConsulta().getDayOfMonth()) + Integer.toString(cita.getFechaConsulta().getMonthValue()) + Integer.toString(cita.getFechaConsulta().getYear()) + "log.txt");
        try {
			Files.write(ruta, cita.toString().getBytes(), StandardOpenOption.APPEND);
		} catch (IOException e) {
			try {
				Files.write(ruta, cita.toString().getBytes());
			} catch (IOException f) {
				System.err.println("Ha ocurrido un error al escribir en " + e.getMessage());
			}
		}
    }
}
















