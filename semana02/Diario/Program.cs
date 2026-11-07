using System;

// INDO ALÉM DOS REQUISITOS:
// 1. O diário é salvo como um arquivo .csv de verdade, que abre direto no
//    Excel: vírgulas e aspas dentro das respostas são tratadas corretamente,
//    o arquivo tem cabeçalho (Data, Pergunta, Resposta), a linha "sep=," faz
//    o Excel em português reconhecer as colunas e o UTF-8 com BOM mantém
//    os acentos.
// 2. As perguntas não se repetem: o gerador sorteia sem repetição até usar
//    todas, e só então recomeça. Isso evita a sensação de "de novo essa?".
// 3. Ao sair, se houver entradas que ainda não foram salvas, o programa
//    pergunta se o usuário quer salvar antes, para não perder o que escreveu.

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDeComando gerador = new GeradorDeComando();
        bool temAlteracoesNaoSalvas = false;
        string escolha = "";

        Console.WriteLine("Bem-vindo ao Programa de Diário!");

        while (escolha != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");
            escolha = Console.ReadLine() ?? "";

            if (escolha == "1")
            {
                string comando = gerador.ObterComandoAleatorio();
                Console.WriteLine(comando);
                Console.Write("> ");
                string resposta = Console.ReadLine() ?? "";

                Entrada novaEntrada = new Entrada();
                novaEntrada._data = DateTime.Now.ToShortDateString();
                novaEntrada._textoComando = comando;
                novaEntrada._textoEntrada = resposta;

                diario.AdicionarEntrada(novaEntrada);
                temAlteracoesNaoSalvas = true;
            }
            else if (escolha == "2")
            {
                diario.ExibirTodas();
            }
            else if (escolha == "3")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string arquivo = Console.ReadLine() ?? "";

                if (diario.CarregarDeArquivo(arquivo))
                {
                    temAlteracoesNaoSalvas = false;
                }
            }
            else if (escolha == "4")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string arquivo = Console.ReadLine() ?? "";

                diario.SalvarEmArquivo(arquivo);
                temAlteracoesNaoSalvas = false;
            }
            else if (escolha == "5")
            {
                if (temAlteracoesNaoSalvas)
                {
                    Console.Write("Você tem entradas não salvas. Deseja salvar antes de sair? (s/n) ");
                    string salvar = Console.ReadLine() ?? "";

                    if (salvar.ToLower() == "s")
                    {
                        Console.Write("Qual é o nome do arquivo? ");
                        string arquivo = Console.ReadLine() ?? "";
                        diario.SalvarEmArquivo(arquivo);
                    }
                }

                Console.WriteLine("Até a próxima!");
            }
            else
            {
                Console.WriteLine("Opção inválida. Digite um número de 1 a 5.");
            }
        }
    }
}
