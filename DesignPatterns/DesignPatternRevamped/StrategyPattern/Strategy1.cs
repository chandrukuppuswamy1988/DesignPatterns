
namespace StrategyPattern
{
    public class Strategy1 : IStrategy
    {
        public int Move(Context c)
        {
            return ++c.Counter;
        }
    }


}
