using UnityEngine;
using UnityEngine.Events;

namespace Source.Scripts.Coin
{
    public class ClickDetector : MonoBehaviour
    {
        public UnityEvent onClick;

        private void OnMouseDown()
        {
            onClick.Invoke();
        }
    }
}
