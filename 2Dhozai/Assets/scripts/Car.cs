using UnityEngine;

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
        //��X(�����������)
        print("knight test");

        //�m�ߨ��o��� Get
        print(brand);
        //�m�߳]�w��� Set
        windowsky = true;
        cc = 5000;
        weight = 9.9f;
    }
    
    //��s�ƥ�G�j���@��60���A60fps�A�B�z���󲾰ʩάO��ť���a��J
    private void Update()
    {
        print("hi");
    }
    #endregion
}
