using UnityEngine;

public class UIMainInteraction : MonoBehaviour
{
    [SerializeField] GameObject[] spawnObjects;

    public void SpawnPills()
    {
        GameObject pills = Instantiate(spawnObjects[0], this.transform.position + new Vector3(0f, 0.5f, 0f), new Quaternion(0f, 0f, 0f, 0f));

        //print(pills.transform.name + pills.transform.tag);

        Destroy(pills, 30f);
    }

    public void SpawnCake()
    {
        GameObject cake = Instantiate(spawnObjects[1], this.transform.position + new Vector3(0f, 0.5f, 0f), new Quaternion(0f, 0f, 0f, 0f));

        //print(cake.transform.name + cake.transform.tag);

        Destroy(cake, 30f);
    }
}
