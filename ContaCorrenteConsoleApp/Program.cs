using System;

namespace ContaCorrenteConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();

            conta1.saldo = 1000;
            conta1.numero = 12;
            conta1.limite = 2000000;
            conta1.eEspecial = true;

            conta1.Sacar(200);

            conta1.Depositar(300);

            conta1.Depositar(500);

            conta1.Sacar(200);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 300;
            conta2.numero = 13;
            conta2.limite = 2000000;
            conta2.eEspecial = true;

            conta1.TransferirDeUmaContaParaOutra(conta2, 400);

            conta1.ExibirExatrato();
            
        }
    }
}
