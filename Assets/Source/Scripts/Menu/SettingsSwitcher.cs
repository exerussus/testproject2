
using UnityEngine;

public class SettingsSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject _settingsUI;
    [SerializeField] private GameObject _gameTouchPadUI;

    public void Switch()
    {
        _gameTouchPadUI.SetActive(!_gameTouchPadUI.activeSelf);
        _settingsUI.SetActive(!_gameTouchPadUI.activeSelf);
    }
}
