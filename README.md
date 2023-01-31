# TangramProjectRepository

# 타이틀 씬을 만들기 위한 리소스 리스트업

# -백그라운드 이미지

# -타이틀 이미지

# 팝업을 만들기 위해서 필요한 리로스 리스트업

# - 팝업 백 이미지

# - 메인 버튼 이미지

# - 닫기 버튼 이미지

- Issue.
- Summary : Unity 2D 프로젝트에서 IPointMoveHandler를 사용해 Object Drag를 구현하던 중 이슈 발생
- Detail
  1.  IPointerMoveHandler 에서 콜하는 OnPointerMove 메서드는 IDragHandler 에서 구현하는 OnDrag메서드보다 호출 속도가 느려서 오브젝트 드래그 중 오브젝트를 놓침
      이후에는 OnDrag메서드를 사용해서 구현하는 것이 더 나은 방식인 것으로 추정
  2.  PointerEventData 에서 가지고 오는 마우스 position을 기준으로 오브젝트 위치를 계산할 때 오브젝트 자신의 Pivot(Center) 위치 만큼의 오차가 발생.
      오브젝트의 Local 포지션을 마우스 포인터를 기준으로 절대좌표로 재설정 했을 때 Pivot 이슈가 발생하는 것을 확인, 이후 오브젝트를 움직일 때 절대좌표가 아닌 상대적인 움직임
      즉, Delta 를 더해서 연산하는 방식이 오차가 적을 것으로 추정
  3.  캔버스 하위에 위치한 오브젝트를 움직일 때 Local Position을 연산해서 움직이면 Anchor 의 Pivot과 Canvas의 ScaleFactor 값 만큼의 오차가 발생하게 된다.
      이후에는 LocalPostion이 아닌, Anchored Position과 ScaleFactor 값을 고려해서 연산하는 것이 오차가 적을 것으로 추정

# 오전 10:13 2023-01-31 tag v0.2.1
