
using UnityEngine;

public class EnemySpawnSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject _spawner;

    public void SwitchActive()
    {
        _spawner.SetActive(!_spawner.activeSelf);
    }
}
