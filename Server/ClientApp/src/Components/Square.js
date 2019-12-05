import React, {Component} from "react";
import axios from "../axios/axios";

export default class Square extends Component {

    hitSquare = (clickedSquare) => {


        let temp = this.props.squares;
        temp.map(square => {
            if (clickedSquare.coordinates === square.coordinates) {
                //square.fieldType = 3;
                axios.post('board', {
                    row: square.coordinates.row,
                    column: square.coordinates.column
                    
                })
                    .then(function (response) {
                        console.log(response);
                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            }
            return square;
        });
        let hitSquaree = this.props.hitSquaree;
        hitSquaree();
    };


    render() {
        let isShip = "S";
        let ocean = "~~";
        // "col-xs-1-10 text-center"
        return (
            <div
                className={this.props.square.fieldType === 1 ? "col-xs-1-10 text-center squareShip" : "col-xs-1-10 text-center square"}
                onClick={this.hitSquare.bind(Square, this.props.square)}>


                <p className="squareValue">{this.props.square.fieldType === 3 ? isShip : ocean}</p>

            </div>

        )
    }

}