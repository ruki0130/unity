using UnityEngine;

public class player : MonoBehaviour
{
    [Header("���ʳt��"),Range(0, 1000)]
    public float speet = 10.5f;
    [Header("���D����"),Range(0, 3000)]
    public int height = 100;
    [Header("��q"),Range(0, 200)]
    public int hp = 100;
    [Header("�O�_�b�a�O�W"),Tooltip("�x�s�}��O�_�b�a�W")]
    public bool floor = false;

    AudioSource aud;
    Rigidbody2D rig;
    Animator ani;

}
