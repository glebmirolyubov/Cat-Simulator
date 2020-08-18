public class PlayState : ICatState
{
    public ICatState DoState(CatSimulator catSimulator)
    {
        switch (catSimulator.catMood)
        {
            case CatSimulator.CatMood.bad:
                PlayWhenBadMood(catSimulator);
                break;

            case CatSimulator.CatMood.good:
                PlayWhenGoodMood(catSimulator);
                break;

            case CatSimulator.CatMood.excellent:
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
        catSimulator.reactionText.text = "Сидит на месте";
    }

    private void PlayWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = "Медленно бегает за мячиком";
        catSimulator.catMood = CatSimulator.CatMood.excellent;
    }

    private void PlayWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = "Носится, как угорелая";
    }
}