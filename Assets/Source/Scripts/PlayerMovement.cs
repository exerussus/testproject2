
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void FixedUpdate()
    {
        var horizontalAxis = Input.GetAxis("Horizontal");
        var verticalAxis = Input.GetAxis("Vertical");
        
        var directionVector = new Vector3(verticalAxis, 0, horizontalAxis);
        var fixedDirectionVector = Vector3.ClampMagnitude(directionVector, 1);
        
        _animator.SetFloat(ParametersConstant.AxisH, horizontalAxis);
        _animator.SetFloat(ParametersConstant.AxisV, verticalAxis);
        _animator.SetFloat(ParametersConstant.MovementSpeed, fixedDirectionVector.magnitude);
    }
}
