Random rnd = new Random();

int[] sides = new int[10], cubeAreas = new int[10];
Console.WriteLine("Uzunluğu:     Alanı:");
for (int i = 0; i < sides.Length; i++)
{
    sides[i] = rnd.Next(1,10);
    cubeAreas[i] = sides[i] * sides[i];
    Console.WriteLine(sides[i] +"     ==>     " + cubeAreas[i]);
}

Console.ReadKey();