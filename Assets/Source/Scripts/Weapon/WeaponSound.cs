using System;
using UnityEngine;

namespace Source.Scripts.Weapon
{
    public class WeaponSound : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private AudioClip _audioClip;
        [SerializeField] private WeaponKeyListener _weaponKeyListener;

        private void OnEnable()
        {
            _weaponKeyListener.OnShoot += MakeSound;
        }

        private void OnDisable()
        {
            _weaponKeyListener.OnShoot -= MakeSound;
        }

        private void MakeSound()
        {
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}