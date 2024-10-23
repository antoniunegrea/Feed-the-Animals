using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectColisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        if(other.tag=="Moose")
        {
            Scorring.scoreValue = Scorring.scoreValue + Scorring.scoreValueMoose;
        }
        else if (other.tag == "Cow")
        {
            Scorring.scoreValue = Scorring.scoreValue + Scorring.scoreValueCow;
        }
        else if (other.tag == "Fox")
        {
            Scorring.scoreValue = Scorring.scoreValue + Scorring.scoreValueFox;
        }
        else if (other.tag == "Rooster")
        {
            Scorring.scoreValue = Scorring.scoreValue + Scorring.scoreValueRooster;
        }
        else if (other.tag == "Stag")
        {
            Scorring.scoreValue = Scorring.scoreValue + Scorring.scoreValueStag;
        }
        else if (other.tag == "Dog")
        {
            Scorring.scoreValue = Scorring.scoreValue + Scorring.scoreValueDog;
        }
        else if (other.tag == "Chick")
        {
            Scorring.scoreValue = Scorring.scoreValue + Scorring.scoreValueChick;
        }
        else if(other.tag == "Horse")
        {
            Scorring.scoreValue = Scorring.scoreValue + Scorring.scoreValueHorse;
        }
    }
}
