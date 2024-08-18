// See https://aka.ms/new-console-template for more information

List<string> invited = new List<string>();
invited.Add("Bülent Ersoy");
invited.Add("Ajda Pekkan");
invited.Add("Ebru Gündeş");
invited.Add("Hadise");
invited.Add("Hande Yener");
invited.Add("Tarkan");
invited.Add("Funda Arar");
invited.Add("Demet Akalın");

Console.WriteLine("****** Invited People ******");

for (int i = 0; i < invited.Count(); i++)
{
    Console.Write((i + 1) + " - " + invited[i] + "\n");
}


