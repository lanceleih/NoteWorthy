﻿using App.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace CeeSharp
{
    public partial class Achievements : System.Web.UI.Page
    {
        private static Dictionary<int, Boolean> achievements = new Dictionary<int, bool>();
        private static string trophies;
        private const int AchievementsNumber = 12;
        private List<HtmlGenericControl> imgs = new List<HtmlGenericControl>();

        /// <summary>
        /// Set up Achievement page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Load</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            SetUpIcons();

            populate();
            // trophies = "1,2,3,5,";
            trophies = Context.User.Identity.GetAchievement();
            retrieveTrophies(trophies);
            highLight();

        }

        /// <summary>
        /// Set up Achievements Icons.
        /// </summary>
        private void SetUpIcons()
        {
            for (int i = 0; i < AchievementsNumber; i++)
            {
                HtmlGenericControl li = new HtmlGenericControl("li");
                HtmlGenericControl img = new HtmlGenericControl("img");
                img.Attributes["runat"] = "server";
                img.Attributes["src"] = "Icons/002-success.png";
                img.Attributes["height"] = 75.ToString();
                img.Attributes["data-placement"] = "top";
                img.Attributes["data-toggle"] = "popover";
                img.Attributes["data-trigger"] = "hover";
                img.Attributes["title"] = "Level " + (i + 1) + "!";
                img.Attributes["data-content"] = "Finished level " + (i + 1);

                imgs.Add(img);
                li.Controls.Add(img);
                if (imgList != null)
                    imgList.Controls.Add(li);
            }
        }

        /// <summary>
        /// Initialize achievement dictionary.
        /// </summary>
        private void populate()
        {
            //achievements[1] = false;
            //achievements[2] = false;
            //achievements[3] = false;
            //achievements[4] = false;
            //achievements[5] = false;
            //achievements[6] = false;
            //achievements[7] = false;
            //achievements[8] = false;
            //achievements[9] = false;
            //achievements[10] = false;
            //achievements[11] = false;
            //achievements[12] = false;

            for (int i = 0; i < AchievementsNumber; i++)
                achievements[i] = false;
        }

        /// <summary>
        /// Parse User Achievement.
        /// </summary>
        /// <param name="trophies">User Achievement String</param>
        private void retrieveTrophies(string trophies)
        {
            //Debug.WriteLine("INSIDE ACHIEVEMENTS");
            //string check = string.Empty;
            //int id = 0;
            //foreach(char c in trophies)
            //{
            //    if(char.IsDigit(c))
            //    {
            //        check += c;
            //    } else
            //    {
            //        id = Int32.Parse(check);
            //        check = string.Empty;
            //        Debug.WriteLine("Number: " + id);
            //        achievements[id] = true;
            //        id = 0;
            //    }
            //}

            foreach (string num in trophies.Split(','))
                if (num != string.Empty && num != "0")
                    achievements[Int32.Parse(num)] = true;
        }

        /// <summary>
        /// Mark the Achievements that the User has completed.
        /// </summary>
        private void highLight()
        {
            foreach (var trophy in achievements)
            {
                if (trophy.Value.Equals(true))
                {
                    imgs[trophy.Key-1].Attributes["src"] = "Icons/yay.png";
                    //switch (trophy.Key)
                    //{
                    //    case 1:
                    //        if (!Object.ReferenceEquals(img1, null))
                    //        {
                    //            img1.Src = "Icons/yay.png";
                    //            img1.Height = 75;
                    //        }
                    //        break;
                    //    case 2:
                    //        if (!Object.ReferenceEquals(img2, null))
                    //        {
                    //            img2.Src = "Icons/yay.png";
                    //            img2.Height = 75;
                    //        }
                    //        break;
                    //    case 3:
                    //        if (!Object.ReferenceEquals(img3, null))
                    //        {
                    //            img3.Src = "Icons/yay.png";
                    //            img3.Height = 75;
                    //        }
                    //        break;
                    //    case 4:
                    //        if (!Object.ReferenceEquals(img4, null))
                    //        {
                    //            img4.Src = "Icons/yay.png";
                    //            img4.Height = 75;
                    //        }
                    //        break;
                    //    case 5:
                    //        if (!Object.ReferenceEquals(img5, null))
                    //        {
                    //            img5.Src = "Icons/yay.png";
                    //            img5.Height = 75;
                    //        }
                    //        break;

                    //}
                }
            }
        }
    }
}