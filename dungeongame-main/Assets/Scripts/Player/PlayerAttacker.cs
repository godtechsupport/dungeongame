using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace moon
{
    public class PlayerAttacker : MonoBehaviour
    {
        AnimatorHandle animatorHandler;
        private void Awake()
        {
            animatorHandler = GetComponentInChildren<AnimatorHandle>();
        }
        public void HandleLightAttack(WeaponItem weapon)
        {
            animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_1, true);
        }
        public void HandleHeavyAttack(WeaponItem weapon)
        {
            animatorHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_1, true);
        }
    }
}