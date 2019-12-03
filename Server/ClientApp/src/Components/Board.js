import React, {Component} from "react";
import Square from "./Square";
export default class Board extends Component {
    constructor(props){
        super(props);

    }
    state = {
        squares: [
            {
                id: "1",
                isShip: false
            },
            {
                id: "2",
                isShip: false
            },
            {
                id: "3",
                isShip: false
            },
            {
                id: "4",
                isShip: false
            },
            {
                id: "5",
                isShip: false
            },
            {
                id: "6",
                isShip: false
            },
            {
                id: "7",
                isShip: false
            },
            {
                id: "8",
                isShip: false
            },
            {
                id: "9",
                isShip: false
            },
            {
                id: "10",
                isShip: false
            },
            {
                id: "11",
                isShip: false
            },
            {
                id: "12",
                isShip: false
            },
            {
                id: "13",
                isShip: false
            },
            {
                id: "14",
                isShip: false
            },
            {
                id: "15",
                isShip: false
            },
            {
                id: "16",
                isShip: false
            },
            {
                id: "17",
                isShip: false
            },
            {
                id: "18",
                isShip: false
            },
            {
                id: "19",
                isShip: false
            },
            {
                id: "20",
                isShip: false
            },

        ]
    };



    render() {


        return(

            this.state.squares.map(square =>
                <Square
                    square={square}
                key={square.id}/>
            )
        );

    }

}