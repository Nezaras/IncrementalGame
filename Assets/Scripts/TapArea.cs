using UnityEngine.EventSystems;
using UnityEngine;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown (PointerEventData eventData)
    {
        GameManager.Instance.CollectByTap (eventData.position, transform);
    }
}
