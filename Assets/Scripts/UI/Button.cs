using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 主にボタンのアニメーション
/// </summary>
public class Button : MonoBehaviour
{
    public IEnumerator Blink()
    {
        const short DERAY = 5;

        yield return new WaitForSeconds(DERAY);
        gameObject.GetComponent<Text>().color = COLORS.BUTTON;
    }
}
