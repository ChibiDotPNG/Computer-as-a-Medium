{
    // C# is case sensitive
    // Most statements end with ;
    // Blocks of code are denoted with {}
    // () Are for methods and conditions, i.e,
    void Start()
}

//Enables unity features
using UnityEngine;

//Creates class: PlayerMovement, 
//Allows it to work as a unity component
public class PlayerMovement : MonoBehavior

{
    void Start()
    //Runs once before the first update 
    //when script is enabled
    {
        Debug.Log("This prints a message into the unity console")
    }
    void Update()
    // Runs script once per frame
    {
        //code goes here
    }
}

{
    // Variables
    // Pretty much the same as python
    // put em before start
    // structure- Access-DataType-Name-Value(opt)
}

{
    // Access

    //Public- other scripts can see and 
    // it can be changed in unity

    //Private- Only the creating script can see
    // cant be changed in unity

    //[SerializeField] Private
    //Private but can be edited in unity
}

{
    //Data types

    //int -whole numbers
    //float -decimals
    //bool -true/false
    //string -text
   
    //Unity Spef

    // GameObject-references an object
    //Transform-stores reference to obj transfor,
    //Rigidbody2D-stores reference to RB2D component
    //Animator-Stores reference to animator component
    //Custom- reference other scripts using their name
    //++
}

{

}