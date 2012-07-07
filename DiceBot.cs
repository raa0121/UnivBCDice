using System;
using System.Collections.Generic;
using System.Text;

namespace UnivBCDice
{
    class DiceBot
    {
        BCDice _bcdice = new BCDice();
        const int DEFAULT_SEND_MODE = 2;
        int _sendMode = DEFAULT_SEND_MODE;
        int _sortType = 0;
        int _sameDiceRerollCount = 0;
        int _sameDiceRerollType = 0;
        int _d66Type = 0;
        bool _isPrintMaxDice = false;
        int _upplerRollThreshold = 0;
        int _unlimitedRollDiceType = 0;
        int rerollNumber = 0;
        string _defaultSuccessTarget = "";
        int _rerollLimitCount = 0;
        string _fractionType = "omit";

        string _gameType = "none";


        public string gameType
        {
            get
            {
                return _gameType;
            }
            set
            {
                _gameType = value;
            }
        }

        public int setSendMode
        {
            set
            {
                _sendMode = value;
            }
        }

        public int upplerRollThreshold
        {
            set
            {
                _upplerRollThreshold = value;
            }
        }

        public BCDice bcdice
        {
            get
            {
                return _bcdice;
            }
            set
            {
                _bcdice = value;
            }
        }

        public int rand(int max)
        {
            return _bcdice.rand(max);
        }

        public string check_suc(List<int> param)
        {
            return _bcdice.check_suc(param);
        }

        
    }
}
