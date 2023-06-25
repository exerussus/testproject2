
using UnityEngine;

namespace Source.Scripts.Movements
{
    public class PlayerMovements : Movements
    {
        [SerializeField] private float _speed = 10f;
        [SerializeField] private float _rotationSpeed = 50f;
        [SerializeField] private Rigidbody _rigidbody;

        protected override void Move(float verticalAxis, float horizontalAxis)
        {
            // var directionVector = new Vector3(verticalAxis * transform.forward.x, 0, horizontalAxis * transform.forward.z);
            // var fixedDirectionVector = Vector3.ClampMagnitude(directionVector, 1);
            // _rigidbody.velocity = fixedDirectionVector * _speed;
            
            var translation = verticalAxis * _speed;
            var rotation = horizontalAxis * _rotationSpeed;
            var moveDirection = new Vector3(0, 0, translation);
            _rigidbody.velocity = transform.TransformDirection(moveDirection);
            transform.Rotate(0, rotation * Time.deltaTime, 0);
        }
    }
}
