namespace GameExample.TapCount
{
    public class OnTapCountValueChangeCommand
    {
        private readonly TapCountModel _model;

        public OnTapCountValueChangeCommand(TapCountModel model)
        {
            _model = model;
        }

        public void Execute()
        {
            _model.TapCount.Value++;
        }
    }
}