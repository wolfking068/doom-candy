﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shop : MonoBehaviour
{
    public gun gun;
    public bashballbat bat;
    public int add;
    public int addrange;
    public int addbashballbat;
    public int maxdamige;
    public int maxdamigebashbballbat;
    public int maxrange;
    public player_movment player;
    public int change;
    public int gundamigepriceprice;
    public int rangeforgunprice;
    public int damegeforbatprice;
    public int change2;
    public int change3;
    public int change4;
    public bool gundamigeprice;
    public bool gunranigeprice;
    public bool batprice;
    public Text gunprice;
    public Text gunpriceringe;
    public Text batpricedamige;
    private void Start()
    {
        gunprice.text = gundamigepriceprice.ToString();
        gunpriceringe.text = rangeforgunprice.ToString();
        batpricedamige.text = damegeforbatprice.ToString();
    }
    public void damige_for_gun()
    {
        if (gundamigepriceprice <= player.points && gun.damige < maxdamige)
        {
            gun.damige += add;
            change2 = player.points -= gundamigepriceprice;
            player.points = change2;
            player.play.score2();
            gun.damige = Mathf.Clamp(gun.damige, 0, maxdamige);
            gundamigepriceprice += 5;
            gunprice.text = gundamigepriceprice.ToString();
            if(maxdamige == gun.damige)
            {
                gunprice.text = "max for this shop";
            }

        }
    }
    public void range_for_gun()
    {
        if (rangeforgunprice<= player.points&&gun.range < maxrange)
        {
            gun.range += addrange;
            gun.range = Mathf.Clamp(gun.range, 0, maxrange);
            change3 = player.points -= rangeforgunprice;
            player.points = change3;
            player.play.score2();
            rangeforgunprice += 5;
            gunpriceringe.text = rangeforgunprice.ToString();
            if(maxrange == gun.range)
            {
                gunpriceringe.text = "max for this shop";
            }
        }
    }
    public void damige_for_bashballbat()
    {
        if (damegeforbatprice <= player.points && bat.damige < maxdamigebashbballbat)
        {
            bat.damige += addbashballbat;
            bat.damige = Mathf.Clamp(bat.damige, 0, maxdamigebashbballbat);
            change4 = player.points -= damegeforbatprice;
            player.points = change4;
            player.play.score2();
            damegeforbatprice += 5;
            batpricedamige.text = damegeforbatprice.ToString();

            if (maxdamigebashbballbat == bat.damige)
            {
                batpricedamige.text = "max for this shop";
            }
        }
    }
}
