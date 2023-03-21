using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace moon
{
    public class Interactable : MonoBehaviour
    {
        public float radius = 0.6f;
        public string interactableText;

        public virtual void Interact(PlayerManager playerManager)
        {
            Debug.Log("You interacted with an object");
        }
    }
}