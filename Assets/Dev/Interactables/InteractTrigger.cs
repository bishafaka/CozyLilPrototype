using UnityEngine;
using UnityEngine.Events;

public class InteractTrigger : MonoBehaviour
{
	[SerializeField] GameObject interactObject;
	[SerializeField] UnityEvent onInteract;
    bool playerInside;

	void Start()
	{
		if(interactObject!=null)
			interactObject.SetActive(false);
	}
	void OnDestroy()
	{
		if(InputManager.Instance!=null)
			InputManager.Instance.InteractPressed-=OnInteractPressed;
	}
	void OnDisable()
	{
		if(InputManager.Instance!=null)
			InputManager.Instance.InteractPressed-=OnInteractPressed;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(!other.CompareTag("Player"))
			return;
		playerInside=true;
		if(interactObject!=null)
			interactObject.SetActive(true);
		if(InputManager.Instance!=null)
			InputManager.Instance.InteractPressed+=OnInteractPressed;
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if(!other.CompareTag("Player"))
			return;
		playerInside=false;
		if(interactObject!=null)
			interactObject.SetActive(false);
		if(InputManager.Instance!=null)
			InputManager.Instance.InteractPressed-=OnInteractPressed;
	}
	void OnInteractPressed()
	{
		if(!playerInside)
			return;
		onInteract?.Invoke();
	}
}
