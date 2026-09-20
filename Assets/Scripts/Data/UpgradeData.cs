using UnityEngine;

// 메뉴에 "Create > Cookie Clicker > Upgrade Data" 항목이 생기게 해줌
[CreateAssetMenu(fileName = "New Upgrade", menuName = "Cookie Clicker/Upgrade Data")]
public class UpgradeData : ScriptableObject
{
    [Header("표시 정보")]
    public string upgradeName = "클릭 강화";   // 버튼에 표시될 이름

    [Header("가격 설정")]
    public long baseCost = 10;                 // 최초 구매 비용
    public float costMultiplier = 1.5f;        // 구매할 때마다 비용이 몇 배씩 늘어날지

    [Header("효과")]
    public long clickPowerIncrease = 1;        // 구매 시 클릭당 획득량 증가량
}
