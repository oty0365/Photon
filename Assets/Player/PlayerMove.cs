using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class PlayerMove : MonoBehaviourPunCallbacks
{
    public PhotonView _photonView;
    public float speed;
    private Rigidbody2D _rb2D;
    // Start is called before the first frame update
    void Start()
    {
        _rb2D=GetComponent<Rigidbody2D>();
        _photonView=GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_photonView.IsMine)
        {
            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
            _photonView.RPC("Move",RpcTarget.All,input);  
        }

 
            
    }

    
   
    [PunRPC] void Move(Vector3 input){
        
        _rb2D.velocity = input.normalized*Time.deltaTime*speed;
    }
}
