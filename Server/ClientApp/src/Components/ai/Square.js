import React, {Component} from "react";

export default class Square extends Component {
    getSquareValue = (fieldType) => {
        switch (fieldType) {
            case 0: {
                return "~~";
            }
            case 1: {
                return "~~";
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
            className="col-xs-1-10 text-center square"
            onClick={this.props.hitSquaree.bind(Square, this.props.square)}>
            <p className="squareValue">{this.getSquareValue(this.props.square.fieldType)}</p>
        </div>;
        return (
            content


        )
    }

}