
using System;
using UnityEngine;

public abstract class KeyListener : MonoBehaviour
{
    private float _axisV;
    private float _axisH;

    public Action<float, float> OnAxisChange;

    protected abstract float AxisV();
    protected abstract float AxisH();
    
    private void Update()
    {
        _axisV = AxisV();
        _axisH = AxisH();
    }

    private void FixedUpdate()
    {
        OnAxisChange?.Invoke(_axisV, _axisH);
    }
}
