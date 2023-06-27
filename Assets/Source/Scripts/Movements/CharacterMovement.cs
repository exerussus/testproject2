
using Source.Scripts.Constants;
using Source.Scripts.Tools;
using UnityEngine;

namespace Source.Scripts.Movements
{
    public class CharacterMovement : Movements
    {
        [SerializeField] private Animator _animator;
        private float _currentSpeedDirection;
        private float _currentAxisH;
        private float _currentAxisV;

        private void Start()
        {
            Cursor.visible = false;
        }

        protected override void Move(float verticalAxis, float horizontalAxis, bool isSpeedModeOn)
        {
            _currentAxisH = GradualChanger.GetGradualChange(_currentAxisH, horizontalAxis, 
                decreaseMultiply: 2f,
                increaseMultiply: 2f);
            _currentAxisV = GradualChanger.GetGradualChange(_currentAxisV, verticalAxis, 
                decreaseMultiply: 2f,
                increaseMultiply: 2f);
            
            var directionVector = new Vector3(_currentAxisV, 0, _currentAxisH);
            var fixedDirectionVector = Vector3.ClampMagnitude(directionVector, 1);

            _animator.SetFloat(Parameters.AxisH, _currentAxisH);
            _animator.SetFloat(Parameters.AxisV, _currentAxisV);
            _animator.SetFloat(Parameters.MovementSpeed, fixedDirectionVector.magnitude);
        }

        protected override void Rotate(float mouseAxisX)
        {
            transform.Rotate(0, mouseAxisX, 0);
        }
    }
}
