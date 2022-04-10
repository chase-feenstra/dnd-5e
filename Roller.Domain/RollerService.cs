namespace Roller.Domain
{
    public interface IRollerService
    {
        int[] Roll(int times, int dice);
    }
    public class RollerService : IRollerService
    {
        public int[] Roll(int times, int dice)
        {
            var result = new List<int>();
            while(times > 0)
            {
                result.Add(new Random().Next(1, dice));
                times--;
            }

            return result.ToArray();
        }
    }
}