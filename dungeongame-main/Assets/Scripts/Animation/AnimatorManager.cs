﻿using UnityEngine;
using System.Collections;

namespace moon
{
    public class AnimatorManager : MonoBehaviour
    {
        public Animator anim;

        public void PlayTargetAnimation(string targetAnim, bool isInteracting)
        {
            anim.applyRootMotion = isInteracting;
            anim.SetBool("isInteracting", isInteracting);
            anim.CrossFade(targetAnim, 0.2f);
        }
    }
}