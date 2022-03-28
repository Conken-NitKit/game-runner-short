using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// BGM、SEをファイル名を指定して再生できるとようにするクラスです
/// </summary>
public class SoundManager : MonoBehaviour
{
    [SerializeField, Range(0, 1), Tooltip("マスタ音量")]
    float volume = 1;
    [SerializeField, Range(0, 1), Tooltip("BGMの音量")]
    float bgmVolume = 1;
    [SerializeField, Range(0, 1), Tooltip("SEの音量")]
    float seVolume = 1;

    AudioClip[] bgm;
    AudioClip[] se;

    Dictionary<string, int> bgmIndex = new Dictionary<string, int>();
    Dictionary<string, int> seIndex = new Dictionary<string, int>();

    AudioSource bgmAudioSource;
    AudioSource seAudioSource;

    public float Volume
    {
        set
        {
            volume = Mathf.Clamp01(value);
            bgmAudioSource.volume = bgmVolume * volume;
            seAudioSource.volume = seVolume * volume;
        }
        get
        {
            return volume;
        }
    }

    public float BgmVolume
    {
        set
        {
            bgmVolume = Mathf.Clamp01(value);
            bgmAudioSource.volume = bgmVolume * volume;
        }
        get
        {
            return bgmVolume;
        }
    }

    public float SeVolume
    {
        set
        {
            seVolume = Mathf.Clamp01(value);
            seAudioSource.volume = seVolume * volume;
        }
        get
        {
            return seVolume;
        }
    }

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);

        bgmAudioSource = gameObject.AddComponent<AudioSource>();
        seAudioSource = gameObject.AddComponent<AudioSource>();

        bgm = Resources.LoadAll<AudioClip>("Audio/BGM");
        se = Resources.LoadAll<AudioClip>("Audio/SE");

        for (int i = 0; i < bgm.Length; i++)
        {
            bgmIndex.Add(bgm[i].name, i);
        }

        for (int i = 0; i < se.Length; i++)
        {
            seIndex.Add(se[i].name, i);
        }
    }

    /// <summary>
    /// 引数で指定された名前のBGMのインデックス番号をとってきます
    /// </summary>
    public int GetBgmIndex(string name)
    {
        if (bgmIndex.ContainsKey(name))
        {
            return bgmIndex[name];
        }
        else
        {
            Debug.LogError("指定された名前のBGMファイルが存在しません。");
            return 0;
        }
    }

    /// <summary>
    /// 引数で指定された名前のSEのインデックス番号をとってきます
    /// </summary>
    public int GetSeIndex(string name)
    {
        if (seIndex.ContainsKey(name))
        {
            return seIndex[name];
        }
        else
        {
            Debug.LogError("指定された名前のSEファイルが存在しません。");
            return 0;
        }
    }

    /// <summary>
    /// インデックス番号からBGMをとってきて流します
    /// </summary>
    public void PlayBgm(int index)
    {
        index = Mathf.Clamp(index, 0, bgm.Length);

        bgmAudioSource.clip = bgm[index];
        bgmAudioSource.loop = true;
        bgmAudioSource.volume = BgmVolume * Volume;
        bgmAudioSource.Play();
    }

    /// <summary>
    /// ファイル名からBGMを流します
    /// </summary>
    public void PlayBgmByName(string name)
    {
        PlayBgm(GetBgmIndex(name));
    }

    /// <summary>
    /// 現在流れているBGMを止めます
    /// </summary>
    public void StopBgm()
    {
        bgmAudioSource.Stop();
        bgmAudioSource.clip = null;
    }

    /// <summary>
    /// インデックス番号からSEをとってきて流します
    /// </summary>
    public void PlaySe(int index)
    {
        index = Mathf.Clamp(index, 0, se.Length);

        seAudioSource.PlayOneShot(se[index], SeVolume * Volume);
    }

    /// <summary>
    /// ファイル名からSEを流します
    /// </summary>
    public void PlaySeByName(string name)
    {
        PlaySe(GetSeIndex(name));
    }

    /// <summary>
    /// 現在流れているSEを止めます
    /// </summary>
    public void StopSe()
    {
        seAudioSource.Stop();
        seAudioSource.clip = null;
    }
}
