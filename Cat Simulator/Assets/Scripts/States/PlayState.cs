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

    private void PlayWhenBadMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Play").reactionBadMood;
    }

    private void PlayWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Play").reactionGoodMood;
        catSimulator.catMood = CatMood.excellent;
    }

    private void PlayWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Play").reactionExcellentMood;
    }
}