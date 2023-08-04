

    void AnimatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {

            if (isJumping)
            {
                ninjaAnimator.SetBool("isFlyingSword", true);
            }
            else
            {
                ninjaAnimator.SetBool("isHitSword", true);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (isJumping)
            {
                ninjaAnimator.SetBool("isFlyingKick", true);
            }
            else
            {
                ninjaAnimator.SetBool("isHitKick", true);
            }

        }
    }
