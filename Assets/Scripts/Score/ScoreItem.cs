using System.Collections;
using System.Collections.Generic;
using Score.Manager;
using UnityEngine;

/// <summary>
/// スコアアップアイテムクラス
/// </summary>
public class ScoreItem : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] ScoreManager scoreManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DestroyMySelf();
        }
    }

    /// <summary>
    /// スコアを加算して自分を消すメソッド
    /// </summary>
    private void DestroyMySelf()
    {
        // TODO:消えるアニメーション挿入
        scoreManager.IncreaseScore(score);
        Destroy(this.gameObject);
    }
}
