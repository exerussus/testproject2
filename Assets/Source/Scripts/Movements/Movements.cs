
using UnityEngine;
namespace Source.Scripts.Movements
{
    public abstract class Movements : MonoBehaviour
    {
        [SerializeField] private KeyListener.KeyListener _keyListener;

        private void OnEnable()
        {
            _keyListener.OnAxisChange += Move;
            _keyListener.OnRotation += Rotate;
            _keyListener.OnJump += Jump;
        }

        private void OnDisable()
        {
            _keyListener.OnAxisChange -= Move;
            _keyListener.OnRotation -= Rotate;
            _keyListener.OnJump -= Jump;
        }

        protected abstract void Move(float verticalAxis, float horizontalAxis, bool isSpeedModOn);
        protected abstract void Rotate(float mouseAxisX);
        protected abstract void Jump();
    }
}
