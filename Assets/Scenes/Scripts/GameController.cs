using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController: MonoBehaviour
{
    public Text displayText;
    [HideInInspector] public RoomHandler roomHandler;
    [HideInInspector] public List<string> interactionDescriptionInRoom = new List<string>();
    [HideInInspector] public InteractionHandler interactionHandler;
    List<string> actionLog = new List<string>();
    public InputAction[] inputActions;

    // Start is called before the first frame update
    void Awake()
    {
        interactionHandler = GetComponent<InteractionHandler>();
        roomHandler = GetComponent<RoomHandler>();
    }

    void Start()
    {
        LoadRoom();
        DisplayLoggedText();
    }

 
    //TODO Live machen damit Äderung sichtbar werden
    public void LoadRoom()
    {
        WriteToTerminal(roomHandler.GetRoomDescription());
    }

    public void WriteToTerminal(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }

    public void DisplayLoggedText()
    {
        string logAsText = string.Join("\n", actionLog.ToArray());
        displayText.text = logAsText;
    }

    public string TestVerbDictionaryWithNoun(Dictionary<string,string> verbDictorary, string verb, string noun)
    {
        if (verbDictorary.ContainsKey(noun))
        {
            return verbDictorary[noun];
        }
        return "You can't " + verb + " " + noun;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
