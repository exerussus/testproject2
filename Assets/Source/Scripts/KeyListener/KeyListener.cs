using System;
using UnityEngine;

namespace Source.Scripts.KeyListener
{
    public abstract class KeyListener : MonoBehaviour
    {
        private float _axisV;
        private float _axisH;
        private bool _isSpeedModOn;
        private float _mouseAxisX;
        
        public Action<float, float, bool> OnAxisChange;
        public Action<float> OnRotation;

        protected abstract float SetAxisV();
        protected abstract float SetAxisH();
        protected abstract bool SwitchSpeedMode();
        protected abstract float GetMouseAxisX();
    
        private void Update()
        {
            _axisV = SetAxisV();
            _axisH = SetAxisH();
            if (SwitchSpeedMode()) _isSpeedModOn = !_isSpeedModOn;
            _mouseAxisX = GetMouseAxisX();
            
            OnRotation?.Invoke(_mouseAxisX);
        }

        private void FixedUpdate()
        {
            OnAxisChange?.Invoke(_axisV, _axisH, _isSpeedModOn);
        }
    }
}
