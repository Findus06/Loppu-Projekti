using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomSpawner : MonoBehaviour
{
  public int openingDirection;
  // 1 --> Tarvitsee ala ovi
  // 2 --> Tarvitsee ylä ovi
  // 3 --> Tarvitsee vasen ovi
  // 4 --> Tarvitsee oikea ovi

 private RoomTemplates templates;
 private int rand;
 private bool spawned = false;

  void start()
  {
    templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
    Invoke("Spawn", 0.1f);
  }

  void Spawn()
  {
    if (spawned == false)
    {
      if(openingDirection == 1)
    {
        rand = Random.Range(0, templates.bottomRooms.Length);
        Instantiate(templates.bottomRooms[rand], transform.position, Quaternion.identity);
    }
     else if(openingDirection == 2)
     {
        rand = Random.Range(0, templates.topRooms.Length);
        Instantiate(templates.topRooms[rand], transform.position, Quaternion.identity);
     }
     else if(openingDirection == 3)
     {
        rand = Random.Range(0, templates.leftRooms.Length);
        Instantiate(templates.leftRooms[rand], transform.position, Quaternion.identity);
     }
     else if(openingDirection == 4)
     {
        rand = Random.Range(0, templates.rightRooms.Length);
        Instantiate(templates.rightRooms[rand], transform.position, Quaternion.identity);
     }
     spawned = true;
    }

     
    
        
     
  }

}
