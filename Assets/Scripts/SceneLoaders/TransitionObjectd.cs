using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionObjectd : MonoBehaviour
{
    private GameObject Instance;
    void Awake () {
        if(Instance != null){
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad (this.gameObject);
        Instance = this.gameObject;
    }
}
