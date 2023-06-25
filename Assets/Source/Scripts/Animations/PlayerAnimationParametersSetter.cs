
using UnityEngine;
using Source.Scripts.Constants;

namespace Source.Scripts.Animations
{
    public class PlayerAnimationParametersSetter : AnimationParametersSetter
    {
        protected override void SetAnimationsParameters(Animator animator, float axisV, float axisH)
        {
            var directionVector = new Vector3(axisV, 0, axisH);
            var fixedDirectionVector = Vector3.ClampMagnitude(directionVector, 1);
            
            animator.SetFloat(Parameters.AxisH, axisH);
            animator.SetFloat(Parameters.AxisV, axisV);
            animator.SetFloat(Parameters.MovementSpeed, fixedDirectionVector.magnitude);
        }
    }
}
