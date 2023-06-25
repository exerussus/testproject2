
using UnityEngine;

namespace Source.Scripts.KeyListener
{
    public class PlayerKeyListener : global::Source.Scripts.KeyListener.KeyListener
    {
        protected override float AxisV()
        {
            return Input.GetAxis("Vertical");
        }

        protected override float AxisH()
        {
            return Input.GetAxis("Horizontal");
        }
    }
}
