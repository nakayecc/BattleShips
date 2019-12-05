import React, {Component} from "react";

export default class SquarePlayer extends Component {
    getSquareValue = (fieldType) => {
        switch (fieldType) {
            case 0: {
                return "~~";
            }
            case 1: {
                return "S";
            }
            case 2: {
                return "X";
            }
            case 3: {
                return "O";
            }
        }
    };
    render() {

        let spinner = <div className="spinner-border" role="status">
            <span className="sr-only">Loading...</span>
        </div>;
        let content = <div
            className={this.props.square.fieldType === 1 ? "col-xs-1-10 text-center squareShip" : "col-xs-1-10 text-center square"}>
            <p className="squareValue">{this.getSquareValue(this.props.square.fieldType)}</p>
        </div>;
        return (
            content


        )
    }

}