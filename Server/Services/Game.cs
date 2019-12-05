﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Server.Models.Board;
using Server.Models.Ships;

namespace Server.Services
{
    public class Game : IGame
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Player CurrentPlayer { get; set; }

        private List<Tuple<int, int>> siShooTuples;


        public Game()
        {
            this.Player1 = new Player();
            this.Player2 = new Player();
            this.CurrentPlayer = Player1;
        }


        public void PutShip(int shipId, ShipType shipType, List<Square> shipSquares)
        {
            ShipFactory shipyard = new ShipFactory();
            var ship = ShipFactory.CreateShip(shipSquares);

            foreach (var boardSquare in ship.ShipSquares.SelectMany(shipSquare => Player1.Ocean.Board
                .Where(boardSquare => shipSquare.Coordinates.Column == boardSquare.Coordinates.Column &&
                                      shipSquare.Coordinates.Row == boardSquare.Coordinates.Row)))
            {
                boardSquare.fieldType = FieldType.Ship;
            }
        }

        public void Shoot(Coordinates coordinates)
        {
            foreach (var square in Player1.Ocean.Board)
            {
                if (square.Coordinates.Column == coordinates.Column && square.Coordinates.Row == coordinates.Row)
                {
                    if (square.fieldType == FieldType.Empty || square.fieldType == FieldType.Ship)
                    {
                        if (square.IsOccupied())
                        {
                            square.fieldType = FieldType.Hit;
                        }
                        else
                        {
                            square.fieldType = FieldType.Miss;
                            Si();
                        }
                    }
                }
            }

        }

        private Coordinates SiCoordinates()
        {
            Random random = new Random();

            var column = random.Next(1, 11);
            var row = random.Next(1, 11);

            return new Coordinates(row,column);
        }

        private void Si()
        {
            var cord = SiCoordinates();
            
            foreach (var square in Player2.Ocean.Board)
            {
                if (square.Coordinates.Column == cord.Column && square.Coordinates.Row == cord.Row)
                {
                    if (square.fieldType == FieldType.Empty || square.fieldType == FieldType.Ship)
                    {
                        if (square.IsOccupied())
                        {
                            square.fieldType = FieldType.Hit;
                        }
                        else
                        {
                            square.fieldType = FieldType.Miss;
                        }
                    }
                }




            }
        }
    }
}