namespace MarsRoversCase;

public class Position : IPosition
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
    public Direction Direction { get; set; } = Direction.N;


    private void TurnLeft()
    {
        switch (this.Direction)
        {
            case Direction.N:
                this.Direction = Direction.W;
                break;
            case Direction.S:
                this.Direction = Direction.E;
                break;
            case Direction.E:
                this.Direction = Direction.N;
                break;
            case Direction.W:
                this.Direction = Direction.S;
                break;
            default:
                break;
        }
    }

    private void TurnRight()
    {
        switch (this.Direction)
        {
            case Direction.N:
                this.Direction = Direction.E;
                break;
            case Direction.S:
                this.Direction = Direction.W;
                break;
            case Direction.E:
                this.Direction = Direction.S;
                break;
            case Direction.W:
                this.Direction = Direction.N;
                break;
            default:
                break;
        }
    }

    public void Move()
    {
        switch (this.Direction)
        {
            case Direction.N:
                this.Y++;
                break;
            case Direction.S:
                this.Y--;
                break;
            case Direction.E:
                this.X++;
                break;
            case Direction.W:
                this.X--;
                break;
            default:
                break;
        }
    }

    public void StartMove(List<int> maxPoint, string moves)
    {
        foreach (var move in moves)
        {
            switch (move)
            {
                case 'M':
                    this.Move();
                    break;
                case 'L':
                    this.TurnLeft();
                    break;
                case 'R':
                    this.TurnRight();
                    break;
                default:
                    throw new InvalidDataException($"Invalid data type {move}");
            }
        }
    }
}
