﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Upgrade;

namespace UpgradesList
{

    public class ClusterMissiles : GenericSecondaryWeapon
    {
        public ClusterMissiles() : base()
        {
            Type = UpgradeType.Missiles;

            Name = "Cluster Missiles";
            ShortName = "Cluster Missiles";
            ImageUrl = "https://vignette2.wikia.nocookie.net/xwing-miniatures/images/1/10/Cluster_Missiles.png";
            Cost = 4;

            MinRange = 1;
            MaxRange = 2;
            AttackValue = 3;

            RequiresTargetLockOnTargetToShoot = true;

            SpendsTargetLockOnTargetToShoot = true;
            IsDiscardedForShot = true;

            IsTwinAttack = true;
        }

        public override void AttachToShip(Ship.GenericShip host)
        {
            base.AttachToShip(host);
        }

    }

}