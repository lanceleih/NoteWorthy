using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CeeSharp
{
    public partial class Achievements : System.Web.UI.Page
    {
        private static Dictionary<int, Boolean> achievements = new Dictionary<int, bool>();
        private static string trophies;
        protected void Page_Load(object sender, EventArgs e)
        {
            populate();
            trophies = "1,2,3,5,";
            retrieveTrophies(trophies);
            highLight();

        }

        private void populate()
        {
            achievements[1] = false;
            achievements[2] = false;
            achievements[3] = false;
            achievements[4] = false;
            achievements[5] = false;
            achievements[6] = false;
            achievements[7] = false;
            achievements[8] = false;
            achievements[9] = false;
            achievements[10] = false;
            achievements[11] = false;

        }

        private void retrieveTrophies(string trophies)
        {
            Debug.WriteLine("INSIDE ACHIEVEMENTS");
            string check = string.Empty;
            int id = 0;
            foreach(char c in trophies)
            {
                if(char.IsDigit(c))
                {
                    check += c;
                } else
                {
                    id = Int32.Parse(check);
                    check = string.Empty;
                    Debug.WriteLine("Number: " + id);
                    achievements[id] = true;
                    id = 0;
                }
            }
        }

        private void highLight()
        {
            foreach(var trophy in achievements)
            {
                if(trophy.Value.Equals(true))
                {
                    switch(trophy.Key)
                    {
                        case 1:
                            if(!Object.ReferenceEquals(img1, null))
                            {
                                img1.Src = "Icons/yay.png";
                                img1.Height = 75;
                            }
                            break;
                        case 2:
                            if (!Object.ReferenceEquals(img2, null))
                            {
                                img2.Src = "Icons/yay.png";
                                img2.Height = 75;
                            }
                            break;
                        case 3:
                            if (!Object.ReferenceEquals(img3, null))
                            {
                                img3.Src = "Icons/yay.png";
                                img3.Height = 75;
                            }
                            break;
                        case 4:
                            if (!Object.ReferenceEquals(img4, null))
                            {
                                img4.Src = "Icons/yay.png";
                                img4.Height = 75;
                            }
                            break;
                        case 5:
                            if (!Object.ReferenceEquals(img5, null))
                            {
                                img5.Src = "Icons/yay.png";
                                img5.Height = 75;
                            }
                            break;

                    }
                }
            }
        }
    }
}