public class PetState : ICatState
{
    public ICatState DoState(CatSimulator catSimulator)
    {
        switch (catSimulator.catMood)
        {
            case CatSimulator.CatMood.bad:
                PetWhenBadMood(catSimulator);
                break;

            case CatSimulator.CatMood.good:
                PetWhenGoodMood(catSimulator);
                break;

            case CatSimulator.CatMood.excellent:
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
        catSimulator.reactionText.text = "Царапает";
    }

    private void PetWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = "Мурлычет";
        catSimulator.catMood = CatSimulator.CatMood.excellent;
    }

    private void PetWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Happy");
        catSimulator.reactionText.text = "Мурлычет и виляет хвостом";
    }

}
