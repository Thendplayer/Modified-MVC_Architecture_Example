using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameExample.TapCount
{
    public class TapCountView : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private TextMeshProUGUI _countText;

        public Button.ButtonClickedEvent ButtonClickedEvent => _button.onClick;

        public void SetCountValue(int value)
        {
            _countText.text = value.ToString();
        }
    }
}