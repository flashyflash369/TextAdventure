using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text displayText;

    [HideInInspector] RoomNavigation roomNavigation;

    public List<string> logActions = new List<string>();

    private void Awake()
    {
        roomNavigation = this.GetComponent<RoomNavigation>();
    }

    private void Start()
    {
        DisplayRoomText();
        DisplayLoggedText();
    }

    public void DisplayLoggedText()
    {
        string logAsText = string.Join("\n", logActions.ToArray());
        displayText.text = logAsText;
    }

    public void DisplayRoomText()
    {
        string combinedText = roomNavigation.currentRoom.description + "\n";
        LogStringWithReturn(combinedText);
    }

    public void LogStringWithReturn(string stringToAdd)
    {
        logActions.Add(stringToAdd + "\n");
    }
}
