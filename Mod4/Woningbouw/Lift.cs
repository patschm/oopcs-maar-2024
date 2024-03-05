namespace Woningbouw;

public class Lift
{
    private int _currentFloor = 0;

    public int CurrentFloor
    {
        get 
        { 
            return _currentFloor;
        }
    }
    public void Call(int floor)
    {
        System.Console.WriteLine("Zzzzzzz...");
        _currentFloor = floor;
    }
}
