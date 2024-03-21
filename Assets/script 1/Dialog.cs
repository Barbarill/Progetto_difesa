using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog //qui potremmo aggiungere anche qualcosa da dare al personaggio tipo oggetto
{
    [SerializeField] List<string> lines;

    public List<string> Lines => lines;
}
