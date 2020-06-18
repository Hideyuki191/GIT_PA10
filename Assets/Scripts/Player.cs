using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public Rigidbody AngryDuck;
    public static int points;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if(transform.position.y <= -4.62f)
        {
            SceneManager.LoadScene("LoseGame");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            AngryDuck.AddForce(transform.up * 100);
        }
    }

    private void OnCollisionEnter(Collision obstacle)
    {
        if(obstacle.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("LoseGame");
        }
    }
}
