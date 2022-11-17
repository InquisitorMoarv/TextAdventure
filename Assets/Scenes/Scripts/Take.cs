using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="TextAdventure/InputAction/Take")]
public class Take : InputAction
{
    public override void RespondToInput(GameController controller, string[] inputWords)
    {
        controller.interactionHandler.Take(controller.roomHandler.currtentRoom, inputWords[1]);
    }
}
