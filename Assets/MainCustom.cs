using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCustom : MonoBehaviour
{
    [SerializeField]
    Button button;
    [SerializeField]
    Dropdown dropdown;
    [SerializeField]
    Call call;

    int beforePlayerListLength;

    private void Start()
    {

        button.onClick.AddListener(() =>
        {
            Player targetPlayer = PhotonNetwork.PlayerList[dropdown.value];
            call.RPCCall(targetPlayer);
        });
    }

    private void Update()
    {
        if (PhotonNetwork.PlayerList.Length != beforePlayerListLength)
        {
            beforePlayerListLength = PhotonNetwork.PlayerList.Length;

            dropdown.ClearOptions();

            List<string> _dropDowns = new List<string>();
            foreach (var player in PhotonNetwork.PlayerList)
            {
                _dropDowns.Add(player.ActorNumber.ToString());
            }
            dropdown.AddOptions(_dropDowns);
        }
    }
}
