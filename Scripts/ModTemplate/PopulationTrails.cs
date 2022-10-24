﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AstralCodex
{
    class PopulationTrails : Trails
    {

        void Awake()
        {
            targetPaths = new List<string> {
                "Traveller_HEA_Player_v2",
                "QuantumMoon_Body",
                "Villager_HEA_Slate",
                "Traveller_HEA_Gabbro",
                "Traveller_HEA_Chert",
                "Traveller_HEA_Riebeck",
                "DarkBramble_Body",
                "Villager_HEA_Tephra",
                "Villager_HEA_Galena",
                "Villager_HEA_Mica",
                "Villager_HEA_Gneiss",
                "Villager_HEA_Spinel",
                "Villager_HEA_Rutile",
                "Villager_HEA_Marl",
                "Villager_HEA_Porphy",
                "Villager_HEA_Gossan",
                "Villager_HEA_Arkose_GhostMatter",
                "Villager_HEA_Moraine",
                "Character_HEA_Hal_Museum",
                "Villager_HEA_Tektite_2",
                "Villager_HEA_Esker",
                "Villager_HEA_Hornfels (1)",
                "Villager_HEA_Tuff",
                "TimeLoopRing_Body/Characters_TimeLoopRing/NPC_Player"
                };
        }

        public override void Start()
        {
            base.Start();
            //Lower alpha on player trail
            Color c = trails[0].material.color;
            c.a = 1f;
            trails[0].material.color = c;
        }
    }
}