using UnityEngine;

public class ItemPicker : MonoBehaviour
{
    [SerializeField] float _distanceToInteract = 3f;
    [SerializeField] LayerMask _interactableMask;
    private Transform _playerTransform;

    void Awake()
    {
        _playerTransform = transform; 
    }

    void Update()
    {
        TryPickUpItem();
    }
    private void TryPickUpItem()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f, _interactableMask))
            {
                ItemRegister holder = hit.collider.GetComponent<ItemRegister>();

                    float dist = Vector3.Distance(_playerTransform.position, hit.transform.position);

                    if (dist <= _distanceToInteract)
                    {
                        Debug.Log("Picked up: " + holder.item.itemName);
                        Destroy(hit.transform.root.gameObject);
                    }
                else
                {
                    Debug.Log("What happened");
                }
            }
        }
    }
}
