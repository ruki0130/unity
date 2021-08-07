using UnityEngine;
using UnityEngine.SceneManagement;  //�ޥ� �����޲z API

public class SceneController : MonoBehaviour
{
    //Unity �L�k���W�}����]
    //�}����������L�C�A����@��
    //���O�P�ɮצW�٤��P

    //Unity ���s�p��P�}�����q
    //1.���}����k
    //2.�ݭn���骫�󱾦��}��
    //3.���sOn Click �]�w�I���ƥ󬰦�����H�έn�I�s����k

    /// <summary>
    /// ���J�C������
    /// </summary>
    public void LoadGameScene()
    {
        //����1��A���J����
        Invoke("DelayLoadGameScene",1);
    }

    //���ݤ@�q�ɶ��A�����k
    //Invoke ����I�s
    private void DelayLoadGameScene()
    {
        //�����޲z.���J����(�����W��) - ���J���w������
        SceneManager.LoadScene("�C������");
    }
    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame()
    {
        Invoke("DelayQuitGame", 1);
    }

    public void DelayQuitGame()
    {
        Application.Quit();   //���ε{��.���}() - �����C��
        print("���}�C��");     //Quit �b�s�边�����|����

    }
}
