
using UnityEngine;

public class PlayerKeyListener : KeyListener
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
