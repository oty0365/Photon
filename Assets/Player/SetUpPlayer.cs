using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetUpPlayer : MonoBehaviour
{
    private TextMeshPro _playerNameTag;

    private void Start()
    {
        _playerNameTag = transform.GetChild(1).GetComponent<TextMeshPro>();
        _playerNameTag.text = DataPrefs.playername;
    }
    
}
