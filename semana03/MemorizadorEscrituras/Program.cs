using System;

class Program
{
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("Provérbios", 3, 5, 6);
        Escritura escritura = new Escritura(referencia,
            "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. " +
            "Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas.");

        // Laço principal (será preenchido na próxima etapa):
        // 1. Console.Clear() e mostrar escritura.ObterTexto()
        // 2. Ler a entrada: Enter oculta mais palavras, "sair" encerra
        // 3. Parar quando escritura.EstaCompletamenteOculta() for verdadeiro
    }
}
