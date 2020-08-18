public class KickState : ICatState
{
    public ICatState DoState(CatSimulator catSimulator)
    {
        switch (catSimulator.catMood)
        {
            case CatSimulator.CatMood.bad:
                KickWhenBadMood(catSimulator);
                break;

            case CatSimulator.CatMood.good:
                KickWhenGoodMood(catSimulator);
                break;

            case CatSimulator.CatMood.excellent:
                KickWhenExcellentMood(catSimulator);
                break;

            default:
                break;
        }

        return catSimulator.defaultState;
    }

    private void KickWhenBadMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = "Прыгает и кусает за правое ухо";
    }

    private void KickWhenGoodMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = "Убегает на ковер и писает";
        catSimulator.catMood = CatSimulator.CatMood.bad;
    }

    private void KickWhenExcellentMood(CatSimulator catSimulator)
    {
        catSimulator.catAnimator.SetTrigger("Angry");
        catSimulator.reactionText.text = "Убегает в другую комнату";
        catSimulator.catMood = CatSimulator.CatMood.bad;
    }
}
