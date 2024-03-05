namespace Woningbouw;

class Program
{
    static void Main(string[] args)
    {
        //Etage._lift.Call(235);

        Etage[] flat = new Etage[40];
        for(int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage {EtageNummer = i};
        }
        flat[35].CallLift();
       // flat[28].CallLift();

        foreach(var et in flat)
        {
            et.ToonLiftStatus();
        }
    }
}
