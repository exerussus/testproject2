
using UnityEngine;
using Source.Scripts.Constants;
using Source.Scripts.Tools;

namespace Source.Scripts.Animations
{
    public class PlayerAnimationParametersSetter : AnimationParametersSetter
    {
        private float _currentBlendValue;
        
        protected override void SetAnimationsParameters(Animator animator, float axisV, float axisH, bool isSpeedModeOn)
        {
            var directionVector = new Vector3(axisV, 0, axisH);
            var fixedDirectionVector = Vector3.ClampMagnitude(directionVector, 1);

            var rawBlendValue = fixedDirectionVector.magnitude;
            rawBlendValue = isSpeedModeOn && rawBlendValue < PlayerSettings.SpeedMode ? 
                PlayerSettings.SpeedMode : rawBlendValue;
            
            animator.SetFloat(Parameters.AxisH, axisH);
            animator.SetFloat(Parameters.AxisV, axisV);

            _currentBlendValue = GradualChanger.GetGradualChange(_currentBlendValue, rawBlendValue);
            animator.SetFloat(Parameters.MovementSpeed, _currentBlendValue);
        }
    }
}
