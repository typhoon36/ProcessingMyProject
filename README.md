# Ghost Slayer

![Title](https://github.com/user-attachments/assets/5bc6f5e9-a3f5-46e9-ba98-c3a261846f2e) ![Dialog](https://github.com/user-attachments/assets/eae12b7d-b539-441e-bdbe-ff206bf430ef)


## 게임 소개

- 장르 : 메트로배니아 액션 RPG

- 개발기간 (2024.06.10 → 2024.09 28)

- 목적  : 즐겨했던 메트로배니아 RPG 게임을 직접 구현해보고자 제작한 프로젝트입니다.

- 관리 : Github




## 개발 환경
- 플랫폼 : Windows 11

- 언어 : C#

- 엔진 환경 : Unity 2022.03.15(LTS)




## 사용 기술

| 항목 | 설명 |
| ------------ | ------------- |
| 디자인 패턴 | 싱글톤 패턴을 사용하여 스크립트 관리 |
| Object Pooling | 자주 사용되는 객체는 재사용하여 관리 |
| FSM | 몬스터들의 패턴을 직관적으로 관리 |
| 직렬화 | 유니티상에서 클래스를 직렬화하여 작업 편의성 증대 |
| 코루틴  | 연출은 코루틴으로 관리하여 메모리 확보 |
| Save | 게임내 데이터를 글로벌 변수에 저장 및 관리 |


## 구현 기능

* Player
  * 유령 방랑자

* 일반 몬스터
   * 나무 엔트
   * 덤불 앤트
   * 슬라임
* 보스 몬스터
   * 숲지기(패턴:이동,기본공격,총알공격)

 * 아이템
    * 무기2,방패1,귀환서 1

* UI
   * Scene
      * TitleScene  : 시작 , 종료 버튼
      * InGame : HP,MP 
   * Popup
      * 메뉴,인벤토리,대화창
   * WorldSPace
      * 닉네임,몬스터 HP바
        

 ## 기술 문서



 ## velog



 ## 영상
