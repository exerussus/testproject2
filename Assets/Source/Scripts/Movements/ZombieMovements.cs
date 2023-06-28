
using UnityEngine;

namespace Source.Scripts.Movements
{
    public class ZombieMovements : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed = 20f;
        [SerializeField] private Camera _camera;
        
        private void Update()
        {
            var direction = _camera.transform.position - transform.position;
            direction.y = 0;
            direction.Normalize();

            var toRotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 
                _rotationSpeed * Time.deltaTime);
        }
    }
}