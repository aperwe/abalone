using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abalone.Game
{
    public class Game
    {
        User user1;
        public User User1
        {
            get
            {
                return user1;
            }
            private set
            {
                user1 = value;
            }
        }

        User user2;
        public User User2
        {
            get
            {
                return user2;
            }
            private set
            {
                user2 = value;
            }
        }

        Board board;
        public Board Board
        {
            get
            {
                return board;
            }
            private set
            {
                board = value;
            }
        }

        public static Game CreateGame()
        {
            Game game = new Game();
            game.User1 = new User();
            game.User2 = new User();
            game.board = new Board();
            return game;
        }
    }
}
