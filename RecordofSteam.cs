using System;
using System.Collections.Generic;
using System.Text;

namespace UnivBCDice
{
    public class RecordofSteam : DiceBot
    {
        public String gameType()
        {
            return "RecordofSteam";
        }

        public String getHelpMessage()
        {
            return 
@"2S2@1
RecordofSteam: (2S2@1) ＞ 1,2,3,4 ＞ 1回転 ＞ 成功数2

4S3@2
RecordofSteam: (4S3@2) ＞ 2,1,2,4,4,4,2,3,4,5,6 ＞ 4回転 ＞ 成功数5";
        }

        public String rollDiceCommandResult(String String)
        {
            String result="";
            
            return result;
        }
    }
}
