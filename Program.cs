namespace QueenAttack
{
  public class Program 
  {
    static void Main() 
    {
      // List<string> queenCoor;
      string[] queenCoor;
      string[] attackCoor;

      Console.WriteLine("Enter the coordinates of your queen [0,0]:");
      string queen = Console.ReadLine();
      queenCoor = queen.Split(",");
      string[] invalid = {"0", "w"};
      while (queenCoor.Length != 2 || !Board.CheckCoordinate(queenCoor[0], queenCoor[1]))
      {
        Console.WriteLine("COORDINATES INVALID!");
        Console.WriteLine("Enter the coordinates of your queen [0,0]:");
        queen = Console.ReadLine();
        queenCoor = queen.Split(",");
      }
      
      Console.WriteLine("Enter the coordinates of your attack [0,0]:");
      string attack = Console.ReadLine();
      attackCoor = attack.Split(",");
      while (attackCoor.Length != 2 || !Board.CheckCoordinate(attackCoor[0], attackCoor[1]))
      {
        Console.WriteLine("COORDINATES INVALID!");
        Console.WriteLine("Enter the coordinates of your attack [0,0]:");
        attack = Console.ReadLine();
        attackCoor = queen.Split(",");
      }

      if (Board.checkValid(int.Parse(queenCoor[0]), int.Parse(queenCoor[1]), int.Parse(attackCoor[0]), int.Parse(attackCoor[1])))
      {
        Console.WriteLine("Valid move");
      }
      else
      {
        Console.WriteLine("INVALID MOVE!");
      }
    }
  }
}