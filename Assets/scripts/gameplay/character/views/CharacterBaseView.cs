using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GamePlay.Character.Views {
    public abstract class CharacterBaseView : MonoBehaviour
    {
        protected CharacterController controller;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        #region AUX
        public void SetController (CharacterController controller) {
            this.controller = controller;
        }
        #endregion
    }

}
