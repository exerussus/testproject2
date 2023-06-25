
using UnityEngine;

namespace Source.Scripts.Animations
{
    public abstract class AnimationParametersSetter : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        [SerializeField] private KeyListener.PlayerKeyListener _playerKeyListener;

        private void OnEnable()
        {
            _playerKeyListener.OnAxisChange += SetAnimation;
        }

        private void OnDisable()
        {
            _playerKeyListener.OnAxisChange -= SetAnimation;
        }

        protected abstract void SetAnimationsParameters(Animator animator, float axisV, float axisH);

        private void SetAnimation(float axisV, float axisH)
        {
            SetAnimationsParameters(_animator, axisV, axisH);
        }
    }
}