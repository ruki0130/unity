using UnityEngine;

/// <summary>
/// �{��API�H�βĤ@�إΪk�G�R�A static
/// </summary>

public class APIStatic : MonoBehaviour
{
    //API��������j��
    //1.�R   �A�G������r(static)
    //2.�D�R�A�G�L����r

    //���
    //�ݩʡGProperties �i�H�z�Ѭ����P�����
    //��k�GMethods

    private void Start()
    {
        #region �{���R�A�ݩʻP��k
        //�R�A�ݩ�
        //1.���o
        //�y�k�G���O.�R�A�ݩ�
        print("�H����:" + Random.value);                     //0~1��
        print("�L���j:" + Mathf.Infinity);

        //2.�]�w
        //�y�k�G���O.�R�A�ݩ� ���w ��;
        Cursor.visible = false;          //�ƹ����Хi���� -�u���bĲ�Igame������
        //Random.value = 7.7f;   - �߿W�ݩʤ���]�w Read Only
        Screen.fullScreen = true;

        //�R�A��k
        //3.�I�s
        //�y�k�G���O.�R�A��k(�����޼�);
        float r = Random.Range(7.5f, 9.8f);
        print("�H���d��7.5~9.8:" + r);
        #endregion

        #region �m��
        //���o�R�A�ݩ�
        print("�Ҧ���v���ƶq" + Camera.allCamerasCount);
        print("2D���O" + Physics2D.gravity);
        print("��P�v" + Mathf.PI);
        //�]�w�R�A�ݩ�
        Physics2D.gravity = new Vector2(0, -20);
        print("2D���O" + Physics2D.gravity);
        Time.timeScale = 0.5f;      //�C�ʧ@  - �ְʧ@ 2 / �Ȱ� 0
        print("�ɶ��j�p" + Time.timeScale);

        //�I�s�R�A����k
        number = Mathf.Floor(number);
        print("9099�h�p���I" + number);

        float d = Vector3.Distance(a, b);
        print("AB�Z��" + d);

        Application.OpenURL("https://unity.com/");
        #endregion
    }

    public float hp = 78;
    public float number = 9.99f;
    public Vector3 a = new Vector3(1, 1, 1);
    public Vector3 b = new Vector3(22,22,22);
    private void Update()
    {
        hp = Mathf.Clamp(hp, 0, 100);    //�ƾ�,����(��,�̤p��,�̤j��) - �N��J���ȧ��b�̤p�̤j�d��
        print("��q" + hp);

        #region �m��
        //���o�R�A�ݩ�
        print("�O�_���U���N��" + Input.anyKey);
        print("�C���L�F�h�[" + Time.time);

        //�I�s�R�A��k
        bool space = Input.GetKeyDown("space");
        print("�O�_���U�ť���" + space);
        #endregion
    }
}
