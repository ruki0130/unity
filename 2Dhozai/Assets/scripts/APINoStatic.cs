using UnityEngine;

public class APINoStatic : MonoBehaviour
{
    //API���G������j�� 
    //1.�R   �A�G������r(static)
    //2.�D�R�A�G�L����r

    //�ϥΫD�R�A�ݩ�
    //1.���w�q���D�R�A�ݩʪ����O���
    public Transform traA;
    public Camera cam;
    public Transform traB;
    public Light lightA;

    public Camera camA;
    public SpriteRenderer srA;
    public Transform traC;
    public Rigidbody2D rig;

    private void Start()
    {
        #region �{�ѫD�R�A
        //1.���o�D�R�A�ݩ�
        //print("���o�y��" + Transform.position); __���~

        //�ϥΫD�R�A�ݩ�
        //2.�ϥλy�k�G���.�D�R�A�ݩ�
        //3.��쥲����J�n������T���� _���ର�ŭ�
        print("���o�ߤ���y��:" + traA.position);
        print("���o��v�����I���C��" + cam.backgroundColor);

        //2.�]�w�D�R�A�ݩ�
        //�y�k�G���.�D�R�A�ݩ� ���w ��;
        cam.backgroundColor = new Color(0.8f, 0.5f, 0.6f);

        //3.�I�s�D�R�A��k
        //�y�k�G���.�D�R�A��k(�������޼�);
        traB.Translate(1, 0, 0);
        lightA.Reset();
        #endregion

        #region �D�R�A�m��
        //1.���o�D�R�A�ݩ�
        print("��v���`��:" + camA.depth);
        print("�Ϥ�1�C��:" + srA.color);

        //2.�]�w�D�R�A�ݩ�
        camA.backgroundColor = Random.ColorHSV();
        srA.flipY = true;

        #endregion
    }

    private void Update()
    {
        //3.�I�s�D�R�A��k
        traC.Rotate(0, 0, 1);
        rig.AddForce(new Vector2(0, 10));
    }
}
