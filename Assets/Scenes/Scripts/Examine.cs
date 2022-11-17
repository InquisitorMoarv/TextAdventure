using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "TextAdventure/InputAction/Examine")]
public class Examine : InputAction
{
    public override void RespondToInput(GameController controller, string[] inputWords)
    {
        controller.WriteToTerminal(controller.TestVerbDictionaryWithNoun(controller.interactionHandler.examineDictornay, inputWords[0], inputWords[1]));
    }

}
