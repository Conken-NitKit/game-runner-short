using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 主にボタンのアニメーション
/// </summary>
public class Button : MonoBehaviour
{
    public IEnumerator Blink()
    {
        const short DERAY = 5;
        const float INTERVAL = 0.4583333f;
        COLORS COLORS = new COLORS();
        Text TEXT = transform.Find("Text").gameObject.GetComponent<Text>();

        while (true)
        {
            yield return new WaitForSeconds(DERAY);
            TEXT.color = COLORS.BUTTON;
            yield return new WaitForSeconds(DERAY);

        }
    }
}
