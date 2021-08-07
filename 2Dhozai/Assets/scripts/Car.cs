using UnityEngine;    //�ޥ�unity�������Ѫ�API(unity engine �R�W�Ŷ�)

public class Car : MonoBehaviour
{
    #region ����
    //�����ѡG�K�[�����B½Ķ�B��������...�|�Q�{������
    //2021.07.17(��)�}�o�T���}��

    /*�h�����
     * �h�����
     * �h�����
     * �h�����
     */
    #endregion 

    #region ���P�|�j����
    //���G�x�s²�檺���
    //�y�k�G
    //������� ���W�� ���w�Ÿ� �w�]�� ����
    //���w�Ÿ� =
    //�׹����G
    //1.�p�H private �w�] - �����
    //2.���} public           - ���

    //Unity ���`�Ϊ��|�j����
    //���    int        �ҡG1�A99�A0�A-123
    //�B�I�� float    ��:2.3�A3.1415�A-1.123(�᭱F�j�p�g���i)
    //�r��    string   �ҡGBMW�A���h�A��ܤ��e
    //���L�� bool     �ҡGtrue,false
    

    //�w�q��� field (���q�ACC�ơA�~�P�A���L�ѵ��A�C��)
    //�HUnity���ݩʭ��Oinspector�ƭȬ��D
    public float weight = 3.5f;
    public int cc = 2000;
    public string brand = "���h";
    public bool windowsky = true;

    //�i�H�ϥΤ���A������ĳ-�s�X&�ഫ�į���D
    public int ���L�ƶq = 4;

    //����ݩʡG���U���K�[�B�~�\��
    //�y�k[�ݩʦW��(�ݩʭ�)]
    //���D�G[Header(�r��)]
    [Header("���L�ƶq")]
    public int wheelcount = 4;
    //���ܡG[tooltip(�r��)]���|��ܦb���O�A�ƹ����d�~�|�X�{
    [Tooltip("�o�����O�]�w�T������")]
    public float height = 1.5f;
    //�d��G[Range(�̤p��,�̤j��)]-�ȭ�Float&int
    [Range(2,10)]
    public int doorcount;
    #endregion 

    #region ��L����
    //�C�� color
    public Color color1;                                                                  //�����w���¦�z��
    public Color red = Color.red;                                                   //�ϥιw�]�C��
    public Color yellow = Color.yellow;
    public Color colorCustom1 =new Color(0.5f,0.5f,0);             //�ۭq�C��(R,G,B)
    public Color colorCustom2 = new Color(0.5f, 0,0.5f, 0.5f);  //�ۭq�C��(R,G,B,A)

    //�y�� 2-4�� Vector2-4
    //�O�s�ƭȸ�T - �B�I��
    public Vector2 v2;
    public Vector2 v2zero = Vector2.zero;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2up = Vector2.up;
    public Vector2 v2right = Vector2.right;
    public Vector2 v2custom = new Vector2(-99.5f, 100.5f);

    //��������
    public KeyCode kc;
    public KeyCode forward = KeyCode.D;
    public KeyCode attack = KeyCode.Mouse0;  //����0,�k��1,�u��2

    //�C������P����
    public GameObject goCamera;  //�C������]�t�����W���H�αM�פ����w�m��
    //����ȭ���s���ݩʭ��O�������󪺪��~
    public Transform tracar;
    public SpriteRenderer sprPicture;
    #endregion

    #region �ƥ�
    //�}�l�ƥ�G����C���ɰ���@���A�B�z��l��
    private void Start()
    {
        #region �m�����
        //��X(�����������)
        print("knight test");

        //�m�ߨ��o��� Get
        print(brand);
        //�m�߳]�w��� Set
        windowsky = true;
        cc = 5000;
        weight = 9.9f;
        #endregion

        //�I�s��k�y�k�G��k�W��()
        Drive50();
        Drive100();
        Drive(150,"������");           //�I�s�ɤp�������٬��޼�(�ݶ�Ʀr) �޼ƥ����Ҷ�
        Drive(200,"�F�F�F");
        Drive(300);                         //���w�]�Ȫ��Ѽ�( = "������)"�i�H���ε��޼�(,"�F�F�F")

        Drive(80, "�H��");               //�ɼ�8 0 ���ĸH�� �S�� �ǹ�    __ ���~
        Drive(90,effect: "�H��");    //�ɼ�9 0 ���ī����� �S�ĸH��  __ ���T
        //�ϥΦh�ӹw�]�ȰѼƮɥi�H�ϥ� �ѼƦW��:��
        
        float kg = KG();                 //�ϰ��ܼ�_�Ȧb���A�����ϥ�
        print("�ର���窺��T:" + kg);

        print("BMI:" + BMI(60, 1.68f));  //�����N�Ǧ^��k���Ȩϥ�
    }
    
    //��s�ƥ�G�j���@��60���A60fps�A�B�z���󲾰ʩάO��ť���a��J
    private void Update()
    {
        print("hi");
    }
    #endregion

# region ��kmethod
    //��k�G��@����������欰�A�Ҧp�G�T�����e�}�B�}�ҨT�������T�ü��񭵼�
    //���y�k�G�׹��� ���� �W�� ���w �w�]��;
    //��k�y�k�G �׹��� �Ǧ^���� �W�� (�Ѽ�)�a�{���϶��b(�n�b��)
    //�����Gvoid-�L�Ǧ^
    //�w�q��k�G���|����A�����I�s-�b�ƥ󤺩I�s����k
    //���@�ʡB�X�R��
    private void Drive50()
    {
        print("�}����50~");
    }

    private void Drive100()
    {
        print("�}����100~");
    }
    //�Ѽƻy�k�G���� �ѼƦW�� - �g�b�p�A���� (�Ȧb����k�i�ϥ�)
    //�Ѽ�1,�Ѽ�2,�Ѽ�3.....�Ѽ�N(�ɶq�O��5�H��)
    //�Ѽƹw�]�G���� �ѼƦW�� ���w ��
    //�w�]�ȥu���b�̥k��(int speed�n��b���w�]�Ȫ��e��)
    
    /// <summary>
    /// �o�O�}������k�A�i�H�Ψӽվ㨮�l���t�סB���ĻP�S��
    /// </summary>
    /// <param name="speed">�t��</param>
    /// <param name="sound">����</param>
    /// <param name="effect">�S��</param>
    private void Drive (int speed, string sound = "������", string effect = "�ǹ�")
    {
        print("�}����~" + speed);
        print("�}������~" + sound);
        print("�}���S��~" + effect);
    }

    /// <summary>
    /// �����ഫ������
    /// </summary>
    /// <returns>�ର���窺���q��T</returns>
    private float KG()
    {
        return weight * 1000;
    }

    /// <summary>
    /// BMI�p��
    /// </summary>
    /// <param name="weght">�魫</param>
    /// <param name="height">����</param>
    /// <returns></returns>
    private float BMI(float weght, float height)
    {
        return weght / (height * height);
    }
    #endregion
}
