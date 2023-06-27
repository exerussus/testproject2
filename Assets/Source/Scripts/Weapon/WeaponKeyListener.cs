
using System;
using UnityEngine;

namespace Source.Scripts.Weapon
{
    public class WeaponKeyListener : MonoBehaviour
    {
        public Action OnShoot;

        private bool GetPressed()
        {
            return Input.GetMouseButtonDown(0);
        }
        
        private void Update()
        {
            if (GetPressed()) OnShoot?.Invoke();
        }
    }
}
