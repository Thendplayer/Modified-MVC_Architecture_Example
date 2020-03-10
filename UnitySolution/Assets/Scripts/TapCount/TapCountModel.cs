using UniRx;

namespace GameExample.TapCount
{
    public class TapCountModel
    {
        public ReactiveProperty<int> TapCount;

        public TapCountModel()
        {
            TapCount = new ReactiveProperty<int>();
        }
    }
}