using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiFireBalls : MonoBehaviour
{

   
    public GameObject fireBall;
    private GameObject newFireBall;
    private Vector3 point;
    bool creation = false;
    // Start is called before the first frame update
    void Start()
    {
        point = transform.position;

        if (GameObject.FindGameObjectsWithTag("FireBall").Length < 4)
        {
            creation = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (creation)
        { 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 newPos;
                newFireBall = Instantiate(fireBall, point, Quaternion.identity);
                newFireBall.transform.localScale = 0.5f * newFireBall.transform.localScale;
                newPos = newFireBall.transform.position;
                newPos.x += 1;
                newFireBall.transform.position = newPos;

                newFireBall = Instantiate(fireBall, point, Quaternion.identity);
                newFireBall.transform.localScale = 0.5f * newFireBall.transform.localScale;
                newPos = newFireBall.transform.position;
                newPos.x -= 1;
                newFireBall.transform.position = newPos;

                Destroy(gameObject);

            }
        }
    }
}
