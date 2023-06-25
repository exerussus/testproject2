using Source.Scripts.Constants;
using UnityEngine;

namespace Source.Scripts.Movements
{
    public class CharacterMovement : Movements
    {
        [SerializeField] private Animator _animator;

        protected override void Move(float verticalAxis, float horizontalAxis)
        {

            var directionVector = new Vector3(verticalAxis, 0, horizontalAxis);
            var fixedDirectionVector = Vector3.ClampMagnitude(directionVector, 1);
        
            _animator.SetFloat(Parameters.AxisH, horizontalAxis);
            _animator.SetFloat(Parameters.AxisV, verticalAxis);
            _animator.SetFloat(Parameters.MovementSpeed, fixedDirectionVector.magnitude);
        }
    }
}
