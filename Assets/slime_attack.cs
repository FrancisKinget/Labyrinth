using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class slime_attack : MonoBehaviour
{
    private GameObject player;
    private float speed = 3.0f;
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, player.transform.position) < 17.5f)
        {
            float step = speed * Time.deltaTime​​​​​​​;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
            Vector3 position = new Vector3(transform.position.x, y, transform.position.z);
            transform.position = position;
            transform.LookAt(player.transform);
        }
       
    }

}
