using UnityEngine;

public class player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speet = 10.5f;
    [Header("跳躍高度"), Range(0, 3000)]
    public int height = 100;
    [Header("血量"), Range(0, 200)]
    public int hp = 100;
    [Header("是否在地板上"), Tooltip("儲存腳色是否在地上")]
    public bool floor = false;

    AudioSource aud;
    Rigidbody2D rig;
    Animator ani;
    #endregion

    #region 事件

    #endregion

    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    /// <param name="horizontal">左右數值</param>
    private void Move(float horizontal)
    {

    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    {

    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">造成的傷害</param>
    public void Damage(float damage)
    {

    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 吃道具
    /// </summary>
    /// <param name="propName">道具名稱</param>
    private void EatProp(string propName)
    {

    }

}

    #endregion
