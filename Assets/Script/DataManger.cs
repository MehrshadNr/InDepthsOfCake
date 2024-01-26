using UnityEngine;

[CreateAssetMenu(menuName = "test")]
public class DataManger : ScriptableObject
{
    public int Board;
    public int PlayerNumber;
    public bool Qte;
    public bool classicMode;
    public bool musicMode;
    public float GameMusicVolume;
    public float MenuMusicVolume;
    public bool MobileMode;
}
