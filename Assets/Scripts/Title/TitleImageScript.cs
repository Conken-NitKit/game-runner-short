using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleImageScript : MonoBehaviour
{
    public Sprite[] sprites;
    public AudioClip se;
    private Image image;
    private float current;

    void Start()
    {
        image = GetComponent<Image>();
        image.sprite = sprites[0];
        current = 0f;
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
