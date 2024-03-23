using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLayer : MonoBehaviour
{
    internal static object i;
    [SerializeField] LayerMask portalLayer;
 

    public LayerMask TriggerableLayer
    {
        get => portalLayer;
    }
  
}
