using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public int waitTimeBeforeStoneDestroy = 5;
    public int damageValue = 1;
    void Awake() {
        StartCoroutine(DestroyStone());
    }

    IEnumerator DestroyStone() {
        yield return new WaitForSeconds(waitTimeBeforeStoneDestroy);
        Destroy(gameObject);
    }
}
