using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace moon
{
    public class STABar : MonoBehaviour
    {
        public Slider slider;

        private void Start()
        {
            slider = GetComponent<Slider>();
        }

        public void SetMaxStamina(int maxStamina)
        {
            slider.maxValue = maxStamina;
            slider.value = maxStamina;
        }

        public void SetCurrentStamina(int currentStamina)
        {
            slider.value = currentStamina;
        }
    }
}