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
        if (Input.GetKeyUp("z") == true)
        {
            Maine(Cid);
        }
    }

    //次のIDを返す
    int Choices()
    {

        return 0;
    }

    void Maine(int a)
    {
        //選択肢やキャラ名や画像変化等の動作が必要な時をcaseに
        switch (a)
        {

            default:
                Gamemanager.ChangeDialogue(a + 1);
                Cid += 1;
                break;
        }
    }

}
