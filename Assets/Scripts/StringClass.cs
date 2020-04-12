using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringClass
{
    //キャラ名
    public static readonly string CharacterName0 = "1man";
    public static readonly string CharacterName1 = "2man";
    public static readonly string CharacterName2 = "3man";

    public static readonly string[] CharacterNames =
    {
        CharacterName0,
        CharacterName1,
        CharacterName2
    };

    //ここから会話文
    //会話文を入力する上でのルール 分岐などが無い限りダイアログのidは飛ばさない
    public static readonly string Dialogue0 = "いち";
    public static readonly string Dialogue1 = "に";
    public static readonly string Dialogue2 = "さぁん";
    public static readonly string Dialogue3 = "し";
    public static readonly string Dialogue4 = "ご";
    public static readonly string Dialogue5 = "ろぉく";
    public static readonly string Dialogue6 = "なな";
    public static readonly string Dialogue7 = "はち";

    public static readonly string[] Dialogues =
{
        Dialogue0,
        Dialogue1,
        Dialogue2,
        Dialogue3,
        Dialogue4,
        Dialogue5,
        Dialogue6,
        Dialogue7
    };
}
