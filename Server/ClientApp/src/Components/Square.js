import React, {Component} from "react";
import axios from "../axios/axios";

export default class Square extends Component {
    getSquareValue = (fieldType) => {
        switch (fieldType) {
            case 0: {
                return "~~";
            }
            case 1: {
                return "S";
            }
            case 2: {
                return "O";
            }
            case 3: {
                return "X";
            }
        }
    };
    render() {

        //console.log(this.props);
        let isShip = "S";
        let ocean = "~~";


        let spinner = <div className="spinner-border" role="status">
            <span className="sr-only">Loading...</span>
        </div>;
        let content = <div
            className={this.props.square.fieldType === 1 ? "col-xs-1-10 text-center squareShip" : "col-xs-1-10 text-center square"}
            onClick={this.props.hitSquaree.bind(Square, this.props.square)}>
            <p className="squareValue">{this.getSquareValue(this.props.square.fieldType)}</p>
        </div>;
        return (
            content


        )
    }

}