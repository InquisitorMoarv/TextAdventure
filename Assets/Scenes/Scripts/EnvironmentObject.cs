using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/Room")]
public class EnviromentObject : ScriptableObject
{
    public string noun = "name";
    [TextArea]
    public string description = "Description of Object";
    public Interaction[] interactions;
}
