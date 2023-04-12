namespace Tilfeldige_firkanter;

public class VirtualScreenCell
{
    public bool Up { get; private set; }
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }

    public VirtualScreenCell(bool up, bool down, bool left, bool right)
    {
        Up = up;
        Down = down;
        Left = left;
        Right = right;
    }
    public VirtualScreenCell()
    {
        Up = false;
        Down = false;
        Left = false;
        Right = false;
    }
    public char GetCharacter()
    {
        if (Up && Down && Left && Right)
        {
            return '┼';
        }
        if (Up && Down && Left)
        {
            return '┤';
        }

        if (Up && Down && Right)
        {
            return '├';
        }

        if (Up && Left && Right)
        {
            return '┴';
        }

        if (Down && Left && Right)
        {
            return '┬';
        }

        if (Up && Down)
        {
            return '│';
        }

        if (Left && Right)
        {
            return '─';
        }

        if (Up && Left)
        {
            return '┘';
        }

        if (Up && Right)
        {
            return '└';
        }

        if (Down && Left)
        {
            return '┐';
        }

        if (Down && Right)
        {
            return '┌';
        }
        return ' ';

    }

    public void AddHorizontal()
    {
        Left = true;
        Right = true;
    }
    
    public void AddVertical()
    {
        Up = true;
        Down = true;
    }

    public void AddLowerLeftCorner()
    {
        Up = true;
        Right = true;
    }

    public void AddUpperLeftCorner()
    {
        Down = true;
        Right = true;
    }

    public void AddUpperRightCorner()
    {
        Down = true;
        Left = true;
    }

    public void AddLowerRightCorner()
    {
        Up = true;
        Left = true;
    }
}