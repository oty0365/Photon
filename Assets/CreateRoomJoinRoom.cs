using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CreateRoomJoinRoom : MonoBehaviourPunCallbacks
{
    public TMP_InputField create;
    public TMP_InputField join;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(create.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(join.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
