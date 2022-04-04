using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class TitleButton : MonoBehaviour
{
    public async void OnClicked()
    {
        await UniTask.Delay(5000);
        SceneManager.LoadScene("Title");
    }
}
