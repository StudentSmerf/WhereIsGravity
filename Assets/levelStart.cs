using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelStart : MonoBehaviour
{
    public GameObject Player;
    public Transform StartPos;
    void Start()
    {
        Instantiate(Player, StartPos, true);
    }


}
