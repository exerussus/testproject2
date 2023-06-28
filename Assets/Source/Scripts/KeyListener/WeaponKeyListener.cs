
using System;
using Source.Scripts.KeyListener;
using UnityEngine;

namespace Source.Scripts.Weapon
{
    public class WeaponKeyListener : MonoBehaviour
    {
        [SerializeField] private ButtonListener _fireButton;
        
        public Action OnShoot;

        private bool GetPressed()
        {
            return _fireButton.GetButtonDown();
        }
        
        private void Update()
        {
            if (GetPressed()) OnShoot?.Invoke();
        }
    }
}
