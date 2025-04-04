
using System;
public class CitaDto
{
    long id;
    string nombre = "aaaaa";
    string apellido1 = "aaaaa";
    string apellido2 = "aaaaa";

    string dni = "aaaaa";
    string consulta = "aaaaa";

    DateTime fechaConsulta;

    Boolean asistencia = false;
    public override String ToString()
    {
        return "Nombre completo: " + nombre + " " + apellido1 + " " + apellido2 + ", Hora: " + fechaConsulta.ToString("hh:mm");
    }

    public long Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido1 { get => apellido1; set => apellido1 = value; }
    public string Apellido2 { get => apellido2; set => apellido2 = value; }
    public string Dni { get => dni; set => dni = value; }
    public string Consulta { get => consulta; set => consulta = value; }
    public DateTime FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
    public bool Asistencia { get => asistencia; set => asistencia = value; }
}