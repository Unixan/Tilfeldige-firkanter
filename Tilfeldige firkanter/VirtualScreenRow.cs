namespace Tilfeldige_firkanter;

public class VirtualScreenRow
{
    private VirtualScreenCell[] _cells;

    public VirtualScreenRow(int screenWidth)
    {
        _cells = new VirtualScreenCell[screenWidth];
        for (var i = 0; i < _cells.Length; i++)
        {
            _cells[i] = new VirtualScreenCell();
        }
    }

    public void AddBoxTopRow(int boxX, int boxWidth)
    {
        var endCorner = boxX + boxWidth - 1;
        _cells[boxX].AddUpperLeftCorner();
        _cells[endCorner].AddUpperRightCorner();
        for (var i = boxX + 1; i < endCorner; i++)
        {
            _cells[i].AddHorizontal();
        }
    }

    public void AddBoxMiddleRow(int boxX, int boxWidth)
    {
        var endWall = boxX + boxWidth - 1;
        _cells[boxX].AddVertical();
        _cells[endWall].AddVertical();
    }

    public void AddBoxBottomRow(int boxX, int boxWidth)
    {
        var endCorner = boxX + boxWidth -1 ;
        _cells[boxX].AddLowerLeftCorner();
        _cells[endCorner].AddLowerRightCorner();
        for (var i = boxX + 1; i < endCorner; i++)
        {
            _cells[i].AddHorizontal();
        }
    }

    public void Show()
    {
        foreach (var cell in _cells)
        {
            Console.Write(cell.GetCharacter());
        }
        Console.WriteLine();
    }
}