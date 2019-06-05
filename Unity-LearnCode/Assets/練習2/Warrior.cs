using UnityEngine;
[System.Serializable]

public class Warrior
{
    public int exp;
    public int lv;
    /// <summary>
    /// 取得預設定戰士的經驗值
    /// </summary>
    public int Exp
    {
        get
        {
            return lv * 10;
        }
        set
        {
            exp = value;
        }
    }
}
