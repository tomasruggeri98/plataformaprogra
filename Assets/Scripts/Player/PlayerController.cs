using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    protected float playerSpeed = 1f;
    protected float playerGravity = 1f;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        playerMovement();
    }

    public void playerMovement() 
    {
        //logica de movimiento
    }
}
