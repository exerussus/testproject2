
using UnityEngine;

namespace Source.Scripts.KeyListener
{
    public class PlayerKeyListener : KeyListener
    {
        protected override float SetAxisV()
        {
            return Input.GetAxis("Vertical");
        }

        protected override float SetAxisH()
        {
            return Input.GetAxis("Horizontal");
        }

        protected override bool SwitchSpeedMode()
        {
            return Input.GetKeyDown(KeyCode.LeftShift);
        }

        protected override float GetMouseAxisX()
        {
            return Input.GetAxis("Mouse X");
        }
    }
}
