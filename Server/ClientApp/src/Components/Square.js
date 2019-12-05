import React, {Component} from "react";
import axios from "../axios/axios";

export default class Square extends Component {

    render() {
        let isShip = "S";
        let ocean = "~~";

        let spinner = <div className="spinner-border" role="status">
            <span className="sr-only">Loading...</span>
        </div>;
        let content = <div
            className={this.props.square.fieldType === 1 ? "col-xs-1-10 text-center squareShip" : "col-xs-1-10 text-center square"}
            onClick={this.props.hitSquaree.bind(Square, this.props.square)}>
            <p className="squareValue">{this.props.square.fieldType === 3 ? isShip : ocean}</p>
        </div>;
        return (
            content

        )
    }

}