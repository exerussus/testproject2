
using Source.Scripts.Movements;
using UnityEngine;

namespace Source.Scripts.Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _parentObject;
        [SerializeField] private GameObject[] _enemyPrefabs;
        [SerializeField] private Transform[] _spawnersTransforms;
        [SerializeField] private Transform _playerTransform;
        [SerializeField] private int _maxEnemyCount = 10;
        [SerializeField] private float _spawnTimer = 3f;
        private float _timeCount = 0f;

        private void Update()
        {
            if (_timeCount >= _spawnTimer)
            {
                _timeCount = 0f;
                if (IsFewEnemy()) CreateEnemy();
            }
            else
            {
                _timeCount += Time.fixedDeltaTime;
            }
        }

        private void CreateEnemy()
        {
            var enemyPrefab = GetRandomEnemy();
            var spawnerTransform = GetRandomSpawnersTransform();
            var enemy = Instantiate(enemyPrefab, spawnerTransform.position, Quaternion.identity,
                _parentObject.transform);
            var direction = _playerTransform.position - spawnerTransform.position;
            var rotation = Quaternion.LookRotation(direction);
            enemy.transform.rotation = rotation;
            var zombieMovements =  enemy.GetComponent<ZombieMovements>();
            zombieMovements.SetMovementTarget(_playerTransform);
        }
        
        private bool IsFewEnemy()
        {
            return _parentObject.transform.childCount < _maxEnemyCount;
        }
        
        private int GetRandomIndex(int listLength)
        {
            return  Random.Range(0, listLength);
        }
        
        private Transform GetRandomSpawnersTransform()
        {
            var randomIndex = GetRandomIndex(_spawnersTransforms.Length);
            return _spawnersTransforms[randomIndex];
        }
        
        private GameObject GetRandomEnemy()
        {
            var randomIndex = GetRandomIndex(_enemyPrefabs.Length);
            return _enemyPrefabs[randomIndex];
        }

    }
}