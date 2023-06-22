
using UnityEngine;
using UnityEngine.Events;

public class ClickDetector : MonoBehaviour
{
    public UnityEvent onClick;

    private void OnMouseDown()
    {
        onClick.Invoke();
    }
}
