using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anime : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    Image img;

    void Start()
    {
        img = GetComponent<Image>();
        img.sprite = sprites[0];
        IEnumerator coroutine = updateImg();
        StartCoroutine(coroutine);
    }

    IEnumerator updateImg()
    {
        foreach (Sprite sprite in sprites)
        {
            img.sprite = sprite;
            yield return new WaitForSeconds(0.1f);
        };
    }
}
