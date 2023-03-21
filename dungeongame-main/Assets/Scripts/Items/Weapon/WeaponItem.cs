using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace moon 
{
    [CreateAssetMenu(menuName = "Items/Weapon Item")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;

        [Header("Idle Animations")]
        public string right_hand_idle;
        public string left_hand_idle;
        public string th_idle;

        [Header("Attack Animations")]
        public string OH_Light_Attack_01;
        public string OH_Light_Attack_02; 
        public string OH_Heavy_Attack;
        public string TH_Light_Attack_01;
        public string TH_Light_Attack_02;
        public string TH_Heavy_Attack;

        [Header("Stamina Costs")]
        public int baseStamina;
        public float lightAttackMultiplier;
        public float heavyAttackMultiplier;
    }
}