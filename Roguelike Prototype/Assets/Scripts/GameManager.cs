using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    DungeonGenerator dungeonGenerator;
    // Start is called before the first frame update
    void Start()
    {
        dungeonGenerator = GetComponent<DungeonGenerator>();

        dungeonGenerator.InitializeDungeon();
        dungeonGenerator.GenerateDungeon();
    }

}
