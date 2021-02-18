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
    public static readonly string Dialogue0 = "僕は「古田　史郎」。";
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
    public static readonly string Dialogue22 = "どう話しかけたらいいだろうか。";
    public static readonly string Dialogue23 = "話しかけられたらどう答えればいいだろうか。";
    public static readonly string Dialogue24 = "とりあえず男子同級生でシュミレーションしてみる。";
    public static readonly string Dialogue25 = "想像や空想は僕のささやかな特技だった。";
    public static readonly string Dialogue26 = "気が済むまで空想したのち、僕の意識は体育館に帰ってくる。";
    public static readonly string Dialogue27 = "檀上で50代だろうか、男性が話している。";
    public static readonly string Dialogue28 = "式開始から40分が経過していた。";
    public static readonly string Dialogue29 = "予定では式は1時間半で終わるらしいけど...";
    public static readonly string Dialogue30 = "退屈だ。欠伸を噛み殺して姿勢を正し式が終わるのを待つ。";
    public static readonly string Dialogue31 = "(暗転)";
    public static readonly string Dialogue32 = "zzzzzzzzzzzzz";
    public static readonly string Dialogue33 = "放送「...です。新入生、起立!」";
    public static readonly string Dialogue34 = "慌てて立ち上がる。式はだいぶ進行していたみたいで、いつの間にか新入生退場にまでなっていた。";
    public static readonly string Dialogue35 = "不安だけどきっと周りも同じだし、すぐに友達もできるさ。";
    public static readonly string Dialogue36 = "そう心の中で呟きながら、僕は体育館を後にする。";
    public static readonly string Dialogue37 = "そしてこれから始まる学校生活に胸を躍らせるのだった。";
    public static readonly string Dialogue38 = "(場面転換)";
    public static readonly string Dialogue39 = "(賑やかなしゃべり声のSE)";
    public static readonly string Dialogue40 = "4月某日。";
    public static readonly string Dialogue41 = "賑やかな休み時間の中、僕は自分の席にひとり座っている。入学式から2週間経ち、周りは個々に人間関係を築いている中、";
    public static readonly string Dialogue42 = "僕は未だ1人も友達ができずにいた。";
    public static readonly string Dialogue43 = "「はぁ...」";
    public static readonly string Dialogue44 = "思わず溜息が出てしまう。";
    public static readonly string Dialogue45 = "元々僕はそこそこ人見知りをする方で、昔から友達は少なかった。加えて、";
    public static readonly string Dialogue46 = "その数少ない友人のうちの誰も、僕と同じ学校ではない。";
    public static readonly string Dialogue47 = "振り返ってみれば、友達作りのチャンスがないわけではなかった。";
    public static readonly string Dialogue48 = "自己紹介のときに何か気の利くことの1つや2つ言えれば...";
    public static readonly string Dialogue49 = "声をかけられたときに、もっとよい対応ができていれば...";
    public static readonly string Dialogue50 = "そんな後悔ばかりが延々と頭の中を巡る。";
    public static readonly string Dialogue51 = "周りの笑い声が自分が孤独であることを痛烈に感じさせる。";
    public static readonly string Dialogue52 = "これからどうしよう...";
    public static readonly string Dialogue53 = "1.選択肢1\n2.選択肢2\n3.選択肢3";
    public static readonly string Dialogue54 = "(場面転換)";
    public static readonly string Dialogue55 = "あれから3週間が経った。僕にはたくさんの友達がいる。";
    public static readonly string Dialogue56 = "昼休みにはその人たちと一緒にサッカーをして遊んでいる。";
    public static readonly string Dialogue57 = "放課後も何人かとたまに寄り道してラーメンを食べに行ったり。";
    public static readonly string Dialogue58 = "「おい！　聞いてるのか！」";
    public static readonly string Dialogue59 = "数学の授業中、強制的に空想の世界から引き戻される。";
    public static readonly string Dialogue60 = "心なしか数人がくすくすと笑った気がする。";
    public static readonly string Dialogue61 = "現実は3週間前と1つも変わっていなかった。";
    public static readonly string Dialogue62 = "依然として友達はできない。";
    public static readonly string Dialogue63 = "それどころか他の人は各々友人との仲をより深めていると見えて、僕はますます声を掛けづらくなっていた。";
    public static readonly string Dialogue64 = "現実を見るのが辛い。";
    public static readonly string Dialogue65 = "僕はいつしか空想の世界に逃げこむようになった。";
    public static readonly string Dialogue66 = "最初は授業の間の休憩と、昼休みくらいだった。";
    public static readonly string Dialogue67 = "でも空想の世界にいるのが心地よくなっていき、授業中にも度々こうして空想に浸ってしまう。";
    public static readonly string Dialogue68 = "仕方ないんだ。そうしてるほうがずっと楽しいし、何より余計なことを考えなくて済む。";
    public static readonly string Dialogue69 = "(暗転)";
    public static readonly string Dialogue70 = "さらに3週間。";
    public static readonly string Dialogue71 = "ますます僕は空想の中の僕を大きくした。";
    public static readonly string Dialogue72 = "あるとき僕は英雄で、世界を救った。";
    public static readonly string Dialogue73 = "そこは公園のベンチだった。";
    public static readonly string Dialogue74 = "あるとき僕は天才で、世界にその名を轟かせた。";
    public static readonly string Dialogue75 = "そこは休み時間の教室だった。";
    public static readonly string Dialogue76 = "他にも色々な世界で色々なことを成し遂げた。";
    public static readonly string Dialogue77 = "僕は現実がどうかを考えなくなっていた。";
    public static readonly string Dialogue78 = "その世界では僕は周りにたくさんの人がいて、皆僕を称賛した。";
    public static readonly string Dialogue79 = "乖離し肥大した妄想は、僕自体を何処かへ追いやってしまった。";
    public static readonly string Dialogue80 = "素晴らしき世界の奥底で、全部嘘であることは分かっている。";
    public static readonly string Dialogue81 = "これは欺瞞なんだ。こんなのはやめなくちゃいけない。";
    public static readonly string Dialogue82 = "心のどこかでそう思いつつ、それでも空想から離れることは決してできない。";
    public static readonly string Dialogue83 = "現実を見るとは、本当の僕が何者にもなれない空っぽな人間であることを直視するということだから。";
    public static readonly string Dialogue84 = "僕が孤独であることを直視するということだから。";
    public static readonly string Dialogue85 = "もし本物の天才ならあるいは孤独でも平気だっただろうか。";
    public static readonly string Dialogue86 = "独り思案する。";
    public static readonly string Dialogue87= "だがそれが無意味な問いであることを僕は誰よりもよく知っている。";
    public static readonly string Dialogue88 = "知りながら僕は自分に嘘を吐き続ける。";
    public static readonly string Dialogue89 = "......End1.白昼夢に生きる嘘吐きの少年";
    public static readonly string Dialogue90 = "";
    public static readonly string Dialogue91 = "";
    public static readonly string Dialogue92 = "";
    public static readonly string Dialogue93 = "";

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
        Dialogue60,
        Dialogue61,
        Dialogue62,
        Dialogue63,
        Dialogue64,
        Dialogue65,
        Dialogue66,
        Dialogue67,
        Dialogue68,
        Dialogue69,
        Dialogue70,
        Dialogue71,
        Dialogue72,
        Dialogue73,
        Dialogue74,
        Dialogue75,
        Dialogue76,
        Dialogue77,
        Dialogue78,
        Dialogue79,
        Dialogue80,
        Dialogue81,
        Dialogue82,
        Dialogue83,
        Dialogue84,
        Dialogue85,
        Dialogue86,
        Dialogue87,
        Dialogue88,
        Dialogue89,
        Dialogue90,
        Dialogue91,
        Dialogue92,
        Dialogue93,
    };
}
