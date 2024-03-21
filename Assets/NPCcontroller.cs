using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCcontroller : MonoBehaviour, interactable
{
    [SerializeField] Dialog dialog;
   public void Interact()
    {
        DialogManager.Instance.ShowDialog(dialog);
    }
}
