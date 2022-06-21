namespace exercicio_01_mesa_13
{
    internal class Program
    {
       
           enum ErrorCode : ushort
        {
            Ok = 200,
            Redirecionamento_Permanente = 301,
            Redirecionamento_Temporario = 302,
            Nao_Encontrado = 404,
            NaoAutorizado = 405,
            ServidorIndisponivel = 503,
            TempoEsgotado = 504
        };
    }
    }
