using UnityEngine;

public enum Direction
{
    N,
    NE,
    E,
    SE,
    S,
    SW,
    W,
    NW
}

public static class DirectionUtilities
{
    public static Vector2 ToVector2(this Direction dir)
    {
        switch (dir)
        {
            case Direction.N: return Vector2.up;
            case Direction.NE: return new Vector2(1f, 1f).normalized;
            case Direction.E: return Vector2.right;
            case Direction.SE: return new Vector2(1f, -1f).normalized;
            case Direction.S: return Vector2.down;
            case Direction.SW: return new Vector2(-1f, -1f).normalized;
            case Direction.W: return Vector2.left;
            case Direction.NW: return new Vector2(-1f, 1f).normalized;
            default: return Vector2.zero; 
        }
    }

    public static Direction Opposite(this Direction dir)
    {
        switch (dir)
        {
            case Direction.N: return Direction.S;
            case Direction.NE: return Direction.SW;
            case Direction.E: return Direction.W;
            case Direction.SE: return Direction.NW;
            case Direction.S: return Direction.N;
            case Direction.SW: return Direction.NE;
            case Direction.W: return Direction.E;
            case Direction.NW: return Direction.SE;
            default: return dir; 
        }
    }

    public static Direction GetRandomDirection()
    {
        Direction[] directions = (Direction[])System.Enum.GetValues(typeof(Direction));
        int randomIndex = Random.Range(0, directions.Length);
        return directions[randomIndex];
    }

}
