using UnityEngine;

public class player : MonoBehaviour
{
    [Header("移動速度"),Range(0, 1000)]
    public float speet = 10.5f;
    [Header("跳躍高度"),Range(0, 3000)]
    public int height = 100;
    [Header("血量"),Range(0, 200)]
    public int hp = 100;
    [Header("是否在地板上"),Tooltip("儲存腳色是否在地上")]
    public bool floor = false;

    AudioSource aud;
    Rigidbody2D rig;
    Animator ani;

}
