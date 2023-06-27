

using UnityEngine;

namespace Source.Scripts.Animations
{
    [RequireComponent(typeof(KeyListener.KeyListener), typeof(Animator))]
    public abstract class AnimationParametersSetter : MonoBehaviour
    {
        private Animator _animator;
        private KeyListener.KeyListener _playerKeyListener;

        private void OnValidate()
        {
            _animator = GetComponent<Animator>();
            _playerKeyListener = GetComponent<KeyListener.KeyListener>();
        }

        private void OnEnable()
        {
            _playerKeyListener.OnAxisChange += SetAnimation;
        }

        private void OnDisable()
        {
            _playerKeyListener.OnAxisChange -= SetAnimation;
        }

        protected abstract void SetAnimationsParameters(Animator animator, float axisV, float axisH, bool isSpeedModeOn);

        private void SetAnimation(float axisV, float axisH, bool isSpeedModeOn)
        {
            SetAnimationsParameters(_animator, axisV, axisH, isSpeedModeOn);
        }
    }
}