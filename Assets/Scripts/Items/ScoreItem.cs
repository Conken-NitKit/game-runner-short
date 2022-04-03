using System;
using System.Collections;
using System.Collections.Generic;
using Score.Manager;
using UnityEngine;
using UniRx;
using Random = System.Random;

namespace Items
{
    public class ScoreItem : BaseItem
    {
        [SerializeField] private int score;
        [SerializeField] private Animator fruitAnimator;
        readonly int animHash = Animator.StringToHash("AnimNumber");
        readonly int vanishAnimHash = Animator.StringToHash("isTaken");

        public void Start()
        {
            fruitAnimator.SetInteger(animHash,new Random().Next(0,7));
        }

        protected override void OnPlayerTaken()
        {
            fruitAnimator.SetBool(vanishAnimHash,true);
            GameObject.FindWithTag("GameManager").GetComponent<ScoreManager>().IncreaseScore(score);
            Observable.Timer(TimeSpan.FromMilliseconds(600))
                 .Subscribe(_ => Destroy(this.gameObject))
                 .AddTo(this);
        }
    }
}
