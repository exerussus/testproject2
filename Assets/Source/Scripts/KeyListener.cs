
using System;
using UnityEngine;

public class KeyListener : MonoBehaviour
{
    private float _axisV;
    private float _axisH;

    public Action<float, float> OnAxisChange;
    
    private void Update()
    {
        _axisV = Input.GetAxis("Vertical");
        _axisH = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        OnAxisChange?.Invoke(_axisV, _axisH);
    }
}
