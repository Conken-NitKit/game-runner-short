using System;
using System.Collections;
using System.Collections.Generic;
using Score.Manager;
using TMPro;
using UnityEngine;
using UniRx;

public class GameSceneManager : MonoBehaviour
{
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private Player player;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private SceneTransitionAnimation sceneTransitionAnimation;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private ScoreManager scoreManager;

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
        sceneTransitionAnimation.OpenTitleSceneTransition();
        yield return new WaitForSeconds(2f);
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
        scoreText.text = scoreManager.Score.ToString();
        gameOverPanel.SetActive(true);
    }
}
