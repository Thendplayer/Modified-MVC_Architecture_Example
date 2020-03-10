using GameExample.TapCount;
using UnityEngine;

namespace GameExample
{
    public class MainInstaller : MonoBehaviour
    {
        [SerializeField] private TapCountInstaller _tapCountInstaller;
    
        private void Start()
        {
            _tapCountInstaller.Install();
        }
    }
}