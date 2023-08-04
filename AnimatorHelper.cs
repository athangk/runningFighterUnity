
using UnityEngine;

public class AnimatorHelper : MonoBehaviour
{
    private Animator fighterAnimator;

    void Start()
    {
        fighterAnimator = GetComponent<Animator>();
    }

    void stopHitKick()
    {

        fighterAnimator.SetBool("isHitKick", false);
    }

    void stopHitSword()
    {

        fighterAnimator.SetBool("isHitSword", false);
    }
    void stopHitFlyingSword()
    {

        fighterAnimator.SetBool("isFlyingSword", false);
    }

    void stopHitFlyingKick()
    {

        fighterAnimator.SetBool("isFlyingKick", false);
    }
}
