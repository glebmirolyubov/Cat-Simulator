using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatSimulator : MonoBehaviour
{
    [Header("Set in Inspector")]
    public Text reactionText;
    public Text currentMoodText;
    public Animator catAnimator;
    public CatActionsScriptableObject catActionsSO;

    public DefaultState defaultState = new DefaultState();
    public PlayState playState = new PlayState();
    public FeedState feedState = new FeedState();
    public PetState petState = new PetState();
    public KickState kickState = new KickState();

    public CatMood catMood = CatMood.good;

    private ICatState currentState;

    private void Start()
    {
        currentState = defaultState;
    }

    private void Update()
    {
        currentState = currentState.DoState(this);
        currentMoodText.text = GetCatMoodAsString();
    }

    public void OnPlayButton()
    {
        currentState = playState;
    }

    public void OnFeedButton()
    {
        currentState = feedState;
    }

    public void OnPetButton()
    {
        currentState = petState;
    }

    public void OnKickButton()
    {
        currentState = kickState;
    }

    string GetCatMoodAsString()
    {
        if (catMood == CatMood.bad)
        {
            return "ПЛОХОЕ";
        }
        else if (catMood == CatMood.good)
        {
            return "ХОРОШЕЕ";
        }
        else
        {
            return "ОТЛИЧНОЕ";
        }
    }
}