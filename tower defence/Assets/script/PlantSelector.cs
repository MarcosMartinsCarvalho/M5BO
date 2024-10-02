    using UnityEngine;

public class PlantSelector : MonoBehaviour
{
    public Transform currentSelected;

    public void PlacePlant(GameObject plant)
    {
        if (currentSelected == null) return;

        Instantiate(plant, currentSelected.position, Quaternion.identity);
        Debug.Log(plant.name + " placed");

        // Optionally, deactivate PlantSelector if it's no longer needed
        gameObject.SetActive(false);
    }
}
