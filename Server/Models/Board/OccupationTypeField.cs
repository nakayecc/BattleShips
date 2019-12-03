using System.ComponentModel;

namespace BattleShip.Models.Board
{
    public enum OccupationTypeField
    {
        [Description("A")]
        Aircraft,

        [Description("B")]
        Battleship,

        [Description("C")]
        Cruiser,

        [Description("S")]
        Submarine,

        [Description("D")]
        Destroyer,

        [Description("X")]
        Hit,

        [Description("O")]
        Miss,

        [Description("")]
        Empty






    }
}