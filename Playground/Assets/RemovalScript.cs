using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovalScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject[] Elim;
    public GameObject[] gone;
    public bool Erased()
    {
        return true;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        print(Erased());
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "worm")
        {
            Elim = GameObject.FindGameObjectsWithTag("Round1");
            foreach (GameObject elim in Elim) //destroy each varible in Elim
            {
                Destroy(elim);
            }

            Destroy(this.gameObject);

            if (collision.gameObject.name == "worm")
            {
                Elim = GameObject.FindGameObjectsWithTag("Round2");
                foreach (GameObject elim in Elim) //destroy each varible in Elim
                {
                    Destroy(elim);
                }

                Destroy(this.gameObject);


            }
            if (collision.gameObject.name == "worm")
            {
                Elim = GameObject.FindGameObjectsWithTag("Round3");
                foreach (GameObject elim in Elim) //destroy each varible in Elim
                {
                    Destroy(elim);
                }

                Destroy(this.gameObject);

            }

            if (collision.gameObject.name == "worm")
            {
                Elim = GameObject.FindGameObjectsWithTag("Round4");
                foreach (GameObject elim in Elim) //destroy each varible in Elim
                {
                    Destroy(elim);
                }

                Destroy(this.gameObject);

            }
        }
        if (collision.gameObject.name == "worm")
        {
            Elim = GameObject.FindGameObjectsWithTag("Round5");
            foreach (GameObject elim in Elim) //destroy each varible in Elim
            {
                Destroy(elim);
            }

            Destroy(this.gameObject);

        }


    }
}