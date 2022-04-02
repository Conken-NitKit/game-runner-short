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
        GameObject TEXT = transform.Find("Text").gameObject;

        yield return new WaitForSeconds(DERAY);
    }
}
