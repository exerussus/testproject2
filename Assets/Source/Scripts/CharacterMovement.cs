
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private KeyListener _keyListener;

    private void OnEnable()
    {
        _keyListener.OnAxisChange += Move;
    }

    private void OnDisable()
    {
        _keyListener.OnAxisChange -= Move;
    }
    
    private void Move(float verticalAxis, float horizontalAxis)
    {

        var directionVector = new Vector3(verticalAxis, 0, horizontalAxis);
        var fixedDirectionVector = Vector3.ClampMagnitude(directionVector, 1);
        
        _animator.SetFloat(ParametersConstant.AxisH, horizontalAxis);
        _animator.SetFloat(ParametersConstant.AxisV, verticalAxis);
        _animator.SetFloat(ParametersConstant.MovementSpeed, fixedDirectionVector.magnitude);
    }
}
