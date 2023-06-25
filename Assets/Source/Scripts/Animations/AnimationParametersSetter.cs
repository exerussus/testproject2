using UnityEngine;

namespace Source.Scripts.Animations
{
    public abstract class AnimationParametersSetter : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        
        protected abstract void SetAnimationsValues(Animator animator);

        public void SetAnimation()
        {
            SetAnimationsValues(_animator);
        }
    }
}