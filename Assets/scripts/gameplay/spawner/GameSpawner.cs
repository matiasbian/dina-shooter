using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GamePlay.Character;

namespace Spawner {
    public class GameSpawner : MonoBehaviour
    {
        [SerializeField] GamePlay.Character.CharacterController prefab; 
        CharacterFactory factory;
        
        // Start is called before the first frame update
        void Start()
        {
            factory = gameObject.AddComponent<CharacterFactory>();
            factory.prefab = prefab;

            factory.CreateaPlayerControlledOne(Vector2.zero);
            factory.CreateAAIOne(Vector2.one);
        }
    }

}
