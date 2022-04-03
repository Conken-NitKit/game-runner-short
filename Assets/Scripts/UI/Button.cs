using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// 主にボタンのアニメーション
/// </summary>
public class Button : MonoBehaviour
{
    COLORS COLORS = new COLORS();

    Text text;
    TextMeshProUGUI TITLE;

    void Awake()
    {
        text = transform.Find("Text").gameObject.GetComponent<Text>();
        TITLE = transform.parent.parent.Find("Title").gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        StartCoroutine("Blink");
    }

    /// <summary>
    /// ボタンの文字を点滅させる
    /// </summary>
    public IEnumerator Blink()
    {
        const float DERAY = 5.0000001f;
        const float INTERVAL = 0.4583333f;

        while (true)
        {
            yield return new WaitForSeconds(DERAY);

            text.color = COLORS.BUTTON_LIGHTED;
            yield return new WaitForSeconds(INTERVAL);

            text.color = COLORS.BUTTON;
            yield return new WaitForSeconds(INTERVAL);

            text.color = COLORS.BUTTON_LIGHTED;
            yield return new WaitForSeconds(INTERVAL);

            text.color = COLORS.BUTTON;
        }
    }

    /// <summary>
    /// ボタンの文字の点滅を止める
    /// </summary>
    public void Stop()
    {
        StopCoroutine("Blink");
    }
}
