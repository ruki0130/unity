using UnityEngine;

public class player : MonoBehaviour
{
    #region ���
    [Header("���ʳt��"), Range(0, 1000)]
    public float speet = 10.5f;
    [Header("���D����"), Range(0, 3000)]
    public int height = 100;
    [Header("��q"), Range(0, 200)]
    public int hp = 100;
    [Header("�O�_�b�a�O�W"), Tooltip("�x�s�}��O�_�b�a�W")]
    public bool floor = false;

    AudioSource aud;
    Rigidbody2D rig;
    Animator ani;
    #endregion

    #region �ƥ�

    #endregion

    #region ��k
    /// <summary>
    /// ����
    /// </summary>
    /// <param name="horizontal">���k�ƭ�</param>
    private void Move(float horizontal)
    {

    }

    /// <summary>
    /// ���D
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// ����
    /// </summary>
    private void Attack()
    {

    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="damage">�y�����ˮ`</param>
    public void Damage(float damage)
    {

    }

    /// <summary>
    /// ���`
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// �Y�D��
    /// </summary>
    /// <param name="propName">�D��W��</param>
    private void EatProp(string propName)
    {

    }

}

    #endregion
