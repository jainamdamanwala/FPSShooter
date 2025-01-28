using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using System.Collections.Generic;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public InputField roomNameInputField;
    public GameObject roomListContainer;
    public GameObject roomListItemPrefab;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        Debug.Log("Connected to Master and joined Lobby.");
    }

    public void CreateRoom()
    {
        if (string.IsNullOrEmpty(roomNameInputField.text)) return;

        PhotonNetwork.CreateRoom(roomNameInputField.text, new RoomOptions { MaxPlayers = 10 });
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room: " + PhotonNetwork.CurrentRoom.Name);
        PhotonNetwork.LoadLevel("GameScene");
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach (Transform child in roomListContainer.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (var roomInfo in roomList)
        {
            GameObject roomItem = Instantiate(roomListItemPrefab, roomListContainer.transform);
            roomItem.GetComponentInChildren<Text>().text = roomInfo.Name;
            roomItem.GetComponent<Button>().onClick.AddListener(() => JoinRoom(roomInfo.Name));
        }
    }

    public void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }
}
