using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 主にボタンのアニメーション
/// </summary>
public class Button : MonoBehaviour
{
    /// <summary>
    /// ボタンの文字を点滅させる
    /// </summary>
    public IEnumerator Blink()
    {
        COLORS COLORS = new COLORS();

        const float DERAY = 5.0000001f;
        const float INTERVAL = 0.4583333f;

        Text TEXT = transform.Find("Text").gameObject.GetComponent<Text>();

        while (true)
        {
            yield return new WaitForSeconds(DERAY);

            TEXT.color = COLORS.BUTTON_LIGHTED;
            yield return new WaitForSeconds(INTERVAL);

            TEXT.color = COLORS.BUTTON;
            yield return new WaitForSeconds(INTERVAL);

            TEXT.color = COLORS.BUTTON_LIGHTED;
            yield return new WaitForSeconds(INTERVAL);

            TEXT.color = COLORS.BUTTON;
        }
    }

    public void Stop()
    {
        IEnumerator blink;

        blink = Blink();

        StopCoroutine(blink);
    }
}
