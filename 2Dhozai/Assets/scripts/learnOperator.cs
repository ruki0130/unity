using UnityEngine;

//認識運算子
//1.數學運算子

public class learnOperator : MonoBehaviour
{
    public int a = 10;
    public int b = 3;
    public int C = 7;
    public int hp = 100;

    public float scoreA = 99;
    public float scoreB = 1;

    public int health = 50;
    public int key = 1;
    public int chest = 7;
    public int diamond = 0;

    private void Start()
    {
        #region 數學運算子
        print(a + b);     //13
        print(a - b);     //7
        print(a * b);     //30
        print(a / b);     //3
        print(a % b);    //1

        C = C + 1;        //=指定符號：右邊先運算再指定給左邊
        C++;                //簡寫
        print("C運算完的結果"+C);

        //指定運算
        //例子：扣血 13
        hp = hp - 13;   //87
        hp -= 13;         //74

        //例子：補血 20
        hp += 20;       //94
        #endregion

        #region 比較運算子
        //>< >= <= == !=
        //使用比較[ˋ算子的結果都是布林值
        //比較正確結果為true 否為false
        print("99 大於1:" + (scoreA > scoreB));               //true
        print("99 小於1:" + (scoreA < scoreB));               //false
        print("99 大於等於1:" + (scoreA >= scoreB));     //true
        print("99 小於等於1:" + (scoreA <= scoreB));     //false
        print("99 等於1:" + (scoreA = scoreB));              //false
        print("99 不等於1:" + (scoreA != scoreB));          //true
        #endregion

        #region 邏輯運算子
        //比較兩筆布林值資料
        //並且 - &&
        //只要有一個布林值為 false 結果就為false
        print(true && true);     //true
        print(true && false);    //false
        print(false && true);    //false
        print(false && false);   //false

        //或者 - ||
        //只要有一個布林值為 true 結果就為true
        print(true && true);     //true
        print(true && false);    //true
        print(false && true);    //true
        print(false && false);   //false

        //過關條件：血量 大於0  並且 鑰匙 要等於1
        print("是否過關" + (health > 0 && key == 1));
        //過關條件：寶箱 大於等於5  或者 鑽石 大於等於2
        print("是否過關" + (chest >= 5 || diamond >= 2));

        //相反 !
        print(!true);
        print(!false);
        #endregion
    }

}
