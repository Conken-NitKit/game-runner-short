using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace UI
{
    /// <summary>
    /// スコアを表示するテキストのクラス
    /// </summary>
    public class ScoreText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;
        
        // TODO:加算アニメーションをつける
        public void SetText(int value)
        {
            text.text = value.ToString();
        }
        
    }
}
