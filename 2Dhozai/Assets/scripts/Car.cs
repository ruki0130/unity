using UnityEngine;

public class Car : MonoBehaviour
{
    #region 註解
    //單行註解：添加說明、翻譯、紀錄等等...會被程式忽略
    //2021.07.17(六)開發汽車腳本

    /*多行註解
     * 多行註解
     * 多行註解
     * 多行註解
     */
    #endregion 

    #region 欄位與四大類型
    //欄位：儲存簡單的資料
    //語法：
    //資料類型 欄位名稱 指定符號 預設值 結尾
    //指定符號 =
    //修飾詞：
    //1.私人 private 預設 - 不顯示
    //2.公開 public           - 顯示

    //Unity 內常用的四大類型
    //整數    int        例：1，99，0，-123
    //浮點數 float    例:2.3，3.1415，-1.123(後面F大小寫都可)
    //字串    string   例：BMW，賓士，對話內容
    //布林值 bool     例：true,false
    

    //定義欄位 field (重量，CC數，品牌，有無天窗，顏色)
    //以Unity的屬性面板inspector數值為主
    public float weight = 3.5f;
    public int cc = 2000;
    public string brand = "賓士";
    public bool windowsky = true;

    //可以使用中文，但不建議-編碼&轉換效能問題
    public int 輪胎數量 = 4;

    //欄位屬性：輔助欄位添加額外功能
    //語法[屬性名稱(屬性值)]
    //標題：[Header(字串)]
    [Header("輪胎數量")]
    public int wheelcount = 4;
    //提示：[tooltip(字串)]不會顯示在面板，滑鼠停留才會出現
    [Tooltip("這個欄位是設定汽車高度")]
    public float height = 1.5f;
    //範圍：[Range(最小數,最大數)]-僅限Float&int
    [Range(2,10)]
    public int doorcount;
    #endregion 

    #region 其他類型
    //顏色 color
    public Color color1;                                                                  //不指定為黑色透明
    public Color red = Color.red;                                                   //使用預設顏色
    public Color yellow = Color.yellow;
    public Color colorCustom1 =new Color(0.5f,0.5f,0);             //自訂顏色(R,G,B)
    public Color colorCustom2 = new Color(0.5f, 0,0.5f, 0.5f);  //自訂顏色(R,G,B,A)

    //座標 2-4維 Vector2-4
    //保存數值資訊 - 浮點數
    public Vector2 v2;
    public Vector2 v2zero = Vector2.zero;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2up = Vector2.up;
    public Vector2 v2right = Vector2.right;
    public Vector2 v2custom = new Vector2(-99.5f, 100.5f);

    //按鍵類型
    public KeyCode kc;
    public KeyCode forward = KeyCode.D;
    public KeyCode attack = KeyCode.Mouse0;  //左鍵0,右鍵1,滾輪2

    //遊戲物件與元件
    public GameObject goCamera;  //遊戲物件包含場景上的以及專案內的預置物
    //元件僅限於存放屬性面板有此元件的物品
    public Transform tracar;
    public SpriteRenderer sprPicture;
    #endregion

    #region 事件
    //開始事件：播放遊戲時執行一次，處理初始化
    private void Start()
    {
        //輸出(任何類型資料)
        print("knight test");

        //練習取得欄位 Get
        print(brand);
        //練習設定欄位 Set
        windowsky = true;
        cc = 5000;
        weight = 9.9f;
    }
    
    //更新事件：大約一秒60次，60fps，處理物件移動或是監聽玩家輸入
    private void Update()
    {
        print("hi");
    }
    #endregion
}
