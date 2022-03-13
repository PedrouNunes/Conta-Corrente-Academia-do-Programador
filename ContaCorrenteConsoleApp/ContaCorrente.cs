using System;

namespace ContaCorrenteConsoleApp
{
    internal partial class Program
    {
        public class ContaCorrente
        {
           public int numero;
           public double saldo;
           public double limite;
           public bool eEspecial;
           public Movimentacao[] movimentacoes = new Movimentacao[100];

            public void Depositar(double quantidade)
            {
                this.saldo += quantidade;
                Movimentacao objeto = new Movimentacao();
                objeto.tipo = TipoMovimentacao.credito;
                objeto.tipo2 = TipoAcao.depositar;
                objeto.valor = quantidade;

                for (int i = 0; i < movimentacoes.Length; i++)
                {
                    if (movimentacoes[i] == null)
                    {
                        movimentacoes[i] = objeto;
                        break;
                    }
                }
            }

            public bool Sacar(double valor)
            {
            
                if (this.limite < valor)
                {

                    return false;
                }
                else
                {
                    this.saldo = this.saldo - valor;
                    Movimentacao objeto = new Movimentacao();
                    objeto.tipo = TipoMovimentacao.credito;
                    objeto.tipo2 = TipoAcao.sacar;
                    objeto.valor = valor;

                    for (int i = 0; i < movimentacoes.Length; i++)
                    {
                        if (movimentacoes[i] == null)
                        {
                            movimentacoes[i] = objeto;
                            break;
                        }
                    }
                }
                return true;
            }

            public bool TransferirDeUmaContaParaOutra(ContaCorrente destino, double valor)
            {
                bool retirou = this.Sacar(valor);
                if (retirou == true)
                {
                    return false;
                }
                else
                {
                    destino.Depositar(valor);
                    return true;
                }
            }

          
            public void ExibirExatrato()
            {
                Console.WriteLine("Saldo da conta: R$" + this.saldo);
                Console.WriteLine();

                Console.WriteLine("Tipo da Ação(tipo da movimentação) - valor da movimentação ");

                for (int i = 0; i < movimentacoes.Length; i++)
                {
                    if(movimentacoes[i] != null)
                    {
                        Console.WriteLine(movimentacoes[i].tipo2 + " (" + movimentacoes[i].tipo + ") - " + movimentacoes[i].valor);
                        
                    }
                }
            }
        }
        }
    }

