public struct Semana4
{
    public string NombrePaciente;
    public DateTime FechaTurno;

    // Método estático para ejecutar el programa
    public static void run()
    {
        Agenda agenda = new Agenda(5); // Capacidad de 5 turnos

        // Agregar turnos
        agenda.AgregarTurno("Juan Pérez", new DateTime(2025, 1, 15, 9, 0, 0));
        agenda.AgregarTurno("María Gómez", new DateTime(2025, 1, 15, 10, 0, 0));

        // Mostrar agenda
        agenda.MostrarAgenda();
    }
}

public class Agenda
{
    private Semana4[] turnos; // Cambié Turno a Semana4
    private int contador;

    public Agenda(int capacidad)
    {
        turnos = new Semana4[capacidad];
        contador = 0;
    }

    public void AgregarTurno(string nombrePaciente, DateTime fechaTurno)
    {
        if (contador < turnos.Length)
        {
            turnos[contador] = new Semana4 { NombrePaciente = nombrePaciente, FechaTurno = fechaTurno };
            contador++;
            Console.WriteLine("Turno agregado con éxito.");
        }
        else
        {
            Console.WriteLine("Agenda llena, no se pueden agregar más turnos.");
        }
    }

    public void MostrarAgenda()
    {
        Console.WriteLine("\nAgenda de Turnos:");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"Paciente: {turnos[i].NombrePaciente}, Fecha: {turnos[i].FechaTurno}");
        }
    }
}

