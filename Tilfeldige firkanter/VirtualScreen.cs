namespace Tilfeldige_firkanter;

public class VirtualScreen
{
    private VirtualScreenRow[] _rows;

    public VirtualScreen(int width, int height)
    {
        _rows = new VirtualScreenRow[height];
        for (var i = 0; i < _rows.Length; i++)
        {
            _rows[i] = new VirtualScreenRow(width);
        }
    }

    public void Add(Box box)
    {
        var startX = box.X;
        var width = box.Width;
        var startY = box.Y;
        var height = box.Height;
        _rows[startY].AddBoxTopRow(startX, width);
        for (var i = startY + 1; i < height + startY; i++)
        {
            _rows[i].AddBoxMiddleRow(startX, width);
        }
        _rows[startY + height].AddBoxBottomRow(startX, width);
    }
    
    public void Show()
    {
        foreach (var row in _rows)
        {
            row.Show();
        }
    }
}