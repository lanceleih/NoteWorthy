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
        private Dictionary<int, Boolean> achievements = new Dictionary<int, bool>();
        protected void Page_Load(object sender, EventArgs e)
        {
            populate();
            string trophies = "1,3,5,7,9,11,";
            retrieveTrophies(trophies);

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
            //Console.WriteLine("INSIDE ACHIEVEMENTS");
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
    }
}