using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitlePanel : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    [SerializeField] AudioClip se;
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        image.sprite = sprites[0];
        GetComponent<AudioSource>().PlayOneShot(se);
        IEnumerator coroutine = updateImg();
        StartCoroutine(coroutine);
    }

    private IEnumerator updateImg()
    {
        foreach (Sprite sprite in sprites)
        {
            image.sprite = sprite;
            yield return new WaitForSeconds(0.1f);
        };
    }
}