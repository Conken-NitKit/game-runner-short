using System.Collections;
using System.Collections.Generic;
using Score.Manager;
using UnityEngine;


namespace Items
{
    /// <summary>
    /// アイテムの基底クラス
    /// </summary>
    public abstract class BaseItem : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                OnPlayerTaken();
            }
        }

        /// <summary>
        /// プレイヤーに取得されたときのメソッド
        /// </summary>
        protected abstract void OnPlayerTaken();
    }
}
