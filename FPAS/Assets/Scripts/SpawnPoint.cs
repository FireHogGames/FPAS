using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {

    public GameObject type;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(time);

        Instantiate(type, transform.position, transform.rotation);

        /*
        yield return new WaitForSeconds(1f);
        Instantiate(type, transform.position, transform.rotation);

        yield return new WaitForSeconds(1f);
        Instantiate(type, transform.position, transform.rotation);
        */

        StartCoroutine(SpawnEnemy());
    }
}
