using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoadCharacters : MonoBehaviour
{
     public GameObject[] charactersPrefabs;
     public Transform spawnPoint;
     public TMP_Text label;
    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab =charactersPrefabs[selectedCharacter];
        GameObject clone = Instantiate(prefab, spawnPoint.position,Quaternion.identity);
        label.text = prefab.name;
        
    }

    
}
