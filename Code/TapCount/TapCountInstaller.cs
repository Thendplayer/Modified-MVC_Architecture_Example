using UnityEngine;

namespace GameExample.TapCount
{
    public class TapCountInstaller : MonoBehaviour
    {
        [SerializeField] private TapCountView _view;
    
        public void Install()
        {
            var model = new TapCountModel();
            var onTapValueChangeCommand = new OnTapCountValueChangeCommand(model);
            var mediator = new TapCountMediator(model, _view, onTapValueChangeCommand);
        }
    }
}