public class DefaultState : ICatState
{
    public ICatState DoState(CatSimulator catSimulator)
    {
        return catSimulator.defaultState;
    }
}