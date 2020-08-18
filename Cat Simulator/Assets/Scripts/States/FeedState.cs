public class FeedState : ICatState
{
    public ICatState DoState(CatSimulator catSimulator)
    {
        switch (catSimulator.catMood)
        {
            case CatMood.bad:
                FeedWhenBadMood(catSimulator);
                break;

            case CatMood.good:
                FeedWhenGoodMood(catSimulator);
                break;

            case CatMood.excellent:
                FeedWhenExcellentMood(catSimulator);
                break;

            default:
                break;
        }

        return catSimulator.defaultState;
    }

    private void FeedWhenBadMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Feed").reactionBadMood;
        catSimulator.catMood = CatMood.good;
    }

    private void FeedWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Feed").reactionGoodMood;
        catSimulator.catMood = CatMood.excellent;
    }

    private void FeedWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Feed").reactionExcellentMood;
    }

}