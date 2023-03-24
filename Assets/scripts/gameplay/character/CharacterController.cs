using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GamePlay.Character.Views;

namespace GamePlay.Character
{
    public class CharacterController : MonoBehaviour
    {

        CharacterBaseView view;
        CharacterModel model;

        Rigidbody2D rigidbody;
        Animator animator;
        SpriteRenderer spriteRenderer;
        // Start is called before the first frame update
        void Awake()
        {
            rigidbody = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void Move (float x, float y) {
            //movement
            x *= model.MOVEMENT_SPEED * Time.deltaTime;
            y *= model.MOVEMENT_SPEED * Time.deltaTime;
            Vector2 newPos = new Vector2 (transform.position.x + x, transform.position.y + y);
            rigidbody.MovePosition(newPos);

            //animation
            animator.SetFloat("Movement", Mathf.Abs(x) + Mathf.Abs(y));
            spriteRenderer.flipX = x < 0;

        }

        #region AUX
        public void SetView (CharacterBaseView view) {
            this.view = view;
        }

        public void SetModel (CharacterModel model) {
            this.model = model;
        }
        #endregion
    }
}
