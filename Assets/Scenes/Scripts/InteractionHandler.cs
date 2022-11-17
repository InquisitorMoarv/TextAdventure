using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    [HideInInspector] public List<string> nounsInRoom = new List<string>();
    public List<Item> inventory = new List<Item>();
    public Dictionary<string, string> examineDictornay = new Dictionary<string, string>();
    public Dictionary<string, string> takeDictornay = new Dictionary<string, string>();
    GameController controller;

    public void Awake()
    {
        controller = GetComponent<GameController>();
    }

    public void DisplayInventory()
    {
  
        StringBuilder inventoryList = new StringBuilder("You look in your Backpack, inside you have: \n");
        for (int i = 0; i < inventory.Count; i++)
        {
            inventoryList.Append(", " + inventory[i].noun);
        }
        controller.WriteToTerminal(inventoryList.ToString());
    }

    public void Take(Room room, string inputWords)
    {
        foreach (Item item in room.items.ToList())
        {
            if(item.noun == inputWords)
            {
                inventory.Add(item);
                
                controller.WriteToTerminal("You pick up" + item.noun );
                room.items.Remove(item);
            }
        }
    }
}
