using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenario : MonoBehaviour
{
    public GameObject gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        Gamemanager Gamemanager = gamemanager.GetComponent<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
