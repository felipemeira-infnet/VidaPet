using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simulador de horários VidaPet");
        Console.WriteLine();

        Console.Write("Dia da semana (1 = segunda-feira, 2 = terça, 3 = quarta, 4 = quinta, 5 = sexta, 6 = sábado, 7 = domingo): ");
        bool diaEhInteiro = int.TryParse(Console.ReadLine(), out int diaSemana);

        Console.Write("Hora (0 a 23): ");
        bool horaEhInteira = int.TryParse(Console.ReadLine(), out int hora);

        Console.Write("Minuto (0 a 59): ");
        bool minutoEhInteiro = int.TryParse(Console.ReadLine(), out int minuto);

        bool entradasInteiras = diaEhInteiro && horaEhInteira && minutoEhInteiro;

        if (!entradasInteiras)
        {
            Console.WriteLine("Entrada inválida. Digite números inteiros para dia, hora e minuto.");
            return;
        }

        bool diaPermitido = diaSemana >= 1 && diaSemana <= 5;
        bool horaMinutoValidos = hora >= 0 && hora <= 23 && minuto >= 0 && minuto <= 59;

        int inicioConsulta = hora * 60 + minuto;
        int fimConsulta = inicioConsulta + 30;

        bool horarioPermitido = diaPermitido
            && horaMinutoValidos
            && inicioConsulta >= 8 * 60
            && fimConsulta <= 18 * 60;
            
        Console.WriteLine();

        if (horarioPermitido)
        {
            Console.WriteLine("Horário permitido");
            Console.WriteLine("A consulta tem duração de 30 minutos.");
        }
        else
        {
            Console.WriteLine("Horário não permitido");

            if (!diaPermitido)
            {
                Console.WriteLine("O atendimento ocorre somente de segunda a sexta-feira (dias de 1 a 5).");
            }
            else if (!horaMinutoValidos)
            {
                Console.WriteLine("Informe uma hora entre 0 e 23 e um minuto entre 0 e 59.");
            }
            else if (hora <= 7)
            {
                Console.WriteLine("O atendimento começa às 08h00.");
            }
            else
            {
                Console.WriteLine("A consulta deve terminar até as 18h00. O último início permitido é às 17h30.");
            }
        }
    }
}
