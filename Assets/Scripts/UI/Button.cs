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
        COLORS COLORS = new COLORS();
        Text TEXT = transform.Find("Text").gameObject.GetComponent<Text>();

        yield return new WaitForSeconds(DERAY);
        TEXT.color = COLORS.BUTTON;
    }
}
