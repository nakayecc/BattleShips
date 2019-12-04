import React, {Component} from "react";
import axios from "../axios/axios";

export default class Square extends Component {

    hitSquare = (clickedSquare) => {
        
        
        let temp = this.props.squares;
        temp.map(square => {
                if(clickedSquare.coordinates === square.coordinates){
                    square.fieldType = 0;
                    axios.put('/board/'+this.props.squareId, square)
                        .then(response => {
                            console.log(response.status);
                        })
                        .catch(function (error) {
                            // handle error
                            console.log(error);
                        })
                        .finally(function () {
                            // always executed
                        });
                }
                return square;
        });
        let hitSquaree = this.props.hitSquaree;
        hitSquaree(temp);
    };
    
        
    

    render() {
        let isShip = "S";
        let ocean = "~~";
        // "col-xs-1-10 text-center"
        return (
            <div className={this.props.square.fieldType === 0 ? "col-xs-1-10 text-center squareShip" : "col-xs-1-10 text-center square"} onClick={this.hitSquare.bind(Square,this.props.square)}>
                

                <p className="squareValue">{this.props.square.fieldType === 0 ? isShip : ocean}</p>

            </div>

        )
    }

}