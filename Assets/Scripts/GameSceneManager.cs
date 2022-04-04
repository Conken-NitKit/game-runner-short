using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GameSceneManager : MonoBehaviour
{
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private Player player;
    [SerializeField] private GameObject gameOverPanel;
    void Start()
    {
        StartCoroutine(GameStartCouroutine());
    }
    
    public void GameOver()
    {
        StartCoroutine(GameOverCouroutine());
    }

    private IEnumerator GameStartCouroutine()
    {
        soundManager.PlaySeByName("ReadyVoice");
        yield return new WaitForSeconds(1);
        soundManager.PlaySeByName("GoVoice (mp3cut.net)");
        soundManager.PlayBgmByName("Let’s!_2");
        player.enabled = true;
    }

    private IEnumerator GameOverCouroutine() 
    {
        soundManager.StopBgm();
        soundManager.PlaySeByName("Hit");
        yield return new WaitForSeconds(1);
        gameOverPanel.SetActive(true);
    }
}
