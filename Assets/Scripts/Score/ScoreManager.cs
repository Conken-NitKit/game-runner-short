using System;
using UniRx;
using UnityEngine;

namespace Score.Manager
{
    public class ScoreManager : MonoBehaviour{

        [SerializeField] private SoundManager soundManager;
        public IReadOnlyReactiveProperty<int> Score => score;
        private readonly IntReactiveProperty score = new IntReactiveProperty(0);

        /// <summary>
        /// 渡された引数スコアを加算するメソッド 
        /// </summary>
        public void IncreaseScore(int scoreOffset)
        {
            score.Value += scoreOffset;
            soundManager.PlaySeByName("ItemGetSE");        
        }

        private void OnDestroy()
        {
            score.Dispose();
        }
    }
}
