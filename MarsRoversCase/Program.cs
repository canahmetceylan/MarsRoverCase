using MarsRoversCase;


Console.WriteLine("Please enter rectangular plateau width. Etc('5 5')");
List<int>? maxPoints = Console.ReadLine()
    .Trim()
    .Split(' ')
    .Select(int.Parse)
    .ToList();

Console.WriteLine("Please enter start position. Etc('1 1 N')");
string[]? startPosition = Console.ReadLine()
                                 .Trim()
                                 .Split(' ');

var position = new Position();

if (startPosition != null && startPosition.Count() == 3)
{
    position.X = int.Parse(startPosition[0]);
    position.Y = int.Parse(startPosition[1]);
    position.Direction = (Direction)Enum.Parse(typeof(Direction), startPosition[2]);
}

Console.WriteLine("Please enter coordinates. Etc('MMRMMRR')");
var moveCoordinate = Console.ReadLine()
    .Trim()
    .ToUpper();

try
{
    if (!string.IsNullOrWhiteSpace(moveCoordinate))
    {
        position.StartMove(maxPoints, moveCoordinate);
        Console.WriteLine($"{position.X} {position.Y} {position.Direction.ToString()}");
    }
    else
    {
        Console.WriteLine("Coordinates cannot be null");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}