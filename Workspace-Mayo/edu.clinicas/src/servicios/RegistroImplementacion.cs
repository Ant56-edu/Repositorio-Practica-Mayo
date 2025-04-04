using Controladores;
using Registros;

class RegistroImplementacion : IRegistroInterfaz
{
    public void LeerArchivo()
    {
        CitaDto cdto = new();
        foreach (string linea in File.ReadAllLines("citas.txt")) {
            String[] elementos = linea.Split(";");
            cdto.Id = Inicio.lista.Count;
            cdto.Dni = elementos[0];
            cdto.Nombre = elementos[1];
            String[] apellidosArray = elementos[2].Split();
            cdto.Apellido1 = apellidosArray[0];
            cdto.Apellido2 = apellidosArray[1];
            cdto.Consulta = elementos[3];
            cdto.FechaConsulta = DateTime.Parse(elementos[4]);
            cdto.Asistencia = Convert.ToBoolean(elementos[5]);
            Inicio.lista.Add(cdto);
        }
    }

    public void EscribirRegistro(CitaDto cita) {
        StreamWriter writer = new StreamWriter("citasConAsistencia-" + cita.FechaConsulta.ToString("dd-MM-yyyy") + "log.txt");
        writer.WriteLine(cita.ToString());
        writer.Close();
    }
}