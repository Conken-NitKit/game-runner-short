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
    private GameObject titleSceneTransitionObjectParent;

    [SerializeField]
    private GameObject gameSceneTransitionObject;

    [SerializeField]
    private int titleSceneTransitionObjectNum;

    private int intervalMoveMilliseconds = 50;

    private float moveSeconds = 0.1f;

    /// <summary>
    /// タイトルシーンからゲームシーンの遷移アニメーション、画面を開くときのメソッド
    /// </summary>
    public async void OpenTitleSceneTransition()
    {
        for (int i = 0; i < titleSceneTransitionObjectNum; i++)
        {
            float sceneTransitionDirection = (i % 2 == 0) ? 1 : -1;//TODO:あまりいい命名じゃない、あとで要リファクタ

            //斜め上下の方向に移動する（画面外）
            titleSceneTransitionObjectParent.transform.GetChild(i).gameObject.transform.DOLocalMove(
                new Vector3(12.6f, 12.6f, 0f) * sceneTransitionDirection, moveSeconds)
                .SetRelative();

            await UniTask.Delay(intervalMoveMilliseconds);
        }
    }

    /// <summary>
    /// タイトルシーンからゲームシーンの遷移アニメーション、画面を閉じるときのメソッド
    /// </summary>
    public async void CloseTitleSceneTransition() {
        for (int i = 0; i < titleSceneTransitionObjectNum; i++)
        {
            float sceneTransitionDirection = (i % 2 == 0) ? -1 : 1;//TODO:あまりいい命名じゃない、あとで要リファクタ

            //斜め上下の方向に移動する（画面外）
            titleSceneTransitionObjectParent.transform.GetChild(i).gameObject.transform.DOLocalMove(
                new Vector3(12.6f, 12.6f, 0f) * sceneTransitionDirection, moveSeconds)
                .SetRelative();

            titleSceneTransitionObjectParent.transform.GetChild(i).gameObject.transform.DOLocalRotate(
                new Vector3(0, 0, 225f), 2f,
                RotateMode.FastBeyond360);

            await UniTask.Delay(intervalMoveMilliseconds);
        }
    }

    /// <summary>
    /// ゲームシーンからタイトルシーンの遷移アニメーション、画面を開くときのメソッド
    /// </summary>
    public void OpenGameSceneTransition()
    {
        gameSceneTransitionObject.transform.DOScale(new Vector3(0f, 0f), 1f);
    }

    /// <summary>
    /// ゲームシーンからタイトルシーンの遷移アニメーション、画面を閉じるときのメソッド
    /// </summary>
    public void CloseGameSceneTransition()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(
            gameSceneTransitionObject.transform.DOJump(
            new Vector3(0f, 0f, 0f), jumpPower: 2f, numJumps: 5, duration: 3f)
            .SetEase(Ease.OutSine)
        );
        sequence.Append(
            gameSceneTransitionObject.transform.DOScale(
            new Vector3(21f, 21f), 1f)
        );
         
        sequence.Play();
    }
}
