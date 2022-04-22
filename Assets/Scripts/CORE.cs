using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    //lists have built in thread safety and array lists do not
    private static List<GameObject> theRoomsGos = new List<GameObject>();
    private static List<Room> theRooms = new List<Room>();
    private static Player currentPlayer = null;

    public static void setPlayer(Player p)
    {
        CORE.currentPlayer = p;
    }

    public static Player getPlayer()
    {
        return CORE.currentPlayer;
    }

    public static void addRoom(Room theRoom)
    {
        CORE.theRooms.Add(theRoom);
    }

    public static void addRoomGO(GameObject go)
    {
        CORE.theRoomsGos.Add(go);
        //print("Added Room");
    }

    public static void display()
    {
        //print("ouch");
    }

    // Start is called before the first frame update
    void Start()
    {
        /*for(int i = 0; i < 20; i++)
        {
            Transform t = Instantiate (enemyPrefab, spawnPoint.position, Quaternion.identity);
            Rigidbody rb = t.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(Random.Range(10,30), 0, Random.Range(10,30));
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}