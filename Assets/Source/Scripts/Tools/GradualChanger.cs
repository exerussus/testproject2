using UnityEngine;

namespace Source.Scripts.Tools
{
    public static class GradualChanger
    {
        public static float GetGradualChange(
            float currentValue, 
            float targetValue,
            float increaseMultiply = 1f,
            float decreaseMultiply = 1f)
        {
            if (currentValue < targetValue)
            {
                if (currentValue + Time.fixedDeltaTime * increaseMultiply <= targetValue)
                    return currentValue + Time.fixedDeltaTime * increaseMultiply;
            }
            if (currentValue > targetValue)
            {
                if (currentValue - Time.fixedDeltaTime * decreaseMultiply >= targetValue)
                    return currentValue - Time.fixedDeltaTime * decreaseMultiply;
            }
            return targetValue;
        }
    }
}