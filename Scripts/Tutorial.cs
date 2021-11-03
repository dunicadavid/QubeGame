using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {

    public GameObject slow;

    public GameObject fast;

    public GameObject dead;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CubeBlue")
        {
            delete();
            slow.SetActive(true);
            Invoke("delete", 4);
        }

        if (other.gameObject.tag == "CubeRed")
        {
            delete();
            fast.SetActive(true);
            Invoke("delete", 4);
        }
        if (other.gameObject.tag == "CubeGold")
        {
            delete();
            dead.SetActive(true);
            Invoke("delete", 4);
        }

    }

    void delete()
    {
        slow.SetActive(false);
        fast.SetActive(false);
        dead.SetActive(false);
    }

}
