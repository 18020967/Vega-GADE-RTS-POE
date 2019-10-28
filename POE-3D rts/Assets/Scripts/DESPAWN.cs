using System.Collections;
using UnityEngine;

public class DESPAWN : MonoBehaviour
{
    //used to despawn sertain objects that needs despawning
    private void Start()
    {
        StartCoroutine(Despawn());
    }

    [SerializeField]
    private float Delay = 1f;

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(Delay);
        Destroy(gameObject);
    }


}
