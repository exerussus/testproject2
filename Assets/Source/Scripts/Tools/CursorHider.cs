
using UnityEngine;

namespace Source.Scripts.Tools
{
    public class CursorHider : MonoBehaviour
    {
        private void Start()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}