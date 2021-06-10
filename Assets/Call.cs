using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Call : MonoBehaviour
{
    [SerializeField]
    PhotonView view;

    public void RPCCall(Player targetPlayer)
    {
        view.RPC("TargetCall", targetPlayer, "호출완료");
    }
}
