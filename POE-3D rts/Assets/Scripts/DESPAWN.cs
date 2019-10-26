using System.Collections;
using UnityEngine;

public class DESPAWN : MonoBehaviour
{
    
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
