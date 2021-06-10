using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPCConnect : MonoBehaviourPunCallbacks, IPunObservable
{
    [SerializeField]
    Text text;

    void IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        //throw new System.NotImplementedException();
    }

    [PunRPC]
    void TargetCall(string value, PhotonMessageInfo info)
    {
        text.text = info.Sender+"님이 당신을 호출했습니다. 메세지 : "+value;
    }
}
