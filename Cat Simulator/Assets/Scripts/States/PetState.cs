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

    private void PetWhenBadMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Pet").reactionBadMood;
    }

    private void PetWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Pet").reactionGoodMood;
        catSimulator.catMood = CatMood.excellent;
    }

    private void PetWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = catSimulator.catActionsSO.getPropertiesObject("Pet").reactionExcellentMood;
    }

}
