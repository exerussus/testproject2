
using UnityEngine;

namespace Source.Scripts.Movements
{
    public class PlayerMovements : Movements
    {
        [SerializeField] private float _speed = 10f;
        [SerializeField] private Rigidbody _rigidbody;

        protected override void Move(float verticalAxis, float horizontalAxis)
        {
            var directionVector = new Vector3(verticalAxis, 0, horizontalAxis);
            var fixedDirectionVector = Vector3.ClampMagnitude(directionVector, 1);
            _rigidbody.velocity = fixedDirectionVector * _speed;
        }
    }
}
