using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GamePlay.Character.Views
{
    public class CharacterPlayerView : CharacterBaseView
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void FixedUpdate()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            controller.Move(horizontal, vertical);
        }


        
    }
}