using UnityEngine;

//�{�ѹB��l
//1.�ƾǹB��l

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
        #region �ƾǹB��l
        print(a + b);     //13
        print(a - b);     //7
        print(a * b);     //30
        print(a / b);     //3
        print(a % b);    //1

        C = C + 1;        //=���w�Ÿ��G�k����B��A���w������
        C++;                //²�g
        print("C�B�⧹�����G"+C);

        //���w�B��
        //�Ҥl�G���� 13
        hp = hp - 13;   //87
        hp -= 13;         //74

        //�Ҥl�G�ɦ� 20
        hp += 20;       //94
        #endregion

        #region ����B��l
        //>< >= <= == !=
        //�ϥΤ��[����l�����G���O���L��
        //������T���G��true �_��false
        print("99 �j��1:" + (scoreA > scoreB));               //true
        print("99 �p��1:" + (scoreA < scoreB));               //false
        print("99 �j�󵥩�1:" + (scoreA >= scoreB));     //true
        print("99 �p�󵥩�1:" + (scoreA <= scoreB));     //false
        print("99 ����1:" + (scoreA = scoreB));              //false
        print("99 ������1:" + (scoreA != scoreB));          //true
        #endregion

        #region �޿�B��l
        //����ⵧ���L�ȸ��
        //�åB - &&
        //�u�n���@�ӥ��L�Ȭ� false ���G�N��false
        print(true && true);     //true
        print(true && false);    //false
        print(false && true);    //false
        print(false && false);   //false

        //�Ϊ� - ||
        //�u�n���@�ӥ��L�Ȭ� true ���G�N��true
        print(true && true);     //true
        print(true && false);    //true
        print(false && true);    //true
        print(false && false);   //false

        //�L������G��q �j��0  �åB �_�� �n����1
        print("�O�_�L��" + (health > 0 && key == 1));
        //�L������G�_�c �j�󵥩�5  �Ϊ� �p�� �j�󵥩�2
        print("�O�_�L��" + (chest >= 5 || diamond >= 2));

        //�ۤ� !
        print(!true);
        print(!false);
        #endregion
    }

}
