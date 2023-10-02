using System;
public class LevelLoadingData
{
    private int _level;

    public LevelLoadingData(int level)
        => _level = level;

    public int Level
    {
        get => _level;
        set
        {
            if(value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _level = value;
        }
    }
}
