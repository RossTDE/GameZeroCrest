using Crestic;

//Это пока оооооочень приблизительный набросок

Coord Computer(Field pole)
{
    byte x, y;
    Random rand = new Random();

    do
    {
        x = (byte)rand.Next(0, 3);
        y = (byte)rand.Next(0, 3);
    } while (pole.field[x, y] != 0);

    return new Coord(x, y);
}

Field pole = new Field();
Coord Pcoord = new Coord(0,0);
Coord Ccoord;

do
{

    Console.Write("Enter first coord: ");
    Pcoord.x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second coord: ");
    Pcoord.y = Convert.ToInt32(Console.ReadLine());
    pole.field[Pcoord.x, Pcoord.y] = 1;

    Ccoord = Computer(pole);
    pole.field[Ccoord.x, Ccoord.y] = 2;
    pole.Print();

} while (true);