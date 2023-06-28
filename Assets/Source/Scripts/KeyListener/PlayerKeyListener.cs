
using UnityEngine;

namespace Source.Scripts.KeyListener
{
    public class PlayerKeyListener : KeyListener
    {
        [SerializeField] private float _movementSensitivity = 1f;
        [SerializeField] private float _rotationSensitivity = 1f;
        
        [SerializeField] private FixedJoystick _movementJoystick;
        [SerializeField] private FixedJoystick _rotationJoystick;
        [SerializeField] private ButtonListener _runButton;
        
        protected override float SetAxisV()
        {
            return _movementJoystick.Vertical * _movementSensitivity;
        }

        protected override float SetAxisH()
        {
            return _movementJoystick.Horizontal * _movementSensitivity;
        }

        protected override bool SwitchSpeedMode()
        {
            return _runButton.GetButtonDown();
        }

        protected override float GetMouseAxisX()
        {
            return _rotationJoystick.Horizontal * _rotationSensitivity;
        }
    }
}
