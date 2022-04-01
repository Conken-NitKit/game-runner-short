using UniRx;
using UnityEngine;

namespace Score.Manager
{
    public class ScoreManager : MonoBehaviour{
        public IReadOnlyReactiveProperty<int> Score => score;
        private readonly IntReactiveProperty score = new IntReactiveProperty(0);

        /// <summary>
        /// 渡された引数スコアを加算するメソッド 
        /// </summary>
        public void IncreaseScore(int scoreOffset)
        {
            score.Value += scoreOffset;
        }

        private void OnDestroy()
        {
            score.Dispose();
        }
    }
}
