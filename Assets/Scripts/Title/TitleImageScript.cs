using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Effect : MonoBehaviour
{
    static GameObject _prefab = null;
    public Sprite[] sprites;
    public float speed;
    public AudioClip se;
    private Image image;
    private float current;


    public static void EffectAdd(float x, float y, string name)
    {
        GameObject prefab = Resources.Load("Prefabs/" + name) as GameObject;
        Vector3 pos = new Vector3(x, y, 0);
        GameObject canvas = GameObject.Find("Canvas");
        GameObject g = Instantiate(prefab, pos, Quaternion.identity) as GameObject;
        g.transform.SetParent(canvas.transform, false);
        g.transform.position = pos;
    }

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
            current += Time.deltaTime * speed;
            index = (int)(current) % sprites.Length;
            if (index > sprites.Length - 1) index = sprites.Length - 1;
            image.sprite = sprites[index];
            yield return new WaitForSeconds(0.01f);
        }

        Destroy(gameObject);
    }
}
