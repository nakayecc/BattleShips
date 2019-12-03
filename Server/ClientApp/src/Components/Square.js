import React, {Component} from "react";

export default class Square extends Component {


    render() {
        let isShip = "S";
        let ocean = "~~";
        console.log(this.props.square.isShip);
        return (
            <div className="col-xs-1-10 text-center square" id={this.props.square.id}>

                <p className="squareValue">{this.props.square.isShip === true ? isShip : ocean}</p>

            </div>

        )
    }

}