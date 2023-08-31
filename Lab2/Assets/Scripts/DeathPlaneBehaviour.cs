using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneBehaviour : MonoBehaviour
{
    Vector3 ogplayerPosition;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        ogplayerPosition = Player.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            RestartGame();
        }
    }

    public void RestartGame()
    {
        Player.transform.position = ogplayerPosition;
    }

   
}
