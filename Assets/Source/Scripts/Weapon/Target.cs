using System.Collections;
using Source.Scripts.Ragdoll;
using UnityEngine;

namespace Source.Scripts.Weapon
{
    public class Target : MonoBehaviour
    {
        [SerializeField] private RigidBodyCinematicSwitcher _rigidbodyCinematicSwitcher;
        [SerializeField] private float _delayDestroy;
        [SerializeField] private float _health = 100f;
        
        public void TakeDamage(float damage)
        {
            if (damage > 0) _health -= damage;
            if (_health <= 0) Die();
            else HitEffect();
        }

        private void HitEffect()
        {
            _rigidbodyCinematicSwitcher.EnableRagdoll();
            StartCoroutine(EnableRagdoll());
        }

        private IEnumerator EnableRagdoll(float delay=0.05f)
        {
            yield return new WaitForSeconds(delay);
            _rigidbodyCinematicSwitcher.DisableRagdoll();
        }
        
        private IEnumerator DestroyCorpse()
        {
            yield return new WaitForSeconds(_delayDestroy);
            Destroy(gameObject);
        }

        private void Die()
        {
            _rigidbodyCinematicSwitcher.EnableRagdoll();
            StartCoroutine(DestroyCorpse());
        }
    }
}