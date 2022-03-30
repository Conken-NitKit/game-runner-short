using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using DG.Tweening;

/// <summary>
/// シーン遷移時のアニメーションクラス
/// </summary>
public class SceneTransitionAnimation : MonoBehaviour
{
    [SerializeField]
    private GameObject[] sceneTransitionObjects;

    private int intervalMoveMilliseconds = 50;

    private float moveSeconds = 0.1f;

    /// <summary>
    /// タイトルシーンからゲームシーンの遷移アニメーション、画面を開くときのメソッド
    /// </summary>
    public async void OpenTitleSceneTransition()
    {
        for (int i = 0; i < sceneTransitionObjects.Length; i++)
        {
            float sceneTransitionDirection = (i % 2 == 0) ? 1 : -1;//TODO:あまりいい命名じゃない、あとで要リファクタ

            //斜め上下の方向に移動する（画面外）
            sceneTransitionObjects[i].transform.DOLocalMove(
                new Vector3(12.6f, 12.6f, 0f) * sceneTransitionDirection, moveSeconds)
                .SetRelative();

            await UniTask.Delay(intervalMoveMilliseconds);
        }
    }

    /// <summary>
    /// タイトルシーンからゲームシーンの遷移アニメーション、画面を閉じるときのメソッド
    /// </summary>
    public async void CloseTitleSceneTransition() { 
        for (int i = sceneTransitionObjects.Length - 1; -1 < i; i--)
        {
            float sceneTransitionDirection = (i % 2 == 0) ? -1 : 1;//TODO:あまりいい命名じゃない、あとで要リファクタ

            //斜め上下の方向に移動する（画面外）
            sceneTransitionObjects[i].transform.DOLocalMove(
                new Vector3(12.6f, 12.6f, 0f) * sceneTransitionDirection, moveSeconds)
                .SetRelative();

            await UniTask.Delay(intervalMoveMilliseconds);
        }
    }
}
