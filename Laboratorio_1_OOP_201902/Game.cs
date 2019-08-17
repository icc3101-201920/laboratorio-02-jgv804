using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Game
    {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private Board boardGame;
        private bool endGame;

        //Constructor
        public Game()
        {
            Random random = new Random();
            players = new Player[2] { new Player(), new Player() };
            ActivePlayer = players[random.Next(0, 2)];
            boardGame = new Board();
            EndGame = false;

        }
        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
        }
        public bool EndGame
        {
            get
            {
                return this.endGame;
            }
            set
            {
                endGame = value;
            }
        }

        //Metodos
        public bool CheckIfEndGame()
        {
            int k;
            for (k = 0; k < 2; k++)
            {
                if (this.players[k].LifePoints == 0)
                {
                    this.endGame= true;
                }

            }
            return this.endGame;
        }
        public int GetWinner()
        {
            if (this.CheckIfEndGame())
            {
                if (players[0].LifePoints == 0)
                {
                    return players[1].Id;
                }
                else
                {
                    return players[0].Id;
                }
            }
            return 999;
        }
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
