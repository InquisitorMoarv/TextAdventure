using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="TextAdventure/InputAction/Inventory")]
public class Inventory : InputAction
{
    public override void RespondToInput(GameController controller, string[] inputWords)
    {
        controller.interactionHandler.DisplayInventory();
    }
}
