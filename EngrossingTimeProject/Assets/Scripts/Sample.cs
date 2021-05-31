using UnityEngine;
using UnityEngine.UI;
using com.amabie.EngrossingTime;

public class Sample : MonoBehaviour
{
    [SerializeField]
    private Text progress;

    [SerializeField]
    private Text feltTime;

    private EngrossingTime engrossingTime;

    void Awake()
    {
        engrossingTime = new EngrossingTime();
        // ゲーム上の体験時間は1分だが
        // ゲーム上30秒説明などに使っていたい場合があるのでそれを想定する
        // 基本は (0, X) で指定する
        engrossingTime.SetFeltTime(30f, 40f);
    }

    void Update()
    {
        engrossingTime.UpdateFletTime(Time.deltaTime);
        progress.text = engrossingTime.Progress + " [%]";
        feltTime.text = engrossingTime.DisplayFeltTime + " [s]";
    }
}
