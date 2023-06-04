string fraseDigitada, fraseCorrigida;

Console.Write("Digite uma frase:");

fraseDigitada = Console.ReadLine()!;

fraseCorrigida = fraseDigitada;

    .replace("A", "4")
    .replace("a", "4")
    .replace("E", "3")
    .replace("e", "3")
    .replace("I", "1")
    .replace("i", "1")
    .replace("O", "0")
    .replace("o", "0")
    .replace("T", "7")
    .replace("t", "7")
    .replace("S", "5")
    .replace("s", "5");

Console.Write($"TEXTO TRADUZIDO {fraseCorrigida}");

