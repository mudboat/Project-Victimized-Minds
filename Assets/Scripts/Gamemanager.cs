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

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeDialogue(int id)
    {
        Dialoguetext.text = StringClass.Dialogues[id];
    }

    public void ChangeName(int id)
    {
        Nametext.text = StringClass.CharacterNames[id];
    }

    public void Dialoguepanelclicked()
    {

    }
}
