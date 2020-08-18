/*
 * Written by Gleb Mirolyubov in August 2020.
 */

public interface ICatState
{
    ICatState DoState(CatSimulator catSimulator);
}