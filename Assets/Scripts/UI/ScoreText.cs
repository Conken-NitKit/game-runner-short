using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

namespace UI
{
    /// <summary>
    /// スコアを表示するテキストのクラス
    /// </summary>
    public class ScoreText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;
        private int nowNumber;

        public void SetText(int value)
        {
            nowNumber = int.Parse(text.text);
            DOTween.To(() => nowNumber, (n) => nowNumber = n, value, 0.6f)
                .OnUpdate(() => text.text = nowNumber.ToString());
        }
    }
}
