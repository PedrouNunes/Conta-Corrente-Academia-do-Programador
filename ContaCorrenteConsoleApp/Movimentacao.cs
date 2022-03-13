namespace ContaCorrenteConsoleApp
{
    internal partial class Program
    {
        public class Movimentacao
        {
            public double valor;
            public TipoMovimentacao tipo;
            public TipoAcao tipo2;

        }
        public enum TipoMovimentacao
        {
            credito, debito
        }
        public enum TipoAcao
        {
            sacar, depositar, transferir
        }
    }
    }

