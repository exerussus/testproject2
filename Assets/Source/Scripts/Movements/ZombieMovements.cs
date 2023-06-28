
using UnityEngine;

namespace Source.Scripts.Movements
{
    public class ZombieMovements : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed = 20f;
        [SerializeField] private Transform _targetTransform;
        private bool _isTargetTransformNull;

        private void Start()
        {
            _isTargetTransformNull = _targetTransform == null;
        }

        public void SetMovementTarget(Transform targetTransform)
        {
            _targetTransform = targetTransform;
        }
        
        private void Update()
        {
            if (_isTargetTransformNull) return;
            var direction = _targetTransform.position - transform.position;
            direction.y = 0;
            direction.Normalize();

            var toRotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 
                _rotationSpeed * Time.deltaTime);
        }
    }
}