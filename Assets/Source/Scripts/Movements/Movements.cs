
using UnityEngine;
namespace Source.Scripts.Movements
{
    public abstract class Movements : MonoBehaviour
    {
        [SerializeField] private KeyListener.KeyListener _keyListener;

        private void OnEnable()
        {
            _keyListener.OnAxisChange += Move;
        }

        private void OnDisable()
        {
            _keyListener.OnAxisChange -= Move;
        }

        protected abstract void Move(float verticalAxis, float horizontalAxis);
    }
}
