using System.Collections.Generic;
using UnityEngine;

namespace Source.Scripts.Coin
{
    public class CoinColorChanger : MonoBehaviour
    {
        [SerializeField] private MeshRenderer _meshRenderer;
        [SerializeField] private List<Material> _materialList;
        private int _maxIndexCount;
        private int _actuallyIndex = 0;

        private void Start()
        {
            _maxIndexCount = _materialList.Count - 1;
            SetColor(0);
        }

        private void SetColor(int index)
        {
            _meshRenderer.material = _materialList[index];
        }
    
        public void ChangeColor()
        {
            _actuallyIndex = _actuallyIndex + 1 > _maxIndexCount ? 0 : _actuallyIndex + 1;
            SetColor(_actuallyIndex);
        }
    }
}
