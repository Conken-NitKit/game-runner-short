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
    private int SPEED = 1;

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
        int index = 0;
        while (index < sprites.Length - 1)
        {
            current += SPEED;
            index = (int)(current) % sprites.Length;
            if (index > sprites.Length - 1) index = sprites.Length - 1;
            image.sprite = sprites[index];
            yield return new WaitForSeconds(0.01f);
        }

        Destroy(gameObject);
    }
}
