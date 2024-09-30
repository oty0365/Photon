using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;

public class SetUpPlayer : MonoBehaviourPunCallbacks
{
    private TextMeshPro _playerNameTag;
    private PhotonView _photonView;
    private void Start()
    {
        _photonView=GetComponent<PhotonView>();
        _playerNameTag = transform.GetChild(1).GetComponent<TextMeshPro>();
        _photonView.Owner.NickName = DataPrefs.playername;
        _photonView.RPC("GetName",RpcTarget.All);



    }

    [PunRPC]
    void GetName()
    {
        _playerNameTag.text = _photonView.Owner.NickName;
    }
}
