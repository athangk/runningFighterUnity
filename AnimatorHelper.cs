
using UnityEngine;

public class AnimatorHelper : MonoBehaviour
{
    private Animator ninjaAnimator;

    void Start()
    {
        ninjaAnimator = GetComponent<Animator>();
    }

    void stopHitKick()
    {

        ninjaAnimator.SetBool("isHitKick", false);
    }

    void stopHitSword()
    {

        ninjaAnimator.SetBool("isHitSword", false);
    }
    void stopHitFlyingSword()
    {

        ninjaAnimator.SetBool("isFlyingSword", false);
    }

    void stopHitFlyingKick()
    {

        ninjaAnimator.SetBool("isFlyingKick", false);
    }
}
