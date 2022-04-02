using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] private Transform player;
        private float firstPositionY;
        private Vector2 offset;

        // Start is called before the first frame update
        void Start()
        {
            Vector3 first = transform.position;
            firstPositionY = first.y;
            offset = first - player.position;
        }

        void LateUpdate() //Lateアップデートだとカメラがガクガクしないみたいです
        {
            Vector2 pos = transform.position;
            transform.position = new Vector3(player.position.x + offset.x, firstPositionY,-10);
        }
    }
}
