
using Source.Scripts.KeyListener;
using UnityEngine;
using Slider = UnityEngine.UI.Slider;

public class RotationSensitivity : MonoBehaviour
{
    [SerializeField] private PlayerKeyListener _playerKeyListener;
    [SerializeField] private Slider _slider;

    public void SetCurrentValue()
    {
        _playerKeyListener.SetRotationSensitivity(_slider.value);
    }
}
