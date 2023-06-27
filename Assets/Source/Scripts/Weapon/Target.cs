using System.Collections;
using Source.Scripts.Ragdoll;
using UnityEngine;

namespace Source.Scripts.Weapon
{
    public class Target : MonoBehaviour
    {
        [SerializeField] private RigidBodyCinematicSwitcher _rigidbodyCinematicSwitcher;
        [SerializeField] private float _delayDestroy;
        
        public void TakeDamage()
        {
            _rigidbodyCinematicSwitcher.EnableRagdoll();
            StartCoroutine(DestroyCorpse());
        }

        private IEnumerator DestroyCorpse()
        {
            yield return new WaitForSeconds(_delayDestroy);
            Debug.Log("Target destroyed");
            Destroy(this);
        }
    }
}