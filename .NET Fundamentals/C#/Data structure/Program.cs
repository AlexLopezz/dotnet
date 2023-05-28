Coords coordenadas = new Coords();
coordenadas.X = 12;
coordenadas.Y = 15;




public struct Coords
{
    public double X { get; set; }
    public double Y { get; set; }
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"{X}:{Y}";
}