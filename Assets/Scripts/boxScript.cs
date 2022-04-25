using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class boxScript : MonoBehaviour
{
    private int count;
    public GameObject thePlayer;
    private Vector3 playerPosition;
    private NavMeshAgent agent; 
    private Room currentRoom;
    private Rigidbody rb;
    public float speed = 20f;
    private Enemy theEnemy;

    void Awake()
    {
        this.theEnemy = new Enemy();
    }

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        CORE.setEnemy(theEnemy);
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        //agent.speed = 20f;
        //agent.Warp(thePlayer.transform.position);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            count++;
            if(count == 3)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(thePlayer.transform.position);
    }
}