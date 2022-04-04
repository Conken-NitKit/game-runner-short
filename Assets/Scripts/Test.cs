using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class Test : MonoBehaviour
{
    public SceneTransitionAnimation sceneTransitionAnimation;

    async void Start()
    {
        await UniTask.Delay(3000);

        sceneTransitionAnimation.OpenTitleSceneTransition();

        await UniTask.Delay(2000);

        sceneTransitionAnimation.CloseTitleSceneTransition();
    }
}
