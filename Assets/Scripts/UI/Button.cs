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
        Text TEXT = this.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();

        yield return new WaitForSeconds(DERAY);
        TEXT.color = COLORS.BUTTON;
        yield return new WaitForSeconds(DERAY);
    }
}
