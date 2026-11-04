{
// C# is case sensitive
// Most statements end with ;
// Blocks of code are denoted with {}
// () Are for methods and conditions, i.e,
Start()
}

//Enables unity features
using UnityEngine;

//Creates class: PlayerMovement, 
//Allows it to work as a unity component
public class PlayerMovement : MonoBehavior

{
    Start()
    //Runs once before the first update 
    //when script is enabled
    {
        Debug.Log("This prints a message into the unity console")
    }
    Update()
    // Runs script once per frame
    {
        //code goes here
    }
}
