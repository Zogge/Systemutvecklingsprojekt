using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public enum Game {Meny, Game1, Game2 }
    public Game currentGame = Game.Meny;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Jungle Drive")
        {
            currentGame = Game.Game1;
        }
    }
}
