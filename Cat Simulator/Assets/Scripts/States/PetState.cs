/*
 * Written by Gleb Mirolyubov in August 2020.
 */

public class PetState : ICatState
{
    public ICatState DoState(CatSimulator catSimulator)
    {
        switch (catSimulator.catMood)
        {
            case CatMood.bad:
                PetWhenBadMood(catSimulator);
                break;

            case CatMood.good:
                PetWhenGoodMood(catSimulator);
                break;

            case CatMood.excellent:
                PetWhenExcellentMood(catSimulator);
                break;

            default:
                break;
        }

        return catSimulator.defaultState;
    }

    /// <summary>
    /// <para>This runs commands when the player pets the cat in a bad mood.</para>
    /// </summary>
    private void PetWhenBadMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Pet").reactionBadMood;
    }

    /// <summary>
    /// <para>This runs commands when the player pets the cat in a good mood.</para>
    /// </summary>
    private void PetWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Pet").reactionGoodMood;
        catSimulator.catMood = CatMood.excellent;
    }

    /// <summary>
    /// <para>This runs commands when the player pets the cat in an excellent mood.</para>
    /// </summary>
    private void PetWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Pet").reactionExcellentMood;
    }

}
