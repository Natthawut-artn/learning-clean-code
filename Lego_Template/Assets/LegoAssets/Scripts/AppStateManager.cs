using System;
using System.Collections.Generic;
using UnityEngine;

public enum AppState
{
    Playing,
    Win,
    GameOver
}

public class AppStateManager : MonoBehaviour
{
    public static AppStateManager Instance;
    void Awake()
    {
        Instance = this;
    }
    private Dictionary<AppState, Action> stateEvents = new Dictionary<AppState, Action>();
    private AppState currentState = AppState.Playing;
    public void ChangeAppState(AppState appState)
    {
        currentState = appState;
        DoEvent();
    }

    public void RegisterEvent(AppState state, Action action)
    {
        if (stateEvents.ContainsKey(state))
        {
            stateEvents[state] += action; 
        }
        else
        {
             stateEvents[state] = action; 
        }
    }

    public void DoEvent()
    {
        if (stateEvents.ContainsKey(currentState))
        {
            stateEvents[currentState]?.Invoke();
        }
    }
}