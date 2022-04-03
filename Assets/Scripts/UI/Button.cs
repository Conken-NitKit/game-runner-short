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
    TextMeshProUGUI title;

    void Awake()
    {
        text = transform.Find("Text").gameObject.GetComponent<Text>();
        title = transform.parent.parent.Find("Title").gameObject.GetComponent<TextMeshProUGUI>();
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
        float playTime = (title.text.Length - 1) * 0.125f + 0.25f + 5;
        const float DERAY = 5.0000001f;
        const float INTERVAL = 0.25f;

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
