using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{
    public Animator anim;

    void OnMouseDown()
    {
        anim.Play("action", -1, 0.25f);
    }
}
