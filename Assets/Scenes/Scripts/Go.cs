using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="TextAdventure/InputAction/Go")]
public class Go : InputAction
{
    public override void RespondToInput(GameController controller, string[] inputWords)
    {
        controller.roomHandler.AttemptToChangeRooms(inputWords[1]);
    }
}
