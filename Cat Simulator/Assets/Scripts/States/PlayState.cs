/*
 * Written by Gleb Mirolyubov in August 2020.
 */

using System.Linq;

public class PlayState : ICatState
{
    public ICatState DoState(CatSimulator catSimulator)
    {
        switch (catSimulator.catMood)
        {
            case CatMood.bad:
                PlayWhenBadMood(catSimulator);
                break;

            case CatMood.good:
                PlayWhenGoodMood(catSimulator);
                break;

            case CatMood.excellent:
                PlayWhenExcellentMood(catSimulator);
                break;

            default:
                break;
        }

        return catSimulator.defaultState;
    }

    /// <summary>
    /// <para>This runs commands when the player plays with the cat in a bad mood.</para>
    /// </summary>
    private void PlayWhenBadMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Play").reactionBadMood;
    }

    /// <summary>
    /// <para>This runs commands when the player plays with the cat in a good mood.</para>
    /// </summary>
    private void PlayWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Play").reactionGoodMood;
        catSimulator.catMood = CatMood.excellent;
    }

    /// <summary>
    /// <para>This runs commands when the player plays with the cat in an excellent mood.</para>
    /// </summary>
    private void PlayWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Play").reactionExcellentMood;
    }
}