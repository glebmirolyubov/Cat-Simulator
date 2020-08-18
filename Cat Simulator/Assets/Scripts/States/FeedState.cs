/*
 * Written by Gleb Mirolyubov in August 2020.
 */

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

    /// <summary>
    /// <para>This runs commands when the player feeds the cat in a bad mood.</para>
    /// </summary>
    private void FeedWhenBadMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Feed").reactionBadMood;
        catSimulator.catMood = CatMood.good;
    }

    /// <summary>
    /// <para>This runs commands when the player feeds the cat in a good mood.</para>
    /// </summary>
    private void FeedWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Feed").reactionGoodMood;
        catSimulator.catMood = CatMood.excellent;
    }

    /// <summary>
    /// <para>This runs commands when the player feeds the cat in an excellent mood.</para>
    /// </summary>
    private void FeedWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Feed").reactionExcellentMood;
    }

}