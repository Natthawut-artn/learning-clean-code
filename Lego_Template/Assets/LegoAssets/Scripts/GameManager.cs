using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            AppStateManager.Instance.ChangeAppState(AppState.Win);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            AppStateManager.Instance.ChangeAppState(AppState.GameOver);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AppStateManager.Instance.ChangeAppState(AppState.Playing);
        }
    }
}
