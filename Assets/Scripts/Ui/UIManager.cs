using TMPro;
using UnityEngine;

//오늘 과제:  터렛과 에너미가 교전하는 로직 구현. 
//  로직으로 승패 결정하기. 랜덤으로 HP, 설정, 살상력 Damage  
// HP random (90,  100)   
// Damage    (40, 200)  
// 



public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI _TurretAmount;  // UI에텍스트 필드.   
    public TextMeshProUGUI _EnemyAmount;  // UI에 텍스트 필드.
    
    public int TotalTurret=5;              //최초 터렛 갯수. 
    public int TotalEnemy= 5;              //최초 터렛 갯수. 

    public GameObject _winOrLosePanel;



    void Start()
    {       
        Turret.StaticDestroyEvent += OneTurretRemove;
        Enemy.OnDestroyEnemy += OneEnemyRemove;
           
        _EnemyAmount.text = TotalEnemy.ToString();
        _TurretAmount.text = TotalTurret.ToString();
    }

    public void OneTurretRemove()
    {
        TotalTurret = TotalTurret - 1; 
        _TurretAmount.text = TotalTurret.ToString();  
    }
    public void GameAgain()
    {
        // 게임을 다시 하는 로직
        // GameManger.cs 에서 다시 Instaicate 를 하면 됨.
        // 과제1: 0이 되는 시점에서 Panel을 on 시키면 시키기.
        // 과제2: 남아있는 에너미 혹은 터렛의 파티클 정지 시키기.(enemyy, turret 클래스에서 처리)
        // 과제3: Again button 클리시 게임 시작.
        //        잔존 게임 오브젝 제거하기.
        //        GameManger 어느 메서드 실행하기.
    }
    public void quit()
    {
        Application.Quit();
    }
}
