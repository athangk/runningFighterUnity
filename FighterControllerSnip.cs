

    void AnimatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {

            if (isJumping)
            {
                fighterAnimator.SetBool("isFlyingSword", true);
            }
            else
            {
                fighterAnimator.SetBool("isHitSword", true);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (isJumping)
            {
                fighterAnimator.SetBool("isFlyingKick", true);
            }
            else
            {
                fighterAnimator.SetBool("isHitKick", true);
            }

        }
    }
