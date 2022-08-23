using System;
{
    int[] age = { 18, 18, 16, 18, 29, 26, 18, 20, 17, 17, 39, 21, 25, 30, 17, 57 };
    int[] shoesize = { 43, 41, 48, 44, 42, 44, 43, 45, 42, 43, 50, 43, 42, 42, 46, 45 };
    double sum = 0;
    double sum2 = 0;
    for (int i = 0; i < age.Length; i++)
    {
      sum += age[i];
      sum2 += shoesize[i];
    }

//gennemsnitsalder = summen af tal (se int sum. age.sum) / antal af tal (length)
    Console.WriteLine("Gennemsnitsalder: ");
    Console.WriteLine(sum / age.Length);
    Console.WriteLine("-------------");
//gennemsnit af skostørrelse = sum af tal / antal af tal (length)
    Console.WriteLine("");
    Console.WriteLine("Gennemsnit af Skostørrelse: ");
    Console.WriteLine(sum2 / shoesize.Length);
    Console.WriteLine("-------------");

}
/* alternativer:
Console.WriteLine ("alder" + (sum /age.Length) + "\n-------");
Console.WriteLine ($"alder {sum /age.Length} \n------"); 
*/