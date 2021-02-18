using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scenario1 : MonoBehaviour
{
    public GameObject gamemanager;
    Gamemanager Gamemanager;
    //初期のダイアログID
    int Cid = 0;
    //初期のキャラ名ID
    int Ccid = 2;
    void Start()
    {
        Gamemanager = gamemanager.GetComponent<Gamemanager>();
        Gamemanager.ChangeName(Ccid);
        Gamemanager.ChangeDialogue(Cid);
    }

    void Update()
    {
        Maine(Cid);    
    }

    //選ばれた選択肢を返す
    int Choices(int a)
    {
        if (Input.GetKeyUp("1"))
        {
            return 1;
        }
        else
        if (Input.GetKeyUp("2"))
        {
            return 2;
        }
        else
        if (Input.GetKeyUp("3"))
        {
            return 3;
        }
        else
            return 0;
    }

    void Maine(int a)
    {
        //選択肢やキャラ名や画像変化等の動作が必要な時をcaseに
        switch (a)
        {
            case 52:
                if (Choices(3) == 1)
                {
                    Gamemanager.ChangeDialogue(55);
                    Cid = 55;
                    break;
                }
                else
                if (Choices(3) == 2)
                    {
                    break;
                    }
                else
                if (Choices(3) == 3)
                    {
                    break;
                    }
                else
               break;

            default:
                if (Input.GetKeyUp(KeyCode.Return)) { Gamemanager.ChangeDialogue(a + 1);
                    Cid += 1; }
                break;
        }
    }

}
