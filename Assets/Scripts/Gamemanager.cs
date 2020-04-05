using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public Text Dialoguetext;
    public Text Nametext;
    // Start is called before the first frame update
    void Start()
    {
        Nametext.text = StringClass.CharacterText0;
        Dialoguetext.text = StringClass.DialogueText0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
