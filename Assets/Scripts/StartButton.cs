using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class StartButton : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;

    public async void OnClicked()
    {
        await UniTask.Delay(3500);
        soundManager.StopBgm();
        SceneManager.LoadScene("Main");
    }
}
