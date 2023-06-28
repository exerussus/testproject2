
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

        protected override void Move(float verticalAxis, float horizontalAxis, bool isSpeedModeOn)
        {
            _currentAxisH = GradualChanger.GetGradualChange(_currentAxisH, horizontalAxis, 
                decreaseMultiply: 2f,
                increaseMultiply: 2f);
            _currentAxisV = GradualChanger.GetGradualChange(_currentAxisV, verticalAxis, 
                decreaseMultiply: 2f,
                increaseMultiply: 2f);
            
            var directionVector = new Vector3(_currentAxisV, 0, _currentAxisH);
            var fixedDirectionValue = Vector3.ClampMagnitude(directionVector, 1).magnitude;

            if (isSpeedModeOn)
                fixedDirectionValue = fixedDirectionValue / PlayerSettings.StandardSpeed * PlayerSettings.SpeedMode;

            _currentSpeedDirection = GradualChanger.GetGradualChange(_currentSpeedDirection, fixedDirectionValue);
            
            _animator.SetFloat(Parameters.AxisH, _currentAxisH);
            _animator.SetFloat(Parameters.AxisV, _currentAxisV);
            _animator.SetFloat(Parameters.MovementSpeed, _currentSpeedDirection);
        }
        
        protected override void Rotate(float mouseAxisX)
        {
            transform.Rotate(0, mouseAxisX, 0);
        }

        protected override void Jump()
        {
            _animator.SetTrigger(Parameters.Jump);
        }
    }
}
