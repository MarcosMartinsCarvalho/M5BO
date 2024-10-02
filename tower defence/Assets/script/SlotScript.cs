using UnityEngine;

public class SlotScript : MonoBehaviour
{
    public bool isOccupied = false;
    [SerializeField] PlantSelector plantSelector;

    private void OnMouseDown()
    {
        if (!isOccupied)
        {
            plantSelector.gameObject.SetActive(true);
            plantSelector.currentSelected = transform;

            // Here you would typically call PlacePlant, but you need to ensure
            // the correct plant is selected before doing so.

            isOccupied = true; // Mark slot as occupied
            Debug.Log("Slot selected and set as currentSelected");
        }
        else
        {
            Debug.Log("Slot already occupied");
        }
    }

    public void PlaceSelectedPlant(GameObject plant)
    {
        if (plantSelector.currentSelected != transform) return;

        plantSelector.PlacePlant(plant);
        isOccupied = true; // Ensure slot is marked as occupied
        Debug.Log("Plant placed on slot");
    }
}
