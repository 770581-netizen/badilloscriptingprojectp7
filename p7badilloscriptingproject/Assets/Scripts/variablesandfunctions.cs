using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class variablesandfunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;


    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }


    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
//this is here to tell me 