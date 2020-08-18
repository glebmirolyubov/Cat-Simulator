/*
 * Written by Gleb Mirolyubov in August 2020.
 */

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

    /// <summary>
    /// <para>This runs commands when the player kicks the cat in a bad mood.</para>
    /// </summary>
    private void KickWhenBadMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Kick").reactionBadMood;
    }

    /// <summary>
    /// <para>This runs commands when the player kicks the cat in a good mood.</para>
    /// </summary>
    private void KickWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Kick").reactionGoodMood;
        catSimulator.catMood = CatMood.bad;
    }

    /// <summary>
    /// <para>This runs commands when the player kicks the cat in an excellent mood.</para>
    /// </summary>
    private void KickWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Kick").reactionExcellentMood;
        catSimulator.catMood = CatMood.bad;
    }
}
