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

}
