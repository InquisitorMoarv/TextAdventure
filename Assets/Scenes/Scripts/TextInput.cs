using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    GameController controller;
    public InputField inputField;
    private void Awake()
    {
        controller = GetComponent<GameController>();
        inputField.onEndEdit.AddListener(AcceptStringInput);
    }
    void AcceptStringInput(string userInput)
    {
        userInput = userInput.ToLower();
        controller.WriteToTerminal(userInput);
        char[] delimiterCharaters = { ' ' };
        string[] seperatedInputWords = userInput.Split(delimiterCharaters);

        for (int i = 0; i < controller.inputActions.Length; i++)
        {
            InputAction inputAction = controller.inputActions[i];
            if(inputAction.keyword == seperatedInputWords[0])
            {
                inputAction.RespondToInput(controller, seperatedInputWords);
            }
        }
        InputComplete();
    }

    void InputComplete()
    {
        controller.DisplayLoggedText();
        inputField.ActivateInputField(); //fokus wieder auf input field
        inputField.text = null;
    }
}
