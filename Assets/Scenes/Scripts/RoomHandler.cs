using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class RoomHandler : MonoBehaviour
{
    public Room currtentRoom;
    private GameController controller;
    Dictionary<string, Room> RoomDictonary = new Dictionary<string, Room>();
    Dictionary<string, Item> ItemDictonary = new Dictionary<string, Item>();
    private void Awake()
    {
        controller = GetComponent<GameController>();
    }

    public string GetRoomDescription()
    {
        StringBuilder roomDescripton = new StringBuilder(currtentRoom.description + "\n");
     
        foreach(Exit exit in currtentRoom.exits)
        {
            roomDescripton.Append("You can go " + exit.direction + " " + exit.directionDescription + "\n");
        }
        return roomDescripton.ToString();
    }

    public string GetRoomObjectsList()
    {
        StringBuilder roomObjects = new StringBuilder("You look around and see" + "\n");
        if (currtentRoom.items == null && currtentRoom.enviromentObjects == null)
        {
            roomObjects.Append("nothing...");
        }
        else
        {
            foreach(Item item in currtentRoom.items )   
            {
                ItemDictonary.Add(item.noun, item);
                roomObjects.Append(", " + item.noun);
            }
            foreach(EnviromentObject enviromentObject in currtentRoom.enviromentObjects)
            {
                roomObjects.Append(", " + enviromentObject.noun);
            }
        }
        return roomObjects.ToString();
    }

    public void AttemptToChangeRooms(string directionWord)
    {
        bool found = false;
        foreach (Exit exit2 in currtentRoom.exits.ToList())
        {
            if (exit2.direction == directionWord)
            {
                currtentRoom = exit2.directionRoom;
                controller.WriteToTerminal("You head " + directionWord);
                controller.LoadRoom();
                found = true;
                break;
            }

        }
        if (!found)
        {
            controller.WriteToTerminal("You can`t go" + directionWord);
        }
    }

    public void ClearExits()
    {
       // RoomDictonary.Clear();
    }
}
