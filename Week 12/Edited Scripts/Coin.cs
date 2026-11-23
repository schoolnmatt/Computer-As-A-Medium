using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour

{

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        transform.localScale = transform.localScale * .2f;
        Destroy(this.gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if (whatDidIHit.tag == "Player")
        {
            gameManager.AddScore(1);
            gameManager.ChangeScoreText(gameManager.score);
            Destroy(this.gameObject);
        }
    }
}