public class KickState : ICatState
{
    public ICatState DoState(CatSimulator catSimulator)
    {
        switch (catSimulator.catMood)
        {
            case CatMood.bad:
                KickWhenBadMood(catSimulator);
                break;

            case CatMood.good:
                KickWhenGoodMood(catSimulator);
                break;

            case CatMood.excellent:
                KickWhenExcellentMood(catSimulator);
                break;

            default:
                break;
        }

        return catSimulator.defaultState;
    }

    private void KickWhenBadMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Kick").reactionBadMood;
    }

    private void KickWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Kick").reactionGoodMood;
        catSimulator.catMood = CatMood.bad;
    }

    private void KickWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Kick").reactionExcellentMood;
        catSimulator.catMood = CatMood.bad;
    }
}
