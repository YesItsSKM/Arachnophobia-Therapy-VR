using UnityEngine;

public class UIMainInteraction : MonoBehaviour
{
    [SerializeField] GameObject[] spawnObjects;

    public void SpawnPills()
    {
        GameObject pills = Instantiate(spawnObjects[0], this.transform.position + new Vector3(0f, 0.5f, 0f), new Quaternion(0f, 0f, 0f, 0f));

        Destroy(pills, 30f);
    }

    public void SpawnCake()
    {
        int index = Mathf.RoundToInt(Random.Range(1f, 2f));

        GameObject food = Instantiate(spawnObjects[index], this.transform.position + new Vector3(0f, 0.5f, 0f), new Quaternion(0f, 0f, 0f, 0f));

        Destroy(food, 30f);
    }
}
