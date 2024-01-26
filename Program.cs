using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Coleções;
using CursoCSharp.OO;
using CursoCSharp.MétodosEFunções;
using CursoCSharp.Exceções;
using CursoCSharp.API;
using CursoCSharp.TópicosAvançados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                { "Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferências - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação de Pontos - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados! - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estruturas de Controle", EstruturaForEach.Executar},
                {"Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Classes E Metodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Parametros Variaveis - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Geters e Seters - Classes e Metodos", GetSet.Executar},
                {"Propriedades - Classes e Metodos", Props.Executar},
                {"Read Only - Classes e Metodos", Readonly.Executar},
                {"Enumerações - Classes e Metodos", ExempEnum.Executar},
                {"Struct - Classes e Metodos", ExempStruct.Executar},
                {"Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e Metodos", ValorVsReferência.Executar},
                {"Parâmetros por Referência - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parâmetros com valor padrão - Classes e Metodos", ParametrosPadrao.Executar},
                
                // Coleções
                {"Array - Coleções", Coleções.Array.Executar},
                {"Listas - Coleções", Listas.Executar},
                {"ArrayListas - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecaoStack.Executar},
                {"Dictionary - Coleções", ColecoesDicionario.Executar},

                //OO
                {"Herança - OO", Heranca.Executar },
                {"Construtor This - OO", ConstrutorThis.Executar },
                {"Encapsulamento - OO", OO.Encapsulamento.Executar },
                {"Polimorfismo - OO", Polimorfismo.Executar },
                {"Abstrasta - OO", Abstract.Executar },
                {"Interface - OO", Interface.Executar },
                {"Sealed - OO", Sealed.Executar },

                //Métodos e Funções
                {"Lambda! - Métodos e Funções", ExemploLambda.Executar },
                {"Delegate com Lambda - Métodos e Funções", LambdaDelegate.Executar },
                {"Delegate - Métodos e Funções", UsandoDelegate.Executar },
                {"Delegates com Funções Anônimas - Métodos e Funções", DelegateFuncAnonima.Executar },
                {"Delegates como parâmetros - Métodos e Funções", DelegatesComoParametros.Executar },
                {"Métodos De Extensão - Métodos e Funções", MetodosDeExtensao.Executar },

                //Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar },
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar },
                
                //Explorando API
                {"PrimeiroArquivo - API", PrimeiroArquivo.Executar },
                {"Lendo Arquivos - API", LendoArquivos.Executar },
                {"File Info! - API", ExemploFileInfo.Executar },
                {"Diretórios - API", Diretorios.Executar },
                {"Directory Info! - API", ExemploDirectoryInfo.Executar },
                {"Usando o Path - API", ExemploPath.Executar },
                {"Usando DataTime", ExemploDataTime.Executar },
                {"Usando TimeSpan", ExemploTimeSpan.Executar },
                
                //Tópicos Avançados
                {"LINQ1 - Tópicos Avançados", LINQ1.Executar },
                {"LINQ2 - Tópicos Avançados", LINQ2.Executar },
                {"Nullables - Tópicos Avançados", Nullables.Executar },
                {"Dynamics - Tópicos Avançados", Dynamics.Executar },
                {"Genericos - Tópicos Avançados", Genericos.Executar },
                
                //Testes
                
            });

            central.SelecionarEExecutar();
        }
    }
}