
using UnityEngine;

namespace Source.Scripts.Weapon
{
    [RequireComponent(typeof(WeaponKeyListener))]
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private float _range = 100f;
        [SerializeField] private Camera _camera;
        [SerializeField] private GameObject _particleFlash;
        [SerializeField] private GameObject _particleFlashPlace;
        [SerializeField] private WeaponKeyListener _weaponKeyListener;

        private void OnEnable()
        {
            _weaponKeyListener.OnShoot += Shoot;
        }

        private void OnDisable()
        {
            _weaponKeyListener.OnShoot -= Shoot;
        }
        
        public void Shoot()
        {
            Instantiate(_particleFlash, _particleFlashPlace.transform.position, _particleFlashPlace.transform.rotation);
            
            RaycastHit hitInfo;
            if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hitInfo, _range))
            {
                Target target = hitInfo.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.TakeDamage();
                }
            }
        }
    }
}