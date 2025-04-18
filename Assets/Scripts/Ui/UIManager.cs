using TMPro;
using UnityEngine;

//���� ����:  �ͷ��� ���ʹ̰� �����ϴ� ���� ����. 
//  �������� ���� �����ϱ�. �������� HP, ����, ���� Damage  
// HP random (90,  100)   
// Damage    (40, 200)  
// 



public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI _TurretAmount;  // UI���ؽ�Ʈ �ʵ�.   
    public TextMeshProUGUI _EnemyAmount;  // UI�� �ؽ�Ʈ �ʵ�.
    
    public int TotalTurret=5;              //���� �ͷ� ����. 
    public int TotalEnemy= 5;              //���� �ͷ� ����. 

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
        // ������ �ٽ� �ϴ� ����
        // GameManger.cs ���� �ٽ� Instaicate �� �ϸ� ��.
        // ����1: 0�� �Ǵ� �������� Panel�� on ��Ű�� ��Ű��.
        // ����2: �����ִ� ���ʹ� Ȥ�� �ͷ��� ��ƼŬ ���� ��Ű��.(enemyy, turret Ŭ�������� ó��)
        // ����3: Again button Ŭ���� ���� ����.
        //        ���� ���� ������ �����ϱ�.
        //        GameManger ��� �޼��� �����ϱ�.
    }
    public void quit()
    {
        Application.Quit();
    }
}
