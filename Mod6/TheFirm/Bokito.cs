
namespace TheFirm
{
    public class Bokito : IContract, IDoeIest
    {
        public void VoerUit()
        {
            Werkt();
        }
        void IDoeIest.VoerUit()
        {

        }

        public void Werkt()
        {
            System.Console.WriteLine("Bokito ramt secretaresses in elkaar");
        }
    }
}