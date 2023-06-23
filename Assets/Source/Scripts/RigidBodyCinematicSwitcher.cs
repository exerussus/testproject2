
using UnityEngine;

public class RigidBodyCinematicSwitcher : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody[] _rigidBodies;
    [SerializeField] private Collider[] _colliders;
    [SerializeField] private bool isKinematicOnStart = false;

    private void Awake()
    {
        if (isKinematicOnStart) SetKinematic();
    }

    public void SetPhysical()
    {
        _animator.enabled = false;
        foreach (var rigidBody in _rigidBodies)
        {
            rigidBody.isKinematic = false;
        }
        foreach (var collider in _colliders)
        {
            collider.isTrigger = false;
        }
    }

    public void SetKinematic()
    {
        _animator.enabled = true;
        foreach (var rigidBody in _rigidBodies)
        {
            rigidBody.isKinematic = true;
        }
        foreach (var collider in _colliders)
        {
            collider.isTrigger = true;
        }
    }
}
