using GameLibrary;
using System.Windows.Forms;
public class PartyRL : Roll {
    public PictureBox Pic { get; private set; }
    public float XP { get; private set; }
    public bool ShouldLevelUpRL { get; private set; }
    public void GainXP(float amount) {
      XP += amount/2;
      if ((int)XP / 75 >= Level) {
        ShouldLevelUpRL = true;
      }
    }    
    public override void LevelUp() {
      base.LevelUp();
      ShouldLevelUpRL = false;
        }
    
    }

public class PartyRU : Rush {
    public PictureBox Pic { get; private set; }
    public float XP { get; private set; }
    public bool ShouldLevelUpRU { get; private set; }
    public void GainXP(float amount) {
         XP += amount/2;
         if ((int)XP / 75 >= Level) {
            ShouldLevelUpRU = true;
         }
    }
    public override void LevelUp() {
      base.LevelUp();
      ShouldLevelUpRU = false;
    }        
}