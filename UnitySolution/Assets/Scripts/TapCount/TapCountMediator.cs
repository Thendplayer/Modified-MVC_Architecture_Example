using UniRx;

namespace GameExample.TapCount
{
    public class TapCountMediator
    {
        public TapCountMediator(
            TapCountModel model, 
            TapCountView view,
            OnTapCountValueChangeCommand onTapCountValueChangeCommand
        )
        {
            view.ButtonClickedEvent.AsObservable().Subscribe(u =>
            {
                onTapCountValueChangeCommand.Execute();
            });

            model.TapCount.AsObservable().Subscribe(value =>
            {
                view.SetCountValue(value);
            });
        }
    }
}