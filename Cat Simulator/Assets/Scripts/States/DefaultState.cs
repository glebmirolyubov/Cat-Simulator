/*
 * Written by Gleb Mirolyubov in August 2020.
 */

public class DefaultState : ICatState
{
    public ICatState DoState(CatSimulator catSimulator)
    {
        return catSimulator.defaultState;
    }
}