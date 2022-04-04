using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cysharp.Threading.Tasks;    

public class Main : SceneBase {

    public override void OnLoad (object options) {
    }
    public void GoResult () => SimpleSceneNavigator.Instance.GoForwardAsync<Title> ().Forget();
}
