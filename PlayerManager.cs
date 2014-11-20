﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipTest.BoardData;

namespace BattleshipTest
{
    class PlayerManager
    {
        Player player;
        ComputerPlayer computerPlayer;

        public PlayerManager()
        {
            player = new Player();
            computerPlayer = new ComputerPlayer("easy");
            updateUpperScreens();
        }

        public PlayerManager(string dif)
        {
            player = new Player();
            computerPlayer = new ComputerPlayer(dif);
            updateUpperScreens();
        }

        public void updateUpperScreens()
        {
            player.board.upperScreen.screen = player.board.upperScreen.getUpperScreenFromOpponent(computerPlayer.board.lowerScreen);
            computerPlayer.board.upperScreen.screen = player.board.upperScreen.getUpperScreenFromOpponent(player.board.lowerScreen);
        }
        public bool update(bool isHumanFirst, bool debugMode)
        {
            if (isHumanFirst)
            {
                player.turn(computerPlayer.board, debugMode);
                if (player.CheckWin(player.board.lowerScreen.Ships))
                {
                    Console.WriteLine("Congratulations You Win");
                    return true;
                }
                computerPlayer.turn();
            }
            else
            {
                computerPlayer.turn();
                player.turn(computerPlayer.board, debugMode);
            }
            return false;
        }
    }
}