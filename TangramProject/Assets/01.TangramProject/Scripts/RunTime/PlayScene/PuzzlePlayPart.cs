using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzlePlayPart : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{

    private bool isClicked = false;
    private RectTransform objRect = default;
    private PuzzleInitZone puzzleInitZone = default;
    void Start()
    {
        isClicked = false;
        objRect = gameObject.GetRect();
        puzzleInitZone = transform.parent.gameObject.GetComponentMust<PuzzleInitZone>();
    }

    //! 마우스 버튼을 눌렀을 때 동작하는 함수
    public void OnPointerDown(PointerEventData eventData)
    {
        isClicked = true;
    }       // OnPointerDown()

    //! 마우스 버튼을 뗏을 때 동작하는 함수
    public void OnPointerUp(PointerEventData eventData)
    {
        isClicked = false;
    }       // OnPointerUp()

    public void OnDrag(PointerEventData eventData)
    {
        if (isClicked)
        {
            gameObject.AddAnchoredPos(eventData.delta / puzzleInitZone.parentCanvas.scaleFactor);
        }

    }

    #region Legacy Object Move Code
    // //! 마우스를 드래그 중일 때 동작하는 함수
    // public void OnPointerMove(PointerEventData eventData)
    // {
    //     if (!isClicked)
    //     {
    //         return;
    //     }
    //     Vector2 mousePos = eventData.position;
    //     GFunc.Log($"X : {mousePos.x} / Y : {mousePos.y}");
    //     gameObject.SetLocalPos(mousePos.x, mousePos.y, 0);
    //     //GFunc.Log($"{mousePos}마우스 포지션");
    // }       // OnPointerMove()
    #endregion
}
