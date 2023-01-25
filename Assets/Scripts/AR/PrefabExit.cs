using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabExit : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        this.gameObject.SetActive(false);
    }
}
