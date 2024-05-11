using StrategyPattern;

namespace StatePattern
{
    public class NormalState : IState
    {

        public int MoveUp(Context context)
        {
            context.Counter += 2;
            return context.Counter;
        }

        public int MoveDown(Context context)
        {
            if (context.Counter < Context.limit)
            {
                context.State = new FastState();
                Console.Write("|| ");
            }
            context.Counter -= 2;
            return context.Counter;
        }
    }
}
