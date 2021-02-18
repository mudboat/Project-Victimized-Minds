using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class FadeScript : MonoBehaviour
{
    bool IsFadeOut; //フェードアウトをするかどうか
    public bool IsFade; //フェードの演出をするかどうか
    public float speed; //フェードの速さ
    Image image;



    void Start()
    {
        image = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFade)
        {
            if (IsFadeOut)
            {
                //フェードアウトの処理
                if (image.color.a < 1) image.color = new Color(0, 0, 0, image.color.a + speed);
                else image.color = new Color(0, 0, 0, 1);
            }
            else
            {
                //フェードインの処理
                if (image.color.a >= 0) image.color = new Color(0, 0, 0, image.color.a - speed);
                else image.color = new Color(0, 0, 0, 0);
            }
        }
    }
    public void StartFade(float s, bool fadeout)
    {
        speed = s;
        IsFadeOut = fadeout ? true : false;
        if (IsFadeOut) image.color = new Color(0, 0, 0, 0);
        else image.color = new Color(0, 0, 0, 1);
        IsFade = true;
    }

}
