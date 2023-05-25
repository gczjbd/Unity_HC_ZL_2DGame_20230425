using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    [Header("移動速度")]
    [Range(0,50)]
    public float movespeeed = 3.5f;
    [Header("剛體")]
    public Rigidbody2D rig;

    private void Awake()
    {
        //print(666);
        //print("嗨~");
        //print("1 + 2");
        //print($"{1 + 2}");
    }

    private void Start()
    {
        //print("<color=yellow>開始</color>");
    }

    private void Update()
    {
        //print("<color=#991111>更新</color>");
        //呼叫移動方法
        Move();
    }

    private void Move()
    {
        print("移動中...")；
    }
}
