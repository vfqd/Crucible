//Imports
using UnityEngine;

//You can find this MonoBehaviour on the FPSController to see how it behaves in Unity

//Name of class has each word capitalized, the MonoBehaviour also implements any interfaces here
public class ExampleMonobehaviour : MonoBehaviour, IExampleInterface<float> {

    //Variables all start with a lowercase letter, every subsequent word is capitalized.
    //Leave a line between each type of variable

    //1st: Public primative variables - accessible in Unity - don't initialize these
    public int someInt;

    //2nd: Private primative vaiables
    private float someFloat = 5f;

    //3rd: Objects
    public GameObject someGameObject;
    public ExampleLogicScript exampleLogicScript;


    // Use this for initialization
    void Start ()
    {	
	}

    //Assign logic script interfaces here, pass this object as a parameter (implements inferface)
    void OnEnable()
    {
        exampleLogicScript.SetExampleInterface(this);
    }
	
	// Update is used for moving non-physics objects and input
	void Update ()
    {
	}

    //Put anything that affects physics (Rigidbody) in FixedUpdate()
    void FixedUpdate()
    {
    }


    //Region for interface implementation requiring Unity engine imports (regions can be
    //expanded and closed on the left
    #region IExampleInterface implementation

    public float SomeValue
    {
        get
        {
            return someFloat;
        }

        set
        {
            someFloat = value;
        }
    }

    public void SomeMethod(float value, float time)
    {
        exampleLogicScript.SomeMethod(value, Time.fixedDeltaTime);
    }
    #endregion
}
