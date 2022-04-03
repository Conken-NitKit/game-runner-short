using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// 主にボタンのアニメーション
/// </summary>
public class MainButton : MonoBehaviour
{
    COLORS COLORS = new COLORS();
    const short TITLE_DELAY = 5;
    const float TITLE_WAVE = 0.125f;
    const float TITLE_PLAY_TIME = 0.25f;

    const float INTERVAL = 0.125f;
    const float COLOR_CHANGES = 3;

    int delayedTitleLength;
    float playTime;

    float delay;

    Text text;
    TextMeshProUGUI title;
    SpriteRenderer outline;

    void Awake()
    {
        text = transform.Find("Text").gameObject.GetComponent<Text>();
        title = transform.parent.parent.Find("Title").gameObject.GetComponent<TextMeshProUGUI>();
        outline = transform.parent.gameObject.GetComponent<SpriteRenderer>();

        delayedTitleLength = title.text.Length - 1;
        playTime = TITLE_DELAY + TITLE_PLAY_TIME + TITLE_WAVE * delayedTitleLength;
        delay = playTime - INTERVAL * COLOR_CHANGES;  //点滅の待ち時間
    }

    void Start()
    {
        StartCoroutine("Blink");
    }

    /// <summary>
    /// ボタンの文字を点滅させる。
    /// </summary>
    IEnumerator Blink()
    {
        while (true)
        {
            text.color = COLORS.BUTTON_LIGHTED;
            yield return new WaitForSeconds(INTERVAL);

            text.color = COLORS.BUTTON;
            yield return new WaitForSeconds(INTERVAL);

            text.color = COLORS.BUTTON_LIGHTED;
            yield return new WaitForSeconds(INTERVAL);

            text.color = COLORS.BUTTON;
            yield return new WaitForSeconds(delay);
        }
    }

    /// <summary>
    /// ボタンの文字の点滅を止める。
    /// </summary>
    void Stop()
    {
        StopCoroutine("Blink");
        text.color = COLORS.BUTTON;
    }

    /// <summary>
    /// ボタンの外枠を点滅させる。
    /// </summary>
    IEnumerator BlinkClicked()
    {
        outline.color = COLORS.BUTTON_LIGHTED;
        yield return new WaitForSeconds(INTERVAL);

        outline.color = COLORS.BUTTON;
        yield return new WaitForSeconds(INTERVAL);

        outline.color = COLORS.BUTTON_LIGHTED;
    }

    public void OnClick()
    {
        Stop();
    }
}
