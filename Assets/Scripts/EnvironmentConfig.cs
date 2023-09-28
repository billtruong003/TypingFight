using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "EnvironmentConfig", menuName = "Config/EnvironmentConfig")]
public class EnvironmentConfig : ScriptableObject
{
    public List<EnvironmentData> sprites;
    public Color DayCol;
    public Color NightCol;
    [Serializable]
    public class EnvironmentSprite
    {
        public string EnvironmentName;
        public Sprite Ground;
        public List<Sprite> Grass1;
        public List<Sprite> Grass2;
        public Sprite Flower;
        public List<Sprite> Leaf;
        public Sprite Tree;
        public Sprite Rock;

        public string GetEnvironmentName()
        {
            return this.EnvironmentName;
        }
        public Sprite GetGround()
        {
            return this.Ground;
        }
        public Sprite GetGrass1()
        {
            Sprite spriteUse = Grass1[UnityEngine.Random.Range(0, Grass1.Count)];
            return spriteUse;
        }
        public Sprite GetGrass2()
        {
            Sprite spriteUse = Grass2[UnityEngine.Random.Range(0, Grass2.Count)];
            return spriteUse;
        }
        public Sprite GetLeaf()
        {
            Sprite spriteUse = Leaf[UnityEngine.Random.Range(0, Leaf.Count)];
            return spriteUse;
        }
        public Sprite GetTrees()
        {
            return this.Tree;
        }
        public Sprite GetRock()
        {
            return this.Rock;
        }
    }
    [Serializable]
    public class EnvironmentData
    {
        public Environment EnvironmentType;
        public EnvironmentSprite Sprites;
        public string GetEnv()
        {
            return Sprites.GetEnvironmentName();
        }
    }
    public enum Environment
    {
        NONE,
        DAY,
        NIGHT,
    }
}
