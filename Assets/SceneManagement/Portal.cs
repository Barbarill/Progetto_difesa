using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour, IPlayerTriggerable
{
    public void OnPlayerTriggerd(player player)
    {
        throw new System.NotImplementedException();
    }

    public void OnPlayerTriggered(player player)
    {
        Debug.Log("Player entered the portal");
    }
}
