using UnityEngine;

public class DogManager : MonoBehaviour
{
    public Dog DogA = new Dog("公", 7);
    public Dog DogB = new Dog("母", 9);

    #region 事件
    private void Start()
    {
        DogA.name = "寶寶";
        DogA.weight = 30.5f;
        DogA.type = "馬爾濟斯";
        DogA.color = "白色";

        //DogA.sex = "公";
        //DogA.age = 7;

        DogB.name = "娜娜";
        DogB.weight = 35.5f;
        DogB.type = "臘腸";
        DogB.color = "咖啡";
        
        //DogB.sex = "母";
        //DogB.age = 9;

        Debug.Log(DogA.name + "品種：" + DogA.type + "顏色：" + DogA.color);
        Debug.Log(DogB.name + "品種：" + DogB.type + "顏色：" + DogB.color);

        DogA.Bark();
        DogB.Bark();

        Debug.Log(DogA.name + "的實際年齡為：" + DogA.ConverAge());
        Debug.Log(DogB.name + "的實際年齡為：" + DogB.ConverAge());

        DogA.Eat("熱狗");
        DogB.Eat("蛋糕", 10 );
    }
    #endregion
}