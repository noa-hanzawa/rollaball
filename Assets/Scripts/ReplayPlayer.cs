using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayPlayer : MonoBehaviour
{
    [SerializeField]
    [Tooltip("")]
    private GameObject playerPrefab;

    // Update is called once per frame
    void Update()
    {
        GameObject playerObj=GameObject.Find(playerPrefab.name);

        if (playerObj == null)
        {
            GameObject newPlayerObj=Instantiate(playerPrefab);
            newPlayerObj.name=playerPrefab.name;
        }

    }
}
