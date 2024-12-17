using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024]; //1KB

        // public override int Read(byte[] array, int offset, int count);

        Console.ReadLine();
    }
}