using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectableGravity : PlayerController
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //al ser parte del mismo objeto que el script anterior se borrara automaticamente despues de ejecutar el codigo
        //aca va la logica de acceder a las variables de gravity o speed del player

        playerGravity = 5;
    }


}
