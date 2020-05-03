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
    public static readonly string Dialogue0 = "僕は「(主人公名)」。";
    public static readonly string Dialogue1 = "どこにでもいる普通の15歳。";
    public static readonly string Dialogue2 = "僕は今、高校の体育館にいる。";
    public static readonly string Dialogue3 = "校長「えー、新入生の皆様、入学おめでとうございます。」";
    public static readonly string Dialogue4 = "この言葉で高校生になったことを改めて実感する。";
    public static readonly string Dialogue5 = "小学校、中学校と違って、同級生のほとんどが見知らぬ顔ばかりだった。";
    public static readonly string Dialogue6 = "当たり前なのだけど、それでも不安のあまり誰か知っている人がいないか確認せずにはいられなかった。";
    public static readonly string Dialogue7 = "ここで3年間、ちゃんとやっていけるだろうか。";
    public static readonly string Dialogue8 = "そんなことを考えながらぼーっと座っていると、少し離れたところに1人の女子が体育館の端に立っているのが見えた。";
    public static readonly string Dialogue9 = "眼鏡はしていないが、黒髪のいかにも優等生という感じの人だ。";
    public static readonly string Dialogue10 = "上級生かな。彼女はゆっくりと壁に沿って歩いていく。";
    public static readonly string Dialogue11 = "放送「次は、新入生代表挨拶。新入生代表の(名前)さん、お願いします。」";
    public static readonly string Dialogue12 = "女子生徒「はい」";
    public static readonly string Dialogue13 = "凛とした声で彼女はそう答えて、檀上へ静かに上っていった。";
    public static readonly string Dialogue14 = "女子生徒「桜の花があたたかい春の風に舞う今日.....」";
    public static readonly string Dialogue15 = "折りたたまれた紙を広げ、代表挨拶を読み上げる。";
    public static readonly string Dialogue16 = "しっかりしていて、とても同級生には見えない。";
    public static readonly string Dialogue17 = "同じクラスだったらいいのにな、とほのかな期待を寄せる。";
    public static readonly string Dialogue18 = "もしそうだったとしても僕には声をかける勇気なんてないけれど。";
    public static readonly string Dialogue19 = "中学のときは、女子からしゃべりかけられたらしゃべるけど、自分から進んで";
    public static readonly string Dialogue20 = "話しかけようとする気にはならなかった。緊張するし...";
    public static readonly string Dialogue21 = "でも、もう高校生だし、女子に限らず積極的に話しかけていかなきゃなあ。";
    public static readonly string Dialogue22 = "..........";
    public static readonly string Dialogue23 = "..............";
    public static readonly string Dialogue24 = "放送「...です。新入生、起立!」";
    public static readonly string Dialogue25 = "慌てて立ち上がる。式はだいぶ進行していたみたいで、いつの間にか新入生退場にまでなっていた。";
    public static readonly string Dialogue26 = "不安だけどきっと周りも同じだし、すぐに友達もできるさ。";
    public static readonly string Dialogue27 = "そう心の中で呟きながら、僕は体育館を後にする。";
    public static readonly string Dialogue28 = "そしてこれから始まる学校生活に胸を躍らせるのだった。";
    public static readonly string Dialogue29 = "4月某日。";
    public static readonly string Dialogue30 = "賑やかな休み時間の中、僕は自分の席にひとり座っている。入学式から2週間経ち、周りは個々に人間関係を築いている中、";
    public static readonly string Dialogue31 = "僕は未だ1人も友達ができずにいた。";
    public static readonly string Dialogue32 = "「はぁ...」";
    public static readonly string Dialogue33 = "思わず溜息が出てしまう。";
    public static readonly string Dialogue34 = "元々僕はそこそこ人見知りをする方で、昔から友達は少なかった。加えて、その数少ない友人のうちの誰も、僕と同じ学校ではない。";
    public static readonly string Dialogue35 = "振り返ってみれば、友達作りのチャンスがないわけではなかった。";
    public static readonly string Dialogue36 = "";
    public static readonly string Dialogue37 = "";
    public static readonly string Dialogue38 = "";
    public static readonly string Dialogue39 = "";
    public static readonly string Dialogue40 = "";
    public static readonly string Dialogue41 = "";
    public static readonly string Dialogue42 = "";
    public static readonly string Dialogue43 = "";
    public static readonly string Dialogue44 = "";
    public static readonly string Dialogue45 = "";
    public static readonly string Dialogue46 = "";
    public static readonly string Dialogue47 = "";
    public static readonly string Dialogue48 = "";
    public static readonly string Dialogue49 = "";
    public static readonly string Dialogue50 = "";
    public static readonly string Dialogue51 = "";
    public static readonly string Dialogue52 = "";
    public static readonly string Dialogue53 = "";
    public static readonly string Dialogue54 = "";
    public static readonly string Dialogue55 = "";
    public static readonly string Dialogue56 = "";
    public static readonly string Dialogue57 = "";
    public static readonly string Dialogue58 = "";
    public static readonly string Dialogue59 = "";
    public static readonly string Dialogue60 = "";
    public static readonly string Dialogue61 = "";
    public static readonly string Dialogue62 = "";
    public static readonly string Dialogue63 = "";
    public static readonly string Dialogue64 = "";
    public static readonly string Dialogue65 = "";
    public static readonly string Dialogue66 = "";
    public static readonly string Dialogue67 = "";
    public static readonly string Dialogue68 = "";
    public static readonly string Dialogue69 = "";
    public static readonly string Dialogue70 = "";
    public static readonly string Dialogue71 = "";
    public static readonly string Dialogue72 = "";
    public static readonly string Dialogue73 = "";
    public static readonly string Dialogue74 = "";
    public static readonly string Dialogue75 = "";
    public static readonly string Dialogue76 = "";
    public static readonly string Dialogue77 = "";
    public static readonly string Dialogue78 = "";
    public static readonly string Dialogue79 = "";
    public static readonly string Dialogue80 = "";
    public static readonly string Dialogue89 = "";
    public static readonly string Dialogue90 = "";
    public static readonly string Dialogue91 = "";
    public static readonly string Dialogue92 = "";
    public static readonly string Dialogue93 = "";
    public static readonly string Dialogue94 = "";
    public static readonly string Dialogue95 = "";
    public static readonly string Dialogue96 = "";
    public static readonly string Dialogue97 = "";
    public static readonly string Dialogue98 = "";
    public static readonly string Dialogue99 = "";
    public static readonly string Dialogue100 = "";
    public static readonly string Dialogue101 = "";

    public static readonly string[] Dialogues =
{
        Dialogue0,
        Dialogue1,
        Dialogue2,
        Dialogue3,
        Dialogue4,
        Dialogue5,
        Dialogue6,
        Dialogue7,
        Dialogue8,
        Dialogue9,
        Dialogue10,
        Dialogue11,
        Dialogue12,
        Dialogue13,
        Dialogue14,
        Dialogue15,
        Dialogue16,
        Dialogue17,
        Dialogue18,
        Dialogue19,
        Dialogue20,
        Dialogue21,
        Dialogue22,
        Dialogue23,
        Dialogue24,
        Dialogue25,
        Dialogue26,
        Dialogue27,
        Dialogue28,
        Dialogue29,
        Dialogue30,
        Dialogue31,
        Dialogue32,
        Dialogue33,
        Dialogue34,
        Dialogue35,
        Dialogue36,
        Dialogue37,
        Dialogue38,
        Dialogue39,
        Dialogue40,
        Dialogue41,
        Dialogue42,
        Dialogue43,
        Dialogue44,
        Dialogue45,
        Dialogue46,
        Dialogue47,
        Dialogue48,
        Dialogue49,
        Dialogue50,
        Dialogue51,
        Dialogue52,
        Dialogue53,
        Dialogue54,
        Dialogue55,
        Dialogue56,
        Dialogue57,
        Dialogue58,
        Dialogue59,
        Dialogue60
    };
}
