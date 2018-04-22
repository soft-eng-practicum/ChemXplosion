using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEditor.Animations;
using NSubstitute;

public class UnitTesting
{

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator GrabItemTransformTest()
    { //Test if the Grab() method correctly adjusts the transform of a chemical
        GameObject chemical = new GameObject(); //GameObject to be grabbed
        GameObject hands = new GameObject(); //Position of players "hands"
        hands.transform.position = new Vector3(0, 2, 0); //Set hands' transform to a y value of 2
        chemical.AddComponent<Pickup>(); //Chemical's PickUp script component
        chemical.AddComponent<Rigidbody>(); //Chemical's RigidBody component
        chemical.GetComponent<Pickup>().hands = hands.transform; //Sets Test Object hands to the hands variable in PickUp script
        chemical.GetComponent<Pickup>().isGrabbed = true;
        chemical.GetComponent<Pickup>().Grab(chemical); //Call Grab() 
        yield return null; //Yield one frame before assertion
        Assert.AreEqual(hands.transform.position.y, chemical.transform.position.y, .1f); //Test will pass if the chemical's location is the same as the player's hands
    }

    [UnityTest]
    public IEnumerator Puzzle3RotationTest() //Test if the Puzzle3 generator's fans rotate when puzzle 3 is solved  
    {
        GameObject generator = new GameObject(); //Generator parent GameObject
        generator.AddComponent<RotateGenerator>(); // Add script to generator
        generator.AddComponent<AudioSource>(); //Audio source to be tested
        generator.GetComponent<AudioSource>().enabled = false; //Audio source will start disabled until solved
        GameObject generatorFan1 = new GameObject(); //One of 4 generator fan GameObjects
        GameObject generatorFan2 = new GameObject();//One of 4 generator fan GameObjects
        GameObject generatorFan3 = new GameObject();//One of 4 generator fan GameObjects
        GameObject generatorFan4 = new GameObject();//One of 4 generator fan GameObjects
        generator.GetComponent<RotateGenerator>().gen1 = generatorFan1;
        generator.GetComponent<RotateGenerator>().gen2 = generatorFan2;
        generator.GetComponent<RotateGenerator>().gen3 = generatorFan3;
        generator.GetComponent<RotateGenerator>().gen4 = generatorFan4;
        Puzzle3.isComplete_Puzzle_3 = true; //Simulate puzzle being solved
        yield return null; //Wait one frame
        Assert.AreEqual(1, generator.GetComponent<RotateGenerator>().gen1.transform.eulerAngles.y); // Test will pass if the fans have begun to rotate around the y axis
    }


    [UnityTest]
    public IEnumerator Puzzle3AudioTest() //Test if the Puzzle3 generator's sound effect starts playing when puzzle 3 is solved
    {
        GameObject generator = new GameObject(); //Generator parent GameObject
        generator.AddComponent<RotateGenerator>(); // Add script to generator
        generator.AddComponent<AudioSource>(); //Audio source to be tested
        generator.GetComponent<AudioSource>().enabled = false; //Audio source will start disabled until solved
        GameObject generatorFan1 = new GameObject(); //One of 4 generator fan GameObjects
        GameObject generatorFan2 = new GameObject();//One of 4 generator fan GameObjects
        GameObject generatorFan3 = new GameObject();//One of 4 generator fan GameObjects
        GameObject generatorFan4 = new GameObject();//One of 4 generator fan GameObjects
        generator.GetComponent<RotateGenerator>().gen1 = generatorFan1;
        generator.GetComponent<RotateGenerator>().gen2 = generatorFan2;
        generator.GetComponent<RotateGenerator>().gen3 = generatorFan3;
        generator.GetComponent<RotateGenerator>().gen4 = generatorFan4;
        Puzzle3.isComplete_Puzzle_3 = true; //Simulate puzzle being solved
        yield return null; //Wait one frame
        Assert.IsTrue(generator.GetComponent<AudioSource>().enabled); //Test will pass if the generators audioSource was enabled

    }

    [UnityTest]
    public IEnumerator DestroyPuzzleOneLock() //Test if desstroyLock() correctly destroys the associated GameObject
    {
        GameObject puzzle1 = new GameObject(); //Puzzle 1 Game Object
        puzzle1.AddComponent<PuzzleOneTable>(); // Add script to puzzle 1
        GameObject exp = new GameObject(); // Explosion gameobject
        PuzzleOneTable.isComplete_Puzzle_1 = true; //Simulates the puzzle being solved
        GameObject doorLock = new GameObject(); //GameObject to be destroyed
        doorLock.AddComponent<Onhit>(); //add OnHit script to doorLock
        doorLock.GetComponent<Onhit>().explosion = exp;
        doorLock.GetComponent<Onhit>().destroyLock(); //Call destroyLock()
        yield return null; //Wait one frame
        Assert.IsTrue(doorLock == null); //Test will pass if doorLock gameObject no longer exists
    }
}
