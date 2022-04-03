using UnityEngine;
using Score.Manager;
using TMPro;
using UniRx;
using UI;

namespace Score.Presenter
{
    /// <summary>
    /// スコアテキストとスコアマネージャーのプレゼンタークラス
    /// </summary>
    public sealed class ScorePresenter : MonoBehaviour
    {
        [SerializeField] private ScoreManager scoreManager;
        [SerializeField] private ScoreText scoreText;

        private void Start()
        {
            scoreManager.Score
                .Subscribe(score =>
                    scoreText.SetText(score))
                .AddTo(this);
        }
    }   
}
