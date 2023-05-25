using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    private void Awake()
    {
        print(666);
        print("嗨~");
        print("1 + 2");
        print($"{1 + 2}");
    }

    private void Start()
    {
        print("<color=yellow>開始</color>");
    }

    private void Update()
    {
        print("<color=#991111>更新</color>");
    }
}
