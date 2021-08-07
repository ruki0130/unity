using UnityEngine;

/// <summary>
/// 認識API以及第一種用法：靜態 static
/// </summary>

public class APIStatic : MonoBehaviour
{
    //API文件分為兩大類
    //1.靜   態：有關鍵字(static)
    //2.非靜態：無關鍵字

    //欄位
    //屬性：Properties 可以理解為等同於欄位
    //方法：Methods

    private void Start()
    {
        #region 認識靜態屬性與方法
        //靜態屬性
        //1.取得
        //語法：類別.靜態屬性
        print("隨機值:" + Random.value);                     //0~1值
        print("無限大:" + Mathf.Infinity);

        //2.設定
        //語法：類別.靜態屬性 指定 值;
        Cursor.visible = false;          //滑鼠指標可見度 -只有在觸碰game視窗後
        //Random.value = 7.7f;   - 唯獨屬性不能設定 Read Only
        Screen.fullScreen = true;

        //靜態方法
        //3.呼叫
        //語法：類別.靜態方法(對應引數);
        float r = Random.Range(7.5f, 9.8f);
        print("隨機範圍7.5~9.8:" + r);
        #endregion

        #region 練習
        //取得靜態屬性
        print("所有攝影機數量" + Camera.allCamerasCount);
        print("2D重力" + Physics2D.gravity);
        print("圓周率" + Mathf.PI);
        //設定靜態屬性
        Physics2D.gravity = new Vector2(0, -20);
        print("2D重力" + Physics2D.gravity);
        Time.timeScale = 0.5f;      //慢動作  - 快動作 2 / 暫停 0
        print("時間大小" + Time.timeScale);

        //呼叫靜態的方法
        number = Mathf.Floor(number);
        print("9099去小數點" + number);

        float d = Vector3.Distance(a, b);
        print("AB距離" + d);

        Application.OpenURL("https://unity.com/");
        #endregion
    }

    public float hp = 78;
    public float number = 9.99f;
    public Vector3 a = new Vector3(1, 1, 1);
    public Vector3 b = new Vector3(22,22,22);
    private void Update()
    {
        hp = Mathf.Clamp(hp, 0, 100);    //數學,夾住(值,最小值,最大值) - 將輸入的值夾在最小最大範圍內
        print("血量" + hp);

        #region 練習
        //取得靜態屬性
        print("是否按下任意鍵" + Input.anyKey);
        print("遊戲過了多久" + Time.time);

        //呼叫靜態方法
        bool space = Input.GetKeyDown("space");
        print("是否按下空白鍵" + space);
        #endregion
    }
}
