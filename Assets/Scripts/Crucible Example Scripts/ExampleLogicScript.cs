//Imports
using UnityEngine;
using System;

//Serializable keyword allows for unit tests
[Serializable]
public class ExampleLogicScript  //All logic needs to go here so it can be tested. The monobehaviour must contain no logic
{
    //Variables all start with a lowercase letter, every subsequent word is capitalized.
    //Leave a line between each type of variable

    //1st: Public primative variables - always use variables, never put values in code directly
    public int exampleInt = 5;
    public float exampleFloat = 10f;
    [Range(0, 100)]
    public float rangeOneHundred = 100f; //Variable restricted to this range

    //2nd: Private primative vaiables
    private float time = float.NegativeInfinity;

    //3rd: Objects
    private IExampleInterface<float> exampleInterface;

    //4th: Enums - use enums for states later on. All enums start with capitals
    enum State
    {
        Happy,
        Sad
    }


    //Methods go below, each word is a method is capitalized

    /// <summary>
    /// Need one of these methods per interface implemented by the monobehaviour class
    /// </summary>
    /// <param name="exampleInterface"></param>
    public void SetExampleInterface (IExampleInterface<float> exampleInterface)
    {
        this.exampleInterface = exampleInterface;
    }

    /// <summary>
    /// Methods in the interface must appear here too
    /// </summary>
    /// <param name="value"></param>
    /// <param name="time"></param>
    public void SomeMethod(float value, float time)
    {
        if (BooleanMethod())
            exampleFloat = GetValue();   
    }

    /// <summary>
    /// Returns a value used by SomeMethod
    /// </summary>
    /// <returns></returns>
    private float GetValue()
    {
        return exampleInt > 5 ? exampleFloat : rangeOneHundred;
    }

    /// <summary>
    /// Used by SomeMethod
    /// </summary>
    /// <returns></returns>
    private bool BooleanMethod()
    {
        return exampleInt > 0;
    }

}
