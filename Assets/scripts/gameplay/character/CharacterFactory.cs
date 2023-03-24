using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GamePlay.Character.Views;

namespace GamePlay.Character {
    public class CharacterFactory : MonoBehaviour
    {
        public CharacterController prefab; 
        
        public CharacterController CreateaPlayerControlledOne (Vector2 spawnPosition) {
            return CreateBase<CharacterPlayerView>(spawnPosition);
        }

        public CharacterController CreateAAIOne (Vector2 spawnPosition) {
            return CreateBase<CharacterAIView>(spawnPosition);
        }

        CharacterController CreateBase<T> (Vector2 spawnPosition) where T : CharacterBaseView  {
            CharacterController controller = Instantiate<CharacterController>(prefab);
            controller.transform.position = spawnPosition;

            CharacterModel model = new CharacterModel();
            T view = controller.gameObject.AddComponent<T>();

            controller.SetModel(model);
            controller.SetView(view);
            view.SetController(controller);

            return controller;
        }
    }
}
