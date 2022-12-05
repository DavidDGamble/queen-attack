namespace QueenAttack
{
  public class Board
  {

    public static bool CheckCoordinate(string x, string y)
    {
      try {
        int newX = int.Parse(x);
        int newY = int.Parse(y);
        return (newX >= 0 && newX <= 8 && newY >= 0 && newY <= 8);
      } catch {
        return false;
      }
    }
    public static bool CheckHorAndVer(int start, int end)
    {
      return start == end;
    }

    public static bool CheckDiagonal(int startX, int startY, int endX, int endY, bool incX, bool incY)
    {
      bool isValid = false;
      int curStartX = startX;
      int curStartY = startY;
      while (CheckCoordinate(curStartX.ToString(), curStartY.ToString()))
      {
        if (curStartX == endX && curStartY == endY)
        {
          isValid = true;
        }
        if (incX)
        {
          curStartX++;
        }
        else
        {
          curStartX--;
        }
        if (incY)
        {
          curStartY++;
        }
        else
        {
          curStartY--;
        }
      }
      return isValid;
    }
    public static bool checkValid(int startX, int startY, int endX, int endY)
    {
      bool horiz = CheckHorAndVer(startX, endX);
      bool vert = CheckHorAndVer(startY, endY);
      bool diag = false;

      bool[,] dirs = new bool[,] { { true, true }, { true, false }, { false, true }, { false, false } };
      for (int d = 0; d < 4; d++) {
        if (CheckDiagonal(startX, startY, endX, endY, dirs[d, 0], dirs[d, 1]))
        {
          diag = true;
        }
      }
      if (horiz || vert || diag)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}