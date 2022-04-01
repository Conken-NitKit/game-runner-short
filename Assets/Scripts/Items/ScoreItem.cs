using System;
using System.Collections;
using System.Collections.Generic;
using Score.Manager;
using UnityEngine;
using Random = System.Random;

namespace Items
{
    public class ScoreItem : BaseItem
    {
        [SerializeField] private int score;
        [SerializeField] private Animator fruitAnimator;
        private int animHash = Animator.StringToHash("AnimNumber");

        public void Start()
        {
            fruitAnimator.SetInteger(animHash,new Random().Next(0,7));
        }

        protected override void OnPlayerTaken()
        {
            GameObject.FindWithTag("GameManager").GetComponent<ScoreManager>().IncreaseScore(score);
            Destroy(this.gameObject);
        }
    }
}
