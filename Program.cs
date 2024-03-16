string tex = "a";
Console.WriteLine("----------------- Soletrar -----------------");
Console.WriteLine("Digite a palavra que quer soletrar: ");
tex = Console.ReadLine()!.ToUpper();
Console.WriteLine(
 String.Join("-",tex.ToCharArray()));