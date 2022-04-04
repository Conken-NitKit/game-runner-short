using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class AfterTitleSceneTransition : MonoBehaviour
{
    [SerializeField]
    private SceneTransitionAnimation sceneTransitionAnimation;

    [SerializeField]
    private SoundManager soundManager;

    async void Start()
    {
        await UniTask.Delay(1);
        soundManager.PlayBgmByName("Title");
        sceneTransitionAnimation.OpenGameSceneTransition();
    }
}
