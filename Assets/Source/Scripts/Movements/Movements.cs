﻿
using UnityEngine;
namespace Source.Scripts.Movements
{
    [RequireComponent(typeof(KeyListener.KeyListener))]
    public abstract class Movements : MonoBehaviour
    {
        private KeyListener.KeyListener _keyListener;

        private void OnValidate()
        {
            _keyListener = GetComponent<KeyListener.KeyListener>();
        }

        private void OnEnable()
        {
            _keyListener.OnAxisChange += Move;
            _keyListener.OnRotation += Rotate;
            _keyListener.OnJump += Jump;
        }

        private void OnDisable()
        {
            _keyListener.OnAxisChange -= Move;
            _keyListener.OnRotation -= Rotate;
            _keyListener.OnJump -= Jump;
        }

        protected abstract void Move(float verticalAxis, float horizontalAxis, bool isSpeedModOn);
        protected abstract void Rotate(float mouseAxisX);
        protected abstract void Jump();
    }
}
