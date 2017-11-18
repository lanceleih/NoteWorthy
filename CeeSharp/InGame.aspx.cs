using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CeeSharp
{
    
    /// <summary>
    /// COMP4952 Project
    /// Author: Teah Elaschuk
    /// Code behind for InGame page: Work in progress
    /// No actual game functionality yet, but the fretboard is created and each fret knows
    /// its note value.
    /// 
    /// Clicking on a fret will display the selected note.
    /// </summary>
    public partial class InGame : System.Web.UI.Page
    {
        /// <summary>
        /// The musical alphabet - we would like to eventually implement this in a singleton class,
        /// or some other globally accessible way
        /// </summary>
        private List<string> alf = new List<string>{
            "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"
        };

        /// <summary>
        /// Number of strings on the guitar
        /// </summary>
        private const int numStrings = 6;  

        /// <summary>
        /// Number of frets on the guitar (12, plus open notes), will expand later
        /// </summary>
        private const int numFrets = 13;

        /// <summary>
        /// Maps the cells to the musical notes
        /// </summary>
        private Dictionary<TableCell, string> notes;


        /// <summary>
        /// Gets the game level info passed via query strings from the game selection page,
        /// or goes back if the values are not defined.
        /// Initializes the fretboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["GameType"] != null 
                && Request.QueryString["Level"] != null)
            {
                // extract the level information and display it at the top of the page
                Label_title.Text = "<h1>" 
                    + Request.QueryString["GameType"].ToString() 
                    + ": " + Request.QueryString["Level"].ToString()
                    + "</h1>";
            } else
            {
                // no level information, go back
                Response.Redirect("~/Game.aspx");
            }
            InitFretboard();
            InitValues();
            SetTooltips();
            SetStringLabels();
        }

        /// <summary>
        /// Creates a mock guitar fretboard using table, tablerow, and tablecell controls.
        /// </summary>
        protected void InitFretboard()
        {
            Table_fretboard.Width = new Unit("100%");
            // for each string on the fretboard, create a table row
            for (int i = 0; i < 6; i++)
            {
                Table_fretboard.Rows.Add(new TableRow());

                // for each fret on the fretboard, create a note and style it
                for (int j = 0; j < numFrets; j++)
                {
                    Table_fretboard.Rows[i].Cells.Add(new TableCell());
                    Table_fretboard.Rows[i].Cells[j].Style.Add("border-left", "solid 2px black");
                    Table_fretboard.Rows[i].Cells[j].Style.Add("border-right", "solid 2px black");
                    Table_fretboard.Rows[i].Cells[j].Style.Add("padding", "0");
                    Table_fretboard.Rows[i].Cells[j].Style.Add("height", "50px");

                    if (j == 0)
                    {
                        // the first note is not technically a fret, but an open string. 
                        // styled differently for clarity
                        Table_fretboard.Rows[i].Cells[j].BackColor = System.Drawing.Color.Beige;
                        Table_fretboard.Rows[i].Cells[j].Controls.Add(new LinkButton { Text = "*" });
                        Table_fretboard.Rows[i].Cells[j].Style.Add("padding-left", "10px");
                        Table_fretboard.Rows[i].Cells[j].Style.Add("padding-right", "10px");
                    }
                    else
                    {
                        // regular fret
                        Table_fretboard.Rows[i].Cells[j].Controls.Add(new ImageButton
                        {
                            ImageUrl = "~/Icons/bigstring.png",
                            Width = new Unit("100%")
                        });
                    }
                }
            }
        }

        /// <summary>
        /// Sets values for each note
        /// </summary>
        protected void InitValues()
        {
            notes = new Dictionary<TableCell, string>();
            int k;
            for(int i = 0; i < numStrings; i++)
            {
                switch(i)
                {
                    case 0:
                        k = 7;      // index of note E
                        break;
                    case 1:
                        k = 2;      // index of note B
                        break;
                    case 2:
                        k = 10;     // index of note G
                        break;
                    case 3:
                        k = 5;      // index of note D
                        break;
                    case 4:
                        k = 0;      // index of note A
                        break;
                    case 5:
                        k = 7;      // index of note E
                        break;
                    default:        // should not get here
                        k = 0;
                        break;                 
                }
                for(int j = 0; j < numFrets; j++)
                {
                    if (k == 12)        // if the index goes out of bounds, go back to the beginning
                        k = 0;
                    notes.Add(Table_fretboard.Rows[i].Cells[j], alf[k++]);
                }
            }
        }

        /// <summary>
        /// Sets hover tags for the notes
        /// </summary>
        protected void SetTooltips()
        {
            string s = "";
            for(int i = 0; i < numStrings; i++)
            {
                for(int j = 1; j < numFrets; j++)
                {
                    if(notes.TryGetValue(Table_fretboard.Rows[i].Cells[j], out s))
                        Table_fretboard.Rows[i].Cells[j].ToolTip = s;
                }
            }
        }

        /// <summary>
        /// Sets the string names in the first column (open notes)
        /// </summary>
        protected void SetStringLabels()
        {
            string s = "";
            for(int i = 0; i < numStrings; i++)
            {
                Control btn = Table_fretboard.Rows[i].Cells[0].Controls[0];
                if (notes.TryGetValue(Table_fretboard.Rows[i].Cells[0], out s))
                    (btn as LinkButton).Text = s;
            }
        }

    }
}