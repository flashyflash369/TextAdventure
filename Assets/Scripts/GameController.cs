using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [HideInInspector] RoomNavigation roomNavigation;

    private void Awake()
    {
        roomNavigation = this.GetComponent<RoomNavigation>();
    }

    private void DisplayText()
    {
        string combinedText = roomNavigation.currentRoom.description + "\n";
    }
}
