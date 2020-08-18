using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(menuName = "Scriptable Objects/CatActionsSO", fileName = "CatActionsSO.asset")]
[System.Serializable]
public class CatActionsScriptableObject : ScriptableObject
{
    static public CatActionsScriptableObject S; // This Scriptable Object is an unprotected Singleton

    public CatActionsScriptableObject()
    {
        S = this; // Assign the Singleton as part of the constructor.
    }

    public List<CatActionsProperties> catActionsList;

    public CatActionsProperties getPropertiesObject(string stateName)
    {
        CatActionsProperties properties;

        properties = catActionsList.Where(x => x.actionState == stateName).SingleOrDefault();

        return properties;
    }
}

[System.Serializable]
public class CatActionsProperties
{
    [Header("Name of the action on the cat (spelling important)")]
    public string actionState;

    [Header("Set these properties")]
    public string reactionBadMood;
    public string reactionGoodMood;
    public string reactionExcellentMood;
}