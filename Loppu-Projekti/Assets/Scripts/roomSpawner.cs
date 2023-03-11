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

  void start()
  {
    templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
  }

  void Update()
  {
     if(openingDirection == 1)
    {
        rand = Random.Range(0, templates.bottomRooms.Length);
        Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
    }
     else if(openingDirection == 2)
     {
        
     }
     else if(openingDirection == 3)
     {

     }
     else if(openingDirection == 4)
     {

     }
        
     
  }

}
