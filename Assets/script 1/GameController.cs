using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { Dialog}

public class GameController : MonoBehaviour
{
    private void Start()
    {
        DialogManager.Instance.OnShowDialog += () =>
        {
            state = GameState.Dialog;
        };

        DialogManager.Instance.OnCloseDialog += () =>
        {
            if (state == GameState.Dialog) ;
                //state = GameState.FreeRoam;
        };
    }

    private GameState state;

    private void Update()
    {
        if (state == GameState.Dialog)
        {
            DialogManager.Instance.HandleUpdate();
        }
    }
}
