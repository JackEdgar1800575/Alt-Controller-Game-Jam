using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public int speed = 3;//How fast the runner moves
    public int lives = 3;//How many lives the player has before they are out
    public bool hidden = false;
    float input;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "Player1")
        {
            handleInput(KeyCode.Alpha1, KeyCode.A);
        }

        if (this.gameObject.tag == "Player2")
        {
            handleInput(KeyCode.Alpha2, KeyCode.B);
        }

        if (lives == 0)
        {
            Destroy(this.gameObject);
        }
    }

    void handleInput(KeyCode button, KeyCode sensor)
    {
        if (!hidden)
        {
            if (Input.GetKeyDown(button))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            if (Input.GetKeyDown(sensor))
            {
                hidden = true;
            }
        }

        if (hidden)
        {
            if (Input.GetKeyDown(sensor))
            {

            }
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            lives--;
        }
    }
}
