public class FeedState : ICatState
{
    public ICatState DoState(CatSimulator catSimulator)
    {
        switch (catSimulator.catMood)
        {
            case CatSimulator.CatMood.bad:
                FeedWhenBadMood(catSimulator);
                break;

            case CatSimulator.CatMood.good:
                FeedWhenGoodMood(catSimulator);
                break;

            case CatSimulator.CatMood.excellent:
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
        catSimulator.reactionText.text = "Все съедает, но если в это время подойти - поцарапает";
        catSimulator.catMood = CatSimulator.CatMood.good;
    }

    private void FeedWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = "Быстро все съедает";
        catSimulator.catMood = CatSimulator.CatMood.excellent;
    }

    private void FeedWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = "Быстро все съедает";
    }

}
